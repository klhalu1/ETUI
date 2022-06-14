
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgArenaMainViewComponentAwakeSystem : AwakeSystem<DlgArenaMainViewComponent> 
	{
		public override void Awake(DlgArenaMainViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgArenaMainViewComponentDestroySystem : DestroySystem<DlgArenaMainViewComponent> 
	{
		public override void Destroy(DlgArenaMainViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
