using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points){}

        public override int RecordEvent() => Points;

        //eternal goals won't mark themselves complete
        public override bool IsComplete() => false;
        public override string GetDetailsString()
        {
            return $"[oo] {ShortName} ({Description}) - Recordable indefinitely";
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal:{ShortName},{Description},{Points}";
        }
    }
}