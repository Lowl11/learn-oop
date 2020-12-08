using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.ApplicationUtils;

namespace Tutorial.OOP.Base
{
    public abstract class PrincipleManagerBase : IPrincipleManager
    {

        public PrincipleManagerBase(string introduction)
        {
            PrintMessage(introduction, withLines: true);
        }

        public virtual void ShowGoodExample()
        {
            Console.WriteLine("Good example:");
        }

        public virtual void ShowBadExample()
        {
            Console.WriteLine("Bad example:");
        }

        private void PrintMessage(string message, bool withLines = false)
        {
            if (withLines)
                ConsoleUtils.PrintLines(withoutNewLines: true);

            Console.WriteLine(message);

            if (withLines)
                ConsoleUtils.PrintLines(withoutNewLines: true);
        }

    }
}
