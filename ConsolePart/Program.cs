using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePart
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryPart.Class1 selector = new LibraryPart.Class1();
            Console.Title = "MASTER 3 commit BRANCH";
            Console.WriteLine(selector.TestMethod());
            Console.ReadLine();

        }
    }
}
