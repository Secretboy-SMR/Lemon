using System.Collections.Generic;
using Lemonade.Net.Protocol;
using Serilog;

namespace Lemonade.World
{
    public class World
    {
        public Scene Scene = new Scene(3);

        public List<Player> Players = new();
        
        public int Level = 1;
        public int OwnerId;

        public List<Encounter.Encounter> pastEncounters;

        public Encounter.Encounter currentEncounter;
        
    
        public void addEntity(SceneEntityInfo entityInfo)
        {
            Scene.addEntity(entityInfo);
        }

        public void RemoveEntity(uint id)
        {
            Scene.removeEntity(id);
        }

        public void changeScene(int id)
        {
            
        }

        public void addPlayer()
        {
            
        }

        public void handleDamage(AttackResult attackResult)
        {
            Log.Information("{a} hit {b} for {c} dmg", attackResult.AttackerId,
                attackResult.DefenseId, attackResult.Damage);
            if (currentEncounter == null)
            {
                currentEncounter = new Encounter.Encounter(this, System.DateTime.Now.Ticks);
            }
            currentEncounter.AddNewAttack(attackResult);
        }

        public void CloseCurrentEncounter()
        {
            pastEncounters.Add(currentEncounter);
            currentEncounter = null;
        }
        
        

    }

        
}
