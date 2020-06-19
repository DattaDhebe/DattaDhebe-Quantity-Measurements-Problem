//-----------------------------------------------------------------------
// <copyright file="CabInvoiceTesting.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Datta Dhebe</author>
//-----------------------------------------------------------------------

namespace Quantity_Measurements_Testing
{
    using System;
    using Quantity_Measurements;
    using NUnit.Framework;
    

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given0FeetAnd0Feet_ShouldReturnEqual()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = new Feet(0.0);
            Assert.AreEqual(feet1, feet2);
        }
    }
}