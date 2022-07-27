using System;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("--------Question 1--------");
            // Console.WriteLine("Enter first number: ");
            // int firstnumber = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter second number: ");
            // int secondnumber = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter third number: ");
            // int thirdnumber = int.Parse(Console.ReadLine());
            // int sum = firstnumber + secondnumber + thirdnumber;
            // Console.WriteLine($"Thier sum is {sum}");

            // Console.WriteLine("--------Question 2---------");
            // Console.WriteLine("Enter radius: ");
            // int radius = int.Parse(Console.ReadLine());
            // double perimeter = (double) 2 * Math.PI * radius;
            // Console.WriteLine($"The perimeter is {perimeter}");
            // double area = (double) Math.PI * radius * radius;
            // Console.WriteLine($"The area is {area}");

            // Console.WriteLine("---------Question 3----------");
            // Console.WriteLine("Enter company's name: ");
            // string name = Console.ReadLine();
            // Console.WriteLine("Enter company address: ");
            // string address = Console.ReadLine();
            // Console.WriteLine("Enter company phone number: ");
            // int phoneNumber = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter company fax number: ");
            // int faxNumber = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter company's website: ");
            // string website = Console.ReadLine();
            // Console.WriteLine("Enter manager's name: ");
            // string Name = Console.ReadLine();
            // Console.WriteLine("Enter manager's surname: ");
            // string surname = Console.ReadLine();
            // Console.WriteLine("Enter manager's phone number: ");
            // int PhoneNumber = int.Parse(Console.ReadLine());
            // Console.WriteLine($"The name of the company is {name} ,it is located at {address} . Their phone number is {phoneNumber},their fax number is {faxNumber}, you can visit their website {website},their manager name is {Name}, his surname is {surname},his phone number is {phoneNumber}");
            
            // Console.WriteLine("---------Question 5---------");
            // Console.WriteLine("Enter first range: ");
            // int fRange = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter second range: ");
            // int sRange = int.Parse(Console.ReadLine());
            // for (int i = 1; i <= 50; i++)
            // {
            //     if (i % 5 == 0)
            //     {
            //         continue;
            //     }
            // }
            // Console.WriteLine();

            // Console.WriteLine("---------Question 6--------");
            // Console.WriteLine("Enter first number: ");
            // int fnum = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter second number: ");
            // int snum = int.Parse(Console.ReadLine()); 
            // if (fnum > snum)
            // {
            //     Console.WriteLine($"The greater is {fnum}");
            // }
            // if (snum > fnum)
            // {
            //     Console.WriteLine($"The greater is {snum}");
            // }

            // Console.WriteLine("---------Question 7---------");
            // Console.WriteLine("Enter your first number: ");
            // int firstnumber = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter your second number: ");
            // int secondnumber = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter your third number: ");
            // int thirdnumber = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter your fourth number: ");
            // int fourthnumber = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter your fifth number: ");
            // int fifthnumber = int.Parse(Console.ReadLine());
            // int sums =  firstnumber + secondnumber + thirdnumber + fourthnumber + fifthnumber;
            // Console.WriteLine($"Their sum is: {sums}");     

            // Console.WriteLine("---------Question 8---------");
            // Console.WriteLine("Enter your first number: ");
            // int firstnumber = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter your second number: ");
            // int secondnumber = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter your third number: ");
            // int thirdnumber = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter your fourth number: ");
            // int fourthnumber = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter your fifth number: ");
            // int fifthnumber = int.Parse(Console.ReadLine());
            // if (((firstnumber > secondnumber) && (firstnumber > thirdnumber) && (firstnumber > fourthnumber) && (firstnumber > fifthnumber)))
            // {
            //     Console.WriteLine("The greatest is: {0}" ,firstnumber);
            // }
            // int greaternumber = firstnumber;
            // if (((secondnumber > firstnumber) && (secondnumber > thirdnumber) && (secondnumber > fourthnumber) && (secondnumber > fifthnumber)))
            // {
            //     Console.WriteLine("The greatest is: {0}" ,secondnumber);
            // }
            // int greaterNumber = secondnumber;
            // if (((thirdnumber > firstnumber) && (thirdnumber > secondnumber) && (thirdnumber > fourthnumber) && (thirdnumber > fifthnumber)))
            // {
            //     Console.WriteLine("The greatest is: {0}" ,thirdnumber);
            // }
            // int greatestnumber = thirdnumber;
            // if (((fourthnumber > firstnumber) && (fourthnumber > secondnumber) && (fourthnumber > thirdnumber) && (fourthnumber > fifthnumber)))
            // {
            //     Console.WriteLine("The greatest is: {0}" ,fourthnumber);
            // }
            // int greatestNumber = fourthnumber;
            // if (((fifthnumber > firstnumber) && (fifthnumber > secondnumber) && (fifthnumber > thirdnumber) && (fifthnumber > fourthnumber)))
            // {
            //     Console.WriteLine("The greatest is: {0}" ,fifthnumber);
            // }
            // int greatnumber = fifthnumber;

          //     Console.WriteLine("-------Question 9--------");
          //     Console.WriteLine("Enter N: ");
          //     int n = int.Parse(Console.ReadLine());
          //     int sum = 0;
          //     for (int i = 0; i <= n; i++)
          //     {
          //         sum = sum + i;
          //         Console.WriteLine("i={0}, sum = {1}",i, sum);
          //     }
            
         //     Console.WriteLine("-------Question 10-------");
         //     int num = 1;
          //     Console.WriteLine("Enter n: ");
          //     int N = int.Parse(Console.ReadLine());
         //     while (num <= N)
         //     {
         //         Console.WriteLine("Number: " + num);
         //         num++;
         //     }

         //    Console.WriteLine("--------Question 11--------");
          //    int previous = -1;
         //    int next = 1;
         //    for (int i = 0; i <= 100; i++)
         //    {
         //        int sums = previous + next;
         //        previous = next;
         //        next = sums;
         //        Console.WriteLine(next);
         //    }

           Console.WriteLine("-------Question 12--------");
           Console.Write("n = ");
           int n = int.Parse(Console.ReadLine());
           int num = 1;
           double sum = 1/2;
           Console.Write("The sum 1");
           while (num < n)
           {
                num++;
                sum += num;
                Console.Write(" + " + num);
           }
           Console.WriteLine(" = " + sum);
 





        }
    }
}
