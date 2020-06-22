//-----------------------------------------------------------------------
// <copyright file="Weights.cs" company="BridgeLabz Solution">
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
    /// class for weights
    /// </summary>
    public class Weights
    { 
        /// <summary>
        /// to specify conversion type
        /// </summary>
        private Unit unit;

        /// <summary>
        /// for giving value
        /// </summary>
        private string value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Weights" /> class.
        /// </summary>
        public Weights()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Weights" /> class.
        /// </summary>
        /// <param name="unit">to specify conversion</param>
        /// <param name="value">for giving value</param>
        public Weights(Unit unit, string value)
        {
            this.unit = unit;
            this.value = value;
        }

        /// <summary>
        /// enum to specify measurements
        /// </summary>
        public enum Unit 
        { 
            /// <summary>
            /// for measurement of kilogram
            /// </summary>
            kilogram,

            /// <summary>
            /// for measurement of grams
            /// </summary>
            Grams,

            /// <summary>
            /// for measurement of Tone
            /// </summary>
            Tonne,

            /// <summary>
            /// for measurement of kilogram TO grams
            /// </summary>
            KilogramToGrams,

            /// <summary>
            /// for measurement of Tone To kilogram
            /// </summary>
            TonneToKilograms
        }

        /// <summary>
        /// Method to convert one volume to another
        /// </summary>
        /// <param name="unit">defines which unit used</param>
        /// <param name="weights">weights for conversion</param>
        /// <returns>returns value after calculation</returns>
        public double ConvertWeigths(Unit unit, double weights)
        {
            try
            {
                if (unit.Equals(Unit.KilogramToGrams) || unit.Equals(Unit.TonneToKilograms))
                {
                    return weights * 1000;
                }

                return weights;
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
    }
}
