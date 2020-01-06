using System;

namespace operators
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Hello World!");
            /*  
                Operators in C#
                Arithmetic:  +, -, %, *, /, ++, --
                Relational:  ==, !=, ===, !==, <, >, <=, >=
                Bitwise:     &, |, ^ XOR, ~, <<, >>
                Logical:     &&, ||, !
                Assignment:  =, +=, -=, *=, /=, %=, &=, ^=, |=, <<=, >>=
            */
            int age = 40;
            int realAge = 55;

            if (age == 30 || realAge == 55) {
                System.Console.WriteLine("True");
            } else {
                System.Console.WriteLine("False");
            }

            Console.WriteLine();

        }
    }
}
