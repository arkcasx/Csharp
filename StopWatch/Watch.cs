using System;
using System.Security.AccessControl;

namespace StopWatch
{
    public class Watch
    {
        private bool _running;
        
        
        public DateTime StartTime { get; private set; }
        public void Start()
        {
            if (!_running)
            {
                StartTime = DateTime.Now;
                _running = true;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch is running");
            }
            
        }

        public TimeSpan StopTime ()
        {

            if (_running)
            {
                var timeSpan = DateTime.Now - StartTime;
                /* var hourSpan = timeSpan.Hours;
                 var minuteSpan = timeSpan.Minutes;
                 var secondSpan = timeSpan.Seconds;
                 var time = hourSpan + ":" + minuteSpan + ":" + secondSpan;*/
                _running = false;
                return timeSpan;

            }
            else
            {
                throw new InvalidOperationException("Stopwatch is not running");
            }
                
            
            
        }
    }
}