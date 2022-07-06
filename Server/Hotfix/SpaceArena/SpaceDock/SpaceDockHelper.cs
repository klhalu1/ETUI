namespace ET
{
    [FriendClass(typeof(SpaceDockComponent))]
    public static class SpaceDockHelper
    {
        public static void UnLockeSpaceDock(Unit unit,int index)
        {
            unit.GetComponent<SpaceDockComponent>()?.UnLockSpaceDock(index);
        }
    }
}