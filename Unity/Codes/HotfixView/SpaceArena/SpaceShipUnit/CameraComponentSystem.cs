using UnityEngine;

namespace ET
{
    [ObjectSystem]
    public class CameraComponentAwakeSystem : AwakeSystem<CameraComponent>
    {
        public override void Awake(CameraComponent self)
        {
            
        }
    }

    [ObjectSystem]
    public class CameraComponentUpdateSystem : LateUpdateSystem<CameraComponent>
    {
        public override void LateUpdate(CameraComponent self)
        {
            self.LateUpdate();
        }
    }
    
    [FriendClass(typeof(CameraComponent))]
    public static class CameraComponentSystem
    {
        public static void LateUpdate(this CameraComponent self)
        {
            if(self.TargetGameObject == null || self.SpaceShipCamera == null)
                return;
            //计算出相机的位置
            Vector3 disPos = self.TargetGameObject.transform.position + Vector3.up *self.distanceUp - self.TargetGameObject.transform.forward * self.distanceAway;
 
            self.SpaceShipCamera.transform.position = Vector3.Lerp(self.SpaceShipCamera.transform.position, disPos, Time.deltaTime * self.smooth);
            //相机的角度
            self.SpaceShipCamera.transform.LookAt(self.TargetGameObject.transform.position);
        }
    }
}