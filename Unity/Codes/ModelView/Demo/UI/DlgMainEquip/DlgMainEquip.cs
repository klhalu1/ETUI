namespace ET
{
	public  class DlgMainEquip :Entity,IAwake,IUILogic
	{

		public DlgMainEquipViewComponent View { get => this.Parent.GetComponent<DlgMainEquipViewComponent>();} 

		 

	}
}
