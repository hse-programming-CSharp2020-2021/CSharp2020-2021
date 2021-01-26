using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class A
    {
        int a;
        static int a2;
        protected int a3;
        internal int a4;
        public int a5;
        public A()
        {
            a = 1;
            a3 = 1;
            a4 = 1;
            a5 = 1;
        }
        static A()
        {
            a2 = 12;
        }

        public class A2 : A // если убрать public - ошибка, несогласованность по доступности
        {
            public A2()
            {
                base.a = 1;
            }

            public int GetPrivateA2()
            {
                return base.a;
            }
        }

        public string GetInfo()
        {
            return "class A";
        }
        virtual public string GetInfo2()
        {
            return "class A";
        }

        /*
        Модификатор sealed можно использовать для метода или свойства, которое переопределяет 
        виртуальный метод или свойство в базовом классе. Это позволяет классам наследовать от 
        вашего класса, запрещая им при этом переопределять определенные виртуальные методы или свойства.
        */
        public virtual void AVirtual1()
        {
            Console.WriteLine("A.Virtual.1");
        }
        public virtual void AVirtual2()
        {
            Console.WriteLine("A.Virtual.2");
        }

    }

    public class B : A // если убрать public, то C нельзя будет наследовать от В из-за несоответсвия доступности
    {
        int b;
        public B()
        {
            b = 2;
        }
        public int GetA()
        {
            return 0;
            //return base.a; // недоступен из-за его уровння защиты
        }
        public int GetProtectedA()
        {
            return base.a3;
        }
        public int GetInternalA()
        {
            return base.a4;
        }
        public int GetPublicA()
        {
            return base.a5;
        }
    }

    sealed public class C : B
    {
        int c;
        public C()
        {
            c = 3;
        }
    }

    public abstract class ExampleAbstract
    {
        public abstract void DoWork(int i);
        /*
        public abstract void DoWork(int i)
        {

        }*/
        public virtual void DoWork2(int i)
        {
            Console.WriteLine(i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
