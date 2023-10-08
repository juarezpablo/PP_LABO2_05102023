using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Entidades
    
{
    public enum ESistema { Decimal, Binario, Octal};
    public abstract class Numeracion
    {
        protected static string msgError="Numero Invalido";
        protected string valor;
       

        public string Valor
        {
            get
            {
                return this.valor;
            }
        }
        internal abstract double ValorNumerico{ get ;}
            

       
        
        
        
        private Numeracion()       
        {
            
        }
        protected Numeracion(string valor)
        {
            InicializaValor(valor);
        }


        private void InicializaValor(string valor)
        {
            if (this.EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = msgError;
            }
        }

 
        

        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);
        protected virtual bool EsNumeracionValida(string valor)
        {
            bool retorno = Regex.IsMatch(valor, "[a-zA-Z]|\\s");

            return retorno;
        }
       

        public static bool operator  ==(Numeracion n1, Numeracion n2)
        {
            if((n1.GetType == n2.GetType)&& (n1.EsNumeracionValida(n1.Valor)&& n2.EsNumeracionValida(n2.Valor)))
            {
                return true;
            }
            else { return false; }
        }
        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            if ((n1.GetType == n2.GetType) && (n1.EsNumeracionValida(n1.Valor) && n2.EsNumeracionValida(n2.Valor)))
            {
                return false;
            }
            else { return true; }
        }



        
    }
}