//-----------------------------------------------------------------------
// <copyright file="CabInvoiceTesting.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Datta Dhebe</author>
//-----------------------------------------------------------------------

namespace Quantity_Measurements
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Feet
    {
        private double value;

        public Feet(double value)
        {
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Feet feet &&
                   value == feet.value;
        }
    }
}
