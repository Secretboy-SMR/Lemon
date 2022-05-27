using Lemonade.Net.Protocol;

namespace Lemonade.World.Entity
{
    public class Monster : IEntity<Monster>
    {
        private int id;
        
        public int entityId
        {
            get;
            set;
        }

        public Monster fromSceneEntityInfo(SceneEntityInfo sceneEntityInfo)
        {
            
            return this;
        }
    }
}
