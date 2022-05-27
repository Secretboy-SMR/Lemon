using System.Collections.Generic;
using System.Threading.Tasks;
using Lemonade.Net.Protocol;

namespace Lemonade.Encounter
{
    public class Encounter
    {
        public int EncounterId { get; set; }
        public string EncounterName { get; set; }

        public Task Timeout;
        private long latestTS;

        private List<AttackResult> Attacks;

        private World.World _world;
        public Encounter(World.World world, long timestamp)
        {
            Attacks = new List<AttackResult>();
            _world = world;
            Task.Run(DPSUpdateLoop);
        }

        public void AddNewAttack(AttackResult result)
        {
            Attacks.Add(result);
            latestTS = System.DateTime.Now.Ticks;
            
            Timeout = Task.Run(checkTimeout);

        }

        public void checkTimeout()
        {
            Timeout.Wait(30000);
            //allowing for some error
            if (latestTS - System.DateTime.Now.Ticks > 31000)
            {
                CloseEncounter();
            }
        }



        public async Task DPSUpdateLoop()
        {
            //TODO: implement actual dps calcs
            
            await Task.Delay(500);
            _ = DPSUpdateLoop();
        }
        public void CloseEncounter()
        {
            // do some final calculations
            // and wrap up
            // then signal to World.cs that the encounter is over
            _world.CloseCurrentEncounter();
        }
        
        


    }
}
