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
        /// declaration for Feet and assigned to null
        /// </summary>
        private Length feet = null;

        /// <summary>
        /// declaration for Inch and assigned to null
        /// </summary>
        private Length inch = null;

        /// <summary>
        /// declaration for Yard and assigned to null
        /// </summary>
        private Length yard = null;

        /// <summary>
        /// declaration for Yard and assigned to null
        /// </summary>
        private Length centiMeter = null;

        /// <summary>
        /// Method to Assign of Class Instance
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.feet = new Length();
            this.inch = new Length();
            this.yard = new Length();
            this.centiMeter = new Length();
        }

        /// <summary>
        /// TC-1.1 : Given first Feet 0 and second Feet 0 when checked should return Equal.
        /// </summary>
        [Test]
        public void Given0FeetAnd0Feet_WhenChecked_ShouldReturnEqual()
        {
            double feet1 = this.feet.ConvertLength(Length.Unit.Feet, 0.0);
            double feet2 = this.feet.ConvertLength(Length.Unit.Feet, 0.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// TC-1.2 : Given first Feet Value and second Feet Null when checked should return Not Equal.
        /// </summary>
        [Test]
        public void Given0FeetAndNull_WhenChecked_ShouldReturnNotEqual()
        {
            double feet1 = this.feet.ConvertLength(Length.Unit.Feet, 0.0);
            Length feet2 = null;
            Assert.AreNotEqual(feet1, feet2);
        }

        /// <summary>
        /// TC-1.3 : Given first Feet 0 and second Feet 2 when checked should return Not Equal.
        /// </summary>
        [Test]
        public void Given0FeetAnd2Feet_WhenChecked_ShouldReturnNotEqual()
        {
            double feet1 = this.feet.ConvertLength(Length.Unit.Feet, 0.0);
            double feet2 = this.feet.ConvertLength(Length.Unit.Feet, 2.0);
            Assert.AreNotEqual(feet1, feet2);
        }

        /// <summary>
        /// TC-1.4 : Given first Feet Object type and second Feet Object type when checked should return Equal.
        /// </summary>
        [Test]
        public void GivenFeetObjectAndFeetObject_WhenChecked_ShouldReturnEqual()
        {
            double feet1 = this.feet.ConvertLength(Length.Unit.Feet, 0.0);
            double feet2 = this.feet.ConvertLength(Length.Unit.Feet, 2.0);
            Assert.AreEqual(feet1.GetType(), feet2.GetType());
        }

        /// <summary>
        /// TC-1.5 : Given first Feet Object and second Feet Object when checked should return Equal.
        /// </summary>
        [Test]
        public void GivenTwoObjectHaveSameReference_WhenCheckedReference_ShouldReturnEqual()
        {
            Length feet1 = new Length();
            Length feet2 = new Length();
            feet1 = feet2;
            bool check = object.ReferenceEquals(feet1, feet2);
            Assert.True(check);
        }

        /// <summary>
        /// TC-1.6 : Given first Feet and second Feet same value when checked should return Equal.
        /// </summary>
        [Test]
        public void Given1stAnd2ndSameValue_WhenChecked_ShouldReturnEqual()
        {
            double feet1 = this.feet.ConvertLength(Length.Unit.Feet, 2.0);
            double feet2 = this.feet.ConvertLength(Length.Unit.Feet, 2.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// TC-1.7 : Given first Inch 0 and second Inch 0 when checked should return Equal.
        /// </summary>
        [Test]
        public void Given0InchAnd0Inch_WhenChecked_ShouldReturnEqual()
        {
            double inch1 = this.inch.ConvertLength(Length.Unit.Inch, 0.0);
            double inch2 = this.inch.ConvertLength(Length.Unit.Inch, 0.0);
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// TC-1.8 : Given first Inch Value and second Inch Null when checked should return Not Equal.
        /// </summary>
        [Test]
        public void Given0InchAndSecondNull_WhenChecked_ShouldReturnNotEqual()
        {
            double inch1 = this.inch.ConvertLength(Length.Unit.Inch, 0.0);
            Length inch2 = null;
            Assert.AreNotEqual(inch1, inch2);
        }

        /// <summary>
        /// TC-1.9 : Given first Inch 0 and second Inch 2 when checked should return Not Equal.
        /// </summary>
        [Test]
        public void Given0InchAnd2Inch_WhenChecked_ShouldReturnNotEqual()
        {
            double inch1 = this.inch.ConvertLength(Length.Unit.Inch, 0.0);
            double inch2 = this.inch.ConvertLength(Length.Unit.Inch, 2.0);
            Assert.AreNotEqual(inch1, inch2);
        }

        /// <summary>
        /// TC-1.10 : Given first Inch Type of Object and second Inch Type of Object when checked should return Equal.
        /// </summary>
        [Test]
        public void Given1stInchObjectAnd2ndInchObjectOfType_WhenChecked_ShouldReturnEqual()
        {
            double inch1 = this.inch.ConvertLength(Length.Unit.Inch, 0.0);
            double inch2 = this.inch.ConvertLength(Length.Unit.Inch, 0.0);
            Assert.AreEqual(inch1.GetType(), inch2.GetType());
        }

        /// <summary>
        /// TC-1.11 : Given first Inch Object reference to second Inch Object when checked should return Equal.
        /// </summary>
        [Test]
        public void GivenInchTwoObjectHaveSameReference_WhenCheckedReference_ShouldReturnReturnEqual()
        {
            double inch1 = this.inch.ConvertLength(Length.Unit.Inch, 0.0);
            double inch2 = inch1;
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// TC-1.12 : Given first Inch and second Inch same value when checked should return Equal.
        /// </summary>
        [Test]
        public void Given1stAnd2ndInchSameValue_WhenChecked_ShouldReturnEqual()
        {
            double inch1 = this.inch.ConvertLength(Length.Unit.Inch, 2.0);
            double inch2 = this.inch.ConvertLength(Length.Unit.Inch, 2.0);
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// TC-1.13 : Given 1 Feet and 1 Inch when checked should return Not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1Inch_WhenChecked_ShouldReturnNotEqual()
        {
            double feet1 = this.feet.ConvertLength(Length.Unit.FeetToInch, 1.0);
            double inch1 = this.inch.ConvertLength(Length.Unit.Inch, 1.0);            
            Assert.AreNotEqual(feet1, inch1);
        }

        /// <summary>
        /// TC-1.14 : Given 0 Feet and 0 Inch when checked should return Equal.
        /// </summary>
        [Test]
        public void Given0FeetAnd0Inch_WhenCompared_ShouldReturnEqual()
        {
            double feet1 = this.feet.ConvertLength(Length.Unit.Feet, 0.0);
            double inch1 = this.inch.ConvertLength(Length.Unit.Inch, 0.0);
            Assert.AreEqual(feet1, inch1);
        }

        /// <summary>
        /// TC-1.15 : Given 0 Feet and 1 Inch when checked should return Not Equal.
        /// </summary>
        [Test]
        public void Given0FeetAnd1Inch_WhenCompared_ShouldReturnNotEqual()
        {
            double feet1 = this.feet.ConvertLength(Length.Unit.Feet, 0.0);
            double inch1 = this.inch.ConvertLength(Length.Unit.Inch, 1.0);
            Assert.AreNotEqual(feet1, inch1);
        }

        /// <summary>
        /// TC-1.16 : Given 1 Feet and 12 Inch when checked should return Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd12Inch_WhenComapared_ShouldReturnEqual()
        {
            double feet1 = this.feet.ConvertLength(Length.Unit.FeetToInch, 1.0);
            double inch1 = this.inch.ConvertLength(Length.Unit.Inch, 12.0);
            Assert.AreEqual(feet1, inch1);
        }

        /// <summary>
        /// TC-1.17 : Given 1 Feet and 1 Feet when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenComapared_ShouldReturnEqual()
        {
            double feet1 = this.feet.ConvertLength(Length.Unit.Feet, 1.0);
            double feet2 = this.feet.ConvertLength(Length.Unit.Feet, 1.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// TC-1.18 : Given 12 Inch and 1 Feet when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given12InchAnd1Feet_WhenComapared_ShouldReturnEqual()
        {
            double inch1 = this.inch.ConvertLength(Length.Unit.Inch, 12.0);
            double feet1 = this.inch.ConvertLength(Length.Unit.FeetToInch, 1.0);
            Assert.AreEqual(inch1, feet1);
        }

        /// <summary>
        /// TC-2.1 : Given 1 Yard and 1 Yard when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1YardAnd1Yard_WhenComparingLength_ShouldReturnEqual()
        {
            double yard1 = this.inch.ConvertLength(Length.Unit.Yard, 1.0);
            double yard2 = this.inch.ConvertLength(Length.Unit.Yard, 1.0);
            Assert.AreEqual(yard1, yard2);
        }

        /// <summary>
        /// TC-2.2 : Given 3 Feet and 1 Yard when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given3FeetAnd1Yard_WhenComparingLength_ShouldReturnEqual()
        {
            double feet1 = this.inch.ConvertLength(Length.Unit.FeetToInch, 3.0);
            double yard1 = this.inch.ConvertLength(Length.Unit.YardToInch, 1.0);
            Assert.AreEqual(feet1, yard1);
        }

        /// <summary>
        /// TC-2.3 : Given 1 Feet and 1 Yard when Compared should return Not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1Yard_WhenComparingLength_ShouldReturnNotEqual()
        {
            double feet1 = this.feet.ConvertLength(Length.Unit.FeetToInch, 1.0);
            double yard1 = this.yard.ConvertLength(Length.Unit.YardToInch, 1.0);
            Assert.AreNotEqual(feet1, yard1);
        }

        /// <summary>
        /// TC-2.4 : Given 1 Yard and 36 Inch when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1InchAnd1Yard_WhenComparingLength_ShouldReturnEqual()
        {
            double yard1 = this.yard.ConvertLength(Length.Unit.YardToInch, 1.0);
            double inch1 = this.inch.ConvertLength(Length.Unit.Inch, 36.0);
            Assert.AreEqual(yard1, inch1);
        }

        /// <summary>
        /// TC-2.5 : Given 1 Yard and 3 Feet when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1YardAnd3Feet_WhenComparingLength_ShouldReturnEqual()
        {
            double yard1 = this.yard.ConvertLength(Length.Unit.YardToInch, 1.0);
            double feet1 = this.feet.ConvertLength(Length.Unit.FeetToInch, 3.0);
            Assert.AreEqual(yard1, feet1);
        }

        /// <summary>
        /// TC-2.6 : Given 36 Inch and 1 Yard when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given36InchAnd1Inch_WhenComparingLength_ShouldReturnEqual()
        {
            double inch1 = this.inch.ConvertLength(Length.Unit.Inch, 36.0);
            double yard1 = this.yard.ConvertLength(Length.Unit.YardToInch, 1.0);
            Assert.AreEqual(inch1, yard1);
        }

        /// <summary>
        /// TC-2.7 : Given null and 1 Yard when Compared should return Not Equal.
        /// </summary>
        [Test]
        public void GivenNullAnd1Yard_WhenComparingLength_ShouldReturnNotEqual()
        {
            Length inch1 = null;
            double yard1 = this.yard.ConvertLength(Length.Unit.Yard, 1.0);
            Assert.AreNotEqual(inch1, yard1);
        }

        /// <summary>
        /// TC-3.1 : Given 0 CentiMeter and 0 CentiMeter when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given0CentiMeterAnd0CentiMeter_WhenComparingLength_ShouldReturnEqual()
        {
            double centiMeter1 = this.inch.ConvertLength(Length.Unit.CentiMeter, 0.0);
            double centiMeter2 = this.yard.ConvertLength(Length.Unit.CentiMeter, 0.0);
            Assert.AreEqual(centiMeter1, centiMeter2);
        }

        /// <summary>
        /// TC-3.2 : Given 0 CentiMeter and 1 CentiMeter when Compared should return Not Equal.
        /// </summary>
        [Test]
        public void Given0CentiMeterAnd1CentiMeter_WhenCompared_ShouldReturnNotEqual()
        {
            double centiMeter1 = this.centiMeter.ConvertLength(Length.Unit.CentiMeter, 0.0);
            double centiMeter2 = this.centiMeter.ConvertLength(Length.Unit.CentiMeter, 1.0);
            Assert.AreNotEqual(centiMeter1, centiMeter2);
        }

        /// <summary>
        /// TC-3.3 : Given first 0 CentiMeter and second CentiMeter Null when Compared should return Not Equal.
        /// </summary>
        [Test]
        public void Given0CentiMeterAndSecondNull_WhenCompared_ShouldReturnNotEqual()
        {
            double centiMeter1 = this.centiMeter.ConvertLength(Length.Unit.CentiMeter, 0.0);
            Length centiMeter2 = null;
            Assert.AreNotEqual(centiMeter1, centiMeter2);
        }

        /// <summary>
        /// TC-3.4 : Given first 0 CentiMeter Object type and second 2 CentiMeter Object type when checked should return Equal.
        /// </summary>
        [Test]
        public void Given0CentiMeterObjectAnd2centiMeterObject_WhenCompared_ShouldReturnEqual()
        {
            double centiMeter1 = this.centiMeter.ConvertLength(Length.Unit.CentiMeter, 0.0);
            double CentiMeter2 = this.centiMeter.ConvertLength(Length.Unit.CentiMeter, 2.0);
            Assert.AreEqual(centiMeter1.GetType(), CentiMeter2.GetType());
        }
    }
}