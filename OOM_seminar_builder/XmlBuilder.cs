using System;
using System.Collections.Generic;
using System.Text;

namespace OOM_seminar_builder
{
    public class XmlBuilder : FormatBuilder
    {
        public XmlBuilder()
        {
            fo = new Person("Xml");
        }

        public override void AddDateOfBirth()
        {
            fo.DateOfBirth = DateTime.Now;
        }

        public override void AddFirstName()
        {
            fo.FirstName = "John";
        }

        public override void AddLastName()
        {
            fo.LastName = "Doe";
        }

        public override string PrintPersonAll()
        {
            return new string($"<?xml version=\"1.0\" encoding=\"UTF - 8\"?> \n" +
                             $"<Person>\n" +
                             $"\t<FirstName>{fo.FirstName}</FirstName>\n" +
                             $"\t<LastName>{fo.LastName}</LastName>\n " +
                             $"\t<DateOfBirth>{fo.DateOfBirth}</DateOfBirth>\n" +
                             $"</Person>");
        }
    }
}
