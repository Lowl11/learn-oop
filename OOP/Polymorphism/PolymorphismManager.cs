using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.OOP.Base;

namespace Tutorial.OOP.Polymorphism
{
    public class PolymorphismManager : PrincipleManagerBase
    {

        private const string ThemeName = "Полиморфизм";

        public PolymorphismManager()
            : base(ThemeName)
        {
            // 
        }

        public override void ShowGoodExample()
        {
            Console.WriteLine("Polymorphism good example");
        }

        public override void ShowBadExample()
        {
            Console.WriteLine("Polymorphism bad example");
        }

    }
}
