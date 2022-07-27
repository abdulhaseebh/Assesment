using System;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Question 1------");
            int a = 3;
            int b = 1;

            if(a > b)
            {
                int oldA = a;
                a = b;
                b = oldA;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }

            Console.WriteLine("-------Question 2--------");


            Console.WriteLine("------Question 3------");
            int first = 5;
            int second = 3;
            int third = 2;
            if ((first > second) && (first > third))
            {
               Console.WriteLine("These first numbers is greater.");
            }
            else
            {
               if ((second > first) && (second > third))
                {
                   Console.WriteLine("The second number is greater.");
                }
                else
                {
                   Console.WriteLine("The third number is greater.");
                }
            }

            Console.WriteLine("-------Question 4-------");
            
            Console.WriteLine("-------Question 6---------");
            Console.Write("Input A (not 0): ");
            sbyte a = Convert.ToSByte(Console.ReadLine());
            Console.Write("Input B: ");
            sbyte b = Convert.ToSByte(Console.ReadLine());
            Console.Write("Input C: ");
            sbyte c = Convert.ToSByte(Console.ReadLine());
            sbyte d = (sbyte)(b * b - 4 * a * c);
            if (d < 0)
            {
              Console.WriteLine("\nD = {0}\nThere are no real roots.", d);
            }
            else if (d  == 0)
            {
              sbyte x1 = (sbyte)(-b / 2 * a);
              Console.WriteLine("\nX2 = {0}", x1);
            }                   
            else
            {
              sbyte x1 = (sbyte)((-b + Math.Sqrt(d)) / (2 *a));
              sbyte x2 = (sbyte)((-b - Math.Sqrt(d)) / (2 * a));
              Console.WriteLine("\nX1 = {0}\nX2 = {1}", x1, x2);
            }
            Console.ReadLine();


        }
    }
}
