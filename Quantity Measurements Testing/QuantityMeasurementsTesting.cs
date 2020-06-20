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
            Length feet1 = new Length(Length.Unit.Feet, 0.0);
            Length feet2 = new Length(Length.Unit.Feet, 0.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// TC-1.2 : Given first Feet Value and second Feet Null when checked should return Not Equal
        /// </summary>
        [Test]
        public void Given0FeetAndNull_WhenChecked_ShouldReturnNotEqual()
        {
            Length feet1 = new Length(Length.Unit.Feet, 0.0);
            Length feet2 = null;
            Assert.AreNotEqual(feet1, feet2);
        }

        /// <summary>
        /// TC-1.3 : Given first Feet 0 and second Feet 2 when checked should return Not Equal
        /// </summary>
        [Test]
        public void Given0FeetAnd2Feet_WhenChecked_ShouldReturnNotEqual()
        {
            Length feet1 = new Length(Length.Unit.Feet, 0.0);
            Length feet2 = new Length(Length.Unit.Feet, 2.0);
            Assert.AreNotEqual(feet1, feet2);
        }

        /// <summary>
        /// TC-1.4 : Given first Feet Object and second Feet Object when checked should return Equal
        /// </summary>
        [Test]
        public void GivenFeetObjectAndFeetObject_WhenChecked_ShouldReturnEqual()
        {
            Length feet1 = new Length(Length.Unit.Feet, 0.0);
            Length feet2 = new Length(Length.Unit.Feet, 2.0);
            Assert.AreEqual(feet1.GetType(), feet2.GetType());
        }

        /// <summary>
        /// TC-1.5 : Given first Feet Object and second Feet Object when checked should return Equal
        /// </summary>
        [Test]
        public void GivenTwoObjectHaveSameReference_WhenCheckedReference_ShouldReturnTrue()
        {
            Length feet1 = new Length(Length.Unit.Feet, 0.0);
            Length feet2 = feet1;
            bool check = object.ReferenceEquals(feet1, feet2);
            Assert.True(check);
        }

        /// <summary>
        /// TC-1.6 : Given first Feet and second Feet same value when checked should return Equal
        /// </summary>
        [Test]
        public void Given1stAnd2ndSameValue_WhenChecked_ShouldReturnNotEqual()
        {
            Length feet1 = new Length(Length.Unit.Feet, 2.0);
            Length feet2 = new Length(Length.Unit.Feet, 2.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// TC-1.7 : Given first Inch 0 and second Inch 0 when checked should return Equal
        /// </summary>
        [Test]
        public void Given0InchAnd0Inch_WhenChecked_ShouldReturnEqual()
        {
            Length inch1 = new Length(Length.Unit.Inch, 0.0);
            Length inch2 = new Length(Length.Unit.Inch, 0.0);
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// TC-1.8 : Given first Inch Value and second Inch Null when checked should return Not Equal
        /// </summary>
        [Test]
        public void Given0InchAndSecondNull_WhenChecked_ShouldReturnNotEqual()
        {
            Length inch1 = new Length(Length.Unit.Inch, 0.0);
            Length inch2 = null;
            Assert.AreNotEqual(inch1, inch2);
        }

        /// <summary>
        /// TC-1.9 : Given first Inch 0 and second Inch 2 when checked should return Not Equal
        /// </summary>
        [Test]
        public void Given0InchAnd2Inch_WhenChecked_ShouldReturnNotEqual()
        {
            Length inch1 = new Length(Length.Unit.Inch, 0.0);
            Length inch2 = new Length(Length.Unit.Inch, 2.0);
            Assert.AreNotEqual(inch1, inch2);
        }

        /// <summary>
        /// TC-1.10 : Given first Inch Type of Object and second Inch Type of Object when checked should return Equal
        /// </summary>
        [Test]
        public void Given1stInchObjectAnd2ndInchObjectOfType_WhenChecked_ShouldReturnEqual()
        {
            Length inch1 = new Length(Length.Unit.Inch, 0.0);
            Length inch2 = new Length(Length.Unit.Inch, 2.0);
            Assert.AreEqual(inch1.GetType(), inch2.GetType());
        }

        /// <summary>
        /// TC-1.11 : Given first Inch Object reference to second Inch Object when checked should return Equal
        /// </summary>
        [Test]
        public void GivenInchTwoObjectHaveSameReference_WhenCheckedReference_ShouldReturnReturnTrue()
        {
            Length inch1 = new Length(Length.Unit.Inch, 0.0);
            Length inch2 = inch1;
            bool check = object.ReferenceEquals(inch1, inch2);
            Assert.True(check);
        }

        /// <summary>
        /// TC-1.12 : Given first Inch and second Inch same value when checked should return Equal
        /// </summary>
        [Test]
        public void Given1stAnd2ndInchSameValue_WhenChecked_ShouldReturnEqual()
        {
            Length inch1 = new Length(Length.Unit.Inch, 2.0);
            Length inch2 = new Length(Length.Unit.Inch, 2.0);
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// TC-1.13 : Given 1 Feet and 1 Inch when checked should return Not Equal
        /// </summary>
        [Test]
        public void Given1FeetAnd1Inch_WhenChecked_ShouldReturnNotEqual()
        {
            Length feet1 = new Length(Length.Unit.Feet, 1.0);
            Length inch2 = new Length(Length.Unit.Inch, 1.0);
            Assert.AreNotEqual(feet1, inch2);
        }

        /// <summary>
        /// TC-1.14 : Given 0 Feet and 0 Inch when checked should return True.
        /// </summary>
        [Test]
        public void Given0FeetAnd0Inch_WhenCompared_ShouldReturnEqualLength()
        {
            Length feet1 = new Length(Length.Unit.Feet, 0.0);
            Length inch1 = new Length(Length.Unit.Inch, 0.0);
            bool compareCheck = feet1.Compare(inch1);
            Assert.True(compareCheck);
        }

        /// <summary>
        /// TC-1.15 : Given 0 Feet and 1 Inch when checked should return False.
        /// </summary>
        [Test]
        public void Given0FeetAnd1Inch_WhenCompared_ShouldReturnNotEqualLength()
        {
            Length feet1 = new Length(Length.Unit.Feet, 0.0);
            Length inch1 = new Length(Length.Unit.Inch, 1.0);
            bool compareCheck = feet1.Compare(inch1);
            Assert.False(compareCheck);
        }

        /// <summary>
        /// TC-1.16 : Given 1 Feet and 12 Inch when checked should return True.
        /// </summary>
        [Test]
        public void Given1FeetAnd12Inch_WhenComapared_ShouldReturnEqualLength()
        {
            Length feet1 = new Length(Length.Unit.Feet, 1.0);
            Length inch1 = new Length(Length.Unit.Inch, 12.0);
            bool compareCheck = feet1.Compare(inch1);
            Assert.True(compareCheck);
        }

        /// <summary>
        /// TC-1.17 : Given 1 Feet and 1 Feet when Comapred should return True.
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenComapared_ShouldReturnTrue()
        {
            Length feet1 = new Length(Length.Unit.Feet, 1.0);
            Length feet2 = new Length(Length.Unit.Feet, 1.0);
            bool compareCheck = feet1.Compare(feet2);
            Assert.True(compareCheck);
        }

        /// <summary>
        /// TC-1.18 : Given 12 Inch and 1 Feet when Comapared should return True.
        /// </summary>
        [Test]
        public void Given12InchAnd1Feet_WhenComapared_ShouldReturnTrue()
        {
            Length inch1 = new Length(Length.Unit.Inch, 12.0);
            Length feet1 = new Length(Length.Unit.Feet, 1.0);
            bool compareCheck = inch1.Compare(feet1);
            Assert.True(compareCheck);
        }

        /// <summary>
        /// TC-1.19 : Given 1 Yard and 1 Yard when Comapred should return Equal Length.
        /// </summary>
        [Test]
        public void Given1YardAnd1Yard_WhenComapared_ShouldReturnTrue()
        {
            Length yard1 = new Length(Length.Unit.Yard, 1.0);
            Length yard2 = new Length(Length.Unit.Yard, 1.0);
            bool compareCheck = yard1.Compare(yard2);
            Assert.True(compareCheck);
        }
    }
}