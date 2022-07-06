using UnityEngine;

namespace ET
{
    [FriendClass(typeof(GlobalComponent))]
    public class AfterUnitCreate_RefreshUnitInfo: AEvent<EventType.AfterUnitCreate>
    {
        protected override void Run(EventType.AfterUnitCreate args)
        {
        }
    }
}