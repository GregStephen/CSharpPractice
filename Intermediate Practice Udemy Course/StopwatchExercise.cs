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
                throw new InvalidOperationException();
            }
            _hasStarted = true;
            _startTime = DateTime.Now;
        }
        
        public void Stop()
        {
            _hasStarted = false;
            _endTime = DateTime.Now;
            Console.WriteLine(Duration);
        }
        
        public TimeSpan Duration
        {
            get 
            {
                var timeBetween = _endTime - _startTime;
                return timeBetween;
            }
        }
    }
}
