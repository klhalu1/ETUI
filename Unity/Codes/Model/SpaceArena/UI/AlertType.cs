namespace ET
{
    public enum AlertType
    {
        OK = 0,
        ConfirmCancle,
    }
    
    public enum AlertOp
    {
        OK = 0,
        Confirm,
        Cancle,
    }
    
    public class DlgAlertData : Entity
    {
        public AlertType AlertType;
        public string Title;
        public string Message;
    }
}