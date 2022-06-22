
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[EnableMethod]
	[ComponentOf(typeof(UIBaseWindow))]
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
		public Transform uiTransform = null;
	}
}
