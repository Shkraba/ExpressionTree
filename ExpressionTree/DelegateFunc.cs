using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionTree
{
    class DelegateFunc
    {

        public static void SimpleFunc()
        {

            //Параметр integer, Результат returns string
            Func<int, string> func1 = (x) => string.Format("string = {0}", x);

            // Func має 2 параметри, результат returns string

            Func<bool, int, string> func2 = (b, x) => string.Format("string = {0} and {1}", b, x);

            // Func не має параметрів і result value (double).

            Func<double> func3 = () => Math.PI / 2;
            
            // Invoke - викликає анонімну функцію.

            Console.WriteLine(func1.Invoke(5));
            Console.WriteLine(func2.Invoke(true, 10));
            Console.WriteLine(func3.Invoke());
            Console.ReadKey();
        }

        public static void Factorial()
        {

            Func<int, int> retFunc = Factorial;
            int n1 = GetInt(6, retFunc);
            Console.WriteLine(n1);  // 720

            int n2 = GetInt(6, x => x * x);
            Console.WriteLine(n2); // 36

            Console.Read();
        }

        static int GetInt(int x1, Func<int, int> retF)
        {
            int result = 0;
            if (x1 > 0)
                result = retF(x1);
            return result;
        }
        static int Factorial(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
