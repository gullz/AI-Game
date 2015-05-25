namespace GAScrabble
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGO = new System.Windows.Forms.Button();
            this.btnContinuous = new System.Windows.Forms.Button();
            this.txtAnagram = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.lstUserInputs = new System.Windows.Forms.ListBox();
            this.btnTesting = new System.Windows.Forms.Button();
            this.lstGettingLetters = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(39, 64);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(75, 23);
            this.btnGO.TabIndex = 0;
            this.btnGO.Text = "First Find";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // btnContinuous
            // 
            this.btnContinuous.Location = new System.Drawing.Point(129, 64);
            this.btnContinuous.Name = "btnContinuous";
            this.btnContinuous.Size = new System.Drawing.Size(75, 23);
            this.btnContinuous.TabIndex = 1;
            this.btnContinuous.Text = "Continuous";
            this.btnContinuous.UseVisualStyleBackColor = true;
            this.btnContinuous.Click += new System.EventHandler(this.btnContinuous_Click);
            // 
            // txtAnagram
            // 
            this.txtAnagram.Location = new System.Drawing.Point(129, 18);
            this.txtAnagram.Name = "txtAnagram";
            this.txtAnagram.Size = new System.Drawing.Size(138, 20);
            this.txtAnagram.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Anagram:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(44, 114);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(94, 24);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "_______";
            this.lblAnswer.Visible = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(223, 64);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(13, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 329);
            this.panel1.TabIndex = 6;
            // 
            // button16
            // 
            this.button16.AccessibleName = "";
            this.button16.Location = new System.Drawing.Point(259, 246);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 73);
            this.button16.TabIndex = 15;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.AccessibleName = "";
            this.button15.Location = new System.Drawing.Point(178, 246);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 73);
            this.button15.TabIndex = 14;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.AccessibleName = "";
            this.button14.Location = new System.Drawing.Point(97, 246);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 73);
            this.button14.TabIndex = 13;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.AccessibleName = "";
            this.button13.Location = new System.Drawing.Point(16, 246);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 73);
            this.button13.TabIndex = 12;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.AccessibleName = "";
            this.button12.Location = new System.Drawing.Point(259, 167);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 73);
            this.button12.TabIndex = 11;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.AccessibleName = "";
            this.button11.Location = new System.Drawing.Point(178, 167);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 73);
            this.button11.TabIndex = 10;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.AccessibleName = "";
            this.button10.Location = new System.Drawing.Point(97, 167);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 73);
            this.button10.TabIndex = 9;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.AccessibleName = "";
            this.button9.Location = new System.Drawing.Point(16, 167);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 73);
            this.button9.TabIndex = 8;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.AccessibleName = "";
            this.button8.Location = new System.Drawing.Point(259, 89);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 73);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.AccessibleName = "";
            this.button7.Location = new System.Drawing.Point(178, 88);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 73);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.AccessibleName = "";
            this.button6.Location = new System.Drawing.Point(97, 88);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 73);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.AccessibleName = "";
            this.button5.Location = new System.Drawing.Point(16, 88);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 73);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.AccessibleName = "";
            this.button4.Location = new System.Drawing.Point(259, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 73);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "";
            this.button3.Location = new System.Drawing.Point(178, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 73);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "button[2]";
            this.button2.Location = new System.Drawing.Point(97, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "button[1]";
            this.button1.Location = new System.Drawing.Point(16, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(372, 30);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(160, 20);
            this.txtUserInput.TabIndex = 7;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(873, 36);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(49, 23);
            this.btnAddToList.TabIndex = 8;
            this.btnAddToList.Text = "Add";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // lstUserInputs
            // 
            this.lstUserInputs.FormattingEnabled = true;
            this.lstUserInputs.Location = new System.Drawing.Point(372, 65);
            this.lstUserInputs.Name = "lstUserInputs";
            this.lstUserInputs.Size = new System.Drawing.Size(160, 121);
            this.lstUserInputs.TabIndex = 9;
            // 
            // btnTesting
            // 
            this.btnTesting.Location = new System.Drawing.Point(372, 325);
            this.btnTesting.Name = "btnTesting";
            this.btnTesting.Size = new System.Drawing.Size(75, 23);
            this.btnTesting.TabIndex = 10;
            this.btnTesting.Text = "Testing";
            this.btnTesting.UseVisualStyleBackColor = true;
            this.btnTesting.Click += new System.EventHandler(this.btnTesting_Click);
            // 
            // lstGettingLetters
            // 
            this.lstGettingLetters.FormattingEnabled = true;
            this.lstGettingLetters.Location = new System.Drawing.Point(372, 193);
            this.lstGettingLetters.Name = "lstGettingLetters";
            this.lstGettingLetters.Size = new System.Drawing.Size(160, 121);
            this.lstGettingLetters.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 104);
            this.label2.TabIndex = 12;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.lblAnswer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAnagram);
            this.groupBox1.Controls.Add(this.btnContinuous);
            this.groupBox1.Controls.Add(this.btnGO);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 328);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lstGettingLetters);
            this.groupBox2.Controls.Add(this.btnTesting);
            this.groupBox2.Controls.Add(this.lstUserInputs);
            this.groupBox2.Controls.Add(this.txtUserInput);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(335, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 358);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(623, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Scrabble Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Button btnContinuous;
        private System.Windows.Forms.TextBox txtAnagram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.ListBox lstUserInputs;
        private System.Windows.Forms.Button btnTesting;
        private System.Windows.Forms.ListBox lstGettingLetters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
    }
}

