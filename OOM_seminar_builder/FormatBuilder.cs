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
            formatBuilder.PrintFirstName();
            formatBuilder.PrintLastName();
            formatBuilder.PrintDateofBirth();
            return formatBuilder.PrintPersonAll();
        }
    }


    //Abstract builder
    public abstract class FormatBuilder
    {       
        public abstract void PrintFirstName();
        public abstract void PrintLastName();
        public abstract void PrintDateofBirth();
        public abstract string PrintPersonAll();

        protected Person fo;
        public Person Person => fo;
    }
}
