﻿namespace Your_salary
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
            label1 = new Label();
            buttonYES = new Button();
            buttonNO = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(115, 61);
            label1.Name = "label1";
            label1.Size = new Size(596, 41);
            label1.TabIndex = 0;
            label1.Text = "Ви задоволені своєю заробітною платою?";
            // 
            // buttonYES
            // 
            buttonYES.BackColor = Color.Chartreuse;
            buttonYES.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonYES.Location = new Point(173, 192);
            buttonYES.Name = "buttonYES";
            buttonYES.Size = new Size(132, 59);
            buttonYES.TabIndex = 1;
            buttonYES.Text = "ТАК";
            buttonYES.UseVisualStyleBackColor = false;
            buttonYES.Click += buttonYES_Click;
            // 
            // buttonNO
            // 
            buttonNO.BackColor = Color.Red;
            buttonNO.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNO.Location = new Point(477, 192);
            buttonNO.Name = "buttonNO";
            buttonNO.Size = new Size(132, 59);
            buttonNO.TabIndex = 2;
            buttonNO.Text = "НІ";
            buttonNO.UseVisualStyleBackColor = false;
            buttonNO.MouseEnter += buttonNO_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonNO);
            Controls.Add(buttonYES);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonYES;
        private Button buttonNO;
    }
}