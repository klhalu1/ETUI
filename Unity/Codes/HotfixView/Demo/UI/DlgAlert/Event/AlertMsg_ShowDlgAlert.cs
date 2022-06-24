namespace ET
{
    public class AlertMsg_ShowDlgAlert: AEvent<EventType.AlertMsg>
    {
        protected override void Run(EventType.AlertMsg args)
        {
            args.ZoneScene.GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Alert,
                WindowID.WindowID_Invaild,
                new ShowWindowData()
                {
                    contextData = new DlgAlertData()
                    {
                        AlertType = args.AlertType,
                        Message = args.Message
                    }
                });
        }
    }
}