using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class SistemaDecimal : Numeracion

    {
        internal override  double ValorNumerico
        {
            get
            {
                return double.Parse(this.valor);
            }
        }
        public SistemaDecimal(string valor):base(valor) 
        {
           
        }
   

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            switch(sistema)
            {
                case ESistema.Binario:
                    return this.DecimalABinario();
                    break;
                case ESistema.Octal:
                    return this.DecimalAOctal();
                    break;
                default:
                    return this;
                    break;
                
            }

        }
        protected override bool EsNumeracionValida(string valor)
        {
            
            return (base.EsNumeracionValida(valor) && this.EsSistemaDecimalValido(valor));
        }

        private bool  EsSistemaDecimalValido (string valor)
        {
            double conversion;
            if (double.TryParse(valor, out conversion)) 
            { 
                return true;
            }
            else
            {
                return false;
            }
        }

        private SistemaBinario DecimalABinario()
        {
            if (ValorNumerico > 0)
            {
                string numeroBinario = string.Empty;
                int numero = int.Parse(valor);
                int resto;
                int resultadoDiv = numero;
                do
                {
                    resto = resultadoDiv % 2;
                    resultadoDiv = resultadoDiv / 2;
                    numeroBinario = resto.ToString() + numeroBinario;

                } while (resultadoDiv > 0);

                SistemaBinario nuevoBinario = new SistemaBinario(numeroBinario);
                return nuevoBinario;
            }
            else { return new SistemaBinario(msgError);   }

        }

        private SistemaOctal DecimalAOctal() 
        {
            if (ValorNumerico > 0)
            {
                string numeroOctal = string.Empty;
                int numero = int.Parse(valor);
                int resto;
                int resultadoDiv = numero;
                do
                {
                    resto = resultadoDiv % 8;
                    resultadoDiv = resultadoDiv / 8;
                    numeroOctal = resto.ToString() + numeroOctal;

                } while (resultadoDiv > 8);

                SistemaOctal nuevoOctal = new SistemaOctal(numeroOctal);
                return nuevoOctal;
            }
            else { return new SistemaOctal(msgError); }
        }
    }
}
