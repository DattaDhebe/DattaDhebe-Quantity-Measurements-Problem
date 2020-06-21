//-----------------------------------------------------------------------
// <copyright file="Length.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Datta Dhebe</author>
//-----------------------------------------------------------------------

namespace Quantity_Measurements
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Text;

    /// <summary>
    /// Class for Feet Entity
    /// </summary>
    public class Length
    {
        /// <summary>
        /// pre-defined value for converting Feet to Inch
        /// </summary>
        private const double FeetToInch = 12.0;

        /// <summary>
        /// pre-defined value for converting Yard to Inch
        /// </summary>
        private const double YardToInch = 36.0;

        /// <summary>
        /// pre-defined value for converting Centimeter to Inch
        /// </summary>
        private const double CentimeterToInch = 2.5;

        /// <summary>
        /// pre-defined value for converting Gallon to Liter
        /// </summary>
        private const double GallonToLiter = 3.78;

        /// <summary>
        /// pre-defined value for converting Liter to Milliliter
        /// </summary>
        private const double LiterToMilliliter = 1000;

        /// <summary>
        /// Initializes a new instance of the <see cref="Length" /> class.
        /// </summary>
        public Length() 
        { 
        }   

        /// <summary>
        /// enum to specify if Inch of Feet
        /// </summary>
        public enum Unit
        {
            /// <summary>
            /// Measurement for Feet
            /// </summary>
            Feet,

            /// <summary>
            /// Measurement for Inch
            /// </summary>
            Inch,

            /// <summary>
            /// Measurement for Yard
            /// </summary>
            Yard,

            /// <summary>
            /// Measurement for Gallon
            /// </summary>
            Gallon,

            /// <summary>
            /// Measurement for Liter
            /// </summary>
            Liter,

            /// <summary>
            /// Measurement for Centimeter
            /// </summary>
            Centimeter,

            /// <summary>
            /// Measurement for Milliliter
            /// </summary>
            Milliliter,

            /// <summary>
            /// enum Indicating conversion from Feet To Inch
            /// </summary>
            FeetToInch,

            /// <summary>
            /// enum Indicating conversion from Yard To Inch
            /// </summary>
            YardToInch,

            /// <summary>
            /// enum Indicating conversion from Centimeter To Inch
            /// </summary>
            CentimeterToInch,

            /// <summary>
            /// enum Indicating conversion from Gallon To Liter
            /// </summary>
            GallonToLiter,

            /// <summary>
            /// enum Indicating conversion from Liter To Milliliter
            /// </summary>
            LiterToMilliliter
        }

        /// <summary>
        /// Method to convert one length to another
        /// </summary>
        /// <param name="unit">defines which unit used</param>
        /// <param name="length">length for conversion</param>
        /// <returns>returns value after calculation</returns>
        public double ConvertLength(Unit unit, double length)
        {
            try
            {
                if (unit.Equals(Unit.FeetToInch))
                {
                    return length * FeetToInch;
                }
                
                if (unit.Equals(Unit.YardToInch))
                {
                    return length * YardToInch;
                }

                if (unit.Equals(Unit.CentimeterToInch))
                {
                    return length / CentimeterToInch;
                }

                if (unit.Equals(Unit.GallonToLiter))
                {
                    return length * GallonToLiter;
                }

                if (unit.Equals(Unit.LiterToMilliliter))
                {
                    return length * LiterToMilliliter;
                }

                return length;
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidLength, e.Message);
            }
            catch (Exception e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidLength, e.Message);
            }
        }

        /// <summary>
        /// Method For Addition of Two Length
        /// </summary>
        /// <param name="firstValue">contains first length</param>
        /// <param name="secondValue">contains second length</param>
        /// <returns>return addition of Lengths</returns>
        public double CalculateLength(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
