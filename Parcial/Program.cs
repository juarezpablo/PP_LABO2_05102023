using System.Drawing;
using System.Text.RegularExpressions;

namespace Parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string valor = "000101";
            bool retorno = Regex.IsMatch(valor, "[a-zA-Z]|\\s");
            //Console.WriteLine(retorno);

            bool retornoTest2;
            double conversion;
            if (double.TryParse(valor, out conversion))
            {
                retornoTest2=true;
            }
            else
            {
               retornoTest2= false;
            }
           // Console.WriteLine(retornoTest2);

            bool retornoTest3= !Regex.IsMatch(valor, "[a-zA-Z]|\\s|[2-9]");
          //  Console.WriteLine(retornoTest3);

            //----Binario a Decimal----//
            string valorbinario = "101001";
            int potencias = valorbinario.Length-1;
            double aux = 0;   
            double acumuladorResultado=0;          
            foreach(char caracterNum in valorbinario)
            {
                aux=Math.Pow(2, potencias);
                acumuladorResultado = acumuladorResultado +(int.Parse(caracterNum.ToString()) *aux);
                potencias--;
            }

            Console.WriteLine (acumuladorResultado);
            //--------------------------------//




        }
    
    }
}