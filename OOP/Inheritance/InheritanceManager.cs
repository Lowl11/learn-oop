using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.OOP.Base;

namespace Tutorial.OOP.Inheritance
{
    /*
     * Наследование - процесс, посредством которого один объект может приобретать свойства и методы другого.
     * Так же дается возможность дополнять или изменять эти свойства.
     * 
     * Плюшки:
     *      1. Сокращение кода или избавление от копипасты. Если один и тот же метод применяется в нескольких классах, можно 
     *          описать данный метод в базовом классе (мб в абстрактном) и после наследования от данного класса все наследники
     *          будут иметь эту реализию.
     *      2. 
     */
    public class InheritanceManager : PrincipleManagerBase
    {

        private const string ThemeName = "Наследование";

        public InheritanceManager()
            : base(ThemeName)
        {
            // 
        }

        public override void ShowGoodExample()
        {
            base.ShowGoodExample();
        }

        public override void ShowBadExample()
        {
            base.ShowBadExample();
        }

    }
}
