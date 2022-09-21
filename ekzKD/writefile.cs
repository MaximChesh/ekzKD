using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekzKD
{
    internal class writefile
    {
        public static void writetxt(string fileNamewrite, string result /*, int i, int j, int day*/ )
        {
            File.WriteAllText(fileNamewrite, result);
        }
    }
}
