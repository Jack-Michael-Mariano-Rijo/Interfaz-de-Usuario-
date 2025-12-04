namespace Tarea_3
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
            label2 = new Label();
            labelAFP = new Label();
            labelSFS = new Label();
            labelBruto = new Label();
            labelNeto = new Label();
            button1 = new Button();
            buttonLimpiar = new Button();
            buttonsalir = new Button();
            labelDesc = new Label();
            labelTotalDesc = new Label();
            textBoxPagoporhora = new TextBox();
            textBoxHoratrabajadas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 68);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 2;
            label1.Text = "Pago por hora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 68);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 3;
            label2.Text = "Horas trabajadas";
            // 
            // labelAFP
            // 
            labelAFP.AutoSize = true;
            labelAFP.Location = new Point(58, 191);
            labelAFP.Name = "labelAFP";
            labelAFP.Size = new Size(34, 20);
            labelAFP.TabIndex = 4;
            labelAFP.Text = "AFP";
            // 
            // labelSFS
            // 
            labelSFS.AutoSize = true;
            labelSFS.Location = new Point(197, 191);
            labelSFS.Name = "labelSFS";
            labelSFS.Size = new Size(32, 20);
            labelSFS.TabIndex = 5;
            labelSFS.Text = "SFS";
            // 
            // labelBruto
            // 
            labelBruto.AutoSize = true;
            labelBruto.Location = new Point(349, 191);
            labelBruto.Name = "labelBruto";
            labelBruto.Size = new Size(45, 20);
            labelBruto.TabIndex = 6;
            labelBruto.Text = "Bruto";
            // 
            // labelNeto
            // 
            labelNeto.AutoSize = true;
            labelNeto.Location = new Point(505, 191);
            labelNeto.Name = "labelNeto";
            labelNeto.Size = new Size(42, 20);
            labelNeto.TabIndex = 7;
            labelNeto.Text = "Neto";
            // 
            // button1
            // 
            button1.Location = new Point(469, 344);
            button1.Name = "button1";
            button1.Size = new Size(142, 29);
            button1.TabIndex = 8;
            button1.Text = "Carcular Promedio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(265, 344);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(107, 29);
            buttonLimpiar.TabIndex = 9;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonsalir
            // 
            buttonsalir.Location = new Point(39, 344);
            buttonsalir.Name = "buttonsalir";
            buttonsalir.Size = new Size(83, 29);
            buttonsalir.TabIndex = 10;
            buttonsalir.Text = "Salir";
            buttonsalir.UseVisualStyleBackColor = true;
            buttonsalir.Click += buttonsalir_Click;
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Location = new Point(58, 265);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(41, 20);
            labelDesc.TabIndex = 11;
            labelDesc.Text = "Desc";
            // 
            // labelTotalDesc
            // 
            labelTotalDesc.AutoSize = true;
            labelTotalDesc.Location = new Point(197, 265);
            labelTotalDesc.Name = "labelTotalDesc";
            labelTotalDesc.Size = new Size(74, 20);
            labelTotalDesc.TabIndex = 12;
            labelTotalDesc.Text = "TotalDesc";
            // 
            // textBoxPagoporhora
            // 
            textBoxPagoporhora.Location = new Point(132, 91);
            textBoxPagoporhora.Name = "textBoxPagoporhora";
            textBoxPagoporhora.Size = new Size(125, 27);
            textBoxPagoporhora.TabIndex = 13;
            // 
            // textBoxHoratrabajadas
            // 
            textBoxHoratrabajadas.Location = new Point(391, 91);
            textBoxHoratrabajadas.Name = "textBoxHoratrabajadas";
            textBoxHoratrabajadas.Size = new Size(134, 27);
            textBoxHoratrabajadas.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 415);
            Controls.Add(textBoxHoratrabajadas);
            Controls.Add(textBoxPagoporhora);
            Controls.Add(labelTotalDesc);
            Controls.Add(labelDesc);
            Controls.Add(buttonsalir);
            Controls.Add(buttonLimpiar);
            Controls.Add(button1);
            Controls.Add(labelNeto);
            Controls.Add(labelBruto);
            Controls.Add(labelSFS);
            Controls.Add(labelAFP);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label labelAFP;
        private Label labelSFS;
        private Label labelBruto;
        private Label labelNeto;
        private Button button1;
        private Button buttonLimpiar;
        private Button buttonsalir;
        private Label labelDesc;
        private Label labelTotalDesc;
        private TextBox textBoxPagoporhora;
        private TextBox textBoxHoratrabajadas;
    }
}
