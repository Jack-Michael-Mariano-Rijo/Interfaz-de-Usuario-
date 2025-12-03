namespace Tarea_1
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
            buttonCarcular = new Button();
            labelSuma = new Label();
            labelResta = new Label();
            labelMultiplicacion = new Label();
            labelDivision = new Label();
            textBoxNumero1 = new TextBox();
            textBoxNumero2 = new TextBox();
            SuspendLayout();
            // 
            // buttonCarcular
            // 
            buttonCarcular.Location = new Point(448, 378);
            buttonCarcular.Name = "buttonCarcular";
            buttonCarcular.Size = new Size(94, 29);
            buttonCarcular.TabIndex = 0;
            buttonCarcular.Text = "Carcular";
            buttonCarcular.UseVisualStyleBackColor = true;
            buttonCarcular.Click += buttonCarcular_Click;
            // 
            // labelSuma
            // 
            labelSuma.AutoSize = true;
            labelSuma.Location = new Point(61, 192);
            labelSuma.Name = "labelSuma";
            labelSuma.Size = new Size(46, 20);
            labelSuma.TabIndex = 1;
            labelSuma.Text = "Suma";
            // 
            // labelResta
            // 
            labelResta.AutoSize = true;
            labelResta.Location = new Point(171, 192);
            labelResta.Name = "labelResta";
            labelResta.Size = new Size(45, 20);
            labelResta.TabIndex = 2;
            labelResta.Text = "Resta";
            // 
            // labelMultiplicacion
            // 
            labelMultiplicacion.AutoSize = true;
            labelMultiplicacion.Location = new Point(278, 192);
            labelMultiplicacion.Name = "labelMultiplicacion";
            labelMultiplicacion.Size = new Size(103, 20);
            labelMultiplicacion.TabIndex = 3;
            labelMultiplicacion.Text = "Multiplicacion";
            // 
            // labelDivision
            // 
            labelDivision.AutoSize = true;
            labelDivision.Location = new Point(423, 192);
            labelDivision.Name = "labelDivision";
            labelDivision.Size = new Size(62, 20);
            labelDivision.TabIndex = 4;
            labelDivision.Text = "Division";
            // 
            // textBoxNumero1
            // 
            textBoxNumero1.Location = new Point(61, 87);
            textBoxNumero1.Name = "textBoxNumero1";
            textBoxNumero1.Size = new Size(125, 27);
            textBoxNumero1.TabIndex = 5;
            // 
            // textBoxNumero2
            // 
            textBoxNumero2.Location = new Point(360, 87);
            textBoxNumero2.Name = "textBoxNumero2";
            textBoxNumero2.Size = new Size(125, 27);
            textBoxNumero2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 455);
            Controls.Add(textBoxNumero2);
            Controls.Add(textBoxNumero1);
            Controls.Add(labelDivision);
            Controls.Add(labelMultiplicacion);
            Controls.Add(labelResta);
            Controls.Add(labelSuma);
            Controls.Add(buttonCarcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCarcular;
        private Label labelSuma;
        private Label labelResta;
        private Label labelMultiplicacion;
        private Label labelDivision;
        private TextBox textBoxNumero1;
        private TextBox textBoxNumero2;
    }
}
