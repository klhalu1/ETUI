using System;

namespace ET
{
    public static class NumericHelper
    {
        public static async ETTask<int> TestUpdateNumric(Scene zoneScene)
        {
            M2C_AddUnitMoney m2CAddUnitMoney = null;
            try
            {
                m2CAddUnitMoney = (M2C_AddUnitMoney) await zoneScene.GetComponent<SessionComponent>().Session.Call(new C2M_AddUnitMoney() { });
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCode.ERR_NetWorkError;
            }

            if (m2CAddUnitMoney.Error != ErrorCode.ERR_Success)
            {
                Log.Error(m2CAddUnitMoney.Error.ToString());
                return m2CAddUnitMoney.Error;
            }

            return ErrorCode.ERR_Success;
        }
    }
}