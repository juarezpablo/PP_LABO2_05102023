using System;
using System.Collections.Generic;
using System.Linq;
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
        private static Esistema sistema;

        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public List<string> Operaciones { get => operaciones; }
        public Numeracion PrimerOperando { get => primerOperando; set => primerOperando = value; }
        public Numeracion Resultado { get => resultado; }
        public Numeracion SegundoOperando { get => segundoOperando; set => segundoOperando = value; }
        public Esistema Sistema { get => sistema; set => sistema = value; }


        private Calculadora() 
        { 
            
        }
        public Calculadora()
        {
            List<string> operaciones = new List<string>();
        }
        public Calculadora(string nombreAlumno)
        {
            NombreAlumno = nombreAlumno;
           
        }

        public void Calcular()
        {

        }
        public void Calcular(char operador)
        {
            
        }
        private Numeracion MapeaResultado(double valor)
        {
            return new Numeracion(valor);
        }
    }
}
