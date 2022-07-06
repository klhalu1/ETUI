
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgMainSpaceDockViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.ToggleGroup E_ModelGroupToggleGroup
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ModelGroupToggleGroup == null )
     			{
		    		this.m_E_ModelGroupToggleGroup = UIFindHelper.FindDeepChild<UnityEngine.UI.ToggleGroup>(this.uiTransform.gameObject,"Center/E_ModelGroup");
     			}
     			return this.m_E_ModelGroupToggleGroup;
     		}
     	}

		public UnityEngine.UI.Image E_ModelGroupImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ModelGroupImage == null )
     			{
		    		this.m_E_ModelGroupImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/E_ModelGroup");
     			}
     			return this.m_E_ModelGroupImage;
     		}
     	}

		public UnityEngine.UI.Toggle E_Model2DToggle
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Model2DToggle == null )
     			{
		    		this.m_E_Model2DToggle = UIFindHelper.FindDeepChild<UnityEngine.UI.Toggle>(this.uiTransform.gameObject,"Center/E_ModelGroup/E_Model2D");
     			}
     			return this.m_E_Model2DToggle;
     		}
     	}

		public UnityEngine.UI.Toggle E_Model3DToggle
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_Model3DToggle == null )
     			{
		    		this.m_E_Model3DToggle = UIFindHelper.FindDeepChild<UnityEngine.UI.Toggle>(this.uiTransform.gameObject,"Center/E_ModelGroup/E_Model3D");
     			}
     			return this.m_E_Model3DToggle;
     		}
     	}

		public UnityEngine.UI.Button E_PreviousButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PreviousButton == null )
     			{
		    		this.m_E_PreviousButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/E_Previous");
     			}
     			return this.m_E_PreviousButton;
     		}
     	}

		public UnityEngine.UI.Image E_PreviousImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PreviousImage == null )
     			{
		    		this.m_E_PreviousImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/E_Previous");
     			}
     			return this.m_E_PreviousImage;
     		}
     	}

		public UnityEngine.UI.Button E_NextButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextButton == null )
     			{
		    		this.m_E_NextButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/E_Next");
     			}
     			return this.m_E_NextButton;
     		}
     	}

		public UnityEngine.UI.Image E_NextImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextImage == null )
     			{
		    		this.m_E_NextImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/E_Next");
     			}
     			return this.m_E_NextImage;
     		}
     	}

		public UnityEngine.UI.Button E_ListButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ListButton == null )
     			{
		    		this.m_E_ListButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/E_List");
     			}
     			return this.m_E_ListButton;
     		}
     	}

		public UnityEngine.UI.Image E_ListImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ListImage == null )
     			{
		    		this.m_E_ListImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/E_List");
     			}
     			return this.m_E_ListImage;
     		}
     	}

		public UnityEngine.UI.Button E_UnLockButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_UnLockButton == null )
     			{
		    		this.m_E_UnLockButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/E_UnLock");
     			}
     			return this.m_E_UnLockButton;
     		}
     	}

		public UnityEngine.UI.Image E_UnLockImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_UnLockImage == null )
     			{
		    		this.m_E_UnLockImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/E_UnLock");
     			}
     			return this.m_E_UnLockImage;
     		}
     	}

		public UnityEngine.UI.Button E_BuildButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_BuildButton == null )
     			{
		    		this.m_E_BuildButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/E_Build");
     			}
     			return this.m_E_BuildButton;
     		}
     	}

		public UnityEngine.UI.Image E_BuildImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_BuildImage == null )
     			{
		    		this.m_E_BuildImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/E_Build");
     			}
     			return this.m_E_BuildImage;
     		}
     	}

		public UnityEngine.UI.Button E_GetButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_GetButton == null )
     			{
		    		this.m_E_GetButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/E_Get");
     			}
     			return this.m_E_GetButton;
     		}
     	}

		public UnityEngine.UI.Image E_GetImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_GetImage == null )
     			{
		    		this.m_E_GetImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/E_Get");
     			}
     			return this.m_E_GetImage;
     		}
     	}

		public UnityEngine.UI.Button E_SellButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SellButton == null )
     			{
		    		this.m_E_SellButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/E_Sell");
     			}
     			return this.m_E_SellButton;
     		}
     	}

		public UnityEngine.UI.Image E_SellImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SellImage == null )
     			{
		    		this.m_E_SellImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/E_Sell");
     			}
     			return this.m_E_SellImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_ModelGroupToggleGroup = null;
			this.m_E_ModelGroupImage = null;
			this.m_E_Model2DToggle = null;
			this.m_E_Model3DToggle = null;
			this.m_E_PreviousButton = null;
			this.m_E_PreviousImage = null;
			this.m_E_NextButton = null;
			this.m_E_NextImage = null;
			this.m_E_ListButton = null;
			this.m_E_ListImage = null;
			this.m_E_UnLockButton = null;
			this.m_E_UnLockImage = null;
			this.m_E_BuildButton = null;
			this.m_E_BuildImage = null;
			this.m_E_GetButton = null;
			this.m_E_GetImage = null;
			this.m_E_SellButton = null;
			this.m_E_SellImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.ToggleGroup m_E_ModelGroupToggleGroup = null;
		private UnityEngine.UI.Image m_E_ModelGroupImage = null;
		private UnityEngine.UI.Toggle m_E_Model2DToggle = null;
		private UnityEngine.UI.Toggle m_E_Model3DToggle = null;
		private UnityEngine.UI.Button m_E_PreviousButton = null;
		private UnityEngine.UI.Image m_E_PreviousImage = null;
		private UnityEngine.UI.Button m_E_NextButton = null;
		private UnityEngine.UI.Image m_E_NextImage = null;
		private UnityEngine.UI.Button m_E_ListButton = null;
		private UnityEngine.UI.Image m_E_ListImage = null;
		private UnityEngine.UI.Button m_E_UnLockButton = null;
		private UnityEngine.UI.Image m_E_UnLockImage = null;
		private UnityEngine.UI.Button m_E_BuildButton = null;
		private UnityEngine.UI.Image m_E_BuildImage = null;
		private UnityEngine.UI.Button m_E_GetButton = null;
		private UnityEngine.UI.Image m_E_GetImage = null;
		private UnityEngine.UI.Button m_E_SellButton = null;
		private UnityEngine.UI.Image m_E_SellImage = null;
		public Transform uiTransform = null;
	}
}
