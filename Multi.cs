﻿using System;
using System.Runtime.CompilerServices;
namespace MyConsoleApp{
    class Program{
        static int Multi(int a,int b){
            return a*b;
        }

         static void Main(string[] args){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int multi = Multi(a, b);
            Console.WriteLine("Thuc hien phep tinh co ket qua");
            Console.WriteLine("Ket qua cua ");
            Console.WriteLine($"a * b = {multi}");
        }
    }
}