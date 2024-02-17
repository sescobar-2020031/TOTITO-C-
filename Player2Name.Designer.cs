namespace TotitoSE
{
    partial class Player2Name
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player2Name));
            button1 = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(316, 269);
            button1.Name = "button1";
            button1.Size = new Size(181, 32);
            button1.TabIndex = 9;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(171, 218);
            panel1.Name = "panel1";
            panel1.Size = new Size(33, 29);
            panel1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(204, 218);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Escribe tu nombre.";
            textBox1.Size = new Size(437, 29);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 15, 36);
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(171, 158);
            label1.Name = "label1";
            label1.Size = new Size(470, 37);
            label1.TabIndex = 6;
            label1.Text = "Elige el nombre para el Jugador #2.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(841, 427);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Player2Name
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 417);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Player2Name";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nombre Jugador #2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}