using Entidades;
namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        Numeracion.Esistema sistema;
        Numeracion primerOperando;
        Numeracion segundoOperando;
        Numeracion resultado;
        Operacion calculadora;
        public FrmCalculadora()
        {
            InitializeComponent();
        }
        private void setResultado()
        {

        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {

            Numeracion primerOperando = new Numeracion(Numeracion.Esistema.Decimal, txtPrimerOperador.Text);
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            Numeracion segundoOperando = new Numeracion(Numeracion.Esistema.Decimal, txtSegundoOperador.Text);
        }
    }
}