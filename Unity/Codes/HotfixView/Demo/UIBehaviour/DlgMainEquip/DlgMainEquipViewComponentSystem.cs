
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgMainEquipViewComponentAwakeSystem : AwakeSystem<DlgMainEquipViewComponent> 
	{
		public override void Awake(DlgMainEquipViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgMainEquipViewComponentDestroySystem : DestroySystem<DlgMainEquipViewComponent> 
	{
		public override void Destroy(DlgMainEquipViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
