
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgMainShopViewComponentAwakeSystem : AwakeSystem<DlgMainShopViewComponent> 
	{
		public override void Awake(DlgMainShopViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgMainShopViewComponentDestroySystem : DestroySystem<DlgMainShopViewComponent> 
	{
		public override void Destroy(DlgMainShopViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
