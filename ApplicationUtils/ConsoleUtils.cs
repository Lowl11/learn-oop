using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.ApplicationUtils
{
    public class ConsoleUtils
    {

        public static void PrintLines(bool withoutNewLines = false)
        {
            string newLine = String.Empty;
            if (!withoutNewLines)
                newLine = "\n";
            Console.WriteLine($"{newLine}============================================={newLine}");
        }

    }
}
