using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseOchoEjercicio8
{
    class Metro
    {
        public float CantidadDeMetros;

        private Metro()
        { }

        private Metro(float CantDeMetro)
        {
            this.CantidadDeMetros = CantDeMetro;
        }

        public static Metro operator +(Metro MetroUno, Centimetro CentiUno)
        {
            return new Metro(MetroUno.CantidadDeMetros + (CentiUno.CantidadDeCentimetros/100));
        }

        //Operador de casteo. Explicit e Implicit. Explicit es cuando le tenés que especificar.
        public static implicit operator Metro(float numero)
        {
            return new Metro(numero);
        }
    }
}
