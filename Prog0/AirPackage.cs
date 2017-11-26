/*
 Grading ID : C4811
 Program 1A 
 CIS 200-01 
 DUE DATE: 10/10/16 
 This abstract class creates methods to determin if a package is considered heavy and/or large
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class AirPackage : Package
    {
    // creates constant variables that hold the MIN requirment for 
    // a package to be considered either Heavy or Large    
    const int HEAVY_AS_F = 75;
    const int LARGE_BOX = 100;

    // Precondition:  None
    // Postcondition: The air package is created with values for origin, and destination
    //                addresses, length, width, height, and weight    
    public AirPackage(Address originAddress, Address destAddress,
           double length, double width, double height, double weight) :
           base(originAddress, destAddress, length, width, height, weight)
    {
                
    }
    // Precondition:  weight must hold a non negative value
    // Postcondition: returns a bool value to confirm if the air package is 
    //                deemed "Heavy" or not  
    public bool IsHeavy()
    {
        if (Weight >= HEAVY_AS_F)
            return true;
        else
            return false;
    }
    // Precondition:  weight must hold a non negative value
    // Postcondition: returns a bool value to confirm if the air package is 
    //                deemed "Large" or not  
    public bool IsLarge()
    {
        if (Length + Width + Height >= LARGE_BOX)
            return true;
        else
            return false;
    }

    // Precondition:  None
    // Postcondition: returns a string with info from parcel, package and air package
    public override string ToString()
    {
        return $"{base.ToString()}{Environment.NewLine}Package is Heavy: {IsHeavy()}{Environment.NewLine}Package is Large: {IsLarge()}";
    }

}

