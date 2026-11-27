namespace Calculadora
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
            txtPantalla = new TextBox();
            lblResultado = new Label();
            btnCE = new Button();
            btnBorrar = new Button();
            btnDivision = new Button();
            btnC = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMulti = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSuma = new Button();
            btnPunto = new Button();
            btn0 = new Button();
            btnSigno = new Button();
            btnIgual = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnResta = new Button();
            SuspendLayout();
            // 
            // txtPantalla
            // 
            txtPantalla.Location = new Point(12, 32);
            txtPantalla.Multiline = true;
            txtPantalla.Name = "txtPantalla";
            txtPantalla.Size = new Size(458, 50);
            txtPantalla.TabIndex = 1;
            txtPantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(420, 9);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 20);
            lblResultado.TabIndex = 2;
            lblResultado.TextAlign = ContentAlignment.TopCenter;
            lblResultado.UseWaitCursor = true;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(12, 110);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(100, 80);
            btnCE.TabIndex = 3;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(251, 110);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(100, 80);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "⌫";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(370, 110);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(100, 80);
            btnDivision.TabIndex = 3;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Location = new Point(130, 110);
            btnC.Name = "btnC";
            btnC.Size = new Size(100, 80);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 196);
            btn7.Name = "btn7";
            btn7.Size = new Size(100, 80);
            btn7.TabIndex = 3;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += numero_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(130, 196);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 80);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += numero_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(251, 196);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 80);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += numero_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(370, 196);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(100, 80);
            btnMulti.TabIndex = 3;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 282);
            btn4.Name = "btn4";
            btn4.Size = new Size(100, 80);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += numero_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(130, 282);
            btn5.Name = "btn5";
            btn5.Size = new Size(100, 80);
            btn5.TabIndex = 3;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += numero_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(251, 282);
            btn6.Name = "btn6";
            btn6.Size = new Size(100, 80);
            btn6.TabIndex = 3;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += numero_Click;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(370, 282);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(100, 80);
            btnSuma.TabIndex = 3;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            // 
            // btnPunto
            // 
            btnPunto.Location = new Point(12, 454);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(100, 80);
            btnPunto.TabIndex = 3;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += numero_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(130, 454);
            btn0.Name = "btn0";
            btn0.Size = new Size(100, 80);
            btn0.TabIndex = 3;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += numero_Click;
            // 
            // btnSigno
            // 
            btnSigno.Location = new Point(251, 454);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new Size(100, 80);
            btnSigno.TabIndex = 3;
            btnSigno.Text = "+/-";
            btnSigno.UseVisualStyleBackColor = true;
            btnSigno.Click += signo_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(370, 454);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(100, 80);
            btnIgual.TabIndex = 3;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 368);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 80);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += numero_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(130, 368);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 80);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += numero_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(251, 368);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 80);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += numero_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(370, 368);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(100, 80);
            btnResta.TabIndex = 3;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 553);
            Controls.Add(btnResta);
            Controls.Add(btn3);
            Controls.Add(btnIgual);
            Controls.Add(btnSigno);
            Controls.Add(btnSuma);
            Controls.Add(btn6);
            Controls.Add(btn2);
            Controls.Add(btnMulti);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn5);
            Controls.Add(btn1);
            Controls.Add(btnDivision);
            Controls.Add(btnPunto);
            Controls.Add(btn8);
            Controls.Add(btn4);
            Controls.Add(btnBorrar);
            Controls.Add(btn7);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(lblResultado);
            Controls.Add(txtPantalla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPantalla;
        private Label lblResultado;
        private Button btnCE;
        private Button btnBorrar;
        private Button btnDivision;
        private Button btnC;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMulti;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSuma;
        private Button btnPunto;
        private Button btn0;
        private Button btnSigno;
        private Button btnIgual;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnResta;
    }
}
