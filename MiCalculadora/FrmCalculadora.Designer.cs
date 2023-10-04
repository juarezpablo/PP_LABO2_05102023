namespace MiCalculadora
{
    partial class FrmCalculadora
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
            groupBox1 = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            label1 = new Label();
            lblResultado = new Label();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            txtPrimerOperador = new TextBox();
            txtSegundoOperador = new TextBox();
            cmbOperacion = new ComboBox();
            btnOperar = new Button();
            btnCerrar = new Button();
            btnLimpiar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbBinario);
            groupBox1.Controls.Add(rdbDecimal);
            groupBox1.Location = new Point(212, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(204, 55);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(77, 24);
            rdbBinario.TabIndex = 1;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(57, 55);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(85, 24);
            rdbDecimal.TabIndex = 0;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 78);
            label1.Name = "label1";
            label1.Size = new Size(140, 37);
            label1.TabIndex = 1;
            label1.Text = "Resultado:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(370, 78);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 28);
            lblResultado.TabIndex = 2;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(103, 280);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(176, 28);
            lblPrimerOperador.TabIndex = 3;
            lblPrimerOperador.Text = "Primer Operador:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.Location = new Point(347, 280);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(114, 28);
            lblOperacion.TabIndex = 4;
            lblOperacion.Text = "Operacion:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(502, 280);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(195, 28);
            lblSegundoOperador.TabIndex = 5;
            lblSegundoOperador.Text = "Segundo Operador:";
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperador.Location = new Point(103, 319);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(192, 34);
            txtPrimerOperador.TabIndex = 6;
            txtPrimerOperador.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperador.Location = new Point(502, 319);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(195, 34);
            txtSegundoOperador.TabIndex = 7;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // cmbOperacion
            // 
            cmbOperacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperacion.Location = new Point(325, 317);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(151, 36);
            cmbOperacion.TabIndex = 8;
            // 
            // btnOperar
            // 
            btnOperar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(103, 375);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(192, 47);
            btnOperar.TabIndex = 9;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(301, 375);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(192, 47);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.BorderSize = 3;
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(502, 375);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(195, 47);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCerrar);
            Controls.Add(btnOperar);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FrmCalculadora";
            Text = "Calculadora Juarez Pablo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private Label label1;
        private Label lblResultado;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private TextBox txtPrimerOperador;
        private TextBox txtSegundoOperador;
        private ComboBox cmbOperacion;
        private Button btnOperar;
        private Button btnCerrar;
        private Button btnLimpiar;
    }
}