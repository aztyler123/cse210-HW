using System;
using System.Collections.Generic;

namespace EventPartyPlanning
{
    public class Lecture : Event //this is inheritanceat work
    {
        private string _speaker;
        private int _capacity;

        public Lecture(string title, string description, string date, string time, Address address, string speaker, int capactiy) : base(title, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capactiy;
        }

        public override string GenerateFullDetails()
        {
            return($"Event Type: Lecture\n" +
                $"{GenerateStandardDetails()}\n" +
                $"Speaker: {_speaker}\n" +
                $"Capacity: {_capacity} seats");
        }

        public override string GenerateShortDescription()
        {
            return BaseShortDescription("Lecture");
        }


    }
}