using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CKScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Process yasca = new Process();
            yasca.StartInfo.FileName = ("D:\\args.exe");
            yasca.StartInfo.Arguments = "1 2 3 4 5 6 7 8 2 1 4 2";
            yasca.Start();
            //Console.Read();
        }
    }
}
