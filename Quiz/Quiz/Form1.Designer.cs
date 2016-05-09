namespace Quiz
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataSelect = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.questionBox = new System.Windows.Forms.Label();
            this.questionNo = new System.Windows.Forms.Label();
            this.choiceButton3 = new System.Windows.Forms.RadioButton();
            this.choiceButton2 = new System.Windows.Forms.RadioButton();
            this.choiceButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.answerBox = new System.Windows.Forms.Label();
            this.TrueFalse = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataSelect);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Controls.Add(this.questionBox);
            this.panel1.Controls.Add(this.questionNo);
            this.panel1.Controls.Add(this.choiceButton3);
            this.panel1.Controls.Add(this.choiceButton2);
            this.panel1.Controls.Add(this.choiceButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 198);
            this.panel1.TabIndex = 2;
            // 
            // dataSelect
            // 
            this.dataSelect.FormattingEnabled = true;
            this.dataSelect.Items.AddRange(new object[] {
            "Static",
            "Dynamic"});
            this.dataSelect.Location = new System.Drawing.Point(44, 34);
            this.dataSelect.Name = "dataSelect";
            this.dataSelect.Size = new System.Drawing.Size(84, 21);
            this.dataSelect.TabIndex = 8;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(37, 74);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(105, 52);
            this.start.TabIndex = 7;
            this.start.Text = "Start Test";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(96, 172);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Visible = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(8, 63);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(163, 43);
            this.questionBox.TabIndex = 5;
            this.questionBox.Text = "Question";
            this.questionBox.Visible = false;
            this.questionBox.Click += new System.EventHandler(this.questionBox_Click);
            // 
            // questionNo
            // 
            this.questionNo.AutoSize = true;
            this.questionNo.Location = new System.Drawing.Point(8, 34);
            this.questionNo.Name = "questionNo";
            this.questionNo.Size = new System.Drawing.Size(75, 13);
            this.questionNo.TabIndex = 4;
            this.questionNo.Text = "Question No 1";
            this.questionNo.Visible = false;
            this.questionNo.Click += new System.EventHandler(this.label2_Click);
            // 
            // choiceButton3
            // 
            this.choiceButton3.AutoSize = true;
            this.choiceButton3.BackColor = System.Drawing.SystemColors.Control;
            this.choiceButton3.Location = new System.Drawing.Point(11, 155);
            this.choiceButton3.Name = "choiceButton3";
            this.choiceButton3.Size = new System.Drawing.Size(67, 17);
            this.choiceButton3.TabIndex = 3;
            this.choiceButton3.TabStop = true;
            this.choiceButton3.Text = "Choice 3";
            this.choiceButton3.UseVisualStyleBackColor = false;
            this.choiceButton3.Visible = false;
            // 
            // choiceButton2
            // 
            this.choiceButton2.AutoSize = true;
            this.choiceButton2.BackColor = System.Drawing.SystemColors.Control;
            this.choiceButton2.Location = new System.Drawing.Point(11, 132);
            this.choiceButton2.Name = "choiceButton2";
            this.choiceButton2.Size = new System.Drawing.Size(67, 17);
            this.choiceButton2.TabIndex = 2;
            this.choiceButton2.TabStop = true;
            this.choiceButton2.Text = "Choice 2";
            this.choiceButton2.UseVisualStyleBackColor = false;
            this.choiceButton2.Visible = false;
            // 
            // choiceButton1
            // 
            this.choiceButton1.AutoSize = true;
            this.choiceButton1.BackColor = System.Drawing.SystemColors.Control;
            this.choiceButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.choiceButton1.Location = new System.Drawing.Point(11, 109);
            this.choiceButton1.Name = "choiceButton1";
            this.choiceButton1.Size = new System.Drawing.Size(67, 17);
            this.choiceButton1.TabIndex = 1;
            this.choiceButton1.Text = "Choice 1";
            this.choiceButton1.UseVisualStyleBackColor = false;
            this.choiceButton1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "C# Quiz";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 45);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "State";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Time";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Score:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time remaining:";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(187, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Next Question";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.answerBox);
            this.panel3.Controls.Add(this.TrueFalse);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(187, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(92, 198);
            this.panel3.TabIndex = 5;
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(4, 63);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(82, 132);
            this.answerBox.TabIndex = 2;
            this.answerBox.Text = "Answer";
            this.answerBox.Visible = false;
            // 
            // TrueFalse
            // 
            this.TrueFalse.AutoSize = true;
            this.TrueFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueFalse.Location = new System.Drawing.Point(4, 34);
            this.TrueFalse.Name = "TrueFalse";
            this.TrueFalse.Size = new System.Drawing.Size(43, 13);
            this.TrueFalse.TabIndex = 1;
            this.TrueFalse.Text = "Check";
            this.TrueFalse.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Answer";
            this.label6.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton choiceButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label questionNo;
        private System.Windows.Forms.RadioButton choiceButton3;
        private System.Windows.Forms.RadioButton choiceButton2;
        private System.Windows.Forms.Label questionBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TrueFalse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label answerBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox dataSelect;
    }
}

