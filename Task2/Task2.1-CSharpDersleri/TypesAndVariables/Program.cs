using System;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //* Value Types

            int intMin = -2147483648;
            int intMax = 2147483647;

            long longMin = -9223372036854775808;
            long longMax = 9223372036854775807;

            short shortMin = -32768;
            short shortMax = 32767;

            byte byteMin = 0;
            byte byteMax = 255;

            bool conditionPos = true;
            bool ConditionNeg = false;

            char character = 'A';

            float floatingPointFloat = 10.4987645f; //10.4F
            double floatingPointDouble = 10.4987645321;
            decimal floatingPointDecimal = 10.498764532123456789m; //10.4M

            var number = 10;
            number = 'A';

            Console.WriteLine("Int min value is {0}, max value is {1}", intMin, intMax);
            Console.WriteLine("Long min value is {0}, max value is {1}", longMin, longMax);
            Console.WriteLine("Short min value is {0}, max value is {1}", shortMin, shortMax);
            Console.WriteLine("Byte min value is {0}, max value is {1}", byteMin, byteMax);
            Console.WriteLine("Condition positive is {0}, negative is {1}", conditionPos, ConditionNeg);
            Console.WriteLine("Character is : {0}", (int)character); //ASCII code
            Console.WriteLine("Float is {0}, Double is {1}, Decimal is {2}", floatingPointFloat, floatingPointDouble, floatingPointDecimal);
            Console.WriteLine(Days.Friday + " : " + (int)Days.Friday); //23
            Console.WriteLine(number);

            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday = 10, Tuesday = 20, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
