using System;
using System.Linq;

namespace DotnetTestSelf
{
    public class Program
    {
        public static void Main(string[] args)
        {
          
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "dotnet.exe";
            var largs = args.Where(a => a != "--").ToList();
            largs.Insert(0, "run");
            proc.StartInfo.Arguments = string.Join(" ", largs);
            
            proc.Start();
            proc.WaitForExit();            
        }
    }
}
