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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Concrete_Shape_Constraints
{
    /// <summary>
    /// QuadrilateralConstraint Class - a concrete constraint that represents the constraints for a quadrilateral object.
    /// Note: the purpose of this class is to represent the extensibility of my design.
    /// The lack of implementation is intentional.
    /// </summary>
    public class QuadrilateralConstraint : IConstraints
    {
        /// <summary>
        /// Evaluate Method - to begin the evaluation process using the current constraints
        /// </summary>
        public void Evaluate()
        {

        } // end method Evaluate()
    } // end class QuadrilateralConstraint
} // end namespace Calculator.Concrete_Shapes
