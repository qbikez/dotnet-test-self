using System;
using System.Linq;

namespace DotnetTestSelf
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("args:");
            foreach (var a in args) {
                System.Console.WriteLine(a);
            }
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "dotnet.exe";
            var largs = args.ToList();
            largs.Insert(0, "run");
            proc.StartInfo.Arguments = string.Join(" ", largs);
            
            proc.Start();
            
        }
    }
}
