namespace Reserva_puesto_avion
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
            pictureBox1 = new PictureBox();
            btnAsiento1 = new Button();
            btnAsiento2 = new Button();
            btnAsiento4 = new Button();
            btnAsiento3 = new Button();
            btnAsiento6 = new Button();
            btnAsiento5 = new Button();
            btnAsiento8 = new Button();
            btnAsiento7 = new Button();
            lblSelecciona = new Label();
            lblDisponible = new Label();
            lblOcupado = new Label();
            iconDisponible = new Button();
            iconOcupado = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Avi;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(51, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 480);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAsiento1
            // 
            btnAsiento1.AccessibleName = "A1";
            btnAsiento1.BackColor = Color.ForestGreen;
            btnAsiento1.ForeColor = Color.Black;
            btnAsiento1.Location = new Point(231, 195);
            btnAsiento1.Name = "btnAsiento1";
            btnAsiento1.Size = new Size(19, 19);
            btnAsiento1.TabIndex = 5;
            btnAsiento1.Tag = "1";
            btnAsiento1.UseCompatibleTextRendering = true;
            btnAsiento1.UseVisualStyleBackColor = false;
            btnAsiento1.Click += button1_Click_2;
            // 
            // btnAsiento2
            // 
            btnAsiento2.AccessibleName = "B1";
            btnAsiento2.BackColor = Color.ForestGreen;
            btnAsiento2.Location = new Point(256, 195);
            btnAsiento2.Name = "btnAsiento2";
            btnAsiento2.Size = new Size(19, 19);
            btnAsiento2.TabIndex = 2;
            btnAsiento2.Tag = "2";
            btnAsiento2.UseVisualStyleBackColor = false;
            btnAsiento2.Click += button2_Click;
            // 
            // btnAsiento4
            // 
            btnAsiento4.AccessibleName = "B2";
            btnAsiento4.BackColor = Color.ForestGreen;
            btnAsiento4.Location = new Point(256, 231);
            btnAsiento4.Name = "btnAsiento4";
            btnAsiento4.Size = new Size(19, 19);
            btnAsiento4.TabIndex = 4;
            btnAsiento4.Tag = "4";
            btnAsiento4.UseVisualStyleBackColor = false;
            // 
            // btnAsiento3
            // 
            btnAsiento3.AccessibleName = "A2";
            btnAsiento3.BackColor = Color.ForestGreen;
            btnAsiento3.Location = new Point(231, 231);
            btnAsiento3.Name = "btnAsiento3";
            btnAsiento3.Size = new Size(19, 19);
            btnAsiento3.TabIndex = 3;
            btnAsiento3.Tag = "3";
            btnAsiento3.UseVisualStyleBackColor = false;
            // 
            // btnAsiento6
            // 
            btnAsiento6.AccessibleName = "B3";
            btnAsiento6.BackColor = Color.ForestGreen;
            btnAsiento6.Location = new Point(255, 263);
            btnAsiento6.Name = "btnAsiento6";
            btnAsiento6.Size = new Size(19, 19);
            btnAsiento6.TabIndex = 6;
            btnAsiento6.Tag = "6";
            btnAsiento6.UseVisualStyleBackColor = false;
            // 
            // btnAsiento5
            // 
            btnAsiento5.AccessibleName = "A3";
            btnAsiento5.BackColor = Color.ForestGreen;
            btnAsiento5.Location = new Point(230, 263);
            btnAsiento5.Name = "btnAsiento5";
            btnAsiento5.Size = new Size(19, 19);
            btnAsiento5.TabIndex = 5;
            btnAsiento5.Tag = "5";
            btnAsiento5.UseVisualStyleBackColor = false;
            // 
            // btnAsiento8
            // 
            btnAsiento8.AccessibleName = "B4";
            btnAsiento8.BackColor = Color.ForestGreen;
            btnAsiento8.Location = new Point(256, 298);
            btnAsiento8.Name = "btnAsiento8";
            btnAsiento8.Size = new Size(19, 19);
            btnAsiento8.TabIndex = 8;
            btnAsiento8.Tag = "8";
            btnAsiento8.UseVisualStyleBackColor = false;
            // 
            // btnAsiento7
            // 
            btnAsiento7.AccessibleName = "A4";
            btnAsiento7.BackColor = Color.ForestGreen;
            btnAsiento7.Location = new Point(231, 298);
            btnAsiento7.Name = "btnAsiento7";
            btnAsiento7.Size = new Size(19, 19);
            btnAsiento7.TabIndex = 7;
            btnAsiento7.Tag = "7";
            btnAsiento7.UseVisualStyleBackColor = false;
            // 
            // lblSelecciona
            // 
            lblSelecciona.AutoSize = true;
            lblSelecciona.BackColor = Color.Gainsboro;
            lblSelecciona.Font = new Font("Segoe UI", 10F);
            lblSelecciona.Location = new Point(12, 23);
            lblSelecciona.Name = "lblSelecciona";
            lblSelecciona.Size = new Size(223, 19);
            lblSelecciona.TabIndex = 9;
            lblSelecciona.Text = "Selecciona un asiento para reservar";
            lblSelecciona.Click += label1_Click;
            // 
            // lblDisponible
            // 
            lblDisponible.AutoSize = true;
            lblDisponible.Font = new Font("Segoe UI", 12F);
            lblDisponible.Location = new Point(51, 71);
            lblDisponible.Name = "lblDisponible";
            lblDisponible.Size = new Size(84, 21);
            lblDisponible.TabIndex = 10;
            lblDisponible.Text = "Disponible";
            // 
            // lblOcupado
            // 
            lblOcupado.AutoSize = true;
            lblOcupado.Font = new Font("Segoe UI", 12F);
            lblOcupado.Location = new Point(51, 102);
            lblOcupado.Name = "lblOcupado";
            lblOcupado.Size = new Size(73, 21);
            lblOcupado.TabIndex = 11;
            lblOcupado.Text = "Ocupado";
            // 
            // iconDisponible
            // 
            iconDisponible.BackColor = Color.ForestGreen;
            iconDisponible.ForeColor = Color.CornflowerBlue;
            iconDisponible.Location = new Point(141, 74);
            iconDisponible.Name = "iconDisponible";
            iconDisponible.Size = new Size(19, 19);
            iconDisponible.TabIndex = 12;
            iconDisponible.UseCompatibleTextRendering = true;
            iconDisponible.UseVisualStyleBackColor = false;
            // 
            // iconOcupado
            // 
            iconOcupado.BackColor = Color.Red;
            iconOcupado.ForeColor = Color.CornflowerBlue;
            iconOcupado.Location = new Point(141, 105);
            iconOcupado.Name = "iconOcupado";
            iconOcupado.Size = new Size(19, 19);
            iconOcupado.TabIndex = 13;
            iconOcupado.UseCompatibleTextRendering = true;
            iconOcupado.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(505, 545);
            Controls.Add(iconOcupado);
            Controls.Add(iconDisponible);
            Controls.Add(lblOcupado);
            Controls.Add(lblDisponible);
            Controls.Add(lblSelecciona);
            Controls.Add(btnAsiento8);
            Controls.Add(btnAsiento7);
            Controls.Add(btnAsiento6);
            Controls.Add(btnAsiento5);
            Controls.Add(btnAsiento4);
            Controls.Add(btnAsiento3);
            Controls.Add(btnAsiento2);
            Controls.Add(btnAsiento1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Sistema de reservas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnAsiento1;
        private Button btnAsiento2;
        private Button btnAsiento4;
        private Button btnAsiento3;
        private Button btnAsiento6;
        private Button btnAsiento5;
        private Button btnAsiento8;
        private Button btnAsiento7;
        private Label lblSelecciona;
        private Label lblDisponible;
        private Label lblOcupado;
        private Button iconDisponible;
        private Button iconOcupado;
    }
}
