using Lemonade.Net.Protocol;

namespace Lemonade.World.Entity
{
    public class Avatar : IEntity<Avatar>
    {
        private int _id;
        
        public int EntityId
        {
            get;
            set;
        }

        public Avatar FromSceneEntityInfo(SceneEntityInfo sceneEntityInfo)
        {
            
            return this;
        }
    }
}
