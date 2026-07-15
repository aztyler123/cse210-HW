using System;

namespace EternalQuest
{
    //progressive goals add-on for above and beyond

    public class ProgressiveGoal : Goal
    {
        private double _currentProgress;
        private double _targetProgress;
        private string _unit;

        public string Unit => _unit;
        public double CurrentProgress => _currentProgress;
        public double TargetProgress => _targetProgress;

        public ProgressiveGoal(string name, string description, int points, double targetProgress, string unit, double currentProgress = 0) : base(name, description, points)
        {
            _targetProgress = targetProgress;
            _unit = unit;
            _currentProgress = currentProgress;
        }

        public int RecordProgressAmount(double amount)
        {
            if (IsComplete()) return 0;

            _currentProgress += amount;
            if (_currentProgress > _targetProgress) _currentProgress = _targetProgress;

            // Calculate the proportional points earned based on progress made
            double completionRatio = amount / _targetProgress;
            int pointsEarned = (int)(Points * completionRatio);

            // Add a 50% milestone completion bonus if they hit the target metric
            if (IsComplete())
            {
                pointsEarned += (int)(Points * 0.5);
            }

            // Fallback to guarantee they get at least some points for making an effort
            return pointsEarned > 0 ? pointsEarned : 10;
        }

        public override int RecordEvent()
        {
            return RecordProgressAmount(1.0);
        }
        public override bool IsComplete() => _currentProgress >= _targetProgress;

        public override string GetDetailsString()
        {
            string statusSymbol = IsComplete() ? "[X]" : "[ ]";
            return $"{statusSymbol} {ShortName} ({Description}) -- Progress: {_currentProgress}/{_targetProgress} {_unit}";
        }

        public override string GetStringRepresentation()
        {
            return $"ProgressiveGoal:{ShortName},{Description},{Points},{_targetProgress},{_unit},{_currentProgress}";
        }

    }
    
}