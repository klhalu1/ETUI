
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[EnableMethod]
	[ComponentOf(typeof(UIBaseWindow))]
	public  class DlgLoadingViewComponent : Entity,IAwake,IDestroy 
	{
		public void DestroyWidget()
		{
			this.uiTransform = null;
		}

		public Transform uiTransform = null;
	}
}
