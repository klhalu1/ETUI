namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	public  class DlgMainSpaceDock :Entity,IAwake,IUILogic
	{

		public DlgMainSpaceDockViewComponent View { get => this.Parent.GetComponent<DlgMainSpaceDockViewComponent>();}

		public int CurrentIndex = 0;
	}
}
