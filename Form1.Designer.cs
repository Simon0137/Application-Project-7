﻿namespace Application_Project_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(26, 23);
            button1.Name = "button1";
            button1.Size = new Size(194, 42);
            button1.TabIndex = 0;
            button1.Text = "Submit Answers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(26, 99);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 1;
            label1.Text = "Pass/Not Pass";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 155);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 2;
            label2.Text = "CorrectAnswers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 180);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 3;
            label3.Text = "Incorrect Answers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 23);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 4;
            label4.Text = "Correcting Answers";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 599);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Grade Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}