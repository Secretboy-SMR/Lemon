using Lemonade.Net.Protocol;

namespace Lemonade.World.Entity
{
    public class Avatar : IEntity<Avatar>
    {
        private int id;
        
        public int entityId
        {
            get;
            set;
        }

        public Avatar fromSceneEntityInfo(SceneEntityInfo sceneEntityInfo)
        {
            
            return this;
        }
    }
}
