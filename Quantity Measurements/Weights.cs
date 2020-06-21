using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurements
{
    public class Weights
    {
        /// <summary>
        /// pre-defined value for converting Kilogram to Grams
        /// </summary>
        private const double KilogramToGrams = 1000;

        /// <summary>
        /// pre-defined value for converting Tonne to Kilogram
        /// </summary>
        private const double TonneToKilograms = 1000;

        

        public enum Unit 
        { 
            kilogram,
            Grams,
            Tonne,
            KilogramToGrams,
            TonneToKilograms
        }

        public double ConvertWeigths(Unit unit, double weights)
        {
            try
            {
                if (unit.Equals(Unit.KilogramToGrams))
                {
                    return weights * KilogramToGrams;
                }

                if (unit.Equals(Unit.TonneToKilograms))
                {
                    return weights * TonneToKilograms;
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
