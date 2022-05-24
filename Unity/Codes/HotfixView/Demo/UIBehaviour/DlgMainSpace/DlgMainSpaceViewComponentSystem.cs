
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgMainSpaceViewComponentAwakeSystem : AwakeSystem<DlgMainSpaceViewComponent> 
	{
		public override void Awake(DlgMainSpaceViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgMainSpaceViewComponentDestroySystem : DestroySystem<DlgMainSpaceViewComponent> 
	{
		public override void Destroy(DlgMainSpaceViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
