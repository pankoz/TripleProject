using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Web;
using System.Web.Configuration;
using System.Web.Hosting;

namespace LibraryPart
{
    public class Class1
    {
        public bool IsWebApp { get { return procName.StartsWith("iisexpress"); } }
        public bool IsConApp { get { return !procName.StartsWith("iisexpress"); } }

        public System.Diagnostics.Process currProc { get { return System.Diagnostics.Process.GetCurrentProcess(); } }
        public string procName { get { return currProc.ProcessName; } }

        public string TestMethod()
        {
            string result = "";
            try
            {
                if (IsWebApp)
                { 
                    result = "It's a Web!";
                    Console.WriteLine("OK");
                }
                
                if (IsConApp)
                { 
                    result = "It's a Console!";
                    Console.WriteLine("OK");
                }
                
            }
            catch (Exception exc)
            {
                result += exc.ToString();
            }
            return result; 
        }

    }
}
