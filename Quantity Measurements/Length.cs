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
        /// variable indicating conversion Feet to Inch
        /// </summary>
        private const double FeetToInch = 12.0;

        /// <summary>
        /// variable indicating conversion Inch to Feet
        /// </summary>
        private const double InchToFeet = 12.0;

        /// <summary>
        /// variable indicating conversion Feet to Yard
        /// </summary>
        private const double FeetToYard = 3.0;

        /// <summary>
        /// variable indicating conversion Yard to Inch
        /// </summary>
        private const double YardToInch = 36.0;

        /// <summary>
        /// Variable to specify Unit
        /// </summary>
        private Unit unit;

        /// <summary>
        /// variable indicating value of Feet
        /// </summary>
        private double value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Length" /> class.
        /// </summary>
        /// <param name="unit">To specify Measurements</param>
        /// <param name="value">Feet value</param>
        public Length(Length.Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
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
            Yard
        }

        /// <summary>
        /// Method to compare Between Feet and Inch
        /// </summary>
        /// <param name="that">object for compare</param>
        /// <returns>Return true or false</returns>
        public bool Compare(Length that)
        {
            if (this.unit.Equals(that.unit))
            {
                return this.Equals(that);
            }

            if (this.unit.Equals(Unit.Feet) && that.unit.Equals(Unit.Inch))
            {
                return that.value.CompareTo(this.value * FeetToInch) == 0;
            }

            if (this.unit.Equals(Unit.Inch) && that.unit.Equals(Unit.Feet))
            {
                return that.value.CompareTo(this.value / InchToFeet) == 0;
            }

            if (this.unit.Equals(Unit.Feet) && that.unit.Equals(Unit.Yard))
            {
                return that.value.CompareTo(this.value / FeetToYard) == 0;
            }

            if (this.unit.Equals(Unit.Yard) && that.unit.Equals(Unit.Inch))
            {
                return that.value.CompareTo(this.value * YardToInch) == 0;
            }

            return false;
        }

        /// <summary>
        /// Method to Compare two objects
        /// </summary>
        /// <param name="obj">object for Equality Check</param>
        /// <returns>return if equal or not</returns>
        public override bool Equals(object obj)
        {
            return obj is Length length &&
                   this.unit == length.unit &&
                   this.value == length.value;
        }

        /// <summary>
        /// Method to returns HashCode of value
        /// </summary>
        /// <returns>return HashCode</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.value);
        }
    }
}
