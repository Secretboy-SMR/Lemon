using System.Collections.Generic;
using System.Linq;
using Lemonade.Constants;
using Lemonade.Net.Protocol;
using Serilog;

namespace Lemonade.World
{
    
    //idk why i even bothered making this class
    
    public class Scene
    {
        public World World;
        public Scene(World world, uint id)
        {
            World = world;
            Id = id;
        }

        //ownedid -> ownerid
        //owner can have more than one owned id
        private Dictionary<uint, uint> OwnerDictionary = new(); 
        
        public uint Id;
        
        private Dictionary<uint, SceneEntityInfo> _entities = new();

        public void AddEntity(SceneEntityInfo entityInfo)
        {
            _entities.Add(entityInfo.EntityId, entityInfo);
            if (entityInfo.Gadget != null && entityInfo.Gadget.OwnerEntityId != null)
            {
                AssociateOwner(entityInfo.Gadget.OwnerEntityId, entityInfo.EntityId);
            }
        }
        
        public void RemoveEntity(uint entityId)
        {
            if (_entities.ContainsKey(entityId)) _entities.Remove(entityId);
            if (OwnerDictionary.ContainsKey(entityId)) OwnerDictionary.Remove(entityId);

        }

        public void AssociateOwner(uint ownerId, uint entityId)
        {
            OwnerDictionary.Add(entityId, ownerId);
        }

        public void ChangeEntityStats(uint id, FightPropPair fpr)
        {
            uint proptype = 0;
            float propvalue = 0;
            float propdelta = 0;

            int found = 0;
            if (_entities.ContainsKey(id))
                foreach (var pair in _entities[id].FightPropList)
                {
                    if (pair.PropType == fpr.PropType)
                    {
                        proptype = pair.PropType;
                        propdelta = fpr.PropValue-pair.PropValue;

                        propvalue = fpr.PropValue;
                        pair.PropValue = fpr.PropValue;
                        found++;
                    }
                }
            
            if(found >0) Log.Information("Entity {id}'s {propType} was changed to {value}(change of {delta}).", id, (FightPropType)proptype, propvalue, propdelta);
        }

        public void MoveEntity(uint id, MotionInfo motionInfo)
        {
            if (_entities.ContainsKey(id)) _entities[id].MotionInfo = motionInfo;
            
            //World.GameLogger.AddEntry();
        }

        public uint? GetOwner(uint id)
        {

            if (OwnerDictionary.TryGetValue(id,out Id))
            {
                return Id;
            }
            else
            {
                return null;
            }
        }

        public ProtEntityType? GetEntityType(uint entityId)
        {
            try
            {
                return (ProtEntityType)(entityId >> 24);
            }catch
            {
                return null;
            }
        }

        public int GetEntityCount()
        {
            return _entities.Count;
        }
        
    }
}
