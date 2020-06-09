using System;

namespace OOM_seminar_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            FormatBuilder builder;
            var director = new BuilderDirecotr();

            builder = new JsonBuilder("Jane","Doe", new DateTime(2020,6,9));
            var outputJson = director.Create(builder);
            Console.WriteLine(outputJson);
            Console.WriteLine();

            builder = new XmlBuilder("Jon", "Doe", new DateTime(2020,6,9));
            var outputXml = director.Create(builder);
            Console.WriteLine(outputXml);
            Console.WriteLine();

            JsonBuilder jsbuild = new JsonBuilder("test", "test", new DateTime(2000, 5, 7));
            var tmp = director.Create(jsbuild);
            Console.WriteLine(tmp);
            Console.WriteLine();


        }
    }
}
