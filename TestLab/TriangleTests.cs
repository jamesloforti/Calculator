// ******************************************************************************************************************
//  Shape Calculator - to calculate attributes of a shape to determine its type
//  Copyright(C) 2018  James LoForti
//  Contact Info: jamesloforti@gmail.com
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.If not, see<https://www.gnu.org/licenses/>.
//									     ____.           .____             _____  _______   
//									    |    |           |    |    ____   /  |  | \   _  \  
//									    |    |   ______  |    |   /  _ \ /   |  |_/  /_\  \ 
//									/\__|    |  /_____/  |    |__(  <_> )    ^   /\  \_/   \
//									\________|           |_______ \____/\____   |  \_____  /
//									                             \/          |__|        \/ 
//
// ******************************************************************************************************************
//
using Calculator.Concrete_Shape_Constraints;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLab
{
    /// <summary>
    /// TriangleTests Class - test cases for TriangleConstraints class
    /// </summary>
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void IsValid()
        {
            TriangleConstraint tc = new TriangleConstraint();
            Assert.IsTrue(tc.IsValid(3, 4, 5));
            Assert.IsTrue(tc.IsValid(5, 2, 5));
            Assert.IsFalse(tc.IsValid(1, 1, 5));
        }

        [TestMethod]
        public void IsEquilateral()
        {
            TriangleConstraint tc = new TriangleConstraint();
            Assert.IsTrue(tc.IsEquilateral(3, 3, 3));
            Assert.IsFalse(tc.IsEquilateral(1, 1, 5));
        }

        [TestMethod]
        public void IsIsosceles()
        {
            TriangleConstraint tc = new TriangleConstraint();
            Assert.IsTrue(tc.IsIsosceles(5, 4, 5));
            Assert.IsTrue(tc.IsIsosceles(2, 2, 5));
            Assert.IsFalse(tc.IsIsosceles(1, 3, 5));
        }

        [TestMethod]
        public void LawOfCosine()
        {
            TriangleConstraint tc = new TriangleConstraint();
            Assert.AreEqual(tc.LawOfCosine(3, 4, 5), 90);
            Assert.IsTrue(tc.LawOfCosine(5, 5, 6) < 90);
            Assert.IsTrue(tc.LawOfCosine(6, 6, 10) > 90);
        }
    } // end class TriangleTests
} // end namespace TestLab
