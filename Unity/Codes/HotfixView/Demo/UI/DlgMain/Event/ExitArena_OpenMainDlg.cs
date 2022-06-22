namespace ET
{
    public class ExitArena_OpenMainDlg : AEvent<EventType.ExitArena>
    {
        protected override void Run(EventType.ExitArena args)
        {
            args.ZoneScene.GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Main);
            args.ZoneScene.GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Loading);
        }
    }
}