using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.OOP.Encapsulation.BaseForExample
{
    public abstract class QuadraticEquationBase
    {

        /* 
         * Метод вынесен в данный класс чтобы показать пример как использовать "protected" и зачем он вообще нужен
         * 
         * Конкретно в данном примере мы вынесли проверку, можем ли мы вычислить X1 и X2 по данному дискриминанту
         *      этот метод используется в обоих классах: BadQuadraticEquation и GoodQuadraticEquation.
         * 
         * Частично здесь задето Наследование, но пока забейте, просто поймите что таким образом когда Good и Bad классы
         *      унаследовались от QuadraticEquationBase они получили данный метод себе тоже благодаря "protected".
         */
        protected bool PossibleToCalcualteX(int discriminant)
        {
            if (discriminant >= 0)
                return true;

            return false;
        }

    }
}
