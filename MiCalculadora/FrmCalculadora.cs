using Entidades;
namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        List<char> caracteres = new List<char> { ' ', '+', '-', '/', '*' };
        private Numeracion.Esistema sistema;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private Operacion calculadora;
        public FrmCalculadora()
        {
            InitializeComponent();
        }
        private void setResultado()
        {
            if(rdbBinario.Checked)
            {
                sistema = Numeracion.Esistema.Binario;
                lblResultado.Text = resultado.ConvertirA(sistema);
            }
            else if(rdbDecimal.Checked)
            {
                sistema = Numeracion.Esistema.Decimal;
                lblResultado.Text = resultado.Valor;

            }
            
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {

            Numeracion primerOperando = new Numeracion(Numeracion.Esistema.Decimal, txtPrimerOperador.Text);
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            Numeracion segundoOperando = new Numeracion(Numeracion.Esistema.Decimal, txtSegundoOperador.Text);
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
            Numeracion primerOperando = new Numeracion(Numeracion.Esistema.Decimal, txtPrimerOperador.Text);
            Numeracion segundoOperando = new Numeracion(Numeracion.Esistema.Decimal, txtSegundoOperador.Text);
            Operacion calculadora = new Operacion(primerOperando, segundoOperando);
            char tipoOperacion = (char)cmbOperacion.SelectedItem;
            resultado = calculadora.Operar(tipoOperacion);
            setResultado();
            //lblResultado.Text = resultado.Valor;

        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperacion.Items.Clear();
            cmbOperacion.DataSource = caracteres;
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            foreach(Control control in  cmbOperacion.Controls)
            {
                if (control is RadioButton && ((RadioButton)control).Checked)
                {
                    if(control.Text == "Decimal")
                    {
                        sistema = Numeracion.Esistema.Decimal;

                    }
                    else
                    {
                        sistema = Numeracion.Esistema.Binario;
                    }

                }
            }
            //setResultado();
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in cmbOperacion.Controls)
            {
                if (control is RadioButton && ((RadioButton)control).Checked)
                {
                    if (control.Text == "Decimal")
                    {
                        sistema = Numeracion.Esistema.Decimal;

                    }
                    else
                    {
                        sistema = Numeracion.Esistema.Binario;
                    }

                }
            }
        //    setResultado();
        }
    }
}