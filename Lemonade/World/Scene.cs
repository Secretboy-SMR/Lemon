using System.Collections.Generic;
using Lemonade.Net.Protocol;

namespace Lemonade.World
{
    public class Scene
    {
        public Scene(int id)
        {
            this.id = id;
        }
        public int id;
        
        private Dictionary<uint, SceneEntityInfo> Entities = new();

        public void addEntity(SceneEntityInfo entityInfo)
        {
            Entities.Add(entityInfo.EntityId, entityInfo);
        }

        public void removeEntity(uint entityId)
        {
            if (Entities.ContainsKey(entityId)) Entities.Remove(entityId);
        }
    }
}
