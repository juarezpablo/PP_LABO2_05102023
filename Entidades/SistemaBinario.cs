using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (this.EsSistemaBinarioValido(Valor))
            {
                string valorbinario = Valor;
                int potencias = valorbinario.Length - 1;
                double aux = 0;
                double acumuladorResultado = 0;
                foreach (char caracterNum in valorbinario)
                {
                    aux = Math.Pow(2, potencias);
                    acumuladorResultado = acumuladorResultado + (int.Parse(caracterNum.ToString()) * aux);
                    potencias--;
                }
                return new SistemaDecimal(acumuladorResultado.ToString());
            }
            else
            {
                
                return new SistemaDecimal(Double.MinValue.ToString()) ;
            }
        }
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            switch (sistema)
            {
                case ESistema.Decimal:
                    return BinarioADecimal();
                    break;
                case ESistema.Octal:
                    SistemaDecimal nuevoSistema = BinarioADecimal();
                    return nuevoSistema.CambiarSistemaDeNumeracion(ESistema.Octal);
                    break;
                default:
                    return this;
                    break;
            }
        }
        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor)&&this.EsSistemaBinarioValido(valor);
        }
        private bool EsSistemaBinarioValido(string valor)
        {

            return !Regex.IsMatch(valor, "[a-zA-Z]|\\s|[2-9]"); 
        }
    }
}
