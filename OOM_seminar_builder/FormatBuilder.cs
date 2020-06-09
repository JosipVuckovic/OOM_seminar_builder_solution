using System;
using System.Collections.Generic;
using System.Text;

namespace OOM_seminar_builder
{
    //builder Director
    public class BuilderDirecotr
    {
        public string Create(FormatBuilder formatBuilder)
        {
            formatBuilder.AddFirstName();
            formatBuilder.AddLastName();
            formatBuilder.AddDateOfBirth();
            return formatBuilder.PrintPersonAll();
        }
    }


    //Abstract builder
    public abstract class FormatBuilder
    {
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public abstract void AddFirstName();
        public abstract void AddLastName();
        public abstract void AddDateOfBirth();
        public abstract string PrintPersonAll();

        protected Person fo;
        public Person Person => fo;
    }
}
