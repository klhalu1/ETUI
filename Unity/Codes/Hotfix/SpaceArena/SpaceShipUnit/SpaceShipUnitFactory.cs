namespace ET
{
    public static class SpaceShipUnitFactory
    {
        public static Unit Create(Scene currentScene, UnitInfo unitInfo)
        {
            return new Unit();
        }
    }
}