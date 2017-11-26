/*
 Grading ID : C4811
 Program 1A 
 CIS 200-01 
 DUE DATE: 10/10/16 
 This class creates a property that adds an Express Fee to the the cost of shipping a Next Day Air Package
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class NextDayAirPackage : AirPackage
    {
      private decimal _expressFee; // express fee >= 0
    
    // Precondition:  None
    // Postcondition: The next day air package is created with values for origin, and destination
    //                addresses, length, width, height, weight, and an express fee 
    public NextDayAirPackage(Address originAddress, Address destAddress,
          double length, double width, double height, double weight, decimal expressFee) : 
           base(originAddress, destAddress, length, width, height, weight)
    {
        
    }
                     
    public decimal ExpressFee // declares a property for Express Fee
    {
        // Precondition:  None
        // Postcondition: returns the express fee value  
        get { return _expressFee; }         
    }

    // Precondition:  None
    // Postcondition: returns the cost of shipping a Next Day Air Package
    public override decimal CalcCost()
    {
        decimal baseCost; // declares a variable to hold the base cost of shipping a ND Air Package
        decimal weightCharge = Convert.ToDecimal(.25 * (Weight)); // declares a variable to hold the additional weight charge if the package is too heavy 
        decimal sizeCharge = Convert.ToDecimal(.25 * (Length + Width + Height)); // declares a variable to hold the additional size charge if the package is too large 
        decimal cost; // declares a variable to hold the final cost of shipping a ND Air Package

        baseCost = Convert.ToDecimal(.40 * (Length + Width + Height) + .30 * (Weight)) + ExpressFee;

        if (IsHeavy() == true && IsLarge() == true)
            cost = baseCost + weightCharge + sizeCharge;

        else if (IsHeavy() == true)
            cost = baseCost + weightCharge;

        else if (IsLarge() == true)
            cost = baseCost + sizeCharge;

        else
            cost = baseCost;       

        return cost;
       
    }
    // Precondition:  None
    // Postcondition: returns a string with info from parcel, package, 
    //                air package, and next day air package
    public override string ToString()
    {
        return $"Next Day Air Package{Environment.NewLine}{base.ToString()}{Environment.NewLine}Express Fee: {ExpressFee}";
    }

}

