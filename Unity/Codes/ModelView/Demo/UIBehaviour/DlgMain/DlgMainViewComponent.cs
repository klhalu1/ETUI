
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgMainViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Button E_SpaceDockButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SpaceDockButton == null )
     			{
		    		this.m_E_SpaceDockButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/Group_Bottom/E_SpaceDock");
     			}
     			return this.m_E_SpaceDockButton;
     		}
     	}

		public UnityEngine.UI.Image E_SpaceDockImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SpaceDockImage == null )
     			{
		    		this.m_E_SpaceDockImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/Group_Bottom/E_SpaceDock");
     			}
     			return this.m_E_SpaceDockImage;
     		}
     	}

		public UnityEngine.UI.Button E_EquipButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_EquipButton == null )
     			{
		    		this.m_E_EquipButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/Group_Bottom/E_Equip");
     			}
     			return this.m_E_EquipButton;
     		}
     	}

		public UnityEngine.UI.Image E_EquipImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_EquipImage == null )
     			{
		    		this.m_E_EquipImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/Group_Bottom/E_Equip");
     			}
     			return this.m_E_EquipImage;
     		}
     	}

		public UnityEngine.UI.Button E_SpaceButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SpaceButton == null )
     			{
		    		this.m_E_SpaceButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/Group_Bottom/E_Space");
     			}
     			return this.m_E_SpaceButton;
     		}
     	}

		public UnityEngine.UI.Image E_SpaceImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SpaceImage == null )
     			{
		    		this.m_E_SpaceImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/Group_Bottom/E_Space");
     			}
     			return this.m_E_SpaceImage;
     		}
     	}

		public UnityEngine.UI.Button E_InfoButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_InfoButton == null )
     			{
		    		this.m_E_InfoButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/Group_Bottom/E_Info");
     			}
     			return this.m_E_InfoButton;
     		}
     	}

		public UnityEngine.UI.Image E_InfoImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_InfoImage == null )
     			{
		    		this.m_E_InfoImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/Group_Bottom/E_Info");
     			}
     			return this.m_E_InfoImage;
     		}
     	}

		public UnityEngine.UI.Button E_ShopButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ShopButton == null )
     			{
		    		this.m_E_ShopButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/Group_Bottom/E_Shop");
     			}
     			return this.m_E_ShopButton;
     		}
     	}

		public UnityEngine.UI.Image E_ShopImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ShopImage == null )
     			{
		    		this.m_E_ShopImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/Group_Bottom/E_Shop");
     			}
     			return this.m_E_ShopImage;
     		}
     	}

		public UnityEngine.UI.Text E_NameText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NameText == null )
     			{
		    		this.m_E_NameText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"Center/Group_Top/Group_Head/Image/E_Name");
     			}
     			return this.m_E_NameText;
     		}
     	}

		public UnityEngine.UI.Text E_RoleLevelText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_RoleLevelText == null )
     			{
		    		this.m_E_RoleLevelText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"Center/Group_Top/Group_Head/Image/E_RoleLevel");
     			}
     			return this.m_E_RoleLevelText;
     		}
     	}

		public UnityEngine.UI.Text E_GoldText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_GoldText == null )
     			{
		    		this.m_E_GoldText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"Center/Group_Top/Group_GoldTip/E_Gold");
     			}
     			return this.m_E_GoldText;
     		}
     	}

		public UnityEngine.UI.Text E_MoneyText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MoneyText == null )
     			{
		    		this.m_E_MoneyText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"Center/Group_Top/Group_ExpTip/E_Money");
     			}
     			return this.m_E_MoneyText;
     		}
     	}

		public UnityEngine.UI.Button E_AddMoneyButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_AddMoneyButton == null )
     			{
		    		this.m_E_AddMoneyButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/Group_Top/Group_ExpTip/E_AddMoney");
     			}
     			return this.m_E_AddMoneyButton;
     		}
     	}

		public UnityEngine.UI.Image E_AddMoneyImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_AddMoneyImage == null )
     			{
		    		this.m_E_AddMoneyImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/Group_Top/Group_ExpTip/E_AddMoney");
     			}
     			return this.m_E_AddMoneyImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_SpaceDockButton = null;
			this.m_E_SpaceDockImage = null;
			this.m_E_EquipButton = null;
			this.m_E_EquipImage = null;
			this.m_E_SpaceButton = null;
			this.m_E_SpaceImage = null;
			this.m_E_InfoButton = null;
			this.m_E_InfoImage = null;
			this.m_E_ShopButton = null;
			this.m_E_ShopImage = null;
			this.m_E_NameText = null;
			this.m_E_RoleLevelText = null;
			this.m_E_GoldText = null;
			this.m_E_MoneyText = null;
			this.m_E_AddMoneyButton = null;
			this.m_E_AddMoneyImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Button m_E_SpaceDockButton = null;
		private UnityEngine.UI.Image m_E_SpaceDockImage = null;
		private UnityEngine.UI.Button m_E_EquipButton = null;
		private UnityEngine.UI.Image m_E_EquipImage = null;
		private UnityEngine.UI.Button m_E_SpaceButton = null;
		private UnityEngine.UI.Image m_E_SpaceImage = null;
		private UnityEngine.UI.Button m_E_InfoButton = null;
		private UnityEngine.UI.Image m_E_InfoImage = null;
		private UnityEngine.UI.Button m_E_ShopButton = null;
		private UnityEngine.UI.Image m_E_ShopImage = null;
		private UnityEngine.UI.Text m_E_NameText = null;
		private UnityEngine.UI.Text m_E_RoleLevelText = null;
		private UnityEngine.UI.Text m_E_GoldText = null;
		private UnityEngine.UI.Text m_E_MoneyText = null;
		private UnityEngine.UI.Button m_E_AddMoneyButton = null;
		private UnityEngine.UI.Image m_E_AddMoneyImage = null;
		public Transform uiTransform = null;
	}
}
