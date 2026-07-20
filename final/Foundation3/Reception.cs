using System;
using System.Collections.Generic;

namespace EventPartyPlanning
{
    public class Reception : Event
    {
        private string _rsvpEmail;

        public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
        {
            _rsvpEmail = rsvpEmail; //rsvp is the easiest abbrieviation
        }
        public override string GenerateFullDetails()
        {
            return($"Event Type: Reception\n" +
                $"{GenerateStandardDetails()}\n" +
                $"RSVP Required. Email to register: {_rsvpEmail}");

        }
        public override string GenerateShortDescription()
        {
            return BaseShortDescription("Reception");
        }
    }
}
