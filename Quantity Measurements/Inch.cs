//-----------------------------------------------------------------------
// <copyright file="Inch.cs" company="BridgeLabz Solution">
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
    /// Class for Inch Entity
    /// </summary>
    public class Inch
    {
        /// <summary>
        /// variable indicating value of Feet
        /// </summary>
        private double value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Inch" /> class.
        /// </summary>
        /// <param name="value">Feet value</param>
        public Inch(double value)
        {
            this.value = value;
        }

        /// <summary>
        /// Method to Compare two objects
        /// </summary>
        /// <param name="obj">object for compare</param>
        /// <returns>return if equal or not</returns>
        public override bool Equals(object obj)
        {
            return obj is Inch inch &&
                   this.value == inch.value;
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
