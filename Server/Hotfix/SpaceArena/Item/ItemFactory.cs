namespace ET
{
    [FriendClass(typeof(Item))]
    public static class ItemFactory
    {
        public static Item Create(Entity parent, int configId)
        {
            Item item = parent.AddChild<Item, int>(configId);
            return item;
        }

        public static void AddComponentByItem(Item item)
        {

        }
        
        
    }
}