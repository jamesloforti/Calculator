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
using Calculator.Concrete_Shapes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// Main UI (Main Form) - logic for GUI.
    /// </summary>
    public partial class FrmMain : Form
    {
        //Class Variables:
        private Validate validate;
        private TextBox currTxtBox;
        private Shape triangle;
        //private List<string> userData;
        private string[] userData;
        private bool sideAIsValid;
        private bool sideBIsValid;
        private bool sideCIsValid;

        //String Constants
        private const string PROGRAM_ABOUT = "Author: James LoForti ";
        private const string ZERO = "0";
        private const string ONE = "1";
        private const string TWO = "2";
        private const string THREE = "3";
        private const string FOUR = "4";
        private const string FIVE = "5";
        private const string SIX = "6";
        private const string SEVEN = "7";
        private const string EIGHT = "8";
        private const string NINE = "9";
        private const string DECIMAL = ".";

        /// <summary>
        /// Default Constructor - to initialize the object using default values.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();

            //Set focus to TxtSideA textbox
            ActiveControl = TxtSideA;

            //Init class vars:
            validate = Calculator.Validate.GetInstance();
            currTxtBox = TxtSideA;
            triangle = new Triangle();
            //userData = new List<string>();
            userData = new string[3];
            sideAIsValid = false;
            sideBIsValid = false;
            sideCIsValid = false;

            //Create delegate which is called when all text boxes are validated, then call triangle.Evaluate()
            TxtSideA.TextChanged += new EventHandler(AllSides_TextChanged);
            TxtSideB.TextChanged += new EventHandler(AllSides_TextChanged);
            TxtSideC.TextChanged += new EventHandler(AllSides_TextChanged);
        } // end FrmMain()

        /// <summary>
        /// GetUserData method - to return the List data structure containing the user input for each side.
        /// </summary>
        /// <returns>List of strings</returns>
        //public List<string> GetUserData()
        //{
        //    return userData;
        //} // end method GetUserData()

        public string[] GetUserData()
        {
            return userData;
        } // end method GetUserData()

        /// <summary>
        /// SetResult method - to set the text property of LblResults with the value returned from the shape evaluation.
        /// </summary>
        /// <returns>List of strings</returns>
        public void SetResult(string result)
        {
            //Set results
            LblResults.Text = result;
            LblResults.Visible = true;

            //Clear flags and userData List
            //sideAIsValid = false;
            //sideBIsValid = false;
            //sideCIsValid = false;

            //userData.Clear();
        } // end method SetResult()

        //*********************************** EVENT HANDLERS ***********************************
        /// <summary>
        /// MnuItemAbout_Click event handler - to display a MessageBox which contains the program about info.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void MnuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PROGRAM_ABOUT);
        } // end method MnuItemAbout_Click()

        /// <summary>
        /// MnuItemExit_Click event handler - to close the application and terminate the program.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void MnuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        } // end method MnuItemExit_Click()

        /// <summary>
        /// BtnClear_Click event handler - to clear all controls and data.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            //Clear all data
            TxtSideA.Text = string.Empty;
            TxtSideB.Text = string.Empty;
            TxtSideC.Text = string.Empty;
            LblResults.Visible = false;
            sideAIsValid = false;
            sideBIsValid = false;
            sideCIsValid = false;
            //userData.Clear();

            //Set focus to TxtSideA textbox
            TxtSideA.Focus();
        } // end method BtnClear_Click()

        //*********************************** TEXT-CHANGED EVENTS ***********************************
        /// <summary>
        /// AllSides_TextChanged event handler - subscriber for all side textbox text changed events.
        /// When all sides are valid, userData List is filled with user input from each side textbox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void AllSides_TextChanged(object sender, EventArgs e)
        {
            if (sideAIsValid && sideBIsValid && sideCIsValid)
            {
                //userData.Add(TxtSideA.Text);
                //userData.Add(TxtSideB.Text);
                //userData.Add(TxtSideC.Text);

                userData[0] = TxtSideA.Text;
                userData[1] = TxtSideB.Text;
                userData[2] = TxtSideC.Text;

                triangle.EvalConstraints();
            }

            //userData.Clear();
        } // end method AllSides_TextChanged()

        /// <summary>
        /// TxtSideA_TextChanged event handler - to validate the user input in the textbox for side A.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TxtSideA_TextChanged(object sender, EventArgs e)
        {
            //If the user input is numbers only, or the textbox is empty
            if (validate.Digits(TxtSideA.Text) && !string.IsNullOrEmpty(TxtSideA.Text))
            {
                //Hide invalid input notification and set flag
                LblSideAInvalid.Visible = false;
                sideAIsValid = true;
            }
            else // input is invalid
            {
                //Show invalid input notification and set flag
                if (!string.IsNullOrEmpty(TxtSideA.Text))
                    LblSideAInvalid.Visible = true;
                sideAIsValid = false;
            }
        } // end method TxtSideA_TextChanged()

        /// <summary>
        /// TxtSideB_TextChanged event handler - to validate the user input in the textbox for side B.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TxtSideB_TextChanged(object sender, EventArgs e)
        {
            //If the user input is numbers only, or the textbox is empty
            if (validate.Digits(TxtSideB.Text) && !string.IsNullOrEmpty(TxtSideB.Text))
            {
                //Hide invalid input notification and set flag
                LblSideBInvalid.Visible = false;
                sideBIsValid = true;
            }
            else // input is invalid
            {
                //Show invalid input notification and set flag
                if (!string.IsNullOrEmpty(TxtSideB.Text))
                    LblSideBInvalid.Visible = true;
                sideBIsValid = false;
            }
        } // end method TxtSideB_TextChanged()

        /// <summary>
        /// TxtSideC_TextChanged event handler - to validate the user input in the textbox for side C.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TxtSideC_TextChanged(object sender, EventArgs e)
        {
            //If the user input is numbers only, or the textbox is empty
            if (validate.Digits(TxtSideC.Text) && !string.IsNullOrEmpty(TxtSideC.Text))
            {
                //Hide invalid input notification and set flag
                LblSideCInvalid.Visible = false;
                sideCIsValid = true;
            }
            else // input is invalid
            {
                //Show invalid input notification and set flag
                if (!string.IsNullOrEmpty(TxtSideC.Text))
                    LblSideCInvalid.Visible = true;
                sideCIsValid = false;
            }
        } // end method TxtSideC_TextChanged()

        //*********************************** ENTER EVENTS ***********************************
        /// <summary>
        /// TxtSideA_Enter event handler - to set this textbox as the current textbox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TxtSideA_Enter(object sender, EventArgs e)
        {
            currTxtBox = sender as TextBox;
        } // end method TxtSideA_Enter()

        /// <summary>
        /// TxtSideB_Enter event handler - to set this textbox as the current textbox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TxtSideB_Enter(object sender, EventArgs e)
        {
            currTxtBox = sender as TextBox;
        } // end method TxtSideB_Enter()

        /// <summary>
        /// TxtSideC_Enter event handler - to set this textbox as the current textbox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TxtSideC_Enter(object sender, EventArgs e)
        {
            currTxtBox = sender as TextBox;
        } // end method TxtSideC_Enter()

        //*********************************** LEAVE EVENTS ***********************************
        /// <summary>
        /// TxtSideA_Leave event handler - to set currTxtBox to this textbox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TxtSideA_Leave(object sender, EventArgs e)
        {
            currTxtBox = sender as TextBox;
        } // end method TxtSideA_Leave()

        /// <summary>
        /// TxtSideB_Leave event handler - to set currTxtBox to this textbox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TxtSideB_Leave(object sender, EventArgs e)
        {
            currTxtBox = sender as TextBox;
        } // end method TxtSideB_Leave()

        /// <summary>
        /// TxtSideC_Leave event handler - to set currTxtBox to this textbox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TxtSideC_Leave(object sender, EventArgs e)
        {
            currTxtBox = sender as TextBox;
        } // end method TxtSideC_Leave()

        /// <summary>
        /// OnKeyDown event handler - to override the key down event.
        /// If the KeyCode corresponds to a number, call the corresponding number button click event.
        /// </summary>
        /// <param name="e">KeyEventArgs</param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                Btn9.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                Btn8.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                Btn7.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                Btn6.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                Btn5.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                Btn4.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                Btn3.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                Btn2.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                Btn1.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                Btn0.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
            {
                BtnDecimal.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (currTxtBox.Text.Length > 0)
                    currTxtBox.Text = currTxtBox.Text.Substring(0, currTxtBox.Text.Length - 1);
                e.Handled = true;
            }

            e.SuppressKeyPress = true;
            base.OnKeyDown(e);
        } // end method OnKeyDown()

        /// <summary>
        /// BtnDecimal_Click event handler - to append the decimal character to the text property of currTxtBox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            currTxtBox.AppendText(DECIMAL);
        } // end method BtnDecimal_Click()

        /// <summary>
        /// Btn0_Click event handler - to append the integer 0 to the text property of currTxtBox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Btn0_Click(object sender, EventArgs e)
        {
            currTxtBox.AppendText(ZERO);
        } // end method Btn0_Click()

        /// <summary>
        /// Btn1_Click event handler - to append the integer 1 to the text property of currTxtBox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Btn1_Click(object sender, EventArgs e)
        {
            currTxtBox.AppendText(ONE);
        } // end method Btn1_Click()

        /// <summary>
        /// Btn2_Click event handler - to append the integer 2 to the text property of currTxtBox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Btn2_Click(object sender, EventArgs e)
        {
            currTxtBox.AppendText(TWO);
        } // end method Btn2_Click()

        /// <summary>
        /// Btn3_Click event handler - to append the integer 3 to the text property of currTxtBox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Btn3_Click(object sender, EventArgs e)
        {
            currTxtBox.AppendText(THREE);
        } // end method Btn3_Click()

        /// <summary>
        /// Btn4_Click event handler - to append the integer 4 to the text property of currTxtBox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Btn4_Click(object sender, EventArgs e)
        {
            currTxtBox.AppendText(FOUR);
        } // end method Btn4_Click()

        /// <summary>
        /// Btn5_Click event handler - to append the integer 5 to the text property of currTxtBox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Btn5_Click(object sender, EventArgs e)
        {
            currTxtBox.AppendText(FIVE);
        } // end method Btn5_Click()

        /// <summary>
        /// Btn6_Click event handler - to append the integer 6 to the text property of currTxtBox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Btn6_Click(object sender, EventArgs e)
        {
            currTxtBox.AppendText(SIX);
        } // end method Btn6_Click()

        /// <summary>
        /// Btn7_Click event handler - to append the integer 7 to the text property of currTxtBox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Btn7_Click(object sender, EventArgs e)
        {
            currTxtBox.AppendText(SEVEN);
        } // end method Btn7_Click()

        /// <summary>
        /// Btn8_Click event handler - to append the integer 8 to the text property of currTxtBox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Btn8_Click(object sender, EventArgs e)
        {
            currTxtBox.AppendText(EIGHT);
        } // end method Btn8_Click()

        /// <summary>
        /// Btn9_Click event handler - to append the integer 9 to the text property of currTxtBox.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Btn9_Click(object sender, EventArgs e)
        {
            currTxtBox.AppendText(NINE);
        } // end method Btn9_Click()
    } // end class FrmMain
} // end namespace Calculator
