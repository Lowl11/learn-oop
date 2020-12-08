using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.OOP.Base;
using Tutorial.OOP.Encapsulation.GoodExample;

namespace Tutorial.OOP.Encapsulation
{
    /*
     * Инкапсуляция - механизм языка, позволяющий связывать данные и методы, работающие с данными в единый объект и
     *      скрыть детали реализации от пользователя (то есть другого разработчика).
     *      В общем позволяет все объединять в один класс.
     * 
     * Ремарка: обязательно к прочтению! Важно понимать что Инкапсуляция отвечает не только за сокрытие и это его не
     *      основная часть механизма! Не позволяйте вводить вас в заблуждение!
     *      
     * Ну и должно быть базовое понимание модификаторов доступа:
     *      public - публичный, то есть всем доступный ото всюду
     *      private - приватный, скрытый от всех и вся
     *      protected - защищенный, не доступен снаружи, но доступен классам наследникам
     */
    public class EncapsulationManager : PrincipleManagerBase
    {

        private const string ThemeName = "Инкапсуляция";

        public EncapsulationManager()
            : base(ThemeName)
        {
            // 
        }

        public override void ShowGoodExample()
        {
            base.ShowGoodExample();
            var quadraticEquation = new GoodQuadraticEquation(1, -2, -3);
            quadraticEquation.Calculate();
            /*
             * Если раскомментить нижестоящую строчку кода можно увидеть что Visual Studio вам не позволит использовать метод
             *      "GetX1X2(10)" потому что она сокрыта от сторонних пользователей. В этом и прикол инкапсуляции!
             * 
             * Примечание: можно протестировать еще так: просто пишем "quadraticEquation." и после нажатия на точку появится
             *      список методов доступных от этого объекта.
            */
            // quadraticEquation.GetX1X2(10);
        }

        public override void ShowBadExample()
        {
            base.ShowBadExample();
            var quadratiEquation = new BadQuadraticEquation(1, -2, -3);
            quadratiEquation.Calculate();

            /*
             * Нижестоящая строчка не ругается Visual Studio потому что мы открыли метод "GetDiscriminant()" (как и в прочем остальные)
             *      для всего мира! А зачем? Данный метод как и остальные приватные являются лишь частью процесса.
             *      Это всего лишь кусочек алгоритма высчитывания X1 и X2. Отдельно он никому не нужен и в некоторых случаях
             *      такие методы могут даже нарушить работу алгоритма и повлиять на результат, а это плохо.
             */
            quadratiEquation.GetDiscriminant();
        }

    }
}
