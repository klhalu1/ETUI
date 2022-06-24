﻿using System.Collections;
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
			
		}

	}
}