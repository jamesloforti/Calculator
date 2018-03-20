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
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLab
{
    /// <summary>
    /// ValidateTests Class - test cases for Validate class
    /// </summary>
    [TestClass]
    public class ValidateTests
    {
        [TestMethod]
        public void Digits()
        {
            Validate validate = Calculator.Validate.GetInstance();
            bool result = false;

            result = validate.Digits("165");
            Assert.IsTrue(result);

            result = validate.Digits("165.102");
            Assert.IsTrue(result);

            result = validate.Digits("16d85");
            Assert.IsFalse(result);

            result = validate.Digits("16d-@85");
            Assert.IsFalse(result);
        } // end method Digits()
    } // end class ValidateTests
} // end namespace TestLab
