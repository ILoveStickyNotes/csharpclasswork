using System;

namespace Exercises02
{
    class Stopwatch
    {
        private static bool _running;
        public static DateTime StartTime { get; set; }
        public static DateTime StopTime { get; set; }

        public TimeSpan Duration;  

        public Stopwatch()
        {

        }

        public void Start()
        {
            StartTime = DateTime.Now;
            Console.WriteLine(StartTime);
            if (_running)
                throw new InvalidOperationException("Stopwatch already running");
            _running = true;
        }

        public void Stop()
        {
            StopTime = DateTime.Now;
            Console.WriteLine(StopTime);
            _running = false;
            Duration = StopTime - StartTime;
        }
    }
}