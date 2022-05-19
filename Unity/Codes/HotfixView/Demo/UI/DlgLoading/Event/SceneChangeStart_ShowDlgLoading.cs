namespace ET
{
    public class SceneChangeStart_ShowDlgLoading: AEvent<EventType.SceneChangeStart>
    {
        protected override void Run(EventType.SceneChangeStart args)
        {
            args.ZoneScene.GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Loading);
            Log.Debug("开始加载Loading界面");
            //await ETTask.CompletedTask;
        }
    }
}