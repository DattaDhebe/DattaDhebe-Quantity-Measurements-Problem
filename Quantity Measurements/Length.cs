//-----------------------------------------------------------------------
// <copyright file="Length.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Datta Dhebe</author>
//-----------------------------------------------------------------------

namespace Quantity_Measurements
{
    using System;

    /// <summary>
    /// Class for Feet Entity
    /// </summary>
    public class Length
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Length" /> class.
        /// </summary>
        public Length() 
        { 
        }

        /// <summary>
        /// enum to specify measurements
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
            /// Measurement for Centimeter
            /// </summary>
            Centimeter,
          
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
                    return length * 12.0;
                }
                
                if (unit.Equals(Unit.YardToInch))
                {
                    return length * 36.0;
                }

                if (unit.Equals(Unit.CentimeterToInch))
                {
                    return length / 2.5;
                }
               
                return length;
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidData, e.Message);
            }
            catch (Exception e)
            {
                throw e;
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
            try
            {
                // Addition of two values
                return firstValue + secondValue;
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }
    }
}
