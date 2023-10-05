using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            PrimerOperando = primerOperando;
            SegundoOperando = segundoOperando;
        }
        public Numeracion PrimerOperando
        {
            get { return this.primerOperando; }
            set { this.primerOperando = value; }
        }
        public Numeracion SegundoOperando
        {
            get { return this.segundoOperando; }
            set { this.segundoOperando = value; }
        }

        public Numeracion Operar(char operador)
        {   
            switch (operador)
            {
                case '+':
                    return primerOperando + segundoOperando;
                    break;
                case '-':
                    return primerOperando - segundoOperando;
                    break;
                case '/':
                    return primerOperando / segundoOperando;
                    break;
                case '*':
                    return primerOperando * segundoOperando;
                    break;
                default: return primerOperando+segundoOperando;



            }
             ;
        }
    }
}

