using System.Runtime.CompilerServices;



namespace Entidades
{
    public class Numeracion
    {
        public enum Esistema { Decimal, Binario };
        private Esistema sistema;
        private double valorNumerico;
        
        
        public string Valor
            {
            get
                {
                    return this.valorNumerico.ToString();
                 }
            
            }
        public Numeracion(Esistema sistema,double valorNum)
            
        {
            this.sistema=sistema;
            this.valorNumerico=valorNum;
        }
        public Numeracion(Esistema sistema, string valor)
        {
            InicializarValores(sistema, valor);
        }


        private void InicializarValores(Esistema sistema,string valor)
        {
            if (sistema == Esistema.Binario && EsBinario(valor))
            {
                this.valorNumerico=BinarioADecimal(valor);
            }
            else
            {
                sistema=Esistema.Decimal;
                this.valorNumerico = int.Parse(valor);
            }
        }

        private bool EsBinario(string valor)
        {
            bool retorno=false;
            foreach(char numero in valor)
            {
                if(numero.Equals(0) || numero.Equals(1))
                {
                    retorno=true;
                }
                else
                {
                    retorno=false;
                }
            }
            return retorno;
        }

        public string ConvertirA(Esistema sistema)
        {
           
            if (sistema == Esistema.Binario)
            {
                return DecimalABinario(Valor);
            }
            else
            {
                return BinarioADecimal(Valor).ToString();
            }
        }

        private double BinarioADecimal(string valor)
        {
            if (EsBinario(valor))
            {
                //conversion binario a decimal y retorno el resultado tipo double
                
                double largo = valor.Length;
                double aux =0;
                double acumulador = 0;
                foreach(char numero in valor)
                {
                    if (numero.Equals(1))
                    {
                        acumulador = acumulador + Math.Pow(2, (largo - aux));

                    }
                    aux++;
                }
                return acumulador;
            }
            else
            {
                return 0;
            }
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
        private string DecimalABinario(int valor)
        {
            return "0";
        }

        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
             double resultado =n1.valorNumerico + n2.valorNumerico;
             Numeracion nuevoNum = new Numeracion(Esistema.Decimal,resultado);
             return nuevoNum;
        }

        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            double resultado = n1.valorNumerico - n2.valorNumerico;
            Numeracion nuevoNum = new Numeracion(Esistema.Decimal, resultado);
            return nuevoNum;
        }

        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            double resultado = n1.valorNumerico / n2.valorNumerico;
            Numeracion nuevoNum = new Numeracion(Esistema.Decimal, resultado);
            return nuevoNum;
        }
        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            double resultado = n1.valorNumerico * n2.valorNumerico;
            Numeracion nuevoNum = new Numeracion(Esistema.Decimal, resultado);
            return nuevoNum;
        }
    }
}