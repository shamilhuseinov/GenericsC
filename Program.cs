using System;
namespace test
{
    public class Program
    {
        static void Main()
        {
            //1
            void GenericMethod<T>(T param)
            {
                Console.WriteLine(param);
            }

            GenericMethod<int>(7);

            //2
            void GenericMethod2<T>(T param1, T param2)
            {
                T temp = param1;
                param1 = param2;
                param2 = temp;
                Console.WriteLine($"{param1}, {param2}");
            }

            GenericMethod2<string>("salam", "sagol");
        }
    }
}

