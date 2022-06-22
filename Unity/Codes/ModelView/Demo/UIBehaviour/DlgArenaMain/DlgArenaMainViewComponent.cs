
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[EnableMethod]
	[ComponentOf(typeof(UIBaseWindow))]
	public  class DlgArenaMainViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Button E_QuitButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_QuitButton == null )
     			{
		    		this.m_E_QuitButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Quit");
     			}
     			return this.m_E_QuitButton;
     		}
     	}

		public UnityEngine.UI.Image E_QuitImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_QuitImage == null )
     			{
		    		this.m_E_QuitImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Quit");
     			}
     			return this.m_E_QuitImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_QuitButton = null;
			this.m_E_QuitImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Button m_E_QuitButton = null;
		private UnityEngine.UI.Image m_E_QuitImage = null;
		public Transform uiTransform = null;
	}
}
