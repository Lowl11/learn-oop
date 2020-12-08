using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.OOP.Encapsulation.BaseForExample;

namespace Tutorial.OOP.Encapsulation.GoodExample
{
    /*
     * Как пример возьмем квадратное уравнение. Не ссыте, щя объясню как оно решается если забыли :)
     * Уравнение:
     *      ax^2 + bx + c = 0
     * Решение:
     *      d = b^2 - 4ac
     *      если d > 0:
     *          x1 = (-b + sqrt(d)) / 2a - sqrt это "под корнем"
     *          x2 = (-b - sqrt(d)) / 2a
     *      если d == 0:
     *          x1, x2 = (-b) / 2a - здесь просто убирается "под корнем d"
     *      если d < 0:
     *          ответа нет (он не решаем)
     * 
     * Итак, где же нам здесь использовать инкапсуляцию? Для начала нужно понять в чем вообще цель данного класса.
     * А цель такова: предоставить пользователю, то есть разработчику которому нужен результат и ничего более, метод(ы) который
     *      позволит получить X1, X2 или понять что ответ нельзя вычислить.
     * Значит, нам нужно предоставить всего 1 метод и при этом мы можем не ограничивать себя в использовании множества других (если они нужны).
     */
    public class GoodQuadraticEquation : QuadraticEquationBase
    {

        private int a;
        private int b;
        private int c;

        public GoodQuadraticEquation(int a, int b, int c)
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

        // Этот метод никому знать не нужно
        private (int, int) GetX1X2(int discriminant)
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

        // Этот метод никому знать не нужно
        private int GetDiscriminant()
        {
            return b * b - 4 * a * c;
        }

    }
}
