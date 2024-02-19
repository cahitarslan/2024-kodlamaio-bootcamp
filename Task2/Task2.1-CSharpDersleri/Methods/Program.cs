using System;
using System.Linq;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //int result = Add2(4);

            //int number1 = 20; //ref'de set etme zorunluluğu var!
            //int number3; //out'da set etme zorunluluğu yok.. out, kullanıldığı yerde; method içerisinde set edilmeli!
            //int number2 = 100;

            //var result2 = Add3Ref(ref number1, number2);
            //var result3 = Add3Out(out number3, number2);

            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            //Console.WriteLine(result3);
            //Console.WriteLine(number3);


            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));

            Console.ReadLine();

        }

        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        static int Add2(int x, int number1 = 20, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3Ref(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Add3Out(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }


        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}