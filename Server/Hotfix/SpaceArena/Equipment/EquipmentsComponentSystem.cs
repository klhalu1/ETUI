namespace ET.SpaceArena.Equipment
{
    public class EquipmentsComponentDestroy: DestroySystem<EquipmentsComponent>
    {
        public override void Destroy(EquipmentsComponent self)
        {
            foreach (var item in self.EquipItems.Values)
            {
                item?.Dispose();
            }
            self.EquipItems.Clear();
        }
    }
    
    public class EquipmentsComponentDeserializeSystem: DeserializeSystem<EquipmentsComponent>
    {
        public override void Deserialize(EquipmentsComponent self)
        {
            foreach (var entity in self.Children.Values)
            {
                Item item = entity as Item;
            }
        }
    }
    
    [FriendClass(typeof(EquipmentsComponent))]
    public static class EquipmentsComponentSystem
    {
        
    }
}