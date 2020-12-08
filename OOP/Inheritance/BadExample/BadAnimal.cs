using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.OOP.Inheritance.BadExample
{
    public abstract class BadAnimalBase
    {

        public abstract void Speak();

    }

    public class BadDog : BadAnimalBase
    {

        public override void Speak()
        {
            Console.WriteLine("гав гав");
        }

    }

    public class BadElephant : BadAnimalBase
    {

        public override void Speak()
        {
            Console.WriteLine("Туту");
        }

    }

    public class BadPenguin : BadAnimalBase
    {

        public override void Speak()
        {
            Console.WriteLine("Кря кря"); // хз че они там говорят :)
        }

    }

}
