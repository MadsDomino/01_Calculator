﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(0, Calculator.Add(0, 0));
            Assert.AreEqual(4, Calculator.Add(2, 2));
            Assert.AreEqual(8, Calculator.Add(2, 6));
        }
        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(6, Calculator.Subtract(10, 4));
        }
        [TestMethod]
        public void Sum()
        {
            //Arrange
            int[] numbers = new int[2];
            Assert.AreEqual(0, Calculator.Sum(numbers));

            numbers[0] = 7;
            Assert.AreEqual(7, Calculator.Sum(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            Assert.AreEqual(18, Calculator.Sum(numbers));

        }
         [TestMethod]
         public void Multiply()
         {
            //It multiplies two numbers
            //It multiplies several numbers
            int[] numbers = new int[2];
            numbers[0] = 3;
            numbers[1] = 5;
            Assert.AreEqual(15, Calculator.Multiply(numbers));
            int[] numbers1 = new int[3];
            numbers1[0] = 7;
            numbers1[1] = 5;
            numbers1[2] = 9;
            Assert.AreEqual(315, Calculator.Multiply(numbers1));
             //throw new NotImplementedException();
         }
         [TestMethod]
         public void Power()
         {
            //It raises one number to the power of another number
            Assert.AreEqual(49, Calculator.Power(7, 2));
            Assert.AreEqual(15625, Calculator.Power(5, 6));
            //throw new NotImplementedException();
        }
         [TestMethod]
         public void Factorial()
         {
            //# http://en.wikipedia.org/wiki/Factorial
            //  it "computes the factorial of 0"
            //  it "computes the factorial of 1"
            //  it "computes the factorial of 2"
            //  it "computes the factorial of 5"
            //  it "computes the factorial of 10"
            Assert.AreEqual(120, Calculator.Factorial(5));
             //throw new NotImplementedException();
         }
    }
}
