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
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculator
{
    /// <summary>
    /// HintTextBox Class - to create a textbox control with a "hint" property.
    /// Uses InteropServices and PInvoke.
    /// </summary>
    class HintTextBox : TextBox
    {
        //Configure dll
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr windowHandle, int message, IntPtr windowPtr, string label);

        //Data Members:
        private string hint;

        //Class Properties:
        [Localizable(true)]
        public string Hint
        {
            get
            {
                return hint;
            }
            set
            {
                hint = value;
                UpdateHint();
            }
        } // end method 

        private void UpdateHint()
        {
            if (IsHandleCreated && hint != null)
            {
                SendMessage(Handle, 0x1501, (IntPtr)1, hint);
            }
        } // end method UpdateHint()

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UpdateHint();
        } // end method OnHandleCreated()
    } // end class HintTextBox
} // end namespace Calculator
