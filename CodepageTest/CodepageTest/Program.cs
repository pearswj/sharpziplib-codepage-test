using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.Zip;
using System.IO;

namespace CodepageTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = File.OpenRead(args[0]);
            ZipFile zf = new ZipFile(fs); // we are getting the error on this line that 1 is not a supported code page. Parameter name:   codepage        }
        }
    }
}
