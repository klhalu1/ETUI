using ET.EventType;

namespace ET
{
    public class NumericChangeEvent_NoticeToClient : AEventClass<EventType.NumbericChange> 
    {
        protected override async void Run(object args)
        {
            EventType.NumbericChange numbericChange = args as EventType.NumbericChange;
            if (!(numbericChange.Parent is Unit unit))
            {
                return;
            }

            unit.GetComponent<NumericNoticeComponent>()?.NoticeImmediately(numbericChange);
            await ETTask.CompletedTask;
        }
    }
}