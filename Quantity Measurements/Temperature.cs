using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurements
{
    public class Temperature
    {
        /// <summary>
        /// pre-defined value for converting Kilogram to Grams
        /// </summary>
        private const double CelsiusToFahrenheit = 33.8;

        public enum Unit
        {
            Fahrenheit,
            Celsius,
            CelsiusToFahrenheit     
        }

        public double ConvertWeigths(Unit unit, double temperature)
        {
            try
            {
                if (unit.Equals(Unit.CelsiusToFahrenheit))
                {
                    return temperature * CelsiusToFahrenheit;
                }

                return temperature;
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
    }
}
