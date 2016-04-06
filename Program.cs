using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseOchoEjercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Centimetro UnoC = new Centimetro(10f);
            //Centimetro DosC = new Centimetro(110F);

            Centimetro UnoC;
            UnoC = 10F;

            Centimetro DosC;
            DosC = 110F;

            //Metro UnoM = new Metro(1F);
            //Metro DosM = new Metro(10f);

            Metro UnoM;
            UnoM = 1F;

            Metro DosM;
            DosM = 10F;

            UnoC = UnoC + DosC;
            UnoM = UnoM + UnoC;
            UnoC = UnoC + UnoM;
            UnoC++;

            if (DosC == UnoM)
            {
                Console.Write("Son iguales");
            }

            UnoM = 9F;

            Console.ReadKey();
        }
    }
}
