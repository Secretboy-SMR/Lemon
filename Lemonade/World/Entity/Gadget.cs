using Lemonade.Net.Protocol;

namespace Lemonade.World.Entity
{
    public class Gadget : IEntity<Gadget>
    {
        private int id;
        
        public int entityId
        {
            get;
            set;
        }

        public Gadget fromSceneEntityInfo(SceneEntityInfo sceneEntityInfo)
        {
            
            return this;
        }
    }
}
