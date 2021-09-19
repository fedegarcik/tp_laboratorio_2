
namespace Forms
{
    partial class FormCalculadora
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
            this.txtOperandoDos = new System.Windows.Forms.TextBox();
            this.txtOperandoUno = new System.Windows.Forms.TextBox();
            this.cboOperador = new System.Windows.Forms.ComboBox();
            this.btnConvertirBinario = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.brnLimpiar = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnConvertirDecimal = new System.Windows.Forms.Button();
            this.lstOperaciones = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOperandoDos
            // 
            this.txtOperandoDos.Location = new System.Drawing.Point(309, 51);
            this.txtOperandoDos.MaxLength = 9;
            this.txtOperandoDos.Name = "txtOperandoDos";
            this.txtOperandoDos.Size = new System.Drawing.Size(93, 23);
            this.txtOperandoDos.TabIndex = 3;
            // 
            // txtOperandoUno
            // 
            this.txtOperandoUno.Location = new System.Drawing.Point(12, 51);
            this.txtOperandoUno.MaxLength = 9;
            this.txtOperandoUno.Name = "txtOperandoUno";
            this.txtOperandoUno.Size = new System.Drawing.Size(94, 23);
            this.txtOperandoUno.TabIndex = 1;
            // 
            // cboOperador
            // 
            this.cboOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperador.FormattingEnabled = true;
            this.cboOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            " "});
            this.cboOperador.Location = new System.Drawing.Point(144, 51);
            this.cboOperador.Name = "cboOperador";
            this.cboOperador.Size = new System.Drawing.Size(121, 23);
            this.cboOperador.TabIndex = 2;
            // 
            // btnConvertirBinario
            // 
            this.btnConvertirBinario.Location = new System.Drawing.Point(12, 168);
            this.btnConvertirBinario.Name = "btnConvertirBinario";
            this.btnConvertirBinario.Size = new System.Drawing.Size(149, 38);
            this.btnConvertirBinario.TabIndex = 7;
            this.btnConvertirBinario.Text = "Convertir a Binario";
            this.btnConvertirBinario.UseVisualStyleBackColor = true;
            this.btnConvertirBinario.Click += new System.EventHandler(this.btnConvertirBinario_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(309, 97);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 34);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // brnLimpiar
            // 
            this.brnLimpiar.Location = new System.Drawing.Point(144, 97);
            this.brnLimpiar.Name = "brnLimpiar";
            this.brnLimpiar.Size = new System.Drawing.Size(121, 34);
            this.brnLimpiar.TabIndex = 5;
            this.brnLimpiar.Text = "Limpiar";
            this.brnLimpiar.UseVisualStyleBackColor = true;
            this.brnLimpiar.Click += new System.EventHandler(this.brnLimpiar_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(12, 97);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(94, 34);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnConvertirDecimal
            // 
            this.btnConvertirDecimal.Location = new System.Drawing.Point(263, 168);
            this.btnConvertirDecimal.Name = "btnConvertirDecimal";
            this.btnConvertirDecimal.Size = new System.Drawing.Size(139, 38);
            this.btnConvertirDecimal.TabIndex = 8;
            this.btnConvertirDecimal.Text = "Convertir a Decimal";
            this.btnConvertirDecimal.UseVisualStyleBackColor = true;
            this.btnConvertirDecimal.Click += new System.EventHandler(this.btnConvertirDecimal_Click);
            // 
            // lstOperaciones
            // 
            this.lstOperaciones.Enabled = false;
            this.lstOperaciones.FormattingEnabled = true;
            this.lstOperaciones.ItemHeight = 15;
            this.lstOperaciones.Location = new System.Drawing.Point(473, 23);
            this.lstOperaciones.Name = "lstOperaciones";
            this.lstOperaciones.Size = new System.Drawing.Size(298, 184);
            this.lstOperaciones.TabIndex = 8;
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblResultado.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(12, 9);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(390, 29);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "0";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 221);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lstOperaciones);
            this.Controls.Add(this.btnConvertirDecimal);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.brnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnConvertirBinario);
            this.Controls.Add(this.cboOperador);
            this.Controls.Add(this.txtOperandoUno);
            this.Controls.Add(this.txtOperandoDos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora De  Federico Garcik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOperandoDos;
        private System.Windows.Forms.TextBox txtOperandoUno;
        private System.Windows.Forms.ComboBox cboOperador;
        private System.Windows.Forms.Button btnConvertirBinario;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button brnLimpiar;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnConvertirDecimal;
        private System.Windows.Forms.ListBox lstOperaciones;
        private System.Windows.Forms.Label lblResultado;
    }
}

