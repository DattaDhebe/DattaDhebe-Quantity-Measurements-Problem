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
        public const double FeetToInch = 12.0;

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
            Inch          
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
