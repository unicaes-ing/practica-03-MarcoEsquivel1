using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica3
{
    class ejercicio5
    {
        //Marco René Esquivel Juárez
        //24-Julio
        public void ejer5()
        {
            int numero;
            string nombreNumero = "0";
            Console.WriteLine("Ingrese un numero entre 1-10");
            numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                default:
                    Console.WriteLine("El valor no se encuentra en el rango especificado");
                    break;
                case 1:
                    nombreNumero = "UNO";
                    break;
                case 2:
                    nombreNumero = "DOS";
                    break;
                case 3:
                    nombreNumero = "TRES";
                    break;
                case 4:
                    nombreNumero = "CUATRO";
                    break;
                case 5:
                    nombreNumero = "CINCO";
                    break;
                case 6:
                    nombreNumero = "SEIS";
                    break;
                case 7:
                    nombreNumero = "SIETE";
                    break;
                case 8:
                    nombreNumero = "OCHO";
                    break;
                case 9:
                    nombreNumero = "NUEVE";
                    break;
                case 10:
                    nombreNumero = "DIEZ";
                    break;
            }
            Console.WriteLine("{0}", nombreNumero);
            Console.ReadKey();
        }
    }
}
