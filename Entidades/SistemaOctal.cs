using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaOctal : Numeracion
    {
        internal override double ValorNumerico
        {
            get
            {
                return double.Parse(valor);
            }
        }
        public SistemaOctal(string valor) : base(valor)
        {
        }

        private SistemaDecimal OctalADecimal()
        {
            return new SistemaDecimal(ValorNumerico.ToString());
        }
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            return null;
        }
        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor);
        }
        private bool EsSistemaOctalValido(string valor)
        {
            return false;
        }
    }
}
