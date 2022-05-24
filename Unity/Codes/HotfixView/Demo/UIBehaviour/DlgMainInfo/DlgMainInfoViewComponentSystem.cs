
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgMainInfoViewComponentAwakeSystem : AwakeSystem<DlgMainInfoViewComponent> 
	{
		public override void Awake(DlgMainInfoViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgMainInfoViewComponentDestroySystem : DestroySystem<DlgMainInfoViewComponent> 
	{
		public override void Destroy(DlgMainInfoViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
