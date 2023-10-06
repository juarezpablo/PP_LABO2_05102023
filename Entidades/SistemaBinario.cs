using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        internal override double ValorNumerico
        {
            get
            {
                return double.Parse(valor);
            }
        }
        public SistemaBinario(string valor):base(valor) 
        { 
        }

        private SistemaDecimal BinarioADecimal()
        {
            return new SistemaDecimal(ValorNumerico.ToString());
        }
        public override Numeracion CambiarSistemaDeNumeracion(Esistema sistema)
        {
            switch (sistema)
            {
                case Esistema.Decimal:
                    return BinarioADecimal();
                    break;
                case Esistema.Octal:
                    SistemaDecimal nuevoSistema = BinarioADecimal();
                    return nuevoSistema.CambiarSistemaDeNumeracion(Esistema.Octal);
                    break;
                default:
                    return this;
                    break;
            }
        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor);
        }
        private bool EsSistemaBinarioValido(string valor)
        {
            return false;
        }
    }
}
