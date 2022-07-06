using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
	[FriendClass(typeof(DlgMain))]
	[FriendClass(typeof(DlgMainViewComponent))]
	public static  class DlgMainSystem
	{

		public static void RegisterUIEvent(this DlgMain self)
		{
			self.View.E_SpaceButton.AddListener(() =>
			{
				self.OnMainButtonClickHandler(WindowID.WindowID_MainSpace).Coroutine();
			});
			self.View.E_ShopButton.AddListener(() =>
			{
				self.OnMainButtonClickHandler(WindowID.WindowID_MainShop).Coroutine();
			});
			self.View.E_SpaceDockButton.AddListener(() =>
			{
				self.OnMainButtonClickHandler(WindowID.WindowID_MainSpaceDock).Coroutine();
			});
			self.View.E_EquipButton.AddListener(() =>
			{
				self.OnMainButtonClickHandler(WindowID.WindowID_MainEquip).Coroutine();
			});
			self.View.E_InfoButton.AddListener(() =>
			{
				self.OnMainButtonClickHandler(WindowID.WindowID_MainInfo).Coroutine();
			});
			self.View.E_AddMoneyButton.AddListener(() =>
			{
				self.OnAddMoneyButtonClickHandler().Coroutine();
			});
		}

		public static void ShowWindow(this DlgMain self, Entity contextData = null)
		{
			self.CurrentDlgID = WindowID.WindowID_Invaild;
			self.OnMainButtonClickHandler(WindowID.WindowID_MainSpace).Coroutine();
			self.Refresh().Coroutine();
		}

		public static async ETTask OnMainButtonClickHandler(this DlgMain self,WindowID dlgID)
		{
			if (dlgID != self.CurrentDlgID)
			{
				if (self.CurrentDlgID != WindowID.WindowID_Invaild)
				{
					self.DomainScene().GetComponent<UIComponent>().HideWindow(self.CurrentDlgID);
				}
				self.DomainScene().GetComponent<UIComponent>().ShowWindow(dlgID);
				self.CurrentDlgID = dlgID;
				//置顶UI
				self.View.uiTransform.SetAsLastSibling();
			}
		}

		public static async ETTask Refresh(this DlgMain self)
		{
			Unit unit = UnitHelper.GetMyUnitFromCurrentScene(self.ZoneScene().CurrentScene());
			NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
			
			self.View.E_RoleLevelText.SetText(numericComponent?.GetByKey(NumericType.Level).ToString());
			self.View.E_GoldText.SetText(numericComponent?.GetByKey(NumericType.Gold).ToString());
			self.View.E_MoneyText.SetText(numericComponent?.GetByKey(NumericType.Money).ToString());

			RoleInfosComponent roleInfosComponent = self.ZoneScene().GetComponent<RoleInfosComponent>();
			self.View.E_NameText.SetText(roleInfosComponent?.GetRoleName());
		}
		
		public static async ETTask OnAddMoneyButtonClickHandler(this DlgMain self)
		{
			try
			{
				int error = await NumericHelper.TestUpdateNumric(self.ZoneScene());
				if (error != ErrorCode.ERR_Success)
					return;
				Log.Debug("发送更新属性测试消息成功");
			}
			catch (Exception e)
			{
				Log.Error(e.ToString());
			}
		}

	}
}
