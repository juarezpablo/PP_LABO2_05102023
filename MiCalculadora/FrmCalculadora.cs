using Entidades;
namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        List<char> caracteres = new List<char> { ' ', '+', '-', '/', '*' };

        public FrmCalculadora()
        {
            InitializeComponent();
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


        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            
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
           
        }
    }
}