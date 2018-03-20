namespace Calculator
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MnuMain = new System.Windows.Forms.MenuStrip();
            this.MnuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnDecimal = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.PnlSideA = new System.Windows.Forms.Panel();
            this.LblSideA = new System.Windows.Forms.Label();
            this.LblSideAInvalid = new System.Windows.Forms.Label();
            this.TxtSideA = new Calculator.HintTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PicBxLeft = new System.Windows.Forms.PictureBox();
            this.PicBxRight = new System.Windows.Forms.PictureBox();
            this.LblInstructions = new System.Windows.Forms.Label();
            this.PnlSideB = new System.Windows.Forms.Panel();
            this.LblSideB = new System.Windows.Forms.Label();
            this.LblSideBInvalid = new System.Windows.Forms.Label();
            this.TxtSideB = new Calculator.HintTextBox();
            this.PnlSideC = new System.Windows.Forms.Panel();
            this.LblSideC = new System.Windows.Forms.Label();
            this.LblSideCInvalid = new System.Windows.Forms.Label();
            this.TxtSideC = new Calculator.HintTextBox();
            this.LblResults = new System.Windows.Forms.Label();
            this.MnuMain.SuspendLayout();
            this.PnlSideA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxRight)).BeginInit();
            this.PnlSideB.SuspendLayout();
            this.PnlSideC.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMain
            // 
            this.MnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemFile});
            this.MnuMain.Location = new System.Drawing.Point(0, 0);
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(534, 24);
            this.MnuMain.TabIndex = 1;
            // 
            // MnuItemFile
            // 
            this.MnuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemAbout,
            this.MnuItemExit});
            this.MnuItemFile.Name = "MnuItemFile";
            this.MnuItemFile.Size = new System.Drawing.Size(37, 20);
            this.MnuItemFile.Text = "File";
            // 
            // MnuItemAbout
            // 
            this.MnuItemAbout.Name = "MnuItemAbout";
            this.MnuItemAbout.Size = new System.Drawing.Size(107, 22);
            this.MnuItemAbout.Text = "About";
            this.MnuItemAbout.Click += new System.EventHandler(this.MnuItemAbout_Click);
            // 
            // MnuItemExit
            // 
            this.MnuItemExit.Name = "MnuItemExit";
            this.MnuItemExit.Size = new System.Drawing.Size(107, 22);
            this.MnuItemExit.Text = "Exit";
            this.MnuItemExit.Click += new System.EventHandler(this.MnuItemExit_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.Control;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(89, 355);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(90, 90);
            this.Btn2.TabIndex = 45;
            this.Btn2.TabStop = false;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.SystemColors.Control;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(178, 355);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(90, 90);
            this.Btn3.TabIndex = 44;
            this.Btn3.TabStop = false;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.Control;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(0, 355);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(90, 90);
            this.Btn1.TabIndex = 42;
            this.Btn1.TabStop = false;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // BtnDecimal
            // 
            this.BtnDecimal.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDecimal.Location = new System.Drawing.Point(178, 444);
            this.BtnDecimal.Name = "BtnDecimal";
            this.BtnDecimal.Size = new System.Drawing.Size(90, 90);
            this.BtnDecimal.TabIndex = 41;
            this.BtnDecimal.TabStop = false;
            this.BtnDecimal.Text = ".";
            this.BtnDecimal.UseVisualStyleBackColor = false;
            this.BtnDecimal.Click += new System.EventHandler(this.BtnDecimal_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.SystemColors.Control;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(0, 444);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(179, 90);
            this.Btn0.TabIndex = 39;
            this.Btn0.TabStop = false;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.SystemColors.Control;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(89, 266);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(90, 90);
            this.Btn5.TabIndex = 38;
            this.Btn5.TabStop = false;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.SystemColors.Control;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(178, 266);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(90, 90);
            this.Btn6.TabIndex = 37;
            this.Btn6.TabStop = false;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.SystemColors.Control;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(0, 266);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(90, 90);
            this.Btn4.TabIndex = 35;
            this.Btn4.TabStop = false;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.SystemColors.Control;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(89, 177);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(90, 90);
            this.Btn8.TabIndex = 34;
            this.Btn8.TabStop = false;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.SystemColors.Control;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(178, 177);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(90, 90);
            this.Btn9.TabIndex = 33;
            this.Btn9.TabStop = false;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.SystemColors.Control;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(0, 177);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(90, 90);
            this.Btn7.TabIndex = 31;
            this.Btn7.TabStop = false;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(351, 470);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(108, 44);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // PnlSideA
            // 
            this.PnlSideA.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlSideA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlSideA.Controls.Add(this.LblSideA);
            this.PnlSideA.Controls.Add(this.LblSideAInvalid);
            this.PnlSideA.Controls.Add(this.TxtSideA);
            this.PnlSideA.Location = new System.Drawing.Point(267, 177);
            this.PnlSideA.Name = "PnlSideA";
            this.PnlSideA.Size = new System.Drawing.Size(267, 91);
            this.PnlSideA.TabIndex = 48;
            // 
            // LblSideA
            // 
            this.LblSideA.AutoSize = true;
            this.LblSideA.BackColor = System.Drawing.Color.Gainsboro;
            this.LblSideA.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSideA.Location = new System.Drawing.Point(4, 15);
            this.LblSideA.Name = "LblSideA";
            this.LblSideA.Size = new System.Drawing.Size(60, 54);
            this.LblSideA.TabIndex = 53;
            this.LblSideA.Text = "Side\r\nA";
            this.LblSideA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblSideAInvalid
            // 
            this.LblSideAInvalid.AutoSize = true;
            this.LblSideAInvalid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSideAInvalid.ForeColor = System.Drawing.Color.Red;
            this.LblSideAInvalid.Location = new System.Drawing.Point(66, 4);
            this.LblSideAInvalid.Name = "LblSideAInvalid";
            this.LblSideAInvalid.Size = new System.Drawing.Size(175, 17);
            this.LblSideAInvalid.TabIndex = 2;
            this.LblSideAInvalid.Text = "Length must be a number";
            this.LblSideAInvalid.Visible = false;
            // 
            // TxtSideA
            // 
            this.TxtSideA.BackColor = System.Drawing.Color.White;
            this.TxtSideA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSideA.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSideA.ForeColor = System.Drawing.Color.Black;
            this.TxtSideA.Hint = "Length of side A";
            this.TxtSideA.Location = new System.Drawing.Point(67, 25);
            this.TxtSideA.Name = "TxtSideA";
            this.TxtSideA.Size = new System.Drawing.Size(190, 35);
            this.TxtSideA.TabIndex = 0;
            this.TxtSideA.TextChanged += new System.EventHandler(this.TxtSideA_TextChanged);
            this.TxtSideA.Enter += new System.EventHandler(this.TxtSideA_Enter);
            this.TxtSideA.Leave += new System.EventHandler(this.TxtSideA_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 33);
            this.label1.TabIndex = 49;
            this.label1.Text = "Triangle Calculator";
            // 
            // PicBxLeft
            // 
            this.PicBxLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicBxLeft.BackgroundImage")));
            this.PicBxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBxLeft.Location = new System.Drawing.Point(21, 40);
            this.PicBxLeft.Name = "PicBxLeft";
            this.PicBxLeft.Size = new System.Drawing.Size(78, 101);
            this.PicBxLeft.TabIndex = 50;
            this.PicBxLeft.TabStop = false;
            // 
            // PicBxRight
            // 
            this.PicBxRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicBxRight.BackgroundImage")));
            this.PicBxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBxRight.Location = new System.Drawing.Point(434, 40);
            this.PicBxRight.Name = "PicBxRight";
            this.PicBxRight.Size = new System.Drawing.Size(78, 101);
            this.PicBxRight.TabIndex = 51;
            this.PicBxRight.TabStop = false;
            // 
            // LblInstructions
            // 
            this.LblInstructions.AutoSize = true;
            this.LblInstructions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInstructions.Location = new System.Drawing.Point(152, 83);
            this.LblInstructions.Name = "LblInstructions";
            this.LblInstructions.Size = new System.Drawing.Size(231, 38);
            this.LblInstructions.TabIndex = 52;
            this.LblInstructions.Text = "Enter the length of all 3 sides\r\nof a triangle to calculate its type";
            this.LblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PnlSideB
            // 
            this.PnlSideB.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlSideB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlSideB.Controls.Add(this.LblSideB);
            this.PnlSideB.Controls.Add(this.LblSideBInvalid);
            this.PnlSideB.Controls.Add(this.TxtSideB);
            this.PnlSideB.Location = new System.Drawing.Point(267, 266);
            this.PnlSideB.Name = "PnlSideB";
            this.PnlSideB.Size = new System.Drawing.Size(267, 91);
            this.PnlSideB.TabIndex = 53;
            // 
            // LblSideB
            // 
            this.LblSideB.AutoSize = true;
            this.LblSideB.BackColor = System.Drawing.Color.Gainsboro;
            this.LblSideB.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSideB.Location = new System.Drawing.Point(4, 15);
            this.LblSideB.Name = "LblSideB";
            this.LblSideB.Size = new System.Drawing.Size(60, 54);
            this.LblSideB.TabIndex = 53;
            this.LblSideB.Text = "Side\r\nB";
            this.LblSideB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblSideBInvalid
            // 
            this.LblSideBInvalid.AutoSize = true;
            this.LblSideBInvalid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSideBInvalid.ForeColor = System.Drawing.Color.Red;
            this.LblSideBInvalid.Location = new System.Drawing.Point(66, 4);
            this.LblSideBInvalid.Name = "LblSideBInvalid";
            this.LblSideBInvalid.Size = new System.Drawing.Size(175, 17);
            this.LblSideBInvalid.TabIndex = 2;
            this.LblSideBInvalid.Text = "Length must be a number";
            this.LblSideBInvalid.Visible = false;
            // 
            // TxtSideB
            // 
            this.TxtSideB.BackColor = System.Drawing.Color.White;
            this.TxtSideB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSideB.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSideB.ForeColor = System.Drawing.Color.Black;
            this.TxtSideB.Hint = "Length of side B";
            this.TxtSideB.Location = new System.Drawing.Point(67, 25);
            this.TxtSideB.Name = "TxtSideB";
            this.TxtSideB.Size = new System.Drawing.Size(190, 35);
            this.TxtSideB.TabIndex = 1;
            this.TxtSideB.TextChanged += new System.EventHandler(this.TxtSideB_TextChanged);
            this.TxtSideB.Enter += new System.EventHandler(this.TxtSideB_Enter);
            this.TxtSideB.Leave += new System.EventHandler(this.TxtSideB_Leave);
            // 
            // PnlSideC
            // 
            this.PnlSideC.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlSideC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlSideC.Controls.Add(this.LblSideC);
            this.PnlSideC.Controls.Add(this.LblSideCInvalid);
            this.PnlSideC.Controls.Add(this.TxtSideC);
            this.PnlSideC.Location = new System.Drawing.Point(267, 355);
            this.PnlSideC.Name = "PnlSideC";
            this.PnlSideC.Size = new System.Drawing.Size(267, 91);
            this.PnlSideC.TabIndex = 54;
            // 
            // LblSideC
            // 
            this.LblSideC.AutoSize = true;
            this.LblSideC.BackColor = System.Drawing.Color.Gainsboro;
            this.LblSideC.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSideC.Location = new System.Drawing.Point(4, 15);
            this.LblSideC.Name = "LblSideC";
            this.LblSideC.Size = new System.Drawing.Size(60, 54);
            this.LblSideC.TabIndex = 53;
            this.LblSideC.Text = "Side\r\nC";
            this.LblSideC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblSideCInvalid
            // 
            this.LblSideCInvalid.AutoSize = true;
            this.LblSideCInvalid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSideCInvalid.ForeColor = System.Drawing.Color.Red;
            this.LblSideCInvalid.Location = new System.Drawing.Point(66, 4);
            this.LblSideCInvalid.Name = "LblSideCInvalid";
            this.LblSideCInvalid.Size = new System.Drawing.Size(175, 17);
            this.LblSideCInvalid.TabIndex = 2;
            this.LblSideCInvalid.Text = "Length must be a number";
            this.LblSideCInvalid.Visible = false;
            // 
            // TxtSideC
            // 
            this.TxtSideC.BackColor = System.Drawing.Color.White;
            this.TxtSideC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSideC.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSideC.ForeColor = System.Drawing.Color.Black;
            this.TxtSideC.Hint = "Length of side C";
            this.TxtSideC.Location = new System.Drawing.Point(67, 25);
            this.TxtSideC.Name = "TxtSideC";
            this.TxtSideC.Size = new System.Drawing.Size(190, 35);
            this.TxtSideC.TabIndex = 2;
            this.TxtSideC.TextChanged += new System.EventHandler(this.TxtSideC_TextChanged);
            this.TxtSideC.Enter += new System.EventHandler(this.TxtSideC_Enter);
            this.TxtSideC.Leave += new System.EventHandler(this.TxtSideC_Leave);
            // 
            // LblResults
            // 
            this.LblResults.AutoSize = true;
            this.LblResults.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResults.ForeColor = System.Drawing.Color.ForestGreen;
            this.LblResults.Location = new System.Drawing.Point(206, 132);
            this.LblResults.Name = "LblResults";
            this.LblResults.Size = new System.Drawing.Size(123, 32);
            this.LblResults.TabIndex = 55;
            this.LblResults.Text = "Triangle";
            this.LblResults.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 534);
            this.Controls.Add(this.LblResults);
            this.Controls.Add(this.PnlSideC);
            this.Controls.Add(this.PnlSideB);
            this.Controls.Add(this.LblInstructions);
            this.Controls.Add(this.PicBxRight);
            this.Controls.Add(this.PicBxLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlSideA);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnDecimal);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.MnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shape Calculator";
            this.MnuMain.ResumeLayout(false);
            this.MnuMain.PerformLayout();
            this.PnlSideA.ResumeLayout(false);
            this.PnlSideA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxRight)).EndInit();
            this.PnlSideB.ResumeLayout(false);
            this.PnlSideB.PerformLayout();
            this.PnlSideC.ResumeLayout(false);
            this.PnlSideC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuMain;
        private System.Windows.Forms.ToolStripMenuItem MnuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MnuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem MnuItemExit;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnDecimal;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnClear;
        private HintTextBox TxtSideA;
        private System.Windows.Forms.Panel PnlSideA;
        private System.Windows.Forms.Label LblSideAInvalid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicBxLeft;
        private System.Windows.Forms.PictureBox PicBxRight;
        private System.Windows.Forms.Label LblInstructions;
        private System.Windows.Forms.Label LblSideA;
        private System.Windows.Forms.Panel PnlSideB;
        private System.Windows.Forms.Label LblSideB;
        private System.Windows.Forms.Label LblSideBInvalid;
        private HintTextBox TxtSideB;
        private System.Windows.Forms.Panel PnlSideC;
        private System.Windows.Forms.Label LblSideC;
        private System.Windows.Forms.Label LblSideCInvalid;
        private HintTextBox TxtSideC;
        private System.Windows.Forms.Label LblResults;
    }
}

