using Entidades;

namespace MiCalculadora
{

    public partial class FrmCalculadora : Form
    {
        //List<char> caracteres = new List<char> { ' ', '+', '-', '/', '*' };
        private Calculadora calculadora;
        
        public FrmCalculadora()
        {
            InitializeComponent();
            this.calculadora = new Calculadora("Nombre y Apellido");
        }




        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cierre = MessageBox.Show("Desea cerrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cierre == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;
            calculadora.PrimerOperando =
            this.GetOperando(this.txtPrimerOperando.Text);
            calculadora.SegundoOperando =
            this.GetOperando(this.txtSegundoOperando.Text);
            operador = (char)this.cmbOperacion.SelectedItem;
            this.calculadora.Calcular(operador);
            //  this.calculadora.ActualizaHistorialDeOperaciones(operador);
            this.lblResultado.Text = $"Resultado:{calculadora.Resultado.Valor}";
            //   this.MostrarHistorial();

        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.DataSource = new char[] { '+', '-', '*', '/' };
        }
        private Numeracion GetOperando(string value)
        {
            if (Calculadora.Sistema == ESistema.Binario)
            {
                return new SistemaBinario(value);
            }
            return new SistemaDecimal(value);
        }


        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (Control control in cmbOperacion.Controls)
            //{
            //   if (control is RadioButton && ((RadioButton)control).Checked)
            //   {
            //       if (control.Text == "Decimal")
            //       {
            //           sistema = Numeracion.Esistema.Decimal;
            //
            //      }
            //       else
            //      {
            //          sistema = Numeracion.Esistema.Binario;
            //      }

            //  }
            // }
            Calculadora.Sistema = ESistema.Binario;


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //  this.calculadora.EliminarHistorialDeOperaciones();
            //   this.txtPrimerOperando.Text = string.Empty;
            // this.txtSegundoOperando.Text = string.Empty;
            // this.lblResultado.Text = $"Resultado:";
            //  this.MostrarHistorial();
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Decimal;
        }

        private void rdbOctal_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Octal;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}