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
using System.Text.RegularExpressions;

namespace Calculator
{
    /// <summary>
    /// Validate Class - a singleton class composed of user input validation methods.
    /// </summary>
    public class Validate
    {
        //Data Members:
        private static Validate instance = new Validate(); // ensures singleton is thread safe

        /// <summary>
        /// Default Constructor - to initialize the object using default values.
        /// </summary>
        private Validate() {}

        /// <summary>
        /// GetInstance Method - to return the single instance of the Validate object.
        /// </summary>
        /// <returns>object Validate</returns>
        public static Validate GetInstance()
        {
            return instance;
        } // end method GetInstance()

        /// <summary>
        /// Digits Method - to validate that the given input string is numbers only.
        /// </summary>
        /// <param name="input">string</param>
        /// <returns>bool: true if valid, false if invalid</returns>
        public bool Digits(string input)
        {
            Regex regex = new Regex(@"^[0-9]*(\.[0-9]*)?$");

            //If the input is valid
            if (regex.IsMatch(input))
                return true;

            return false;
        } // end method Digits()
    } // end class Validate
} // end namespace Calculate
