using HoraryClock;
using HoraryEffects;
using System.Runtime.CompilerServices;

namespace Clock
{
    public class ClockManager
    {
        private DateTime _lastCheck;

        public bool IsRunning { get; private set; }
        public double ElapsedTime { get; set; }

        private EffectManager EffectManager { get; set; } = EffectManager.Instance();
        private Config Config { get; set; } = Config.Instance();

        public void Start()
        {
            if (!IsRunning)
            {
                _lastCheck = DateTime.Now;
                IsRunning = true;
                while (IsRunning)
                {
                    DateTime newCheck = DateTime.Now;
                    ElapsedTime += ((newCheck - _lastCheck).TotalMilliseconds);
                    _lastCheck = newCheck;

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
                Start();
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