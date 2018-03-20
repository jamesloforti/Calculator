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
using System;

namespace Calculator.Concrete_Shape_Constraints
{
    enum TriangleType
    {
        EQUILATERAL = 0,
        ISOSCELES = 1,
        SCALENE = 2,
        ACUTE = 3,
        OBTUSE = 4,
        RIGHT = 5,
        INVALID = 6
    };

    /// <summary>
    /// TriangleConstraint Class - a concrete constraint that represents the constraints for a triangle object.
    /// </summary>
    public class TriangleConstraint : IConstraints
    {
        //Data Members:
        private string[] typeStr = { "Equilateral", "Isosceles", "Scalene", "Acute", "Obtuse", "Right", "Invalid" };
        private string[] userData = new string[3];
        private string result = string.Empty;

        //Constants:
        private int NINETY = 90;

        /// <summary>
        /// Evaluate method - to call the necessary methods to calculate the triangle using the current constraints.
        /// </summary>
        public void Evaluate()
        {
            //Prepare data members necessary for calculation process
            InitCalc();

            //Calculate triangle type
            CalcTriangle(double.Parse(userData[0]), double.Parse(userData[1]), double.Parse(userData[2]));

            //Get reference to main form
            FrmMain mainForm = System.Windows.Forms.Application.OpenForms["FrmMain"] as FrmMain;

            //Set triangle evaluation result
            mainForm.SetResult(result);
        } // end method Evaluate()

        /// <summary>
        /// InitCalc method - to prepare the calculation process.
        /// </summary>
        private void InitCalc()
        {
            //Get reference to main form
            FrmMain mainForm = System.Windows.Forms.Application.OpenForms["FrmMain"] as FrmMain;

            //Get the user data from the main form
            userData = mainForm.GetUserData();
        } // end method InitCalc()

        /// <summary>
        /// CalcTriangle method - to call the necessary methods to validate and calculate the type of triangle.
        /// </summary>
        private void CalcTriangle(double a, double b, double c)
        {
            //Test triangle validity
            if (IsValid(a, b, c))
            {
                //Equilateral
                if (IsEquilateral(a, b, c))
                {
                    result = typeStr[(int)TriangleType.EQUILATERAL];
                }
                //Isosceles
                else if (IsIsosceles(a, b, c))
                {
                    result = typeStr[(int)TriangleType.ISOSCELES];
                }
                //Scalene
                else
                {
                    //Sort the side values in ascending order
                    Array.Sort(userData);

                    //Calc Law of Cosine
                    double angle = LawOfCosine(double.Parse(userData[0]), double.Parse(userData[1]), double.Parse(userData[2]));

                    //Acute
                    if (angle < NINETY)
                    {
                        result = typeStr[(int)TriangleType.ACUTE];
                    }
                    //Right
                    else if (angle.Equals(NINETY))
                    {
                        result = typeStr[(int)TriangleType.RIGHT];
                    }
                    //Obtuse
                    else if (angle > NINETY)
                    {
                        result = typeStr[(int)TriangleType.OBTUSE];
                    }
                } // end else
            } // end if
            else
            {
                result = typeStr[(int)TriangleType.INVALID];
            }
        } // end method CalcTriangle()

        /// <summary>
        /// IsValid method - to validate that no two sides of the triangle are less than the other side.
        /// </summary>
        /// <returns>bool</returns>
        public bool IsValid(double a, double b, double c)
        {
            if ((a + b) > c && (b + c) > a && (a + c) > b)
                return true;

            return false;
        } // end method IsValid()

        /// <summary>
        /// IsEquilateral method - to check whether all sides of the triangle are equal.
        /// </summary>
        /// <returns>bool</returns>
        public bool IsEquilateral(double a, double b, double c)
        {
            if (a.Equals(b) && a.Equals(c) && b.Equals(c))
            {
                return true;
            }

            return false;
        } // end method IsEquilateral()

        /// <summary>
        /// IsIsosceles method - to check whether at least two sides of the triangle are equal.
        /// </summary>
        /// <returns>bool</returns>
        public bool IsIsosceles(double a, double b, double c)
        {
            if (a.Equals(b) || a.Equals(c) || b.Equals(c))
            {
                return true;
            }

            return false;
        } // end method IsIsosceles()

        public double LawOfCosine(double a, double b, double c)
        {
            double aSq = Math.Pow(Math.Abs(a), 2);
            double bSq = Math.Pow(Math.Abs(b), 2);
            double cSq = Math.Pow(Math.Abs(c), 2);

            //Calculate the cosine of angle C
            double cosC = ((aSq + bSq - cSq) / (2 * Math.Abs(a) * Math.Abs(b)));
            //Find its inverse
            double inverse = Math.Acos(cosC);
            //Convert to degrees
            double c1 = inverse * 180 / Math.PI;

            return c1;
        } // end method LawOfCosine()
    } // end class TriangleConstraint
} // end namespace Calculator.Concrete_Shapes
