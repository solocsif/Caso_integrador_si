﻿namespace WinFormsApp1
{
    partial class Gestion_de_Inmueble
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(113, 39);
            label1.Name = "label1";
            label1.Size = new Size(250, 31);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Inmuebles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(28, 118);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Inmueble";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(28, 182);
            label3.Name = "label3";
            label3.Size = new Size(163, 28);
            label3.TabIndex = 2;
            label3.Text = "Numero de Matricula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(28, 244);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(28, 362);
            label5.Name = "label5";
            label5.Size = new Size(58, 28);
            label5.TabIndex = 4;
            label5.Text = "Barrio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(28, 302);
            label6.Name = "label6";
            label6.Size = new Size(72, 28);
            label6.TabIndex = 5;
            label6.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(28, 427);
            label7.Name = "label7";
            label7.Size = new Size(47, 28);
            label7.TabIndex = 6;
            label7.Text = "Zona";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(28, 487);
            label8.Name = "label8";
            label8.Size = new Size(137, 28);
            label8.TabIndex = 7;
            label8.Text = "Precio de Alquiler";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(28, 549);
            label9.Name = "label9";
            label9.Size = new Size(96, 28);
            label9.TabIndex = 8;
            label9.Text = "Descripcion";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Casa", "Apartamento" });
            comboBox1.Location = new Point(278, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(278, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(278, 251);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(278, 309);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(278, 367);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(278, 432);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(171, 23);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(278, 492);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(171, 23);
            textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(272, 561);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(177, 91);
            textBox7.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(28, 683);
            button1.Name = "button1";
            button1.Size = new Size(95, 32);
            button1.TabIndex = 17;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(138, 683);
            button2.Name = "button2";
            button2.Size = new Size(95, 32);
            button2.TabIndex = 18;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(248, 683);
            button3.Name = "button3";
            button3.Size = new Size(95, 32);
            button3.TabIndex = 19;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(354, 683);
            button4.Name = "button4";
            button4.Size = new Size(95, 32);
            button4.TabIndex = 20;
            button4.Text = "Iniciar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Gestion_de_Inmueble
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 749);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Gestion_de_Inmueble";
            Text = "Gestion_de_Inmueble";
            Load += Gestion_de_Inmueble_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}