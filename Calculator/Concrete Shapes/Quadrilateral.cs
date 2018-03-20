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

namespace Calculator.Concrete_Shapes
{
    /// <summary>
    /// Quadrilateral Class - a concrete shape class that represents a quadrilateral object.
    /// Note: the purpose of this class is to represent the extensibility of my design.
    /// The lack of implementation is intentional.
    /// </summary>
    public class Quadrilateral : Shape
    {
        /// <summary>
        /// Default Constructor - to initialize the object using default values.
        /// </summary>
        public Quadrilateral()
        {
            constraints = new QuadrilateralConstraint();
        } // end default constructor
    } // end class Quadrilateral
} // end namespace Calculator.Concrete_Shapes
