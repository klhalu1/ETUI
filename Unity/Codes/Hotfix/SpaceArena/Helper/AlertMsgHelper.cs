namespace ET
{
    public static class AlertMsgHelper
    {
        public static async ETTask<AlertOp> ShowDlgMsg(Scene zoneScene, string message, AlertType alertType = AlertType.OK)
        {
            Game.EventSystem.Publish(new EventType.AlertMsg(){ZoneScene = zoneScene,AlertType = alertType,Message = message});
            WaitType.Wait_AlertMsg waitAlertMsg = await zoneScene?.GetComponent<ObjectWait>().Wait<WaitType.Wait_AlertMsg>();
            return waitAlertMsg.Op;
        }
    }
}