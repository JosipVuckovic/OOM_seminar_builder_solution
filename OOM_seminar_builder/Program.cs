using System;

namespace OOM_seminar_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            FormatBuilder builder;
            var director = new BuilderDirecotr();

            builder = new JsonBuilder();
            var outputJson = director.Create(builder);
            Console.WriteLine(outputJson);

            builder = new XmlBuilder();
            var outputXml = director.Create(builder);
            Console.WriteLine(outputXml);


        }
    }
}
