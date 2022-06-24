
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgAlertViewComponentAwakeSystem : AwakeSystem<DlgAlertViewComponent> 
	{
		public override void Awake(DlgAlertViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgAlertViewComponentDestroySystem : DestroySystem<DlgAlertViewComponent> 
	{
		public override void Destroy(DlgAlertViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
