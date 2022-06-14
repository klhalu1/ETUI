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
		}

		public static async ETTask OnVSButtonClickHandler(this DlgMainSpace self)
		{
			await SpaceSceneHelper.EnterArena(self.ZoneScene());
		}

	}
}
