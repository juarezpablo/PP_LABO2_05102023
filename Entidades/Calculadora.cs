using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        private static ESistema sistema= ESistema.Decimal;

        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public List<string> Operaciones { get => operaciones; }
        public Numeracion PrimerOperando { get => primerOperando; set => primerOperando = value; }
        public Numeracion Resultado { get => resultado; }
        public Numeracion SegundoOperando { get => segundoOperando; set => segundoOperando = value; }
        public static ESistema Sistema { get => sistema; set => sistema = value; }

        
        
        public Calculadora() 
        {
            this.Calcular();
            
            List<string> operaciones = new List<string>();
        }
        public Calculadora(string nombreAlumno)
        {
            NombreAlumno = nombreAlumno;
           
        }

        public void Calcular()
        {
            double valorEcuacion;
            if (this.primerOperando == this.segundoOperando)
            {
                valorEcuacion = primerOperando.ValorNumerico + segundoOperando.ValorNumerico;
            }
            else
            {
                valorEcuacion = double.MinValue;
            }
            this.resultado = this.MapeaResultado(valorEcuacion);

        }
        public void Calcular(char operador)
        {
            double valorEcuacion;
            if (this.primerOperando == this.segundoOperando)
            {
                switch (operador)
                {
                    case '-':
                        valorEcuacion = primerOperando.ValorNumerico - segundoOperando.ValorNumerico;
                        break;
                    case '*':
                        valorEcuacion = primerOperando.ValorNumerico * segundoOperando.ValorNumerico;
                        break;
                    case '/':
                        valorEcuacion = primerOperando.ValorNumerico / segundoOperando.ValorNumerico;
                        break;
                    default:
                        valorEcuacion = primerOperando.ValorNumerico + segundoOperando.ValorNumerico;
                        break;
                }
            }
            else
            {
                valorEcuacion = double.MinValue;
            }
            this.resultado=this.MapeaResultado(valorEcuacion);
           // double valorNumResultado = (primerOperando.ValorNumerico)operador (segundoOperando.ValorNumerico);
           
        }
        private Numeracion MapeaResultado(double valor)
        {

            switch (Sistema)
            {
                case ESistema.Decimal:
                    return new SistemaDecimal(valor.ToString());
                    break;
                case ESistema.Binario:
                    return new SistemaBinario(valor.ToString());
                    break;
                default:
                    return new SistemaOctal(valor.ToString());
                    break;
            }
            
        }

        public void ActualizarHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Sistema:{Calculadora.Sistema.ToString()}");
            sb.AppendLine($"Primer Operado:{primerOperando.Valor}");
            sb.AppendLine($"Segundo Operando:{segundoOperando.Valor}");
            sb.AppendLine($"Operado:{operador.ToString()}");
            this.operaciones.Add( sb.ToString());
        }
    }
}
