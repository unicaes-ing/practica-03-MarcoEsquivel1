using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica3
{
    class ejercicio4
    {
        //Marco René Esquivel Juárez
        //24-Julio
        public void ejer4()
        {
            int minutos, zona;
            decimal costoMinuto=0, total;
            Console.WriteLine("Ingrese los minutos que duró la llamada");
            minutos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===========================================================");
            Console.WriteLine("Ingrese el numero correspondiente a la zona de la llamada:");
            Console.WriteLine("1-Occidental, 2-Central, 3-Oriental");
            Console.WriteLine("===========================================================");
            zona = Convert.ToInt32(Console.ReadLine());
            switch (zona)
            {
                case 1:
                    costoMinuto = 0.32m;
                    break;
                case 2:
                    costoMinuto = 0.25m;
                    break;
                case 3:
                    costoMinuto = 0.36m;
                    break;
                default:
                    Console.WriteLine("El numero ingresado no es valido");
                    break;
            }
            total = minutos * costoMinuto;
            Console.WriteLine("===================================================");
            Console.WriteLine("El valor total de la llamada es de: {0}", total.ToString("c2"));
            Console.ReadKey();
        }
    }
}
