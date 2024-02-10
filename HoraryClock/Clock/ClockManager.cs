using HoraryClock;
using HoraryEffects;
using System.Runtime.CompilerServices;

namespace Clock
{
    public class ClockManager
    {
        private static ClockManager _instance;

        private object _lock = new object();
        private DateTime LastCheck { get; set; }
        public bool IsRunning { get; private set; }
        public double ElapsedTime { get; set; }
        public int RefreshDelay { get; set; } = 10;
        private EffectManager EffectManager { get; set; } = EffectManager.Instance();
        private Config Config { get; set; } = Config.Instance();

        private ClockManager()
        {
            IsRunning = false;
            if (Config.PvPOffsett == Config.CHECKED)
            {
                ElapsedTime = 3000;
            }
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
                LastCheck = DateTime.Now;
                IsRunning = true;
                while (IsRunning)
                {
                    lock (_lock)
                    {
                        DateTime newCheck = DateTime.Now;
                        ElapsedTime += ((newCheck - LastCheck).TotalMilliseconds);
                        LastCheck = newCheck;

                        int effectDuration = EffectManager.CurrentEffect().Duration;

                        if (ElapsedTime > effectDuration * 1000)
                        {
                            ElapsedTime -= effectDuration * 1000;
                            EffectManager.AdvanceEffect();
                        }
                    }
                    await Task.Delay(RefreshDelay);
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
            }
            else
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