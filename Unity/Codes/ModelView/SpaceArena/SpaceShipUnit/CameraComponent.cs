using UnityEngine;

namespace ET
{
    public class CameraComponent : Entity, IAwake, ILateUpdate, IDestroy
    {
        public float distanceUp = 10f;//相机与目标的竖直高度参数
        public float distanceAway = 10f;//相机与目标的水平距离参数
        public float smooth = 2f;//位置平滑移动插值参数值
        public float camDepthSmooth = 20f;
        
        public GameObject TargetGameObject { get; set; }
        public GameObject SpaceShipCamera { get; set; }
    }
}