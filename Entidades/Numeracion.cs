using System.Runtime.CompilerServices;



namespace Entidades
    
{
    public enum Esistema { Decimal, Binario, Octal};
    public abstract class Numeracion
    {
        static protected string msgError;
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
            this.valor = valor;
        }

 
        

        public abstract Numeracion CambiarSistemaDeNumeracion(Esistema sistema);
        protected virtual bool EsNumeracionValida(string valor)
        {
            return false;
        }
       

        private string DecimalABinario(string valor)
        {
            //convertir de decimal a binario y retornarlo como string
            string numeroBinario=string.Empty;
            int numero=int.Parse(valor);
            int resto;
            int resultadoDiv=numero;
            do
            {
                resto = resultadoDiv % 2;
                resultadoDiv = resultadoDiv / 2;
                numeroBinario=resto.ToString()+numeroBinario;

            } while (resultadoDiv > 0);

            return numeroBinario ;
        }
        

       
      //  public static bool operator ==(Numeracion n1, Numeracion n2)
      //  {
      //      return n1.sistema == n2.sistema;
      //  }
      //  public static bool operator !=(Numeracion n1, Numeracion n2)
      //  {
      //      return !(n1== n2);
      //  }
      //  public static bool operator ==( Esistema sistema, Numeracion n1)
      //  {
      //      return n1.Sistema==sistema;
      //  }
      //  public static bool operator!=(Esistema sistema, Numeracion n1)
      //  {
      //      return !(n1.Sistema == sistema);
      //  }
    }
}