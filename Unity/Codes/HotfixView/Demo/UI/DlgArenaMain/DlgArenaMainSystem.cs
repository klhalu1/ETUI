using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
	[FriendClass(typeof(DlgArenaMain))]
	public static  class DlgArenaMainSystem
	{

		public static void RegisterUIEvent(this DlgArenaMain self)
		{
			self.View.E_QuitButton.AddListener(() =>
			{
				self.OnQuitButtonClickHandler();
			});
		}

		public static void ShowWindow(this DlgArenaMain self, Entity contextData = null)
		{
		}

		public static async ETTask OnQuitButtonClickHandler(this DlgArenaMain self)
		{
			
		}

	}
}
