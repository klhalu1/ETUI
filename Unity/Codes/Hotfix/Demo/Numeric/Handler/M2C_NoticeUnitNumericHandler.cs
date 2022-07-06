namespace ET
{
    public class M2C_NoticeUnitNumericHandler : AMHandler<M2C_NoticeUnitNumeric>
    {
        protected override async void Run(Session session, M2C_NoticeUnitNumeric message)
        {
            //接收数值变化，不同entity需要分开处理
            session.ZoneScene()?.CurrentScene()?.GetComponent<UnitComponent>()?.Get(message.UnitId)?.GetComponent<NumericComponent>()
                    ?.Set(message.NumericType, message.NewValue);
            await ETTask.CompletedTask;
        }
    }
}