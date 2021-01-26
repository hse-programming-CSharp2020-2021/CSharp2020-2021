using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example01;

// https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords
// https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/classes-and-structs/versioning-with-the-override-and-new-keywords
// https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/sealed

namespace Example02
{
    public class E : A
    {
        public int GetInternalA()
        {
            return 0;
            // return base.a4; // недоступен из-за его уровня защиты
        }
        public int GetPublicA()
        {
            return base.a5;
        }
        new public string GetInfo() // для сокрытия лучше использовать new
        {
            return "class E";
        }
        public override string GetInfo2() // для сокрытия лучше использовать new
        {
            return "class E";
        }
        sealed public override void AVirtual1()
        {
            Console.WriteLine("E.Virtual.1");
        }
        public override void AVirtual2()
        {
            Console.WriteLine("E.Virtual.2");
        }
    }

    /*
    public class F : C // нельзя наследовать от запечатанного типа
    {

    }
    */

    public class G : E
    {
        // Attempting to override F causes compiler error CS0239.
        /*public override void AVirtual1()
        {
            Console.WriteLine("G.Virtual.1");
        }*/

        // Overriding F2 is allowed.
        public override void AVirtual2()
        {
            Console.WriteLine("G.Virtual.2");
        }
    }

    public abstract class ExampleAbstract2 : ExampleAbstract // наследует асбтрактный член, 
        // надо пометить как abstract, т.к. нет реализации
    {

    }

    public class ExampleAbstract3 : ExampleAbstract2
    {
        public override void DoWork(int i)
        {
            Console.WriteLine(i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            //B b = new B(); // недоступен из-за его уровня защиты если internal 
            Console.WriteLine(a.GetInfo());
            Console.WriteLine(a.GetInfo2());
            E e = new E();
            A ae = new E();
            Console.WriteLine(e.GetInfo());
            Console.WriteLine(e.GetInfo2());

            Console.WriteLine(ae.GetInfo());
            Console.WriteLine(ae.GetInfo2());

            G g = new G();
            a.AVirtual1();
            a.AVirtual2();
            e.AVirtual1();
            e.AVirtual2();
            g.AVirtual2();

            //ExampleAbstract exA = new ExampleAbstract(); // нельзя создать экземпляр абстрактного
            ExampleAbstract exA = new ExampleAbstract3();
            exA.DoWork(1000);

            Console.ReadKey();
        }
    }
}
