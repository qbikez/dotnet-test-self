using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(
                Microsoft.Extensions.PlatformAbstractions.PlatformServices.Default.Application,
                Newtonsoft.Json.Formatting.Indented
            ));
            System.Console.WriteLine("args:");
            foreach (var a in args)
            {
                System.Console.WriteLine(a);
            }
            if (args.Length > 1)
            {
                var sleep = int.Parse(args[1]);
                System.Threading.Thread.Sleep(sleep);
            }
        }
    }
}
