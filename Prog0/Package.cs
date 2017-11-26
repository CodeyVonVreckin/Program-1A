/*
 Grading ID : C4811
 Program 1A 
 CIS 200-01 
 DUE DATE: 10/10/16 
 This  abstract class stores basic information about Packages
 (Lenth, Width, Height, and Weight) 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  public abstract class Package : Parcel
    {
        private double _length; // length >=0
        private double _width; // width >=0
        private double _height; // height >=0
        private double _weight; // weight >=0

        // declares a const variable to hold the minium value
        const int MIN_VALUE = 0;

    // Precondition:  length, width, height, and weight >= 0
    // Postcondition: The package is created with values for origin, and destination
    //                addresses, length, width, height, and weight    
    public Package (Address originAddress, Address destAddress,
           double length, double width, double height, double weight) : 
           base (originAddress, destAddress)
    {
        Length = length;
        Width = width;      // declares Properties for length, width, height, and weight
        Height = height;
        Weight = weight;
    }

    public double Length
    {
        // Precondition:  None
        // Postcondition: the length is returned
        get { return _length; }
        
        // Precondition:  value >= 0
        // Postcondition: the package's legnth is set to the
        //                given value or an out of range exception occurs
        set
        {
            if (value >= MIN_VALUE)
                _length = value;
            else
                throw new ArgumentOutOfRangeException("Length", value,
                    "Length must be a Non-Negative integer ( >= 0)");
        }
    }

        public double Width
    {
        // Precondition:  None
        // Postcondition: the width is returned
        get { return _width; }

        // Precondition:  value >= 0
        // Postcondition: the package's width is set to the
        //                given value or an out of range exception occurs
        set
        {
            if(value >= MIN_VALUE)
                _width = value;
            else
                throw new ArgumentOutOfRangeException("Width", value,
                    "Width must be a Non-Negative integer ( >= 0)");
        }
    }

    public double Height
    {
        // Precondition:  None
        // Postcondition: the height is returned
        get { return _height; }

        // Precondition:  value >= 0
        // Postcondition: the package's height is set to the
        //                given value or an out of range exception occurs
        set
        {
            if (value >= MIN_VALUE)
                _height = value;
            else
                throw new ArgumentOutOfRangeException("Height", value,
                    "Height must be a Non-Negative integer ( >= 0)");
        }
    }

    public double Weight
    {
        // Precondition:  None
        // Postcondition: the weight is returned
        get { return _weight; }

        // Precondition:  value >= 0
        // Postcondition: the package's weight is set to the
        //                given value or an out of range exception occurs
        set
        {
            if (value >= MIN_VALUE)
                _weight = value;
            else
                throw new ArgumentOutOfRangeException("Weight", value,
                    "Weight must be a Non-Negative integer ( >= 0)");
        }
    }

    // Precondition:  None
    // Postcondition: a string with information from parcel and
    //                package is returned
    public override string ToString()
    {
        return $"{base.ToString()}{Environment.NewLine}Length: {Length}{Environment.NewLine}Width: {Width}{Environment.NewLine}Height: {Height}{Environment.NewLine}Weight: {Weight}";
        
    }














}









    

