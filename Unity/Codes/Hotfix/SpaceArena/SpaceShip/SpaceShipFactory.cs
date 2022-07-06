namespace ET
{
    public static class SpaceShipFactory
    {
        public static SpaceShip Create(Scene currentScene, int unitInfo)
        {
            return new SpaceShip();
        }
    }
}