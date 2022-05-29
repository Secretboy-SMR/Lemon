using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using Serilog;

using System.Diagnostics;

namespace Lemonade.Encounter
{
    public class Encounter
    {
        public int EncounterId { get; set; }
        public string EncounterName { get; set; }

        public Task TimeoutTask;

        //in ms
        public static int timeout = 10000;

        //actual timestamp from system
        public long startTime;
        
        
        //these two are for relative time
        public Stopwatch EncounterTimer = new Stopwatch();
        public Stopwatch PauseTimer = new Stopwatch();

        private long _latestHitTs;
        private long _earliestHitTs;


        private List<AttackResult> _attacks;

        private World.World _world;
        public DelayedMethodCaller methodCaller = new DelayedMethodCaller(timeout);
        
        
        public Encounter(World.World world, long timestamp)
        {
            Log.Information("Encounter Started!");
            _attacks = new List<AttackResult>();
            _world = world;
            startTime = timestamp;
            
            //Task.Run(DpsUpdateLoop);
        }
        
        public Encounter(World.World world, long timestamp, AttackResult attackResult)
        {
            Log.Information("Encounter Started!");
            _attacks = new List<AttackResult>();
            _world = world;
            startTime = timestamp;

            EncounterTimer.Start();
            //theoretically should always be 0 but who knows 
            _earliestHitTs = EncounterTimer.ElapsedMilliseconds;
            
            
            AddNewAttack(attackResult);
            
            //Task.Run(DpsUpdateLoop);
        }

        public void SetEncounterTimerPauseState(bool flag)
        {
            if (flag)
            {
                EncounterTimer.Stop();
                PauseTimer.Restart();


            }
            else
            {
                EncounterTimer.Start();
                PauseTimer.Stop();

            }
        }

        public void AddNewAttack(AttackResult result)
        {

            _attacks.Add(result);

            _latestHitTs = EncounterTimer.ElapsedMilliseconds;
            
            
            //if this is called repeatedly in an interval less than 10 seconds, then the func doesnt get called
            methodCaller.CallMethod(CloseEncounter);
            
            
        }
        



        public async Task DpsUpdateLoop()
        {
            //TODO: implement actual dps calcs
            
            await Task.Delay(500);
            _ = DpsUpdateLoop();
        }
        
        public async void CloseEncounter()
        {

            
            //check if encounter has been paused, if so, delay by that time

            if (PauseTimer.ElapsedMilliseconds != 0)
            {
                Log.Information("Encounter was paused, skipping");
                return;
            }

            
            var totalDmg = 0.0;
            var totalTime = _latestHitTs - _earliestHitTs;
            
            EncounterTimer.Stop();
            _attacks.ToList().ForEach(_attacks =>
            {
                if (_attacks.AttackerId < (2 << 24))
                {
                    totalDmg += _attacks.Damage;

                }
            });
            
            Log.Information("encounter closed: {A} ",(totalDmg/totalTime) * 1000);
            _world.CloseCurrentEncounter();
        }
        
        


    }
}
