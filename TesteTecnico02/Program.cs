using System;
using System.Globalization;

namespace testeTecnico02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            int a = 0, b = 1, temp;

            while (b <= num) {
                if (b == num) {
                    Console.WriteLine("{0} pertence à sequência de Fibonacci.", num);
                    return;

                }
                temp = a + b;
                a = b;
                b = temp;
                Console.Write(temp + " ");

            }
            Console.WriteLine();
            Console.WriteLine("{0} não pertence à sequência de Fibonacci.", num);

        }
    }
}