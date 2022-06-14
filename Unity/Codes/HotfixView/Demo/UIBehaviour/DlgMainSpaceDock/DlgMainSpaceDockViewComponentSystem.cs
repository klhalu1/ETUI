
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgMainSpaceDockViewComponentAwakeSystem : AwakeSystem<DlgMainSpaceDockViewComponent> 
	{
		public override void Awake(DlgMainSpaceDockViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgMainSpaceDockViewComponentDestroySystem : DestroySystem<DlgMainSpaceDockViewComponent> 
	{
		public override void Destroy(DlgMainSpaceDockViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
