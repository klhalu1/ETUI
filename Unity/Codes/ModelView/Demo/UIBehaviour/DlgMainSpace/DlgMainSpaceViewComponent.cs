﻿
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[EnableMethod]
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

		public void DestroyWidget()
		{
			this.m_E_VSButtonButton = null;
			this.m_E_VSButtonImage = null;
			this.m_E_LevelButtonButton = null;
			this.m_E_LevelButtonImage = null;
			this.m_E_ExploreButtonButton = null;
			this.m_E_ExploreButtonImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Button m_E_VSButtonButton = null;
		private UnityEngine.UI.Image m_E_VSButtonImage = null;
		private UnityEngine.UI.Button m_E_LevelButtonButton = null;
		private UnityEngine.UI.Image m_E_LevelButtonImage = null;
		private UnityEngine.UI.Button m_E_ExploreButtonButton = null;
		private UnityEngine.UI.Image m_E_ExploreButtonImage = null;
		public Transform uiTransform = null;
	}
}