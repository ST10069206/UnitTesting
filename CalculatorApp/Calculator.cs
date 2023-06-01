using System;
namespace CalculatorApp
{
	// public -> can be accesed in the entire application
	// internal -> can only be accessed within the same namespace

	public class Calculator
	{
		/*
		 * Create the following methods:
		 * 1. Method to return the sum of two numbers
		 * 2. A method to return the product of two numbers
		 * 3. A method to return the difference of two numbers. 
		 */

		public Calculator()
		{
		}

		public double SumOfNumbers(double a, double b)
		{
			return a + b; 
		}

        public double ProductOfNumbers(double x, double y)
        {
            return x * y;
        }

        public double DifferencefNumbers(double c, double d)
        {
            return c - d;
        }
    }
}

