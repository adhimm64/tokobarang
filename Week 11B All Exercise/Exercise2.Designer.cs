namespace Week_11B_All_Exercise
{
    partial class Exercise2
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
            this.button3 = new System.Windows.Forms.Button();
            this.lstInfoo = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudMark = new System.Windows.Forms.NumericUpDown();
            this.cbxColumn = new System.Windows.Forms.ComboBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxRow = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInitialze = new System.Windows.Forms.Button();
            this.txtNumAsses = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumStud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtAverage = new System.Windows.Forms.RadioButton();
            this.rbtHighest = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtColumn = new System.Windows.Forms.RadioButton();
            this.rbtRows = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMark)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(691, 507);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstInfoo
            // 
            this.lstInfoo.FormattingEnabled = true;
            this.lstInfoo.ItemHeight = 20;
            this.lstInfoo.Location = new System.Drawing.Point(12, 256);
            this.lstInfoo.Name = "lstInfoo";
            this.lstInfoo.Size = new System.Drawing.Size(777, 244);
            this.lstInfoo.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudMark);
            this.groupBox2.Controls.Add(this.cbxColumn);
            this.groupBox2.Controls.Add(this.btnInput);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbxRow);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(204, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 228);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mark";
            // 
            // nudMark
            // 
            this.nudMark.Location = new System.Drawing.Point(200, 102);
            this.nudMark.Name = "nudMark";
            this.nudMark.Size = new System.Drawing.Size(80, 26);
            this.nudMark.TabIndex = 4;
            // 
            // cbxColumn
            // 
            this.cbxColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColumn.FormattingEnabled = true;
            this.cbxColumn.Location = new System.Drawing.Point(10, 128);
            this.cbxColumn.Name = "cbxColumn";
            this.cbxColumn.Size = new System.Drawing.Size(121, 28);
            this.cbxColumn.TabIndex = 3;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(10, 168);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(268, 38);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "Input Mark";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assessment # (Column)";
            // 
            // cbxRow
            // 
            this.cbxRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRow.FormattingEnabled = true;
            this.cbxRow.Location = new System.Drawing.Point(10, 58);
            this.cbxRow.Name = "cbxRow";
            this.cbxRow.Size = new System.Drawing.Size(121, 28);
            this.cbxRow.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Student # (Row)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInitialze);
            this.groupBox1.Controls.Add(this.txtNumAsses);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumStud);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 228);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Array Initialization";
            // 
            // btnInitialze
            // 
            this.btnInitialze.Location = new System.Drawing.Point(10, 168);
            this.btnInitialze.Name = "btnInitialze";
            this.btnInitialze.Size = new System.Drawing.Size(141, 38);
            this.btnInitialze.TabIndex = 2;
            this.btnInitialze.Text = "Initialize Array";
            this.btnInitialze.UseVisualStyleBackColor = true;
            this.btnInitialze.Click += new System.EventHandler(this.btnInitialze_Click);
            // 
            // txtNumAsses
            // 
            this.txtNumAsses.Location = new System.Drawing.Point(10, 128);
            this.txtNumAsses.Name = "txtNumAsses";
            this.txtNumAsses.Size = new System.Drawing.Size(140, 26);
            this.txtNumAsses.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Assessments";
            // 
            // txtNumStud
            // 
            this.txtNumStud.Location = new System.Drawing.Point(10, 58);
            this.txtNumStud.Name = "txtNumStud";
            this.txtNumStud.Size = new System.Drawing.Size(140, 26);
            this.txtNumStud.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Students";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtAverage);
            this.groupBox3.Controls.Add(this.rbtHighest);
            this.groupBox3.Location = new System.Drawing.Point(512, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 88);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search for Value";
            // 
            // rbtAverage
            // 
            this.rbtAverage.AutoSize = true;
            this.rbtAverage.Location = new System.Drawing.Point(6, 55);
            this.rbtAverage.Name = "rbtAverage";
            this.rbtAverage.Size = new System.Drawing.Size(132, 24);
            this.rbtAverage.TabIndex = 1;
            this.rbtAverage.TabStop = true;
            this.rbtAverage.Text = "Average Mark";
            this.rbtAverage.UseVisualStyleBackColor = true;
            // 
            // rbtHighest
            // 
            this.rbtHighest.AutoSize = true;
            this.rbtHighest.Checked = true;
            this.rbtHighest.Location = new System.Drawing.Point(6, 25);
            this.rbtHighest.Name = "rbtHighest";
            this.rbtHighest.Size = new System.Drawing.Size(128, 24);
            this.rbtHighest.TabIndex = 0;
            this.rbtHighest.TabStop = true;
            this.rbtHighest.Text = "Highest Mark";
            this.rbtHighest.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtColumn);
            this.groupBox4.Controls.Add(this.rbtRows);
            this.groupBox4.Location = new System.Drawing.Point(512, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 88);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "From";
            // 
            // rbtColumn
            // 
            this.rbtColumn.AutoSize = true;
            this.rbtColumn.Location = new System.Drawing.Point(6, 55);
            this.rbtColumn.Name = "rbtColumn";
            this.rbtColumn.Size = new System.Drawing.Size(211, 24);
            this.rbtColumn.TabIndex = 1;
            this.rbtColumn.TabStop = true;
            this.rbtColumn.Text = "All Assessment (Column)";
            this.rbtColumn.UseVisualStyleBackColor = true;
            // 
            // rbtRows
            // 
            this.rbtRows.AutoSize = true;
            this.rbtRows.Checked = true;
            this.rbtRows.Location = new System.Drawing.Point(6, 25);
            this.rbtRows.Name = "rbtRows";
            this.rbtRows.Size = new System.Drawing.Size(174, 24);
            this.rbtRows.TabIndex = 0;
            this.rbtRows.TabStop = true;
            this.rbtRows.Text = "All Students (Rows)";
            this.rbtRows.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(521, 201);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(258, 40);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Exercise2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 557);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lstInfoo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exercise2";
            this.Text = "Exercise 2";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMark)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstInfoo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudMark;
        private System.Windows.Forms.ComboBox cbxColumn;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxRow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInitialze;
        private System.Windows.Forms.TextBox txtNumAsses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumStud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtAverage;
        private System.Windows.Forms.RadioButton rbtHighest;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtColumn;
        private System.Windows.Forms.RadioButton rbtRows;
        private System.Windows.Forms.Button btnCalculate;
    }
}