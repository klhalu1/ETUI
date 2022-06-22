using System;
using ET.WaitType;

namespace ET
{
    public static class SpaceSceneHelper
    {
        public static async ETTask<int> EnterArena(Scene zoneScene)
        {
            M2C_EnterArena m2CEnterArena = null;
            try
            {
                m2CEnterArena = (M2C_EnterArena) await zoneScene.GetComponent<SessionComponent>().Session.Call(new C2M_EnterArena() { });
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCode.ERR_RequestSceneTypeError;
            }
            //await ETTask.CompletedTask;
            await zoneScene.GetComponent<ObjectWait>().Wait<Wait_SceneChangeFinish>();
            return ErrorCode.ERR_Success;
        }
    }
}