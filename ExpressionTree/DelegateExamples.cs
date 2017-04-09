using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionTree
{
    class DelegateExamples
    {
        delegate void GetMessage();
        delegate int Calc(int a, int b);

        public void DeligateWithOutParams()
        {
            GetMessage del; // 2. Создаем переменную делегата
            if (DateTime.Now.Hour < 12)
            {
                del = GoodMorning; // 3. Присваиваем этой переменной адрес метода
            }
            else
            {
                del = GoodEvening;
            }
            del.Invoke(); // 4. Вызываем метод
            Console.ReadLine();
        }

        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }



        public static void DeligateWithParams()
        {
            Calc del;

            //Ask user first number
            Console.WriteLine("Type you first number :");
            string stringFirstNumber = Console.ReadLine();
            Int32 firstNumber = Convert.ToInt32(stringFirstNumber);
          
            //Ask user operation to use
            Console.WriteLine("Enter the operation + (addition), - (soustraction):");
            string stringOperation = Console.ReadLine();
           

            //Ask user second number
            Console.WriteLine("Type you second number :");
            string stringSecondNumber = Console.ReadLine();
            Int32 secondNumber = Convert.ToInt32(stringSecondNumber);

            switch (stringOperation)
            {
                case "+":
                    del = new Calc(Add);
                    break;
                case "-":
                    del = new Calc(Minus);
                    break;
                default:
                    del = new Calc(Equals);
                    break;

            }
         int result = del.Invoke(firstNumber, secondNumber);
            Console.WriteLine("Result: "+result);
            Console.ReadKey();
        }

        private static int Add(Int32 a, Int32 b) => a + b;
        private static int Minus(Int32 a, Int32 b) => a - b;
        private static int Equals(Int32 a, Int32 b) => a;
    }
}
