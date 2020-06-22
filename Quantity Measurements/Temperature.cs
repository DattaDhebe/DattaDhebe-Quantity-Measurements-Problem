//-----------------------------------------------------------------------
// <copyright file="Temperature.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Datta Dhebe</author>
//-----------------------------------------------------------------------

namespace Quantity_Measurements
{
    using System;

    /// <summary>
    /// class for Temperature Entity
    /// </summary>
    public class Temperature
    {
        /// <summary>
        /// pre-defined value for converting Kilogram to Grams
        /// </summary>
        private const double CelsiusToFahrenheit = 33.8;

        /// <summary>
        /// to specify conversion type
        /// </summary>
        private Unit unit;

        /// <summary>
        /// for giving value
        /// </summary>
        private string value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Temperature" /> class.
        /// </summary>
        public Temperature()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Temperature" /> class.
        /// </summary>
        /// <param name="unit">to specify conversion</param>
        /// <param name="value">for giving value</param>
        public Temperature(Unit unit, string value)
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
            /// Temperature for Fahrenheit
            /// </summary>
            Fahrenheit,

            /// <summary>
            /// Temperature for Celsius
            /// </summary>
            Celsius,

            /// <summary>
            /// Temperature for Celsius To Fahrenheit
            /// </summary>
            CelsiusToFahrenheit
        }

        /// <summary>
        /// Method to convert Weights
        /// </summary>
        /// <param name="unit">defines which unit used</param>
        /// <param name="temperature">defines which type of temperature</param>
        /// <returns>return calculated temperature</returns>
        public double ConvertTemperature(Unit unit, double temperature)
        {
            try
            {
                if (unit.Equals(Unit.CelsiusToFahrenheit))
                {
                    return CelsiusToFahrenheit + (temperature * 1.8) - 1.8;
                }

                return temperature;
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
