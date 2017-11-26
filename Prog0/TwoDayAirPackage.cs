/*
 Grading ID : C4811
 Program 1A 
 CIS 200-01 
 DUE DATE: 10/10/16 
 This class creates a property that grants the sender an early or saver delivery type that awards a 10% reduced cost if the Saver type is chosen
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class TwoDayAirPackage : AirPackage
    {
        public enum Delivery { Early , Saver}; // declares a enum variable to hold the Early and Saver option for delivery type

    // Precondition:  None
    // Postcondition: The two day air package is created with values for origin, and destination
    //                addresses, length, width, height, weight, and a delivery type 
    public TwoDayAirPackage(Address originAddress, Address destAddress,
      double length, double width, double height, double weight, Delivery deliveryType) :
       base(originAddress, destAddress, length, width, height, weight)
    {
        DeliveryType = deliveryType; 
    }
     
    public Delivery DeliveryType // declares a delivery type property
    { // Precondition:  None
      // Postcondition: returns the delivery type 
        get;
        // Precondition:  Early, or Saver
        // Postcondition: sets the delivery type to selected type
        set;
    }
    // Precondition:  None
    // Postcondition: returns the cost of shipping a two day air package
    public override decimal CalcCost()
    {
        const decimal SAVER_DISCOUNT = .90M; // declares a constant variable to hold the Saver Discount 
        decimal cost; // declares a variable to hold the final cost
        decimal baseCost; // declares a variable to hold the base cost

        baseCost = Convert.ToDecimal(.25 * (Length + Width + Height) + .25 * (Weight));

        if (DeliveryType == Delivery.Saver)
            cost = baseCost * SAVER_DISCOUNT;
        else
            cost = baseCost;

        return cost;
    }
    // Precondition:  None
    // Postcondition: returns a string with info from parcel, package, 
    //                air package, and two day air package
    public override string ToString()
    {
        return $"Two Day Air Package{Environment.NewLine}{base.ToString()}{Environment.NewLine}Delivery Type: {DeliveryType}";
    }


}

