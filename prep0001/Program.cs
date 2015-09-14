using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prep0001
{
    class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new B();
            A obj2 = new C();
            B obj3 = new C();
            A obj4 = new D();

            Console.WriteLine(obj1.Print());
            Console.WriteLine(obj2.Print());
            Console.WriteLine(obj3.Print());
            Console.WriteLine(obj4.Print());
            Console.ReadKey();

        }
    }

    public class A
    {
        public virtual string Print()
        {
            return "I am A";
        }
    }

    public class B:A
    {
        public override string Print()
        {
            return "I am B:A";
        }
    }

    public class C : B
    {
        public new string Print()
        {
            return "I am C:B";
        }
    }

    public class D : A
    {
        public new string Print()
        {
            return "I am D:A";
        }
    }

}
