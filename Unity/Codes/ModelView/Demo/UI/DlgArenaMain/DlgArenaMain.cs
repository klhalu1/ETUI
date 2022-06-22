namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	public  class DlgArenaMain :Entity,IAwake,IUILogic
	{

		public DlgArenaMainViewComponent View { get => this.Parent.GetComponent<DlgArenaMainViewComponent>();} 

		 

	}
}
