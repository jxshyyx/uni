using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Linq;

// This is the mils to kilometres homework
//namespace Firstapplication
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the distance in miles:");
//            string input = Console.ReadLine();

//            if (double.TryParse(input, out double miles))
//            {
//                double kilometers = miles * 1.60934;
//                Console.WriteLine($"{miles} miles is equal to {kilometers} kilometers.");
//            }
//            else
//            {
//                Console.WriteLine("Please enter a valid number.");
//            }
//        }
//    }
//}

// this is the basic calculator 
    //{
    //    Console.WriteLine("Welcome to the Basic Calculator!");

    //    // asks the user for the first number
    //    Console.Write("Enter the first number: ");
    //    double firstNumber = Convert.ToDouble(Console.ReadLine());

    //    // asks the user for the second number
    //    Console.Write("Enter the second number: ");
    //    double secondNumber = Convert.ToDouble(Console.ReadLine());

    //    // These are the actions that will make the calculator do these operations
    //    double addition = firstNumber + secondNumber;
    //    double subtraction = firstNumber - secondNumber;
    //    double multiplication = firstNumber * secondNumber;
    //    double division = secondNumber != 0 ? firstNumber / secondNumber : double.NaN; //  division by zero is what NaN means ( i got confused and did use google for a lot of this work)

    //    // These are what displays the results to the user
    //    Console.WriteLine($"Addition: {firstNumber} + {secondNumber} = {addition}");
    //    Console.WriteLine($"Subtraction: {firstNumber} - {secondNumber} = {subtraction}");
    //    Console.WriteLine($"Multiplication: {firstNumber} * {secondNumber} = {multiplication}");
        
    //    if (secondNumber != 0)
    //    {
    //        Console.WriteLine($"Division: {firstNumber} / {secondNumber} = {division}");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Division: Cannot divide by zero.");
    //    }
    //}













using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Linq;



            //// Show the conversion options
            //Console.WriteLine("Choose a conversion type:");
            //Console.WriteLine("1. Meters to Feet");
            //Console.WriteLine("2. Kilograms to Pounds");
            //Console.WriteLine("3. Litres to Gallons");
            //Console.Write("Enter your choice (1-3): ");

            //string choice = Console.ReadLine(); 


            //if (choice == "1")
            //{
            //    Console.Write("Enter meters: ");
            //    double meters = Convert.ToDouble(Console.ReadLine());
            //    double feet = meters * 3.28084; 
            //    Console.WriteLine($"{meters} meters is {feet} feet.");
            //}
            //else if (choice == "2")
            //{
            //    Console.Write("Enter kilograms: ");
            //    double kilograms = Convert.ToDouble(Console.ReadLine()); 
            //    double pounds = kilograms * 2.20462;
            //    Console.WriteLine($"{kilograms} kilograms is {pounds} pounds.");
            //}
            //else if (choice == "3")
            //{
            //    Console.Write("Enter litres: ");
            //    double litres = Convert.ToDouble(Console.ReadLine());
            //    double gallons = litres * 0.264172; 
            //    Console.WriteLine($"{litres} litres is {gallons} gallons.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid choice. Please try again.");
{
    {
        {
            using System;
            Console.WriteLine("Please enter these details:");
            Console.WriteLine("1. Name");
            string name = (Console.ReadLine());
            Console.WriteLine("2. Basic salary");
            double basicsalary = Convert.ToDouble(Console.ReadLine());
            {
                if (basicsalary < 0) { Console.WriteLine(" Please enter a positive number")};
                string name = (Console.ReadLine());
                Console.WriteLine("2. Basic salary");
            }
            else if
            {
                Console.WriteLine("3. Bonus percentage");
                double bonuspercentage = Convert.ToDouble(Console.ReadLine());
                {
                    if (bonuspercentage < 0)Console.WriteLine(" Please enter a positive number");
                    string name = (Console.ReadLine());
                    Console.WriteLine("3. Basic salary");
                }
            }
            else if
            {
                Console.WriteLine("3. Bonus percentage");
                double bonuspercentage = Convert.ToDouble(Console.ReadLine());
                {
                    if (bonuspercentage < 0)Console.WriteLine(" Please enter a positive number");
                    string name = (Console.ReadLine());
                    Console.WriteLine("3. Basic salary");
                }
            }

            string bonuspercentage = Convert.ToDouble(Console.ReadLine());
            string totalsalary = basicsalary = (basicsalary * bonuspercentage / 100);
            string taxdeduction = totalsalary * 0.20;
            string netsalary = totalsalary - taxdeduction;


            Console.WriteLine($"{name}");
            Console.WriteLine($"{basicsalary}");
            Console.WriteLine($"{bonuspercentage}");
            Console.WriteLine($"{totalsalary}");
            Console.WriteLine($"{taxdeduction}");
            Console.WriteLine($"{netsalary}");

        }
    } 
}

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        








