namespace ET
{
	public  class DlgMainShop :Entity,IAwake,IUILogic
	{

		public DlgMainShopViewComponent View { get => this.Parent.GetComponent<DlgMainShopViewComponent>();} 

		 

	}
}
