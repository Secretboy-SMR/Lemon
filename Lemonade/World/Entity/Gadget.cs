using Lemonade.Net.Protocol;

namespace Lemonade.World.Entity
{
    public class Gadget : IEntity<Gadget>
    {
        private int _id;
        
        public int EntityId
        {
            get;
            set;
        }

        public Gadget FromSceneEntityInfo(SceneEntityInfo sceneEntityInfo)
        {
            
            return this;
        }
    }
}
