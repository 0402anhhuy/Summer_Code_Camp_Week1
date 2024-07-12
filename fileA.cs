using System;

class fileA
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap a:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhap b:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num1 - num2;

        Console.WriteLine("Ket qua phep tru la: " + result);
    }
}
