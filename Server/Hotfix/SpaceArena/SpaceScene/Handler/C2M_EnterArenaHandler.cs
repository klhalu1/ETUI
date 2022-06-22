using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_EnterArenaHandler : AMActorLocationRpcHandler<Unit, C2M_EnterArena, M2C_EnterArena>
    {
        protected override async ETTask Run(Unit unit, C2M_EnterArena request, M2C_EnterArena response, Action reply)
        {
            try
            {
                StartSceneConfig startSceneConfig = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainScene().Zone, "SpaceArena");
                //await TransferHelper.Transfer(unit, startSceneConfig.InstanceId, startSceneConfig.Name);
                
                // 通知客户端开始切场景
                M2C_StartSceneChange m2CStartSceneChange = new M2C_StartSceneChange() {SceneInstanceId = startSceneConfig.InstanceId, SceneName = startSceneConfig.Name};
                MessageHelper.SendToClient(unit, m2CStartSceneChange);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
   
            reply();
            await ETTask.CompletedTask;
        }
    }
}