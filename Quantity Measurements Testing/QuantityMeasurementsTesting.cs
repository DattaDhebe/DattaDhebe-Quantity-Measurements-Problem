//-----------------------------------------------------------------------
// <copyright file="QuantityMeasurementsTesting.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Datta Dhebe</author>
//-----------------------------------------------------------------------

namespace Quantity_Measurements_Testing
{
    using NUnit.Framework;
    using Quantity_Measurements;

    /// <summary>
    /// Test Cases For Quantity Measurements Problem
    /// </summary>
    public class QuantityMeasurementsTesting
    {
        /// <summary>
        /// creating Object of class Length
        /// </summary>
        private Length length = null;

        /// <summary>
        /// creating Object of class Weights
        /// </summary>
        private Weights weights = null;

        /// <summary>
        /// creating Object of class Temperature
        /// </summary>
        private Temperature temperature = null;

        /// <summary>
        /// creating Object of class volumes
        /// </summary>
        private Volumes volumes = null;

        /// <summary>
        /// Method to Assign of Class Instance
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.length = new Length();
            this.weights = new Weights();
            this.temperature = new Temperature();
            this.volumes = new Volumes();
        }

        /// <summary>
        /// TC-1.1 : Given first Feet 0 and second Feet 0 when checked should return Equal.
        /// </summary>
        [Test]
        public void Given0FeetAnd0Feet_WhenChecked_ShouldReturnEqual()
        {
            try
            {
                double feetOne = this.length.ConvertLength(Length.Unit.Feet, 0.0);
                double feetTwo = this.length.ConvertLength(Length.Unit.Feet, 0.0);
                Assert.AreEqual(feetOne, feetTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.2 : Given first Feet Value and second Feet Null when checked should return Not Equal.
        /// </summary>
        [Test]
        public void Given0FeetAndNull_WhenChecked_ShouldReturnNotEqual()
        {
            try
            {
                double feetOne = this.length.ConvertLength(Length.Unit.Feet, 0.0);
                Length feetTwo = null;
                Assert.AreNotEqual(feetOne, feetTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.3 : Given first Feet 0 and second Feet 2 when checked should return Not Equal.
        /// </summary>
        [Test]
        public void Given0FeetAnd2Feet_WhenChecked_ShouldReturnNotEqual()
        {
            try
            {
                double feetOne = this.length.ConvertLength(Length.Unit.Feet, 0.0);
                double feetTwo = this.length.ConvertLength(Length.Unit.Feet, 2.0);
                Assert.AreNotEqual(feetOne, feetTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.4 : Given first Feet Object type and second Feet Object type when checked should return Equal.
        /// </summary>
        [Test]
        public void GivenFeetObjectAndFeetObject_WhenChecked_ShouldReturnEqual()
        {
            try
            {
                double feetOne = this.length.ConvertLength(Length.Unit.Feet, 0.0);
                double feetTwo = this.length.ConvertLength(Length.Unit.Feet, 2.0);
                Assert.AreEqual(feetOne.GetType(), feetTwo.GetType());
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.5 : Given first Feet Object and second Feet Object when checked should return True.
        /// </summary>
        [Test]
        public void GivenTwoObjectHaveSameReference_WhenCheckedReference_ShouldReturnTrue()
        {
            try
            {
                Length feetOne = new Length();
                Length feetTwo = new Length();
                feetOne = feetTwo;
                bool check = object.ReferenceEquals(feetOne, feetTwo);
                Assert.True(check);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.6 : Given first Feet and second Feet same value when checked should return Equal.
        /// </summary>
        [Test]
        public void Given1stAnd2ndSameValue_WhenChecked_ShouldReturnEqual()
        {
            try
            {
                double feetOne = this.length.ConvertLength(Length.Unit.Feet, 2.0);
                double feetTwo = this.length.ConvertLength(Length.Unit.Feet, 2.0);
                Assert.AreEqual(feetOne, feetTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.7 : Given first Inch 0 and second Inch 0 when checked should return Equal.
        /// </summary>
        [Test]
        public void Given0InchAnd0Inch_WhenChecked_ShouldReturnEqual()
        {
            try
            {
                double inchOne = this.length.ConvertLength(Length.Unit.Inch, 0.0);
                double inchTwo = this.length.ConvertLength(Length.Unit.Inch, 0.0);
                Assert.AreEqual(inchOne, inchTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.8 : Given first Inch Value and second Inch Null when checked should return Not Equal.
        /// </summary>
        [Test]
        public void Given0InchAndSecondNull_WhenChecked_ShouldReturnNotEqual()
        {
            try
            {
                double inchOne = this.length.ConvertLength(Length.Unit.Inch, 0.0);
                Length inchTwo = null;
                Assert.AreNotEqual(inchOne, inchTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.9 : Given first Inch 0 and second Inch 2 when checked should return Not Equal.
        /// </summary>
        [Test]
        public void Given0InchAnd2Inch_WhenChecked_ShouldReturnNotEqual()
        {
            try
            {
                double inchOne = this.length.ConvertLength(Length.Unit.Inch, 0.0);
                double inchTwo = this.length.ConvertLength(Length.Unit.Inch, 2.0);
                Assert.AreNotEqual(inchOne, inchTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.10 : Given first Inch Type of Object and second Inch Type of Object when checked should return Equal.
        /// </summary>
        [Test]
        public void Given1stInchObjectAnd2ndInchObjectOfType_WhenChecked_ShouldReturnEqual()
        {
            try
            {
                double inchOne = this.length.ConvertLength(Length.Unit.Inch, 0.0);
                double inchTwo = this.length.ConvertLength(Length.Unit.Inch, 0.0);
                Assert.AreEqual(inchOne.GetType(), inchTwo.GetType());
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.11 : Given first Inch Object reference to second Inch Object when checked should return Equal.
        /// </summary>
        [Test]
        public void GivenInchTwoObjectHaveSameReference_WhenCheckedReference_ShouldReturnReturnEqual()
        {
            try
            {
                double inchOne = this.length.ConvertLength(Length.Unit.Inch, 0.0);
                double inchTwo = inchOne;
                Assert.AreEqual(inchOne, inchTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.12 : Given first Inch and second Inch same value when checked should return Equal.
        /// </summary>
        [Test]
        public void Given1stAnd2ndInchSameValue_WhenChecked_ShouldReturnEqual()
        {
            try
            {
                double inchOne = this.length.ConvertLength(Length.Unit.Inch, 2.0);
                double inchTwo = this.length.ConvertLength(Length.Unit.Inch, 2.0);
                Assert.AreEqual(inchOne, inchTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.13 : Given 1 Feet and 1 Inch when checked should return Not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1Inch_WhenChecked_ShouldReturnNotEqual()
        {
            try
            {
                double feet = this.length.ConvertLength(Length.Unit.FeetToInch, 1.0);
                double inch = this.length.ConvertLength(Length.Unit.Inch, 1.0);
                Assert.AreNotEqual(feet, inch);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.14 : Given 0 Feet and 0 Inch when checked should return Equal.
        /// </summary>
        [Test]
        public void Given0FeetAnd0Inch_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double feet = this.length.ConvertLength(Length.Unit.Feet, 0.0);
                double inch = this.length.ConvertLength(Length.Unit.Inch, 0.0);
                Assert.AreEqual(feet, inch);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.15 : Given 0 Feet and 1 Inch when checked should return Not Equal.
        /// </summary>
        [Test]
        public void Given0FeetAnd1Inch_WhenCompared_ShouldReturnNotEqual()
        {
            try
            {
                double feet = this.length.ConvertLength(Length.Unit.Feet, 0.0);
                double inch = this.length.ConvertLength(Length.Unit.Inch, 1.0);
                Assert.AreNotEqual(feet, inch);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.16 : Given 1 Feet and 12 Inch when checked should return Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd12Inch_WhenComapared_ShouldReturnEqual()
        {
            try
            {
                double feet = this.length.ConvertLength(Length.Unit.FeetToInch, 1.0);
                double inch = this.length.ConvertLength(Length.Unit.Inch, 12.0);
                Assert.AreEqual(feet, inch);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.17 : Given 1 Feet and 1 Feet when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenComapared_ShouldReturnEqual()
        {
            try
            {
                double feetOne = this.length.ConvertLength(Length.Unit.Feet, 1.0);
                double feetTwo = this.length.ConvertLength(Length.Unit.Feet, 1.0);
                Assert.AreEqual(feetOne, feetTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.18 : Given 12 Inch and 1 Feet when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given12InchAnd1Feet_WhenComapared_ShouldReturnEqual()
        {
            try
            {
                double inch = this.length.ConvertLength(Length.Unit.Inch, 12.0);
                double feet = this.length.ConvertLength(Length.Unit.FeetToInch, 1.0);
                Assert.AreEqual(inch, feet);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-1.19 : Given first Feet Object and second Feet Object when checked should return Exception.
        /// </summary>
        [Test]
        public void GivenTwoObjectHaveSameReference_WhenCheckedReference_ShouldReturnException()
        {
            try
            {
                Length length = new Length();
                Weights weight = new Weights();
                bool check = object.ReferenceEquals(length, weight);
                Assert.False(check);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-2.1 : Given 1 Yard and 1 Yard when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1YardAnd1Yard_WhenComparingLength_ShouldReturnEqual()
        {
            try
            {
                double yardOne = this.length.ConvertLength(Length.Unit.Yard, 1.0);
                double yardTwo = this.length.ConvertLength(Length.Unit.Yard, 1.0);
                Assert.AreEqual(yardOne, yardTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-2.2 : Given 3 Feet and 1 Yard when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given3FeetAnd1Yard_WhenComparingLength_ShouldReturnEqual()
        {
            try
            {
                double feet = this.length.ConvertLength(Length.Unit.FeetToInch, 3.0);
                double yard = this.length.ConvertLength(Length.Unit.YardToInch, 1.0);
                Assert.AreEqual(feet, yard);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-2.3 : Given 1 Feet and 1 Yard when Compared should return Not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1Yard_WhenComparingLength_ShouldReturnNotEqual()
        {
            try
            {
                double feet = this.length.ConvertLength(Length.Unit.FeetToInch, 1.0);
                double yard = this.length.ConvertLength(Length.Unit.YardToInch, 1.0);
                Assert.AreNotEqual(feet, yard);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-2.4 : Given 1 Yard and 36 Inch when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1InchAnd1Yard_WhenComparingLength_ShouldReturnEqual()
        {
            try
            {
                double yard = this.length.ConvertLength(Length.Unit.YardToInch, 1.0);
                double inch = this.length.ConvertLength(Length.Unit.Inch, 36.0);
                Assert.AreEqual(yard, inch);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-2.5 : Given 1 Yard and 3 Feet when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1YardAnd3Feet_WhenComparingLength_ShouldReturnEqual()
        {
            try
            {
                double yard = this.length.ConvertLength(Length.Unit.YardToInch, 1.0);
                double feet = this.length.ConvertLength(Length.Unit.FeetToInch, 3.0);
                Assert.AreEqual(yard, feet);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-2.6 : Given 36 Inch and 1 Yard when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given36InchAnd1Inch_WhenComparingLength_ShouldReturnEqual()
        {
            try
            {
                double inch = this.length.ConvertLength(Length.Unit.Inch, 36.0);
                double yard = this.length.ConvertLength(Length.Unit.YardToInch, 1.0);
                Assert.AreEqual(inch, yard);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-2.7 : Given 1 Feet and 1 Yard when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1YArd_WhenComparingLength_ShouldReturnEqual()
        {
            try
            {
                double feet = this.length.ConvertLength(Length.Unit.FeetToInch, 1.0);
                double yard = this.length.ConvertLength(Length.Unit.YardToInch, 1.0);
                Assert.AreNotEqual(feet, yard);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-2.8 : Given null and 1 Yard when Compared should return Not Equal.
        /// </summary>
        [Test]
        public void GivenNullAnd1Yard_WhenComparingLength_ShouldReturnNotEqual()
        {
            try
            {
                Length inch = null;
                double yard = this.length.ConvertLength(Length.Unit.Yard, 1.0);
                Assert.AreNotEqual(inch, yard);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-2.9 : Given 1 Feet and 1 Yard To Inch when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1YardToInch_WhenComparingLength_ShouldReturnEqual()
        {
            try
            {
                double feet = this.length.ConvertLength(Length.Unit.Feet, 1.0);
                double yard = this.length.ConvertLength(Length.Unit.YardToInch, 1.0);
                Assert.AreNotEqual(feet, yard);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-2.10 : Given 1 Feet and 1 Feet To Inch when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_ComparingLength_ShouldReturnEqual()
        {
            try
            {
                double feet = this.length.ConvertLength(Length.Unit.Feet, 1.0);
                double yard = this.length.ConvertLength(Length.Unit.Feet, 1.0);
                Assert.AreEqual(feet, yard);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-2.11 : Given 1 Feet and 1 YardToInch To Inch when Compared should return Not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1YardToInch_ComparingLength_ShouldReturnEqual()
        {
            try
            {
                double feet = this.length.ConvertLength(Length.Unit.Feet, 1.0);
                double yard = this.length.ConvertLength(Length.Unit.YardToInch, 1.0);
                Assert.AreNotEqual(feet, yard);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-3.1 : Given 0 Centimeter and 0 Centimeter when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given0CentiMeterAnd0CentiMeter_WhenComparingLength_ShouldReturnEqual()
        {
            try
            {
                double centimeterOne = this.length.ConvertLength(Length.Unit.Centimeter, 0.0);
                double centimeterTwo = this.length.ConvertLength(Length.Unit.Centimeter, 0.0);
                Assert.AreEqual(centimeterOne, centimeterTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-3.2 : Given 0 Centimeter and 1 Centimeter when Compared should return Not Equal.
        /// </summary>
        [Test]
        public void Given0CentiMeterAnd1CentiMeter_WhenCompared_ShouldReturnNotEqual()
        {
            try
            {
                double centimeterOne = this.length.ConvertLength(Length.Unit.Centimeter, 0.0);
                double centimeterTwo = this.length.ConvertLength(Length.Unit.Centimeter, 1.0);
                Assert.AreNotEqual(centimeterOne, centimeterTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-3.3 : Given first 0 Centimeter and second Centimeter Null when Compared should return Not Equal.
        /// </summary>
        [Test]
        public void Given0CentiMeterAndSecondNull_WhenCompared_ShouldReturnNotEqual()
        {
            try
            {
                double centimeterOne = this.length.ConvertLength(Length.Unit.Centimeter, 0.0);
                Length centimeterTwo = null;
                Assert.AreNotEqual(centimeterOne, centimeterTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-3.4 : Given first 0 Centimeter Object type and second 2 Centimeter Object type when checked should return Equal.
        /// </summary>
        [Test]
        public void Given0CentiMeterObjectAnd2centiMeterObject_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double centimeterOne = this.length.ConvertLength(Length.Unit.Centimeter, 0.0);
                double centimeterTwo = this.length.ConvertLength(Length.Unit.Centimeter, 2.0);
                Assert.AreEqual(centimeterOne.GetType(), centimeterTwo.GetType());
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-3.5 : Given first Feet Object and second Feet Object when checked should return True.
        /// </summary>
        [Test]
        public void GivenTwoObjectHaveSameReference_WhenComparedReference_ShouldReturnTrue()
        {
            try
            {
                Length centimeterOne = new Length();
                Length centimeterTwo = new Length();
                centimeterOne = centimeterTwo;
                bool check = object.ReferenceEquals(centimeterOne, centimeterTwo);
                Assert.True(check);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-3.6 : Given 2 Centimeter and 2 Centimeter when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given2CentiMeterAnd2CentiMeter_WhenCompared_ShouldReturnNotEqual()
        {
            try
            {
                double centimeterOne = this.length.ConvertLength(Length.Unit.Centimeter, 2.0);
                double centimeterTwo = this.length.ConvertLength(Length.Unit.Centimeter, 2.0);
                Assert.AreEqual(centimeterOne, centimeterTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-3.7 : Given 2 Inch and 5 Centimeter when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given2InchAnd5CentiMeter_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double inch = this.length.ConvertLength(Length.Unit.Inch, 2.0);
                double centimeter = this.length.ConvertLength(Length.Unit.CentimeterToInch, 5.0);
                Assert.AreEqual(inch, centimeter);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-3.8 : Given 1 Inch and 1 Centimeter when Compared should return Not Equal.
        /// </summary>
        [Test]
        public void Given1InchAnd1CentiMeter_WhenCompared_ShouldReturnNotEqual()
        {
            try
            {
                double inch = this.length.ConvertLength(Length.Unit.Inch, 1.0);
                double centimeter = this.length.ConvertLength(Length.Unit.CentimeterToInch, 1.0);
                Assert.AreNotEqual(inch, centimeter);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-3.9 : Given 1 Feet and 1 Centimeter when Compared should return Not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1CentiMeter_WhenCompared_ShouldReturnNotEqual()
        {
            try
            {
                double feet = this.length.ConvertLength(Length.Unit.Feet, 1.0);
                double centimeter = this.length.ConvertLength(Length.Unit.CentimeterToInch, 1.0);
                Assert.AreNotEqual(feet, centimeter);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-3.10 : Given 1 Yard and 1 Inch when Compared should return Not Equal.
        /// </summary>
        [Test]
        public void Given1YardAnd1Inch_WhenCompared_ShouldReturnNotEqual()
        {
            try
            {
                double yard = this.length.ConvertLength(Length.Unit.YardToInch, 1.0);
                double inch = this.length.ConvertLength(Length.Unit.Inch, 1.0);
                Assert.AreNotEqual(yard, inch);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-3.11 : Given 1 Centimeter and 1 Centimeter To Inch when Compared should return Not Equal.
        /// </summary>
        [Test]
        public void Given1CentimeterAnd1CentinmeterToInch_WhenCompared_ShouldReturnNotEqual()
        {
            try
            {
                double yard = this.length.ConvertLength(Length.Unit.CentimeterToInch, 1.0);
                double inch = this.length.ConvertLength(Length.Unit.Centimeter, 1.0);
                Assert.AreNotEqual(yard, inch);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-4.1 : Given 2 inch and 2 inch when Performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given2InchAnd2Inch_WhenCalculated_ShouldReturnResult()
        {
            try
            {
                double firstValue = this.length.ConvertLength(Length.Unit.Inch, 2.0);
                double secondValue = this.length.ConvertLength(Length.Unit.Inch, 2.0);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreEqual(4.0, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-4.2 : Given 1 feet and 2 inch when Performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given1FeetAnd2Inch_WhenCalculated_ShouldReturnResult()
        {
            try
            {
                double firstValue = this.length.ConvertLength(Length.Unit.FeetToInch, 1.0);
                double secondValue = this.length.ConvertLength(Length.Unit.Inch, 2.0);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreEqual(14.0, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-4.3 : Given 1 feet and 1 Feet when Performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenCalculated_ShouldReturnResult()
        {
            try
            {
                double firstValue = this.length.ConvertLength(Length.Unit.FeetToInch, 1.0);
                double secondValue = this.length.ConvertLength(Length.Unit.FeetToInch, 1.0);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreEqual(24.0, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-4.4 : Given 2 inch and 2.5 centimeter when Performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given2InchAnd2AndHalfCentimeter_WhenCalculated_ShouldReturnResult()
        {
            try
            {
                double firstValue = this.length.ConvertLength(Length.Unit.Inch, 2.0);
                double secondValue = this.length.ConvertLength(Length.Unit.CentimeterToInch, 2.5);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreEqual(3.0, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-4.5 : Given 1 yard and 1 yard when Performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given1yardAnd1Yard_WhenCalculated_ShouldReturnResult()
        {
            try
            {
                double firstValue = this.length.ConvertLength(Length.Unit.YardToInch, 1.0);
                double secondValue = this.length.ConvertLength(Length.Unit.YardToInch, 1.0);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreEqual(72.0, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-4.6 : Given 1 yard and 1 yard when Performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given1yardAnd1Inch_WhenCalculated_ShouldReturnResult()
        {
            try
            {
                double firstValue = this.length.ConvertLength(Length.Unit.YardToInch, 1.0);
                double secondValue = this.length.ConvertLength(Length.Unit.Inch, 1.0);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreNotEqual(72.0, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-5.1 : Given 1 gallon and 3.78 liter when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1GallonAnd3Point78Liter_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double gallon = this.volumes.ConvertVolumes(Volumes.Unit.GallonToLiter, 1.0);
                double liter = this.volumes.ConvertVolumes(Volumes.Unit.Liter, 3.78);
                Assert.AreEqual(gallon, liter);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-5.2 : Given 1 liter and 1000 milliliter when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1LiterAnd1000Mililiter_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double liter = this.volumes.ConvertVolumes(Volumes.Unit.LiterToMilliliter, 1.0);
                double mililiter = this.volumes.ConvertVolumes(Volumes.Unit.Milliliter, 1000);
                Assert.AreEqual(liter, mililiter);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-5.3 : Given 1 gallon and 2.78 liter when Compared should return Not Equal.
        /// </summary>
        [Test]
        public void Given1GallonAnd2Point78Liter_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double gallon = this.volumes.ConvertVolumes(Volumes.Unit.GallonToLiter, 1.0);
                double liter = this.volumes.ConvertVolumes(Volumes.Unit.Liter, 2.78);
                Assert.AreNotEqual(gallon, liter);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-5.4 : Given 1 liter and 1 liter when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1LiterAnd1Liter_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double literOne = this.volumes.ConvertVolumes(Volumes.Unit.Liter, 1.0);
                double literTwo = this.volumes.ConvertVolumes(Volumes.Unit.Liter, 1.0);
                Assert.AreEqual(literOne, literTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-5.5 : Given 1 gallon and 1 liter when Compared should return Not Equal.
        /// </summary>
        [Test]
        public void Given1GallonAnd1Liter_WhenCompared_ShouldReturnNotEqual()
        {
            try
            {
                double gallon = this.volumes.ConvertVolumes(Volumes.Unit.GallonToLiter, 1.0);
                double liter = this.volumes.ConvertVolumes(Volumes.Unit.Liter, 1.0);
                Assert.AreNotEqual(gallon, liter);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-5.6 : Given 1 gallon and 1 gallon when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1GallonAnd1Gallon_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double gallonOne = this.volumes.ConvertVolumes(Volumes.Unit.Gallon, 1.0);
                double gallonTwo = this.volumes.ConvertVolumes(Volumes.Unit.Gallon, 1.0);
                Assert.AreEqual(gallonOne, gallonTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-5.7 : Given 0 gallon and 0 Liter when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given0GallonAnd0Liter_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double gallon = this.volumes.ConvertVolumes(Volumes.Unit.Gallon, 0.0);
                double liter = this.volumes.ConvertVolumes(Volumes.Unit.Liter, 0.0);
                Assert.AreEqual(gallon, liter);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-5.8 : Given 1 gallon and 1 Liter when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1GallonAnd1Liter_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double gallonOne = this.volumes.ConvertVolumes(Volumes.Unit.GallonToLiter, 1.0);
                double liter = this.volumes.ConvertVolumes(Volumes.Unit.Liter, 1.0);
                Assert.AreNotEqual(gallonOne, liter);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-5.9 : Given 1 Gallon To Liter and 1 Gallon To Liter when Compared should return Equal.
        /// </summary>
        [Test]
        public void Given1GallonToLiterAnd1GallonToLiter_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double gallonToLiterOne = this.volumes.ConvertVolumes(Volumes.Unit.GallonToLiter, 1.0);
                double gallonToLiterTwo = this.volumes.ConvertVolumes(Volumes.Unit.GallonToLiter, 1.0);
                Assert.AreEqual(gallonToLiterOne, gallonToLiterTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-6.1 : Given 1 gallon and 3.78 liter when Performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given1GallonAnd3Point78Liter_WhenCalculated_ShouldReturnResult()
        {
            try
            {
                double firstValue = this.volumes.ConvertVolumes(Volumes.Unit.GallonToLiter, 1.0);
                double secondValue = this.volumes.ConvertVolumes(Volumes.Unit.Liter, 3.78);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreEqual(7.56, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-6.2 : Given 1 liter and 1000 milliliter when Performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given1LiterAnd1000Milliliter_WhenCalculated_ShouldReturnResult()
        {
            try
            {
                double firstValue = this.volumes.ConvertVolumes(Volumes.Unit.Liter, 1.0);
                double secondValue = this.volumes.ConvertVolumes(Volumes.Unit.MilliliterToLiter, 1000.0);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreEqual(2.0, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-6.3 : Given 1000 milliliter and 1000 milliliter when Performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given1000MilliliterAnd1000Milliliter_WhenCalculated_ShouldReturnResult()
        {
            try
            {
                double firstValue = this.volumes.ConvertVolumes(Volumes.Unit.MilliliterToLiter, 1000.0);
                double secondValue = this.volumes.ConvertVolumes(Volumes.Unit.MilliliterToLiter, 1000.0);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreEqual(2.0, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-6.4 : Given 1 gallon and 1 gallon when Performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given1GallonAnd1Gallon_WhenCalculated_ShouldReturnResult()
        {
            try
            {
                double firstValue = this.volumes.ConvertVolumes(Volumes.Unit.GallonToLiter, 1.0);
                double secondValue = this.volumes.ConvertVolumes(Volumes.Unit.GallonToLiter, 1.0);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreEqual(7.56, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-6.5 : Given 1 gallon and 1 Gallon when converted should return Result.
        /// </summary>
        [Test]
        public void Given1GallonAnd1Gallon_WhenConverted_ShouldReturnResult()
        {
            try
            {
                double firstValue = this.volumes.ConvertVolumes(Volumes.Unit.GallonToLiter, 1.0);
                double secondValue = this.volumes.ConvertVolumes(Volumes.Unit.GallonToLiter, 1.0);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreEqual(7.56, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }
        
        /// <summary>
        /// TC-7.1 : Given 1 kilogram and 1000 grams when compared should return Equal.
        /// </summary>
        [Test]
        public void Given1KilogramAnd1000Grams_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double kilogram = this.weights.ConvertWeigths(Weights.Unit.KilogramToGrams, 1.0);
                double grams = this.weights.ConvertWeigths(Weights.Unit.Grams, 1000.0);
                Assert.AreEqual(kilogram, grams);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-7.2 : Given 1 tone and 1000 kilograms when compared should return Equal.
        /// </summary>
        [Test]
        public void Given1TonneAnd1000Kilograms_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double kilogram = this.weights.ConvertWeigths(Weights.Unit.TonneToKilograms, 1.0);
                double grams = this.weights.ConvertWeigths(Weights.Unit.kilogram, 1000.0);
                Assert.AreEqual(kilogram, grams);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-7.3 : Given 1 tone and 1000 milligrams when performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given1TonneAnd1000mg_WhenCalculated_ShouldReturnEqual()
        {
            try
            {
                double firstValue = this.weights.ConvertWeigths(Weights.Unit.Tonne, 1.0);
                double secondValue = this.weights.ConvertWeigths(Weights.Unit.Grams, 1000.0);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreEqual(1001.0, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-7.4 : Given 1 tone and 1 tone when converted and performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given1TonneAnd1Tonne_WhenConvertedAndCalculated_ShouldReturnEqual()
        {
            try
            {
                double firstValue = this.weights.ConvertWeigths(Weights.Unit.TonneToKilograms, 1.0);
                double secondValue = this.weights.ConvertWeigths(Weights.Unit.TonneToKilograms, 1.0);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreEqual(2000.0, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-7.5 : Given 0 tone and 0 kilogram when converted and performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given0TonneAnd0Kilogram_WhenConvertedAndCalculated_ShouldReturnEqual()
        {
            try
            {
                double firstValue = this.weights.ConvertWeigths(Weights.Unit.Tonne, 0.0);
                double secondValue = this.weights.ConvertWeigths(Weights.Unit.kilogram, 0.0);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreEqual(0.0, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-7.6 : Given 1 tone and 1 tone when converted and performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given1KilogramAnd1Kilogram_WhenConvertedAndCalculated_ShouldReturnEqual()
        {
            try
            {
                double firstValue = this.weights.ConvertWeigths(Weights.Unit.kilogram, 1.0);
                double secondValue = this.weights.ConvertWeigths(Weights.Unit.kilogram, 1.0);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreEqual(2.0, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-7.7 : Given 1 tone and 1 kilogram when converted and performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given1TonneAnd1Kilogram_WhenConvertedAndCalculated_ShouldReturnEqual()
        {
            try
            {
                double firstValue = this.weights.ConvertWeigths(Weights.Unit.TonneToKilograms, 1.0);
                double secondValue = this.weights.ConvertWeigths(Weights.Unit.kilogram, 1.0);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreNotEqual(2.0, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-7.8 : Given 1 grams and 1 kilogram to grams when converted and performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given1GramsAnd1Kilogram_WhenConvertedAndCalculated_ShouldReturnEqual()
        {
            try
            {
                double firstValue = this.weights.ConvertWeigths(Weights.Unit.Grams, 1.0);
                double secondValue = this.weights.ConvertWeigths(Weights.Unit.KilogramToGrams, 1.0);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreNotEqual(2.0, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-7.8 : Given 1 ToneToKilogram and 1 KilogramToTone to grams when converted and performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given1ToneToKilogramAnd1KilogramToTone_WhenConvertedAndCalculated_ShouldReturnEqual()
        {
            try
            {
                double firstValue = this.weights.ConvertWeigths(Weights.Unit.TonneToKilograms, 1.0);
                double secondValue = this.weights.ConvertWeigths(Weights.Unit.KilogramToGrams, 1.0);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreNotEqual(2.0, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-8.1 : Given 1 Celsius and 33.8 Fahrenheit when compared should return Equal.
        /// </summary>
        [Test]
        public void Given1CelsiusAnd33Point8Fahrenheit_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double celsius = this.temperature.ConvertTemperature(Temperature.Unit.CelsiusToFahrenheit, 1.0);
                double fahrenheit = this.temperature.ConvertTemperature(Temperature.Unit.Fahrenheit, 33.8);
                Assert.AreEqual(celsius, fahrenheit);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-8.2 : Given 100 Celsius and 212 Fahrenheit when compared should return Equal.
        /// </summary>
        [Test]
        public void Given100CelsiusAnd212Fahrenheit_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double celsius = this.temperature.ConvertTemperature(Temperature.Unit.CelsiusToFahrenheit, 100.0);
                double fahrenheit = this.temperature.ConvertTemperature(Temperature.Unit.Fahrenheit, 212);
                Assert.AreEqual(celsius, fahrenheit);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-8.3 : Given 2 Celsius and 33.8 Fahrenheit when compared should return Not Equal.
        /// </summary>
        [Test]
        public void Given2CelsiusAnd33Point8Fahrenheit_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double celsius = this.temperature.ConvertTemperature(Temperature.Unit.CelsiusToFahrenheit, 2.0);
                double fahrenheit = this.temperature.ConvertTemperature(Temperature.Unit.Fahrenheit, 33.8);
                Assert.AreNotEqual(celsius, fahrenheit);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-8.4 : Given 0 Celsius and 0 Fahrenheit when compared should return Equal.
        /// </summary>
        [Test]
        public void Given0CelsiusAnd0Fahrenheit_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double celsius = this.temperature.ConvertTemperature(Temperature.Unit.Celsius, 0.0);
                double fahrenheit = this.temperature.ConvertTemperature(Temperature.Unit.Fahrenheit, 0.0);
                Assert.AreEqual(celsius, fahrenheit);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-8.5 : Given 4 Celsius and 39.4 fahrenheit when converted and performed Addition should return Result.
        /// </summary>
        [Test]
        public void Given4CelsiusAnd39Point4_WhenConvertedAndCalculated_ShouldReturnEqual()
        {
            try
            {
                double firstValue = this.temperature.ConvertTemperature(Temperature.Unit.CelsiusToFahrenheit, 4.0);
                double secondValue = this.temperature.ConvertTemperature(Temperature.Unit.Fahrenheit, 39.2);
                double result = this.length.CalculateLength(firstValue, secondValue);
                Assert.AreEqual(78.4, result);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-8.6 : Given 0 CelsiusToFahrenheit and 0 CelsiusToFahrenheit when Converted and compared should return Equal.
        /// </summary>
        [Test]
        public void Given1CelsiusToFerenheitsAnd1CelsiusToFerenheit_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double celsius = this.temperature.ConvertTemperature(Temperature.Unit.CelsiusToFahrenheit, 1.0);
                double fahrenheit = this.temperature.ConvertTemperature(Temperature.Unit.CelsiusToFahrenheit, 1.0);
                Assert.AreEqual(celsius, fahrenheit);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-8.7 : Given 0 CelsiusToFahrenheit and 2 CelsiusToFahrenheit when Converted and compared should return Not Equal.
        /// </summary>
        [Test]
        public void Given1CelsiusToFerenheitsAnd2CelsiusToFerenheit_WhenCompared_ShouldReturnNotEqual()
        {
            try
            {
                double celsius = this.temperature.ConvertTemperature(Temperature.Unit.CelsiusToFahrenheit, 1.0);
                double fahrenheit = this.temperature.ConvertTemperature(Temperature.Unit.CelsiusToFahrenheit, 2.0);
                Assert.AreNotEqual(celsius, fahrenheit);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-8.8 : Given 0 Celsius and 0 Fahrenheit when Converted and compared should return Equal.
        /// </summary>
        [Test]
        public void Given0CelsiusAnd0Ferenheit_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double celsius = this.temperature.ConvertTemperature(Temperature.Unit.Celsius, 0.0);
                double fahrenheit = this.temperature.ConvertTemperature(Temperature.Unit.Fahrenheit, 0.0);
                Assert.AreEqual(celsius, fahrenheit);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-8.9 : Given 0 Celsius and 0 Celsius when Converted and compared should return Equal.
        /// </summary>
        [Test]
        public void Given0CelsiusAnd0Celsius_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double celsiusOne = this.temperature.ConvertTemperature(Temperature.Unit.Celsius, 0.0);
                double celsiusTwo = this.temperature.ConvertTemperature(Temperature.Unit.Celsius, 0.0);
                Assert.AreEqual(celsiusOne, celsiusTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }

        /// <summary>
        /// TC-8.10 : Given 0 Fahrenheit and 0 Fahrenheit when Converted and compared should return Equal.
        /// </summary>
        [Test]
        public void Given0FahrenheitAnd0Fahrenheit_WhenCompared_ShouldReturnEqual()
        {
            try
            {
                double fahrenheitOne = this.temperature.ConvertTemperature(Temperature.Unit.Fahrenheit, 0.0);
                double fahrenheitTwo = this.temperature.ConvertTemperature(Temperature.Unit.Fahrenheit, 0.0);
                Assert.AreEqual(fahrenheitOne, fahrenheitTwo);
            }
            catch (QuantityException e)
            {
                Assert.AreEqual(QuantityException.ExceptionType.InvalidData, e.Message);
            }
        }
    }
}