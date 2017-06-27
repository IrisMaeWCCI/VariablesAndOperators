﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //intializing firstname variables
            string name = "Mike";
            //printing the value of firstname to the console
            Console.WriteLine(name);
            name = "Daniel";
            Console.WriteLine(name);
            string birthMonth = "July";
            Console.WriteLine(birthMonth);

            int age = 65;
            string why = "because I said so";
            char firstInitial = 'L';

            //floating point types
            //float double decimal
            //bool true or false
            float floatNumber = 2.164403304897294849383961032f;
            Console.WriteLine(floatNumber);

            double doubleNumber = 2.164403304897294849383961032d;
            Console.WriteLine(doubleNumber);


            decimal decimalNumber = 2.164403304897294849383961032m;
            Console.WriteLine(decimalNumber);
            //operators allow us to do things with our data; allow us to work with our data

            int Jessica = 23;
            int Sam = 47;
            Console.WriteLine(Jessica<Sam);

            int costPerPerson = 13;
            int numberOfPeople = 4;
            int totalCost = numberOfPeople * costPerPerson;
            Console.WriteLine(totalCost);

            double costForEachOne = 13.5d;
            double numberOfIndividuals = 4d;
            double costForAll = numberOfIndividuals * costForEachOne;
            Console.WriteLine(costForAll);
            //to date we have no user. Let's add some addt'l features to make sure we can receive user input
            //here we are creating a variable to take in user information

            Console.WriteLine("What is the name on the reservation?");
            string reserveName = Console.ReadLine();

            Console.WriteLine("And how many people are in your party?");
            double thoseInYourParty = double.Parse(Console.ReadLine());

            double finalCost= double.Parse(Console.ReadLine());
            Console.WriteLine(thoseInYourParty * finalCost);

            Console.WriteLine("Reservation:"+ reserveName);
            Console.WriteLine("Total Due: $"+costForAll);

            //Lisa needs 7 cups (of sugar)
            //She has 2
            //How much more will she need?
            int totalCups=int.Parse(Console.ReadLine());
            int lisaHasThisManyCups = int.Parse(Console.ReadLine());
            int cupsOfSugarNeeded = totalCups - lisaHasThisManyCups;
            Console.WriteLine(cupsOfSugarNeeded);
            // My Client Needs Receipts
            // Donations come in 1s,5s, 10s, 20s, 50s, 100s, and quarters
            //Ask user how many donations are being made?
            //Print receipt
            //Client wants specific info printed: Name, Address, Email, Donation Amount



        }
    }
}
