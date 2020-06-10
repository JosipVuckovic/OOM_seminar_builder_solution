using System;
using System.Collections.Generic;
using System.Text;

namespace OOM_seminar_builder
{
    public class XmlBuilder : FormatBuilder
    {
        public XmlBuilder(string fname, string lname, DateTime dateBirth)
        {
            fo = new Person(fname, lname, dateBirth);
        }
        public override void PrintFirstName()
        {
           Console.WriteLine($"<?xml version=\"1.0\" encoding=\"UTF - 8\"?> \n" +
                             $"<Person>\n" +
                             $"\t<FirstName>{fo.FirstName}</FirstName>\n" +                           
                             $"</Person>");
            Console.WriteLine();
        }

        public override void PrintLastName()
        {
            Console.WriteLine($"<?xml version=\"1.0\" encoding=\"UTF - 8\"?> \n" +
                             $"<Person>\n" +
                             $"\t<LastName>{fo.LastName}</LastName>\n" +
                             $"</Person>");
            Console.WriteLine();
        }

        public override void PrintDateofBirth()
        {
            Console.WriteLine($"<?xml version=\"1.0\" encoding=\"UTF - 8\"?> \n" +
                             $"<Person>\n" +
                             $"\t<DateOfBirth>{fo.DateOfBirth.ToShortDateString()}</DateOfBirth>\n" +
                             $"</Person>");
            Console.WriteLine();
        }

        public override string PrintPersonAll()
        {
            return new string($"<?xml version=\"1.0\" encoding=\"UTF - 8\"?> \n" +
                             $"<Person>\n" +
                             $"\t<FirstName>{fo.FirstName}</FirstName>\n" +
                             $"\t<LastName>{fo.LastName}</LastName>\n " +
                             $"\t<DateOfBirth>{fo.DateOfBirth.ToShortDateString()}</DateOfBirth>\n" +
                             $"</Person>");           
        }
    }
}
