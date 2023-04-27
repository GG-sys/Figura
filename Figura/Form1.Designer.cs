namespace Figura
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
            inputRaio = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            inputBase = new TextBox();
            label8 = new Label();
            label9 = new Label();
            inputAltura = new TextBox();
            label10 = new Label();
            inputAlturaT = new TextBox();
            button3 = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            inputBaseT = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(116, 103);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 0;
            label1.Text = "Círculo";
            // 
            // inputRaio
            // 
            inputRaio.Location = new Point(116, 149);
            inputRaio.Name = "inputRaio";
            inputRaio.Size = new Size(100, 23);
            inputRaio.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 152);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 2;
            label2.Text = "Raio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 262);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 3;
            label3.Text = "Área: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 261);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 4;
            label4.Text = "area";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(74, 332);
            button1.Name = "button1";
            button1.Size = new Size(181, 23);
            button1.TabIndex = 5;
            button1.Text = "Calcular área do círculo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(310, 332);
            button2.Name = "button2";
            button2.Size = new Size(181, 23);
            button2.TabIndex = 11;
            button2.Text = "Calcular área do Retangulo";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 257);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 10;
            label5.Text = "area";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(326, 258);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 9;
            label6.Text = "Área: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(310, 152);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 8;
            label7.Text = "Comprimento:";
            // 
            // inputBase
            // 
            inputBase.Location = new Point(401, 149);
            inputBase.Name = "inputBase";
            inputBase.Size = new Size(51, 23);
            inputBase.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(352, 99);
            label8.Name = "label8";
            label8.Size = new Size(71, 17);
            label8.TabIndex = 6;
            label8.Text = "Retangulo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(310, 195);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 13;
            label9.Text = "Altura: ";
            label9.Click += label9_Click;
            // 
            // inputAltura
            // 
            inputAltura.Location = new Point(361, 192);
            inputAltura.Name = "inputAltura";
            inputAltura.Size = new Size(91, 23);
            inputAltura.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(570, 198);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 21;
            label10.Text = "Altura";
            // 
            // inputAlturaT
            // 
            inputAlturaT.Location = new Point(612, 195);
            inputAlturaT.Name = "inputAlturaT";
            inputAlturaT.Size = new Size(100, 23);
            inputAlturaT.TabIndex = 20;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 64, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(570, 335);
            button3.Name = "button3";
            button3.Size = new Size(181, 23);
            button3.TabIndex = 19;
            button3.Text = "Calcular área do Triângulo";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(667, 260);
            label11.Name = "label11";
            label11.Size = new Size(29, 15);
            label11.TabIndex = 18;
            label11.Text = "area";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(586, 261);
            label12.Name = "label12";
            label12.Size = new Size(37, 15);
            label12.TabIndex = 17;
            label12.Text = "Área: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(570, 155);
            label13.Name = "label13";
            label13.Size = new Size(31, 15);
            label13.TabIndex = 16;
            label13.Text = "Base";
            // 
            // inputBaseT
            // 
            inputBaseT.Location = new Point(612, 152);
            inputBaseT.Name = "inputBaseT";
            inputBaseT.Size = new Size(100, 23);
            inputBaseT.TabIndex = 15;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(612, 102);
            label14.Name = "label14";
            label14.Size = new Size(67, 17);
            label14.TabIndex = 14;
            label14.Text = "Triângulo";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(206, 262);
            label15.Name = "label15";
            label15.Size = new Size(28, 15);
            label15.TabIndex = 22;
            label15.Text = "cm²";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(442, 257);
            label16.Name = "label16";
            label16.Size = new Size(28, 15);
            label16.TabIndex = 23;
            label16.Text = "cm³";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(702, 260);
            label17.Name = "label17";
            label17.Size = new Size(28, 15);
            label17.TabIndex = 24;
            label17.Text = "cm²";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(inputAlturaT);
            Controls.Add(button3);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(inputBaseT);
            Controls.Add(label14);
            Controls.Add(label9);
            Controls.Add(inputAltura);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(inputBase);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inputRaio);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputRaio;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox inputBase;
        private Label label8;
        private Label label9;
        private TextBox inputAltura;
        private Label label10;
        private TextBox inputAlturaT;
        private Button button3;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox inputBaseT;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}