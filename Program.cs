// See https://aka.ms/new-console-template for more information
using System;

namespace Lab2

{
    class Program
    {
        //Calculate the total amount the user spends on gas and their total speed traveled//
        static void Main(string[] args)
        {

            //Create constant value for GAS_PRICE//
            double GAS_PRICE = 2.96;
            //Create user input and program output variables
            // double milesTraveled = 0.0; TBC
            // double travelTime = 0.0; TBC
            double amtSpentonGas = 0.0;
            double speed = 0.0;

            //Prompt user to enter the total miles they traveled//
            Console.WriteLine("Welcome to the 'Gas and Miles' calculation tool! Please enter the total amount of miles that you have traveled this year.");
            
            //Convert user input (string) into a number
            double milesTraveled  = double.Parse(Console.ReadLine());


           //Prompt user to enter their time traveled//
           Console.WriteLine("You traveled " + milesTraveled + " miles! Now enter the amount of time you traveled in hours.");
           //Convert user input (string) into a number
           double travelTime = double.Parse(Console.ReadLine());

           Console.WriteLine(travelTime + " hours! Impressive!");

           //Calculate amt spent on gas and speed
           double gallonsUsed;
           int milesPerGallon = 25;

           gallonsUsed = (milesTraveled/milesPerGallon);

           amtSpentonGas = gallonsUsed * GAS_PRICE;

           speed = milesTraveled/travelTime;

           //Display output to user
           Console.WriteLine("You spent $" + amtSpentonGas + " on gas, and went a speed of " + speed + " MPH." );
        }
    }
}
//  int grade = int.Parse(Console.ReadLine());