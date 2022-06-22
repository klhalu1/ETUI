namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	public  class DlgMainInfo :Entity,IAwake,IUILogic
	{

		public DlgMainInfoViewComponent View { get => this.Parent.GetComponent<DlgMainInfoViewComponent>();} 

		 

	}
}
