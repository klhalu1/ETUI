namespace ET
{
	public  class DlgMainSpaceShip :Entity,IAwake,IUILogic
	{

		public DlgMainSpaceShipViewComponent View { get => this.Parent.GetComponent<DlgMainSpaceShipViewComponent>();} 

		 

	}
}
