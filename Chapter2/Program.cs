using System;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Question 1--------");
            sbyte fNum = -115;
            Console.WriteLine(fNum);
            sbyte sNum = -44;
            Console.WriteLine(sNum);
            byte tNum = 97 ;
            Console.WriteLine(tNum);
            byte foNum = 224;
            Console.WriteLine(foNum);
            
            Console.WriteLine("-----------Question 2------------");
            decimal num1 = 5;
            Console.WriteLine(num1);
            double num2 = -5.01;
            Console.WriteLine(num2);
            float num3 = 34.567839023F;
            Console.WriteLine(num3);
            float num4 = 12.345F;
            Console.WriteLine(num4);
            double num5 = 8923.1234857;
            Console.WriteLine(num5);
            double num6 = 3456.091124875956542151256683467;
            Console.WriteLine(num6);

            Console.WriteLine("--------Question 3---------");
            int a = 50;
            int b = 40;
            bool number = Math.Abs(a - b) < 0.000001;
            Console.WriteLine(number);

            Console.WriteLine("---------Question 4---------");
            int denary = 256;
            Console.WriteLine(denary);
            int hdecimal = 0x100;
            Console.WriteLine(hdecimal);

            Console.WriteLine("---------Question 5----------");


            Console.WriteLine("----------Question 6---------");
            Console.WriteLine("Enter your gender: ");
            string gender = Console.ReadLine();
            bool isMale = true;    
            Console.WriteLine(isMale);

            Console.WriteLine("---------Question 7---------");
            string firstWord = "Hello ";
            string secondWord = "World";
            object concatenation = firstWord  +  secondWord;
            Console.WriteLine(concatenation);

            Console.WriteLine("---------Question 8----------");
            string fWord = "Hello ";
            string sWord = "World";
            object concatenates = fWord + sWord;
            string concatenate = Convert.ToString(fWord + sWord);
            Console.WriteLine(concatenate);
            
            Console.WriteLine("----------Question 9----------");
            string firstOperand = "\"The\"use\"of quotation causes difficulties\"";
            Console.WriteLine(firstOperand);

            Console.WriteLine("---------Question 10---------");
            Console.WriteLine("  o         o  ");
            Console.WriteLine("o   o     o   o");
            Console.WriteLine("o     o  o    o");
            Console.WriteLine(" o     oo    o ");
            Console.WriteLine("  o         o  ");
            Console.WriteLine("   o       o   ");
            Console.WriteLine("    o     o    ");
            Console.WriteLine("     o   o     ");
            Console.WriteLine("      o o      ");
            Console.WriteLine("       o       ");
            Console.WriteLine();

            Console.WriteLine("---------Question 11---------");
            Console.WriteLine("        c        ");
            Console.WriteLine("      c   c      ");
            Console.WriteLine("    c       c    ");
            Console.WriteLine("  c           c  ");
            Console.WriteLine("c c c c c c c c c");
            Console.WriteLine();

            Console.WriteLine("--------Question 12---------");
            Console.WriteLine("Enter first name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter gender: ");
            char gende = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter unique number: ");
            
            int unumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"You are my employee {fname}");

            Console.WriteLine("---------Question 13---------");
            int number1 = 5;
            int number2 = 10;
            int oldA = number1;
            number1 = number2;
            number2 = oldA;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            

        
            



        }
    }
}


    

