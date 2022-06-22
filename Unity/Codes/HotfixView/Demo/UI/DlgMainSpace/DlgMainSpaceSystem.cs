using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
	[FriendClass(typeof(DlgMainSpace))]
	public static  class DlgMainSpaceSystem
	{

		public static void RegisterUIEvent(this DlgMainSpace self)
		{
			self.View.E_VSButtonButton.AddListener(() =>
			{
				self.OnVSButtonClickHandler();
			});
		}

		public static void ShowWindow(this DlgMainSpace self, Entity contextData = null)
		{
			self.View.E_VSTextText.SetText("战斗");
		}

		public static async ETTask OnVSButtonClickHandler(this DlgMainSpace self)
		{
			self.View.E_VSTextText.SetText("等待进入太空。。。");
			await SpaceSceneHelper.EnterArena(self.ZoneScene());
			self.ZoneScene().GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_ArenaMain);
			self.ZoneScene().GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Loading);
		}

	}
}
