namespace ET
{
    public class ItemAwakeSystem : AwakeSystem<Item, int>
    {
        public override void Awake(Item self, int configId)
        {
            self.ConfigId = configId;
        }
    }
    
    public class ItemDestroySystem : DestroySystem<Item>
    {
        public override void Destroy(Item self)
        {
            self.ConfigId = 0;
            self.Quality = 0;
        }
    }
    
    [FriendClass(typeof(Item))]
    public static class ItemSystem
    {

    }
}