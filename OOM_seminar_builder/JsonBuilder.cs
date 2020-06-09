using System;
using System.Collections.Generic;
using System.Text;

namespace OOM_seminar_builder
{
    public class JsonBuilder : FormatBuilder
    {
        public JsonBuilder(string fname, string lname, DateTime dateBirth)
        {
            fo = new Person(fname, lname, dateBirth);
        }

        public override void PrintDateofBirth()
        {
            Console.WriteLine($"[{{\"FirstName\": \"{fo.FirstName}\"}}]");
            Console.WriteLine();
        }

        public override void PrintFirstName()
        {
            Console.WriteLine($"[{{\"LastName\": \"{fo.LastName}\"}}]");
            Console.WriteLine();
        }

        public override void PrintLastName()
        {
            Console.WriteLine($"[{{\"DateOfBirth\": \"{fo.DateOfBirth.ToShortDateString()}\"}}]");
            Console.WriteLine();
        }

        public override string PrintPersonAll()
        {
            return new string($"[{{\"FirstName\": \"{fo.FirstName}\" , \"LastName\": \"{fo.LastName}\" , \"DateOfBirth\": \"{fo.DateOfBirth.ToShortDateString()}\"}}]");
        }
    }
}
