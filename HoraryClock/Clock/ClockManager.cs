using HoraryClock;
using HoraryEffects;
using System.Runtime.CompilerServices;

namespace Clock
{
    public class ClockManager
    {
        private static ClockManager _instance;

        private DateTime LaastCheck { get; set; }
        public bool IsRunning { get; private set; }
        public double ElapsedTime { get; set; }

        private EffectManager EffectManager { get; set; } = EffectManager.Instance();
        private Config Config { get; set; } = Config.Instance();

        private ClockManager()
        {
            
        }

        public static ClockManager Instance()
        {
            if (_instance == null)
            {
                _instance = new ClockManager();
            }
            return _instance;
        }

        public async Task StartAsync()
        {
            if (!IsRunning)
            {
                LaastCheck = DateTime.Now;
                IsRunning = true;
                while (IsRunning)
                {
                    DateTime newCheck = DateTime.Now;
                    ElapsedTime += ((newCheck - LaastCheck).TotalMilliseconds);
                    LaastCheck = newCheck;

                    if (ElapsedTime > EffectManager.CurrentEffect().Duration * 1000)
                    {
                        ElapsedTime -= EffectManager.CurrentEffect().Duration * 1000;
                        EffectManager.AdvanceEffect();          
                    }
                }
            }
        }

        public void Pause()
        {
            IsRunning = false;
        }

        public void Reset()
        {
            if (!(Config.StartClockOnReset == Config.CHECKED))
            {
                Pause();
            } else
            {
                Task.Run(() => StartAsync());
            }
            if (Config.PvPOffsett == Config.CHECKED)
            {
                ElapsedTime = 3000;
            }
            else
            {
                ElapsedTime = 0;
            }
            EffectManager.Reset();
        }


    }
}