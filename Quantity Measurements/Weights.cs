using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurements
{
    public class Weights
    {
        /// <summary>
        /// pre-defined value for converting Feet to Inch
        /// </summary>
        private const double KilogramToGrams = 1000;

        public enum Unit 
        { 
            kilogram,
            Grams,
            KilogramToGrams
        }

        public double ConvertWeigths(Unit unit, double weights)
        {
            try
            {
                if (unit.Equals(Unit.KilogramToGrams))
                {
                    return weights * KilogramToGrams;
                }

                return weights;
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
