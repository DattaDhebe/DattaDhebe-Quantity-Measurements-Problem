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
        /// TC-1.1 : Given first Feet 0 and second Feet 0 when checked should return Equal
        /// </summary>
        [Test]
        public void Given0FeetAnd0Feet_WhenChecked_ShouldReturnEqual()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = new Feet(0.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// TC-1.2 : Given first Feet Value and second Feet Null when checked should return Not Equal
        /// </summary>
        [Test]
        public void Given0FeetAndNull_WhenChecked_ShouldReturnNotEqual()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = null;
            Assert.AreNotEqual(feet1, feet2);
        }

        /// <summary>
        /// TC-1.3 : Given first Feet 0 and second Feet 2 when checked should return Not Equal
        /// </summary>
        [Test]
        public void Given0FeetAnd2Feet_WhenChecked_ShouldReturnNotEqual()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = new Feet(2.0);
            Assert.AreNotEqual(feet1, feet2);
        }

        /// <summary>
        /// TC-1.4 : Given first Feet Object and second Feet Object when checked should return Equal
        /// </summary>
        [Test]
        public void GivenFeetObjectAndFeetObject_WhenChecked_ShouldReturnNotEqual()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = new Feet(2.0);
            Assert.AreEqual(feet1.GetType(), feet2.GetType());
        }

        /// <summary>
        /// TC-1.5 : Given first Feet Object and second Feet Object when checked should return Equal
        /// </summary>
        [Test]
        public void GivenTwoObjectHaveSameReference_WhenCheckedReference_ShouldReturnNotEqual()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = feet1;
            bool check = System.Object.ReferenceEquals(feet1, feet2);
            Assert.True(check);
        }

        /// <summary>
        /// TC-1.6 : Given first Feet and second Feet same value when checked should return Equal
        /// </summary>
        [Test]
        public void Given1stAnd2ndSameValue_WhenChecked_ShouldReturnNotEqual()
        {
            Feet feet1 = new Feet(2.0);
            Feet feet2 = new Feet(2.0);
            Assert.AreEqual(feet1, feet2);
        }
    }
}