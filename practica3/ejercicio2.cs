using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica3
{
    class ejercicio2
    {
        //Marco René Esquivel Juárez
        //24-Julio
        public void ejer2()
        {
            Random rnd = new Random();
            int numeroAleatorio;
            numeroAleatorio = rnd.Next(1, 101);
            Console.WriteLine("El numero generado es {0}", numeroAleatorio);
            Console.ReadKey();
        }
    }
}
