using System.Collections.Generic;
using Lemonade.Logging;
using Lemonade.Net.Protocol;
using Serilog;



namespace Lemonade.World
{
    public class World
    {
        public Scene Scene;

        public List<Player> Players = new();
        
        public int Level = 1;
        public int OwnerId;

        public List<Encounter.Encounter> PastEncounters = new();

        public Encounter.Encounter? CurrentEncounter;



        public GameLogger GameLogger = OutputManager.CreateLog();

        public World()
        {
            //default
            Scene = new Scene(this,3);
        }

        public void AddEntities(SceneEntityInfo[] entities)
        {
            foreach (SceneEntityInfo entityInfo in entities)
            {           
                Scene.AddEntity(entityInfo);
            }
            //Log.Information($@"Registered {entities.Length} Entit{(entities.Length == 1 ? "y" : "ies")}");
        }

        public void RemoveEntities(uint[] ids, VisionType type)
        {
            foreach (uint entityId in ids)
            {           
                Scene.RemoveEntity(entityId);
            }

            
            
            //Log.Information($@"Removed {ids.Length} Entit{(ids.Length == 1 ? "y" : "ies")}, {Scene.GetEntityCount()} remain");
            
        }

        public void MoveEntity(uint id, MotionInfo motionInfo)
        {
            Scene.MoveEntity(id, motionInfo);
        }

        public void ChangeScene(uint id)
        {
            
            //todo: figure out if i need to do anything special with the removal of entities
            Scene = new Scene(this, id);
        }
        
        public void HandleDamage(AttackResult attackResult)
        {
            if (CurrentEncounter == null)
            {
                CurrentEncounter = new Encounter.Encounter(this, System.DateTime.Now.Ticks,attackResult);
                return;
            }
            CurrentEncounter.AddNewAttack(attackResult);

            uint? Attacker = Scene.GetOwner(attackResult.AttackerId) != null
                ? Scene.GetOwner(attackResult.AttackerId)
                : attackResult.AttackerId;
            
            Log.Information("{as} dmg from {asd} to {asdf}", attackResult.Damage, Attacker, attackResult.DefenseId);
        }

        public void CloseCurrentEncounter()
        {
            PastEncounters.Add(CurrentEncounter);
            CurrentEncounter = null;
        }
        
        

    }

        
}
