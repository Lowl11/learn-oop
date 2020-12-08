using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.OOP.Encapsulation.BaseForExample;

namespace Tutorial.OOP.Encapsulation.GoodExample
{
    /*
     * Здесь описание такое же как и в "хорошем" примере, но с оговоркой что здесь код намеренно неправильный.
     */
    public class BadQuadraticEquation : QuadraticEquationBase
    {

        private int a;
        private int b;
        private int c;

        public BadQuadraticEquation(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // Единственный публичный метод который нужен клиенту (другому разработчику).
        public void Calculate()
        {
            // вычисляем дискриминант
            int discriminant = GetDiscriminant();

            // узнаем можно ли вообще найти X1 и X2
            if (PossibleToCalcualteX(discriminant))
            {
                (int x1, int x2) = GetX1X2(discriminant);

                Console.WriteLine($"X1 = {x1} | X2 = {x2}");
                return;
            }

            Console.WriteLine("Вычисление X1 и X2 невозможно т.к. дискриминант меньше нуля");
        }

        // Этот метод никому знать не нужно но мы его специально дадим всем чтобы показать как не нужно делать
        public (int, int) GetX1X2(int discriminant)
        {
            int x1;
            int x2;

            if (discriminant > 0)
            {
                int sqrtDiscriminant = (int)Math.Sqrt(discriminant);
                x1 = (-b + sqrtDiscriminant) / 2 * a;
                x2 = (-b - sqrtDiscriminant) / 2 * a;
            } else
            {
                x1 = x2 = (-b) / 2 * a;
            }

            return (x1, x2);
        }

        // Этот метод никому знать не нужно но мы его специально дадим всем чтобы показать как не нужно делать
        public int GetDiscriminant()
        {
            return b * b - 4 * a * c;
        }

        // Этот метод никому знать не нужно но мы его специально дадим всем чтобы показать как не нужно делать
        public bool PossibleToCalcualteX(int discriminant)
        {
            if (discriminant >= 0)
                return true;

            return false;
        }

    }
}
