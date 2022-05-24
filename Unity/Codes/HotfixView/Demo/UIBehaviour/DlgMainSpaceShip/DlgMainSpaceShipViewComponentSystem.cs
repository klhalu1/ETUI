
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgMainSpaceShipViewComponentAwakeSystem : AwakeSystem<DlgMainSpaceShipViewComponent> 
	{
		public override void Awake(DlgMainSpaceShipViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgMainSpaceShipViewComponentDestroySystem : DestroySystem<DlgMainSpaceShipViewComponent> 
	{
		public override void Destroy(DlgMainSpaceShipViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
