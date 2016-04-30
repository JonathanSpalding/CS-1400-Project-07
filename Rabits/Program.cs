// Author: Jonathan Spalding
// Assignment: Project 7
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 3/12/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using static System.Console;

namespace Rabits
{
    class Program
    {

        static void Main(string[] args)
        {
            // change background to white
            BackgroundColor = ConsoleColor.White;
            Clear();
            // change text to dark blue
            ForegroundColor = ConsoleColor.DarkBlue;
            // Create Constants
            const int CAGES = 500;
            // State Variables for month, adults, babies, babies made, and total.
            var month = 1;
            var adults = 1;
            var babies = 0;
            var babiesMade = 0;
            var total = 1;
            // Write Student Information
            WriteLine("Jonathan Spalding\nCS1400\nProjecct 07\n");
            // "Table of rabbit population, in pairs.
            WriteLine("Table of rabbit population, in pairs\n");
            // Print out a header for the table.
            WriteLine("Month\tAdults\tBabies\tTotal");
            // Print the start totals for month 1.
            WriteLine($"{month}\t{adults}\t{babies}\t{total}");
            // for loop that stops when the total is greater than the cages.
            for (; total < CAGES; total++)
            {
                // sleep timer. When I first ran the example program it was a little disappointing that the information was already there. It felt like it was just a writeline, and no math was done. With a sleeper it simulates the process of doing the math.
                System.Threading.Thread.Sleep(50);
                // incrament month by 1
                month++;
                // state a variable for how many babies were made.
                babiesMade = adults;
                // add babies from last month to the adults.
                adults = adults + babies;
                // set babies to how many babies are made this month.
                babies = babiesMade;
                // set total Adults plus Babies.
                total = adults + babies;
                // Write the results in the table.
                WriteLine($"{month}\t{adults}\t{babies}\t{total}");
            }
            // display how many months until you run out of cages.
            WriteLine($"\nYou will run out of cages in {month} Months.");
            // readkey true to keep program open.
            ReadKey(true);

        }
    }
}
