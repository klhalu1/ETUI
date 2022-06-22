using UnityEngine;
using UnityEngine.Rendering.Universal;
namespace ET
{
    public class SceneChangeStart_AddComponent: AEvent<EventType.SceneChangeStart>
    {
        protected override void Run(EventType.SceneChangeStart args)
        {
            RunAsync(args).Coroutine();
        }
        
        private async ETTask RunAsync(EventType.SceneChangeStart args)
        {
            Scene currentScene = args.ZoneScene.CurrentScene();
            
            // 加载场景资源
            await ResourcesComponent.Instance.LoadBundleAsync($"{currentScene.Name}.unity3d");
            // 切换到map场景

            SceneChangeComponent sceneChangeComponent = null;
            try
            {
                sceneChangeComponent = Game.Scene.AddComponent<SceneChangeComponent>();
                {
                    await sceneChangeComponent.ChangeSceneAsync(currentScene.Name);
                }
            }
            finally
            {
                sceneChangeComponent?.Dispose();
            }

            SetUICamToMain();
            //currentScene.AddComponent<OperaComponent>();
        }

        private void SetUICamToMain()
        {
            Camera c = GameObject.Find("SpaceCamera")?.GetComponent<Camera>();
            c = c == null? Camera.main : c;
            Camera uiCamera = GameObject.Find("UICamera").GetComponent<Camera>();
            UniversalAdditionalCameraData pCam_uacd = uiCamera?.GetComponent<UniversalAdditionalCameraData>();
            UniversalAdditionalCameraData pMainCam_uacd = c?.GetComponent<UniversalAdditionalCameraData>();
            if (!pMainCam_uacd.cameraStack.Contains(uiCamera))
                pMainCam_uacd.cameraStack.Add(uiCamera);
                
        }
    }
}