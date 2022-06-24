namespace ET
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgAlert :Entity,IAwake,IUILogic
	{

		public DlgAlertViewComponent View { get => this.Parent.GetComponent<DlgAlertViewComponent>();} 

		 

	}
}
