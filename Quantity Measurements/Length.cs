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
    using System.Text;

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
            /// enum Indicating conversion from Feet To Inch
            /// </summary>
            FeetToInch,

            /// <summary>
            /// enum Indicating conversion from Yard To Inch
            /// </summary>
            YardToInch
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
                else if (unit.Equals(Unit.YardToInch))
                {
                    return length * 36.0;
                }

                return length;
            }
            catch (Exception e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidLength, e.Message);
            }
        }
    }
}
