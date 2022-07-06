namespace ET
{
    [NumericWatcher(NumericType.Money)]
    public class NumericWatcher_RefreshMainUI : INumericWatcher
    {
        public void Run(EventType.NumbericChange args)
        {
            args.Parent.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<DlgMain>()?.Refresh();
        }
    }
}