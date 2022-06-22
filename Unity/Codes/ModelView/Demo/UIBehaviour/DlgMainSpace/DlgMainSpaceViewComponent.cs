
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[EnableMethod]
	[ComponentOf(typeof(UIBaseWindow))]
	public  class DlgMainSpaceViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Button E_VSButtonButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_VSButtonButton == null )
     			{
		    		this.m_E_VSButtonButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/E_VSButton");
     			}
     			return this.m_E_VSButtonButton;
     		}
     	}

		public UnityEngine.UI.Image E_VSButtonImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_VSButtonImage == null )
     			{
		    		this.m_E_VSButtonImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/E_VSButton");
     			}
     			return this.m_E_VSButtonImage;
     		}
     	}

		public UnityEngine.UI.Text E_VSTextText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_VSTextText == null )
     			{
		    		this.m_E_VSTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"Center/E_VSButton/E_VSText");
     			}
     			return this.m_E_VSTextText;
     		}
     	}

		public UnityEngine.UI.Button E_LevelButtonButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LevelButtonButton == null )
     			{
		    		this.m_E_LevelButtonButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/E_LevelButton");
     			}
     			return this.m_E_LevelButtonButton;
     		}
     	}

		public UnityEngine.UI.Image E_LevelButtonImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LevelButtonImage == null )
     			{
		    		this.m_E_LevelButtonImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/E_LevelButton");
     			}
     			return this.m_E_LevelButtonImage;
     		}
     	}

		public UnityEngine.UI.Text E_LevelTextText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LevelTextText == null )
     			{
		    		this.m_E_LevelTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"Center/E_LevelButton/E_LevelText");
     			}
     			return this.m_E_LevelTextText;
     		}
     	}

		public UnityEngine.UI.Button E_ExploreButtonButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ExploreButtonButton == null )
     			{
		    		this.m_E_ExploreButtonButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/E_ExploreButton");
     			}
     			return this.m_E_ExploreButtonButton;
     		}
     	}

		public UnityEngine.UI.Image E_ExploreButtonImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ExploreButtonImage == null )
     			{
		    		this.m_E_ExploreButtonImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/E_ExploreButton");
     			}
     			return this.m_E_ExploreButtonImage;
     		}
     	}

		public UnityEngine.UI.Text E_ExploreTextText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ExploreTextText == null )
     			{
		    		this.m_E_ExploreTextText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"Center/E_ExploreButton/E_ExploreText");
     			}
     			return this.m_E_ExploreTextText;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_VSButtonButton = null;
			this.m_E_VSButtonImage = null;
			this.m_E_VSTextText = null;
			this.m_E_LevelButtonButton = null;
			this.m_E_LevelButtonImage = null;
			this.m_E_LevelTextText = null;
			this.m_E_ExploreButtonButton = null;
			this.m_E_ExploreButtonImage = null;
			this.m_E_ExploreTextText = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Button m_E_VSButtonButton = null;
		private UnityEngine.UI.Image m_E_VSButtonImage = null;
		private UnityEngine.UI.Text m_E_VSTextText = null;
		private UnityEngine.UI.Button m_E_LevelButtonButton = null;
		private UnityEngine.UI.Image m_E_LevelButtonImage = null;
		private UnityEngine.UI.Text m_E_LevelTextText = null;
		private UnityEngine.UI.Button m_E_ExploreButtonButton = null;
		private UnityEngine.UI.Image m_E_ExploreButtonImage = null;
		private UnityEngine.UI.Text m_E_ExploreTextText = null;
		public Transform uiTransform = null;
	}
}
