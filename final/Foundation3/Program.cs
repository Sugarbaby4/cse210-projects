using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("143 S 2nd E", "Rexburg", "ID", "USA");
        Address address2 = new Address("604 Patterson Lake Rd", "Winthrop", "WA", "USA");
        Address address3 = new Address("430 NE Juniper St", "Prineville", "OR", "USA");


        List<Event> events = new List<Event>
        {
            new Lecture("Proper Use Of AI", "Tech Talk with BYUI Professer", "23 Jan 2026", "6:00 PM", address1, "Brother Gibbins", 100),
            new Reception("Wedding Reception", "Come celebrate the union of Mara Strong and Collin King", "15 Apr 2026", "9:00 AM", address2, "rsvp@event.com"),
            new OutdoorGathering("Community Picnic", "Family friendly LDS picnic and service project", "20 June 2026", "1:00 PM", address3, "Sunny, 78°F")
        };


        foreach (Event e in events)
        {
            Console.WriteLine("---STANDARD DETAILS---");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine("\n---SHORT DESCRIPTION---");
            Console.WriteLine(e.GetShortDetails());
            Console.WriteLine("\n---Long Description---");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine("---------------------------\n");
        }
    }
}