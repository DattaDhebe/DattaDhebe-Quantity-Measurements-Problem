//-----------------------------------------------------------------------
// <copyright file="QuantityMeasurementsTesting.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Datta Dhebe</author>
//-----------------------------------------------------------------------

namespace Quantity_Measurements_Testing
{
    using System;
    using NUnit.Framework;
    using Quantity_Measurements;

    /// <summary>
    /// Test Cases For Quantity Measurements Problem
    /// </summary>
    public class QuantityMeasurementsTesting
    {
        /// <summary>
        /// Method to Assign of Class Instance
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Given first Feet 0 and second Feet 0 when should return Equal
        /// </summary>
        [Test]
        public void Given0FeetAnd0Feet_ShouldReturnEqual()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = new Feet(0.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Given first Feet Value and second Feel Null should return Not Equal
        /// </summary>
        [Test]
        public void Given0FeetAndNull_ShouldReturnEqual()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = null;
            Assert.AreNotEqual(feet1, feet2);
        }       
    }
}