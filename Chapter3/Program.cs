using System;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Question 1-------");
            Console.WriteLine("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
            int num1 = number % 2;
            Console.WriteLine($"The remainder is {num1}");

            Console.WriteLine("---------Question 2--------");
            Console.WriteLine("Enter number: ");
            int numb = int.Parse(Console.ReadLine());
            int a = numb / (5 * 7);
            bool answer = (a == 5 * 7);
            Console.WriteLine($"The number is {a}"); 


            Console.WriteLine("--------Question 3---------");
            int num = 6000;
            int numb1 = num / 100;
            Console.WriteLine(numb1);
            int number1 = numb1 / 10;
            Console.WriteLine(number1);
            bool equal = (number1 == 7);
            Console.WriteLine($"The number is {equal}");
            
            Console.WriteLine("----------Question 5----------");
            Console.WriteLine("Enter your side a: ");
            int sideA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your side b: ");
            int sideB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height h: ");
            int sideH = int.Parse(Console.ReadLine());
            double Area = (double) 1 / 2 * (sideA + sideB) * sideH;
            Console.WriteLine("The area is: {0}",Area);

            Console.WriteLine("----------Question 6----------");
            Console.WriteLine("Enter your side l: ");
            int sideL = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your side b: ");
            int sidesB = int.Parse(Console.ReadLine());
            double perimeter = (double) 2 * (sideL + sidesB);
            Console.WriteLine("The perimeter is: {0}",perimeter);
            double area = (double) (sideL * sidesB);
            Console.WriteLine("The area is: {0}",area);

            Console.WriteLine("---------Question 7---------");
            Console.WriteLine("Enter your weight: ");
            int weights = int.Parse(Console.ReadLine());
            double weight = (double) 17 / 100 * weights;
            Console.WriteLine($"Your weight on the moon is {weight}");

            





        }
    }
}
