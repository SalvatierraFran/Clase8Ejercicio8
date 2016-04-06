using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseOchoEjercicio8
{
    class Centimetro
    {
        public float CantidadDeCentimetros;

        private Centimetro()
        { }

        private Centimetro(float CantDeCentimetros)
        {
            this.CantidadDeCentimetros = CantDeCentimetros;
        }

        public static Centimetro operator +(Centimetro CentiUno, Centimetro CentiDos)
        {
            return new Centimetro(CentiUno.CantidadDeCentimetros + CentiDos.CantidadDeCentimetros);
        }

        public static Centimetro operator +(Centimetro CentiUno, Metro MetroUno)
        {
            return new Centimetro(CentiUno.CantidadDeCentimetros + (MetroUno.CantidadDeMetros*100));
        }

        public static Centimetro operator ++(Centimetro CentiUno)
        {
            return new Centimetro(CentiUno.CantidadDeCentimetros++);
        }

        public static bool operator ==(Centimetro CentiDos, Metro MetroUno)
        {
            float resul1 = MetroUno.CantidadDeMetros * 100;
            float Reul2 = CentiDos.CantidadDeCentimetros;

            bool resultado = CentiDos.CantidadDeCentimetros == (MetroUno.CantidadDeMetros*100);

            return resultado;
        }

        public static bool operator !=(Centimetro CentiDos, Metro MetroUno)
        {
            return !(CentiDos.CantidadDeCentimetros == (MetroUno.CantidadDeMetros*100));
        }

        public static implicit operator Centimetro(float numero)
        {
            return new Centimetro(numero);
        }
    }
}
