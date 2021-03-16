#nullable enable

using System;

namespace NullHandling
{
    class Program
    {
        public string? Building;   // can be null
        public string Street = string.Empty;      // must have a value
        public string City = string.Empty;        // must have a value
        public string Region = string.Empty;      // must have a value

        static void Main(string[] args)
        {
            /* int thisCannotBeNull = 4;
            // thisCannotBeNull = null; // compile error!
            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault()); */

            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;
        }
    }
}
