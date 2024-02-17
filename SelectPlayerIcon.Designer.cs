﻿namespace TotitoSE
{
    partial class SelectPlayerIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPlayerIcon));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 373);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(5, 3, 14);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(100, 64);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 1;
            label1.Text = "Prueba";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.UseMnemonic = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(154, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(137, 100);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(12, 11, 27);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(3, 3);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(131, 94);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Location = new Point(330, 170);
            panel2.Name = "panel2";
            panel2.Size = new Size(137, 100);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(12, 11, 27);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(3, 3);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(131, 94);
            button2.TabIndex = 1;
            button2.Text = "0";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // SelectPlayerIcon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(623, 366);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelectPlayerIcon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleccióno Icono";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button button2;
    }
}