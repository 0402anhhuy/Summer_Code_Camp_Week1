using System;
using System.Runtime.CompilerServices;
namespace MyConsoleApp{
    class Program{
        static int Add(int a, int b){
            return a + b;
        }
        static int Different(int a, int b){
            return a - b;
        }

        static int Product(int a, int b){
            return a * b;
        }

        static double Divide(int a, int b){
            return (double)a / b;
        }
        static void Main(string[] args){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = Add(a, b);
            int diff = Different(a, b);
            int product = Product(a, b);
            double div = Divide(a, b);
            Console.WriteLine($"a + b = {sum}");
            Console.WriteLine($"a - b = {diff}");
            Console.WriteLine($"a * b = {product}");
            Console.WriteLine($"a / b = {Math.Round(div, 3)}");
        }
    }
}
