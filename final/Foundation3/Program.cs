using System;
using System.Collections.Generic;

namespace EventPartyPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            Address addr1 = new Address("2893 Revere Rd", "Phoneix", "AZ", "89276");
            Address addr2 = new Address("178 Buckeye St", "Detroit", "MA", "17634");
            Address addr3 = new Address("2536 Lily Pond Circle", "Idaho Falls", "ID", "23568");

            List<Event> eventsList = new List<Event>
            {
                new Lecture("The Fall of Our World", "A dive into the loss from AI", "2026-08-12", "12:30 PM", addr1, "Brother Jacob Gibson", 220),
                new Reception("Annual October Fest", "Connect with Adults your Age.", "2026-07-07", "6:00 PM", addr2, "octoberfest_rsvp@event.com"),
                new OutdoorGathering("Coon's Bluff Campout", "An outdoor camping adventure to help bring the community together.", "2026-07-05", "10:00 AM", addr3, "Cloudy with a light wind, 65 degrees Fahrenheit. ")
            };
            int counter = 1;
            foreach (Event eve in eventsList)
            {
                Console.WriteLine("--------------------------------------\n");
                Console.WriteLine($"  Generateing Messages For Event {counter} ");
                Console.WriteLine("--------------------------------------\n");

                Console.WriteLine("---[Message 1: Short Description] ---");
                Console.WriteLine(eve.GenerateShortDescription());
                Console.WriteLine();

                Console.WriteLine("---- [Message 2: Standard Details] ---");
                Console.WriteLine(eve.GenerateStandardDetails());
                Console.WriteLine();

                Console.WriteLine("---- [Message 3: Full Details] ----");
                Console.WriteLine(eve.GenerateFullDetails());
                Console.WriteLine("\n");

                counter++; //I forgot to add it above for it to keep count.

            }

        }
    }
}