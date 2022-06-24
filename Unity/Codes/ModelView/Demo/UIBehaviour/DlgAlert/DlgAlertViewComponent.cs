
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgAlertViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Button E_CloseButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_CloseButton == null )
     			{
		    		this.m_E_CloseButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Close");
     			}
     			return this.m_E_CloseButton;
     		}
     	}

		public UnityEngine.UI.Image E_CloseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_CloseImage == null )
     			{
		    		this.m_E_CloseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Close");
     			}
     			return this.m_E_CloseImage;
     		}
     	}

		public UnityEngine.UI.Image E_FrameImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_FrameImage == null )
     			{
		    		this.m_E_FrameImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"BackGroup/MessageBody/Icom/E_Frame");
     			}
     			return this.m_E_FrameImage;
     		}
     	}

		public UnityEngine.UI.Image E_IconImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_IconImage == null )
     			{
		    		this.m_E_IconImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"BackGroup/MessageBody/Icom/E_Frame/E_Icon");
     			}
     			return this.m_E_IconImage;
     		}
     	}

		public UnityEngine.UI.Text E_TitleText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TitleText == null )
     			{
		    		this.m_E_TitleText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"BackGroup/MessageBody/E_Title");
     			}
     			return this.m_E_TitleText;
     		}
     	}

		public UnityEngine.UI.Text E_MsgText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MsgText == null )
     			{
		    		this.m_E_MsgText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"BackGroup/MessageBody/E_Msg");
     			}
     			return this.m_E_MsgText;
     		}
     	}

		public UnityEngine.UI.Button E_OkButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_OkButton == null )
     			{
		    		this.m_E_OkButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"BackGroup/ButtonGroup/E_Ok");
     			}
     			return this.m_E_OkButton;
     		}
     	}

		public UnityEngine.UI.Image E_OkImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_OkImage == null )
     			{
		    		this.m_E_OkImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"BackGroup/ButtonGroup/E_Ok");
     			}
     			return this.m_E_OkImage;
     		}
     	}

		public UnityEngine.UI.Button E_ComfirmButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ComfirmButton == null )
     			{
		    		this.m_E_ComfirmButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"BackGroup/ButtonGroup/E_Comfirm");
     			}
     			return this.m_E_ComfirmButton;
     		}
     	}

		public UnityEngine.UI.Image E_ComfirmImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ComfirmImage == null )
     			{
		    		this.m_E_ComfirmImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"BackGroup/ButtonGroup/E_Comfirm");
     			}
     			return this.m_E_ComfirmImage;
     		}
     	}

		public UnityEngine.UI.Button E_CancelButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_CancelButton == null )
     			{
		    		this.m_E_CancelButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"BackGroup/ButtonGroup/E_Cancel");
     			}
     			return this.m_E_CancelButton;
     		}
     	}

		public UnityEngine.UI.Image E_CancelImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_CancelImage == null )
     			{
		    		this.m_E_CancelImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"BackGroup/ButtonGroup/E_Cancel");
     			}
     			return this.m_E_CancelImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_CloseButton = null;
			this.m_E_CloseImage = null;
			this.m_E_FrameImage = null;
			this.m_E_IconImage = null;
			this.m_E_TitleText = null;
			this.m_E_MsgText = null;
			this.m_E_OkButton = null;
			this.m_E_OkImage = null;
			this.m_E_ComfirmButton = null;
			this.m_E_ComfirmImage = null;
			this.m_E_CancelButton = null;
			this.m_E_CancelImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Button m_E_CloseButton = null;
		private UnityEngine.UI.Image m_E_CloseImage = null;
		private UnityEngine.UI.Image m_E_FrameImage = null;
		private UnityEngine.UI.Image m_E_IconImage = null;
		private UnityEngine.UI.Text m_E_TitleText = null;
		private UnityEngine.UI.Text m_E_MsgText = null;
		private UnityEngine.UI.Button m_E_OkButton = null;
		private UnityEngine.UI.Image m_E_OkImage = null;
		private UnityEngine.UI.Button m_E_ComfirmButton = null;
		private UnityEngine.UI.Image m_E_ComfirmImage = null;
		private UnityEngine.UI.Button m_E_CancelButton = null;
		private UnityEngine.UI.Image m_E_CancelImage = null;
		public Transform uiTransform = null;
	}
}
