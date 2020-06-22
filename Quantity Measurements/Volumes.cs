//-----------------------------------------------------------------------
// <copyright file="Volumes.cs" company="BridgeLabz Solution">
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
    /// class for Volume
    /// </summary>
    public class Volumes
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
        /// Initializes a new instance of the <see cref="Volumes" /> class.
        /// </summary>
        public Volumes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Volumes" /> class.
        /// </summary>
        /// <param name="unit">to specify conversion</param>
        /// <param name="value">for giving value</param>
        public Volumes(Unit unit, string value)
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
            /// Measurement for Gallon
            /// </summary>
            Gallon,

            /// <summary>
            /// Measurement for Liter
            /// </summary>
            Liter,

            /// <summary>
            /// Measurement for Milliliter
            /// </summary>
            Milliliter,

            /// <summary>
            /// enum Indicating conversion from Gallon To Liter
            /// </summary>
            GallonToLiter,

            /// <summary>
            /// enum Indicating conversion from Liter To Milliliter
            /// </summary>
            LiterToMilliliter,

            /// <summary>
            /// enum Indicating conversion from Milliliter To Liter
            /// </summary>
            MilliliterToLiter
        }

        /// <summary>
        /// Method to convert one volume to another
        /// </summary>
        /// <param name="unit">defines which unit used</param>
        /// <param name="volume">volume for conversion</param>
        /// <returns>returns value after calculation</returns>
        public double ConvertVolumes(Unit unit, double volume)
        {
            try
            {              
                if (unit.Equals(Unit.GallonToLiter))
                {
                    return volume * 3.78;
                }

                if (unit.Equals(Unit.LiterToMilliliter))
                {
                    return volume * 1000;
                }

                if (unit.Equals(Unit.MilliliterToLiter))
                {
                    return volume / 1000;
                }

                return volume;
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
