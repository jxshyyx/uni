﻿using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Linq;

namespace Firstapplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  string name = "Josh";
            //  int age = 18;
            //   string hobby = "Pool";

            //   Console.WriteLine("This is my first c# attempt"); // this prints the given text into the console
            //  Console.WriteLine(""); // this prints the given text into the console



            //Console.WriteLine($"Hello i am {name}."); // this prints the given text into the console
            // Console.WriteLine(name); // console write keeps text on the same line instead of starting a new line like console writeline

            // Console.WriteLine($"I am {age}");
            //  Console.WriteLine(age); 
            // Console.WriteLine($"My main hobby is {hobby}.");
            // Console.ReadLine();    // allows the user to write within the code or takes an input from the user (do not know how much i can play with this)


            string hobby;
            string name;
            int age;
            Console.WriteLine("Hi please enter your name ?");
            name = Console.ReadLine();                      // this will take your name in as an input
                                                            // and then ive used i tin the next line of code however this name is only stored here during the code is
                                                            // ran and is lost instantly after the code is ended.
            Console.WriteLine($"Hello again nice to meet you {name}");
            Console.WriteLine($"what is your hobby {name} ?");
            hobby = Console.ReadLine();
            Console.WriteLine($"so your hobby is {hobby} {name}? Thats Great!");
            Console.WriteLine("Hi please enter your age ?");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"so your hobby is {hobby} and you are {age} {name}");
            int ageIn5Years = age + 5;
            Console.WriteLine($"Did you know your age in 5 years is {ageIn5Years}?");
            double halfAge = age / 2.0;  // had to write 2.0 to make sure the output was also a decimal output icase someones age was an odd number e.g 21
            Console.WriteLine($"And half your age is {halfAge}!!");

                int x = 5;
                int y = 2;
                int modulousResult = x % y;
                Console.WriteLine($"x % y = {modulousResult}");
                //int num1 = 5;

    //int num2 = 3;

    //num1 += num2; //5+3=8

    //Console.WriteLine($"{num1}");

    //Console.WriteLine($"{num2}");

    //num1 -= num2; //8-3=5

    //Console.WriteLine($"{num1}");

    //Console.WriteLine($"{num2}");

    //num1 *= num2; //5*3=15

    //Console.WriteLine($"{num1}");

    //Console.WriteLine($"{num2}");

    //num1 /= num2; //15/3=5

    //Console.WriteLine($"{num1}");

    //Console.WriteLine($"{num2}");

    //num1 %= num2; //5

    //Console.WriteLine($"{num1}");

    //Console.WriteLine($"{num2}");


    // == equal to 
    // ! != equal to 
    // > greater than
    // < less than
    //>= greater or equal to
    //<= less or equal to 
    // && logical and returns true if both statements are true
    // || logical or returns true if one of the statements are true
    // ! logical not reverse the result, returns false if the result is true

    //Console.WriteLine("Could you please enter your score (0-100)");
    //int score =  Convert.ToInt32(Console.ReadLine());

    //string grade;
    //if (score >= 70)
    //{
    //    grade = "First";
    //}
    //else if (score >= 60)
    //{
    //    grade = "2-1";
    //}
    //else if (score >= 50)
    //{
    //    grade = "2-2";
    //}
    //else if (score <= 40)
    //{
    //    grade = "Third";
    //}
    //else
    //{
    //    grade = "Fail";
    //}
    //Console.WriteLine($"Your grade is {grade}");
    //Console.WriteLine("Could you please enter your Surname name");
    //int surname = (Console.ReadLine();
    //Console.WriteLine("Could you please enter your first and last name");
    //string name = Console.ReadLine();
    //Console.WriteLine($"Hello {name} what is your age?");
    //int age = Convert.ToInt32(Console.ReadLine());
    //string greeting = "";
    // if (age <= 12)
    //{
    //    greeting = ($"Hello {name}.Your just a kid!");
    //}
    //else if (age <= 19)
    //{
    //    greeting = ($"Hey {name}.You are a teenager now!");
    //}
    //else if (age >= 20)
    //{
    //    greeting = ($"Hi {name}.Welcome to adulthood!");
    //}
    //else if (age >= 65)
    //{
    //    greeting = ($"Hello {name}.Enjoy your golden years!");

    //}
    //Console.WriteLine (greeting);
    Console.WriteLine("Welcome to the calculator app");
    Console.WriteLine("Please choose an option");
    Console.WriteLine("\t1. Addition");
    Console.WriteLine("\t2. Subtraction");
    Console.WriteLine("\t3. Multiplication");
    Console.WriteLine("\t4. Division");
    Console.WriteLine("\t5. Modulous");

    int userchoice = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please choose your first number");
   double num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Please choose your second number");
   double num2 = Convert.ToDouble(Console.ReadLine());
    double result = 0; 
    switch(userchoice)
    {
        case 1:
            result = num1 + num2;
            break;

        case 2:
            result = num1 - num2;
            break;

        case 3:
            num1 * num2;
            break;

        case 4:
            num1 / num2;
            break;

        case 5:
            result = num1 %= num2;
            break;
    }





}



        }
    }
}



// char is single ' --- char used for single digits (witihn assignment will be used for each pump)
// double " --- double (-1,1.01.-9102)
// string" --- (will be used to print messages to directthe "user" through the application)
// boolean " --- (will be used in a yes/no - true or false ssituation)
// int is whole numbers (1,2,3,1000) will be used for times,ages,dates and maybe just numerical amounts






// You can user several variables in one peice of code but without a way to store these it can get very messy
// once storing saved variables like specific names i should be able to write the code and make it more thorough
// Behaves very similar to php and python however however wants more specific and requires more commands.
//c# is used in far more things and can load the outputs much faster

