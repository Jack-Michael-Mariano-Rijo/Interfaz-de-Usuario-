namespace Tarea_2
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
            buttonPromedio = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            labelNota1 = new Label();
            labelNota2 = new Label();
            labelNota3 = new Label();
            labelNota4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonPromedio
            // 
            buttonPromedio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPromedio.Location = new Point(232, 319);
            buttonPromedio.Name = "buttonPromedio";
            buttonPromedio.Size = new Size(133, 29);
            buttonPromedio.TabIndex = 0;
            buttonPromedio.Text = "ver promedio";
            buttonPromedio.UseVisualStyleBackColor = true;
            buttonPromedio.Click += buttonCarcular_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(457, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(457, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(63, 233);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 6;
            // 
            // labelNota1
            // 
            labelNota1.AutoSize = true;
            labelNota1.Location = new Point(3, 144);
            labelNota1.Name = "labelNota1";
            labelNota1.Size = new Size(54, 20);
            labelNota1.TabIndex = 7;
            labelNota1.Text = "Nota 1";
            // 
            // labelNota2
            // 
            labelNota2.AutoSize = true;
            labelNota2.Location = new Point(3, 233);
            labelNota2.Name = "labelNota2";
            labelNota2.Size = new Size(54, 20);
            labelNota2.TabIndex = 8;
            labelNota2.Text = "Nota 2";
            // 
            // labelNota3
            // 
            labelNota3.AutoSize = true;
            labelNota3.Location = new Point(401, 147);
            labelNota3.Name = "labelNota3";
            labelNota3.Size = new Size(54, 20);
            labelNota3.TabIndex = 9;
            labelNota3.Text = "Nota 3";
            // 
            // labelNota4
            // 
            labelNota4.AutoSize = true;
            labelNota4.Location = new Point(401, 236);
            labelNota4.Name = "labelNota4";
            labelNota4.Size = new Size(54, 20);
            labelNota4.TabIndex = 10;
            labelNota4.Text = "Nota 4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 80);
            label1.Name = "label1";
            label1.Size = new Size(271, 28);
            label1.TabIndex = 11;
            label1.Text = "Promedio De un Estudiante";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 450);
            Controls.Add(label1);
            Controls.Add(labelNota4);
            Controls.Add(labelNota3);
            Controls.Add(labelNota2);
            Controls.Add(labelNota1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonPromedio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPromedio;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label labelNota1;
        private Label labelNota2;
        private Label labelNota3;
        private Label labelNota4;
        private Label label1;
    }
}
