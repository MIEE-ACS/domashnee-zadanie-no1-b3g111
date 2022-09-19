/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("r1=");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("r2=");
            double r2 = Convert.ToDouble(Console.ReadLine());
            double s1 = 3.14 * Math.Pow(r1, 2);
            Console.WriteLine("s1=" + s1);
            double s2 = 3.14 * Math.Pow(r2, 2);
            Console.WriteLine("s2=" + s2);
            double s3 = s1 - s2;
            Console.WriteLine("s3=" + s3);
 
            Console.ReadKey();
        }
    }
}