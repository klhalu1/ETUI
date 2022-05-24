namespace ET
{
	public  class DlgMainSpace :Entity,IAwake,IUILogic
	{

		public DlgMainSpaceViewComponent View { get => this.Parent.GetComponent<DlgMainSpaceViewComponent>();} 

		 

	}
}
