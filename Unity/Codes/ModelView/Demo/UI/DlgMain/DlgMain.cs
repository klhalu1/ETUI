﻿namespace ET
{
	public  class DlgMain :Entity,IAwake,IUILogic
	{

		public DlgMainViewComponent View { get => this.Parent.GetComponent<DlgMainViewComponent>();}

		public WindowID CurrentDlgID = WindowID.WindowID_Invaild;

	}
}
