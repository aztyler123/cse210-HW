using System;
using System.Collections.Generic;
//follow tje written plan for each activity pretty simple.
namespace FitnessTracker
{
    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(string date, int minutes, int laps) : base(date, minutes)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            //conversion equation provided.
            return _laps * 50.0 / 1000.0 * 0.62;
        }
    }
}