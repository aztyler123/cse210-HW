using System;
using System.Collections.Generic;

namespace FitnessTracker
{
    public abstract class Activity
    {
        private string _date;
        private int _minutes;

        public Activity(string date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        //getters that will be protected
        protected string Date => _date;
        protected int Minutes => _minutes;

        public abstract double GetDistance();


        public virtual double GetSpeed()
        {
            if (GetDistance() == 0) return 0;
            return (GetDistance() / _minutes) * 60;
        }

        public virtual double GetPace()
        {
            if (GetDistance() == 0) return 0;
            return (GetDistance() / _minutes) * 60;
        }

        public virtual string GetSummary()
        {
            return($"{_date} {GetType().Name} ({_minutes} min): " +
            $"Distance {GetDistance():F1} miles, " +
            $"Speed {GetSpeed():F1} mph, " +
            $"Pace: {GetPace():F1} min per mile");
        }
    }
}