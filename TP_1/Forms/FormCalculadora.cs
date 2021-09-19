using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Entidades;

namespace Forms
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            this.cboOperador.SelectedIndex = 4;
        }

        /// <summary>
        /// Limpia el formulario
        /// </summary>
        private void Limpiar()
        {
            this.txtOperandoDos.Text = string.Empty;
            this.txtOperandoUno.Text = string.Empty;
            this.cboOperador.Text = "";
            this.lblResultado.Text = "0";
            this.lstOperaciones.Items.Clear();
        }
   
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        /// <summary>
        /// Realiza la operacion pedida entre dos numeros
        /// </summary>
        /// <param name="numeroUno">Primer operando</param>
        /// <param name="numeroDos">Segundo operando</param>
        /// <param name="operador">Operador</param>
        /// <returns></returns>
        private static double Operar(string numeroUno, string numeroDos, string operador)
        {
            StringBuilder operacion = new StringBuilder();
            Operando operandoUno = new Operando(numeroUno);
            Operando operandoDos = new Operando(numeroDos);
           
            return Calculadora.Operar(operandoUno, operandoDos, char.Parse(operador));

            
        }

        private void brnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string resultado = FormCalculadora.Operar(this.txtOperandoUno.Text, this.txtOperandoDos.Text, this.cboOperador.SelectedItem.ToString()).ToString();
            lblResultado.Text = resultado;

            StringBuilder sb = new StringBuilder();
            if(this.cboOperador.SelectedItem.ToString() == " ")
                sb.AppendFormat("{0} + {1} = {2}", this.txtOperandoUno.Text, this.txtOperandoDos.Text, resultado);
            else
               sb.AppendFormat("{0} {1} {2} = {3}", this.txtOperandoUno.Text, this.cboOperador.SelectedItem.ToString(), this.txtOperandoDos.Text, resultado);
            this.lstOperaciones.Items.Add(sb.ToString());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Esta seguro que desea cerrar el programa?", "Confirmacion",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                this.Close();
        }

        private void btnConvertirBinario_Click(object sender, EventArgs e)
        {

            Operando resultado = new Operando();
            string resultadoBinario = resultado.DecimalBinario(this.lblResultado.Text);
            
            if (resultadoBinario == "Valor Invalido")
                MessageBox.Show("Error no se puede convertir a binario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.lblResultado.Text = resultadoBinario;
        }

        private void btnConvertirDecimal_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando();
            string resultadoDecimal = resultado.BinarioDecimal(this.lblResultado.Text);

            if (resultadoDecimal == "Valor Invalido")
                MessageBox.Show("Error no se puede convertir a binario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.lblResultado.Text = resultadoDecimal;
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Esta seguro que desea cerrar el programa?", "Confirmacion",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                e.Cancel = true;
        }
    }
}
