using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_AddUnitMoneyHandler : AMActorLocationRpcHandler<Unit, C2M_AddUnitMoney, M2C_AddUnitMoney>
    {
        protected override async ETTask Run(Unit unit, C2M_AddUnitMoney request, M2C_AddUnitMoney response, Action reply)
        {
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            long newMoney = numericComponent.GetAsLong(NumericType.Money) + 100;
            numericComponent.Set(NumericType.Money,newMoney);
            reply();
            await ETTask.CompletedTask;
        }
    }
}