using System;

namespace nestedclassex
{
    public class Outer_class
    {
        public void method1()
        {
            Console.WriteLine("Outer class method");
        }


        public class Inner_class
        {


            public void method2()
            {
                Console.WriteLine("Inner class Method");
            }
        }
    }


    public class G1
    {


        static public void Main()
        {


            Outer_class obj1 = new Outer_class();
            obj1.method1();

            Outer_class.Inner_class obj2 =
                              new Outer_class.Inner_class();

            obj2.method2();
        }
    }
}
