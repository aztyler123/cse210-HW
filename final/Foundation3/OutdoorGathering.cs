using System;
using System.Collections.Generic;

namespace EventPartyPlanning
{
    public class OutdoorGathering : Event
    {
        private string _weatherForecast;

        public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
        {
            _weatherForecast = weatherForecast;
        }

        public override string GenerateFullDetails()
        {
            return($"Event Type: Outdoor Gathering\n" +
                $"{GenerateStandardDetails()}\n" +
                $"Weather Forecast: {_weatherForecast}");
        }

        public override string GenerateShortDescription()
        {
            return BaseShortDescription("Outdoor Gathering");
        }
    }
}