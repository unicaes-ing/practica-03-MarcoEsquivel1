using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica3
{
    class ejercicio1
    {
        //Marco René Esquivel Juárez
        //24-Julio
        public void ejer1()
        {
            decimal tiempo, minutos, segundos;
            do
            {
                Console.WriteLine("Ingrese las horas que desea convertir");
                tiempo = Convert.ToDecimal(Console.ReadLine());
                Console.Clear();
            } while (tiempo < 0);
            
            if (tiempo > 0)
            {
                minutos = tiempo * 60;
                segundos = tiempo * 3600;
                Console.WriteLine("{0} horas es igual a {1} minutos y tambien es igual a {2} segundos.", tiempo, minutos, segundos);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El valor ingresado no es valido");
            }
        }
    }
}
