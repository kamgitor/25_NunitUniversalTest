using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
// using UniversalTest;
using UniversalTestCpp;


namespace UnityLib
{

	[TestFixture]
	public class NunitTests
	{


		// Add
		[TestCase(1, 1, 2)]
		[TestCase(2, 2, 4)]
		[TestCase(5, 5, 10)]
		[TestCase(15, 15, 30)]
		[TestCase(12, 13, 25)]

		public void TestAddFunction(int val1, int val2, int result)
		{
			Assert.AreEqual(Program.add(val1, val2), result);
		}


		// Subtract
		[TestCase(3, 1, 2)]
		[TestCase(6, 2, 4)]
		[TestCase(15, 5, 10)]
		[TestCase(45, 15, 30)]
		[TestCase(38, 13, 25)]

		public void TestSubtractFunction(int val1, int val2, int result)
		{
			Assert.AreEqual(Program.subtract(val1, val2), result);
		}


		// Power
		[TestCase(3, 9)]
		[TestCase(2, 4)]
		[TestCase(5, 25)]
		[TestCase(6, 36)]

		public void TestPowerFunction(int val1, int result)
		{
			Assert.AreEqual(Program.pow(val1), result);
		}


	}
}
