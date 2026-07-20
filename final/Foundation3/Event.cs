using System;
using System.Collections.Generic;

namespace EventPartyPlanning
{
    public abstract class Event
    {
        private string _title;
        private string _description;
        private string _date;
        private string _time;
        private Address _address;
        
        //use protected for its protection of data but also greater fluidity.
        protected Event(string title, string description, string date, string time, Address address)
        {
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }

        //now generate the getters
        protected string Title => _title;
        protected string Description => _description;
        protected string Date => _date;
        protected string Time => _time;
        protected Address EventAddress => _address;


        //use the +sign to put inorder and keep things on their own line for viewing pleasure. 
        public string GenerateStandardDetails()
        {
            return($"Title: {_title}\n" +
            $"Description: {_description}\n" +
            $"Date: {_date}\n" +
            $"Time: {_time}\n" +
            $"Location: {_address.GetFullAddress()}");
        }

        public abstract string GenerateFullDetails();

        protected string BaseShortDescription(string eventType)
        {
            return($"Type: {eventType} | Title: {_title} | Date: {_date}"); //organization is in the outline
        }
        public abstract string GenerateShortDescription();
    }
}