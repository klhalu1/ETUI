using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
	[FriendClass(typeof(DlgAlert))]
	[FriendClass(typeof(DlgAlertData))]
	public static  class DlgAlertSystem
	{

		public static void RegisterUIEvent(this DlgAlert self)
		{
			self.View.E_OkButton.AddListener(() => { self.OnOkClickHandler();});
			self.View.E_ComfirmButton.AddListener(() => { self.OnConfirmClickHandler();});
			self.View.E_CancelButton.AddListener(() => { self.OnCancelClickHandler();});
			self.View.E_CloseButton.AddListener(() => { self.OnOkClickHandler();});
		}

		public static void ShowWindow(this DlgAlert self, Entity contextData = null)
		{
			if (contextData != null)
			{
				DlgAlertData dlgAlertData = (DlgAlertData) contextData;
				if (dlgAlertData.AlertType == AlertType.OK)
				{
					self.View.E_OkButton.SetVisible(true);
					self.View.E_ComfirmButton.SetVisible(false);
					self.View.E_CancelButton.SetVisible(false);
					self.View.E_CloseButton.interactable = true;
				}
				else if (dlgAlertData.AlertType == AlertType.ConfirmCancle)
				{
					self.View.E_OkButton.SetVisible(false);
					self.View.E_ComfirmButton.SetVisible(true);
					self.View.E_CancelButton.SetVisible(true);
					self.View.E_CloseButton.interactable = false;
				}

				self.View.E_MsgText.SetText(dlgAlertData.Message);
			}
		}

		public static void OnOkClickHandler(this DlgAlert self)
		{
			self.ZoneScene().GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Alert);
			self.ZoneScene().GetComponent<ObjectWait>().Notify(new WaitType.Wait_AlertMsg() {Op = AlertOp.OK});
		}
		
		public static void OnConfirmClickHandler(this DlgAlert self)
		{
			self.ZoneScene().GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Alert);
			self.ZoneScene().GetComponent<ObjectWait>().Notify(new WaitType.Wait_AlertMsg() {Op = AlertOp.Confirm});
		}
		
		public static void OnCancelClickHandler(this DlgAlert self)
		{
			self.ZoneScene().GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Alert);
			self.ZoneScene().GetComponent<ObjectWait>().Notify(new WaitType.Wait_AlertMsg() {Op = AlertOp.Cancle});
		}
	}
}
