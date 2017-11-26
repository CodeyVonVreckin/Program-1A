/*
 Grading ID : C4811
 Program 1A 
 CIS 200-01 
 DUE DATE: 10/10/16 
 This  class calculates the cost of shipping a ground package 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GroundPackage : Package
{
    // Precondition:  None
    // Postcondition: The package is created with values for origin, and destination
    //                addresses, length, width, height, and weight    
    public GroundPackage(Address originAddress, Address destAddress,
           double length, double width, double height, double weight) : 
           base(originAddress, destAddress, length, width, height, weight)
    {

    }       
            
    public int ZoneDistance // declares a propterty for Zone Distance
    {
        // Precondition:  must have a valid origin and destination address
        // Postcondition: returns the difference between the first digits of the origin
        //                and destination zip codes
        get
        { return Math.Abs(OriginAddress.Zip / 10000 
            - DestinationAddress.Zip / 10000); }
    }
    // Precondition:  None
    // Postcondition: returns the cost of shipping a Ground Package
    public override decimal CalcCost()
    {

        return Convert.ToDecimal(.20 * (Length + Width + Height) + .05 * (ZoneDistance + 1) * (Weight));
        
    }
    // Precondition:  None
    // Postcondition: returns a string with info from parcel, package and ground package
    public override string ToString()
    {
        return $"Ground Package{Environment.NewLine}{base.ToString()}{Environment.NewLine}Zone Distance: {ZoneDistance}";
    }
}