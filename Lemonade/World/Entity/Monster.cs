using Lemonade.Net.Protocol;

namespace Lemonade.World.Entity
{
    public class Monster : IEntity<Monster>
    {
        private int _id;
        
        public int EntityId
        {
            get;
            set;
        }

        public Monster FromSceneEntityInfo(SceneEntityInfo sceneEntityInfo)
        {
            
            return this;
        }
    }
}
