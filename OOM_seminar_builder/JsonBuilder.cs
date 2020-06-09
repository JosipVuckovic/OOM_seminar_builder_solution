using System;
using System.Collections.Generic;
using System.Text;

namespace OOM_seminar_builder
{
    public class JsonBuilder : FormatBuilder
    {
        public JsonBuilder()
        {
            fo = new Person("Json");
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
            return new string($"[{{\"FirstName\": \"{fo.FirstName}\" , \"LastName\": \"{fo.LastName}\" , \"DateOfBirth\": \"{fo.DateOfBirth}\"}}]");
        }
    }
}
