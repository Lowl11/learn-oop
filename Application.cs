using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.ApplicationUtils;
using Tutorial.OOP.Base;
using Tutorial.OOP.Encapsulation;
using Tutorial.OOP.Inheritance;
using Tutorial.OOP.Polymorphism;

namespace Tutorial
{
    public class Application
    {

        public void Run()
        {
            IPrincipleManager principleManager = GetPrincipleManager(Principle.Encapsulation);
            principleManager.ShowBadExample();
            ConsoleUtils.PrintLines();
            principleManager.ShowGoodExample();
        }
        
        private IPrincipleManager GetPrincipleManager(Principle principle)
        {
            switch (principle)
            {
                case Principle.Encapsulation:
                    return new EncapsulationManager();
                case Principle.Inheritance:
                    return new InheritanceManager();
                case Principle.Polymorphism:
                    return new PolymorphismManager();
                default:
                    throw new Exception("Отсутствует реализация");
            }
        }

    }
}
