﻿// Grading ID : C4811
// Program 1A
// CIS 200-01
// Due: 10/10/2016
// By: Andrew L. Wright (students use Grading ID)

// File: Program.cs
// Simple test program for initial Parcel classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45", 
                "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", "", 
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321", 
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter l1 = new Letter(a1, a3, 1.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.25M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.75M); // Test Letter 3

            GroundPackage gp1 = new GroundPackage(a1, a2, 10, 20, 30, 40); // test ground package 
            NextDayAirPackage tomorrowAirBox = new NextDayAirPackage(a2, a3, 5, 15, 25, 35, 10.00M); // test bext day air package
            TwoDayAirPackage getWhenYouGetAirBox = new TwoDayAirPackage(a3, a4, 12, 234, 10, 200, TwoDayAirPackage.Delivery.Saver); // test bext day air package
            TwoDayAirPackage mayComeNextWeekAirBox = new TwoDayAirPackage(a2, a4, 70, 30, 25, 150, TwoDayAirPackage.Delivery.Early); // test bext day air package 

            List<Parcel> parcels = new List<Parcel>(); // Test list of parcels

            // Add test data to list
            parcels.Add(l1);
            parcels.Add(l2);
            parcels.Add(l3);
            parcels.Add(gp1);
            parcels.Add(tomorrowAirBox);
            parcels.Add(getWhenYouGetAirBox);
            parcels.Add(mayComeNextWeekAirBox);

            // Display data
            Console.WriteLine("Program 0 - List of Parcels\n\n");

            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("--------------------");
            }
        }
    }
}
