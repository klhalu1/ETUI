namespace ET
{

    public class RoleInfosComponentDestroySystem: DestroySystem<RoleInfosComponent>
    {
        public override void Destroy(RoleInfosComponent self)
        {
            foreach (var roleInfo in self.RoleInfos)
            {
                roleInfo?.Dispose();
            }
            self.RoleInfos.Clear();
            self.CurrentRoleId = 0;
        }
    }

    [FriendClass(typeof(RoleInfosComponent))]
    [FriendClass(typeof(RoleInfo))]
    public static class RoleInfosComponentSystem
    {
        public static string GetRoleName(this RoleInfosComponent self)
        {
            foreach (RoleInfo roleInfo in self.RoleInfos)
            {
                if (roleInfo.Id == self.CurrentRoleId)
                {
                    return roleInfo.Name;
                }
            }
            return null;
        }
        
    }
}