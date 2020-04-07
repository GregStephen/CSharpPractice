using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate_Practice_Udemy_Course
{
    class StopwatchExercise
    {
        private bool _hasStarted;
        private DateTime _startTime;
        private DateTime _endTime;

        public void Start()
        {
            if(_hasStarted)
            {
                throw new InvalidOperationException("Stopwatch already started");
            }
            _hasStarted = true;
            _startTime = DateTime.Now;
        }
        
        public void Stop()
        {
            if(!_hasStarted)
            {
                throw new InvalidOperationException("Stopwatch not started yet");
            }
            _hasStarted = false;
            _endTime = DateTime.Now;
            Console.WriteLine(Duration);
        }
        
        public TimeSpan Duration
        {
            get 
            {
                return _endTime - _startTime;
            
            }
        }
    }
}
