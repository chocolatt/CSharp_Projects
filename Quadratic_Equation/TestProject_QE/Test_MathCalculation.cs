using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Quadratic_Equation;

namespace Quadratic_Equation
{
    [TestClass]
    internal class MathCalculation_Tests
    {
        [TestMethod] 
        public void PositiveTestOfQuadraticEquation()
        {
            var expectedResult = MathCalculation.QuadraticEquation(2, 3, 1);
            double[] actualResult = { -0, 5, 1 };
            NUnit.Framework.Assert.AreEqual(expectedResult, actualResult, "Equition is computed correctly");
        }

    }
}
