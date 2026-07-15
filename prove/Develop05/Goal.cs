using System;

namespace EternalQuest
{
    public abstract class Goal //this will contain privates that are encapsalted.
    {
        private string _shortName;
        private string _description;
        private int _points;

        public Goal(string name, string description, int points)
        {
            _shortName = name;
            _description = description;
            _points = points;

        //made variables that are easily accessible
        }

        //Encapulation
        public string ShortName => _shortName; //separator from member name and implementation makes it a "get"
        public string Description => _description;
        public int Points => _points;


        //polymorphic things
        public abstract int RecordEvent();
        public abstract bool IsComplete();
        public virtual string GetDetailsString()
        {
            string statusCheckbox = IsComplete() ? "[X]" : "[ ]";
            return $"{statusCheckbox} {_shortName} ({_description})";
        }
        public abstract string GetStringRepresentation();
    }
}