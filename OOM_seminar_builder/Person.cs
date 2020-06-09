using System;
using System.Collections.Generic;
using System.Text;

namespace OOM_seminar_builder
{
    public class Person
    {
        private string _type;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string type)
        {
            _type = type;
        }
    }
}
