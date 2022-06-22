namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	public  class DlgMainShop :Entity,IAwake,IUILogic
	{

		public DlgMainShopViewComponent View { get => this.Parent.GetComponent<DlgMainShopViewComponent>();} 

		 

	}
}
