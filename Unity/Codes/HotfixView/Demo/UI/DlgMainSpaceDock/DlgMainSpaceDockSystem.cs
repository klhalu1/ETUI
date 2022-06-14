using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
	[FriendClass(typeof(DlgMainSpaceDock))]
	public static  class DlgMainSpaceDockSystem
	{

		public static void RegisterUIEvent(this DlgMainSpaceDock self)
		{
			self.View.E_PreviousButton.AddListener(() => { self.OnPreviousClickHandler();});
			self.View.E_NextButton.AddListener(() => { self.OnNextClickHandler();});
		}

		public static void ShowWindow(this DlgMainSpaceDock self, Entity contextData = null)
		{
		}

		public static async ETTask OnPreviousClickHandler(this DlgMainSpaceDock self)
		{
		}
		
		public static async ETTask OnNextClickHandler(this DlgMainSpaceDock self)
		{
		}
	}
}
