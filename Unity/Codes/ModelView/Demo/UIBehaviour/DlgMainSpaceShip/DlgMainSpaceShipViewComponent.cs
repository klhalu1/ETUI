
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[EnableMethod]
	public  class DlgMainSpaceShipViewComponent : Entity,IAwake,IDestroy 
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

		public UnityEngine.UI.Button E_PreButtonButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PreButtonButton == null )
     			{
		    		this.m_E_PreButtonButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/E_PreButton");
     			}
     			return this.m_E_PreButtonButton;
     		}
     	}

		public UnityEngine.UI.Image E_PreButtonImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PreButtonImage == null )
     			{
		    		this.m_E_PreButtonImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/E_PreButton");
     			}
     			return this.m_E_PreButtonImage;
     		}
     	}

		public UnityEngine.UI.Button E_NextButtonButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextButtonButton == null )
     			{
		    		this.m_E_NextButtonButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/E_NextButton");
     			}
     			return this.m_E_NextButtonButton;
     		}
     	}

		public UnityEngine.UI.Image E_NextButtonImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NextButtonImage == null )
     			{
		    		this.m_E_NextButtonImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/E_NextButton");
     			}
     			return this.m_E_NextButtonImage;
     		}
     	}

		public UnityEngine.UI.Button E_ListButtonButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ListButtonButton == null )
     			{
		    		this.m_E_ListButtonButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/E_ListButton");
     			}
     			return this.m_E_ListButtonButton;
     		}
     	}

		public UnityEngine.UI.Image E_ListButtonImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ListButtonImage == null )
     			{
		    		this.m_E_ListButtonImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/E_ListButton");
     			}
     			return this.m_E_ListButtonImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_ModelGroupToggleGroup = null;
			this.m_E_ModelGroupImage = null;
			this.m_E_Model2DToggle = null;
			this.m_E_Model3DToggle = null;
			this.m_E_PreButtonButton = null;
			this.m_E_PreButtonImage = null;
			this.m_E_NextButtonButton = null;
			this.m_E_NextButtonImage = null;
			this.m_E_ListButtonButton = null;
			this.m_E_ListButtonImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.ToggleGroup m_E_ModelGroupToggleGroup = null;
		private UnityEngine.UI.Image m_E_ModelGroupImage = null;
		private UnityEngine.UI.Toggle m_E_Model2DToggle = null;
		private UnityEngine.UI.Toggle m_E_Model3DToggle = null;
		private UnityEngine.UI.Button m_E_PreButtonButton = null;
		private UnityEngine.UI.Image m_E_PreButtonImage = null;
		private UnityEngine.UI.Button m_E_NextButtonButton = null;
		private UnityEngine.UI.Image m_E_NextButtonImage = null;
		private UnityEngine.UI.Button m_E_ListButtonButton = null;
		private UnityEngine.UI.Image m_E_ListButtonImage = null;
		public Transform uiTransform = null;
	}
}
