using System.Collections.Generic;

namespace ET
{
    public class SpaceDockComponent : Entity,IAwake,IDestroy
    {
        public Dictionary<int,SpaceShip> SpaceShips= new Dictionary<int,SpaceShip>();
    }
}