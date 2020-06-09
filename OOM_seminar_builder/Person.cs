using System;
using System.Collections.Generic;
using System.Text;

namespace OOM_seminar_builder
{
    public class Person
    {        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string fname, string lname, DateTime dateBirth)
        {
            FirstName = fname;
            LastName = lname;
            DateOfBirth = dateBirth;
        }
    }
}
