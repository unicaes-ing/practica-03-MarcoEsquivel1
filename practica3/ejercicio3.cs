using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica3
{
    class ejercicio3
    {
        //Marco René Esquivel Juárez
        //24-Julio
        public void ejer3()
        {

            int num1, num2, num3;
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("numeros en orden de ingreso {0}, {1}, {2}", num1, num2, num3);
            Console.WriteLine("=================================================");
            if (num1>num2 && num1>num3)
            {
                Console.WriteLine("El numero mayor es {0}", num1);
                if (num2>num3)
                {
                    Console.WriteLine("El segundo numero es {0}", num2);
                    Console.WriteLine("El numero menor es {0}", num3);
                    Console.WriteLine("============================================");
                    Console.WriteLine("numeros en orden ascendente {0}, {1}, {2}", num3, num2, num1);
                }
                else
                {
                    Console.WriteLine("El segundo numero es {0}", num3);
                    Console.WriteLine("El segundo menor es {0}", num2);
                    Console.WriteLine("============================================");
                    Console.WriteLine("numeros en orden ascendente {0}, {1}, {2}", num2, num3, num1);
                }
            }
            else
            {
                if (num2>num1 && num2>num3)
                {
                    Console.WriteLine("El numero mayor es {0}", num2);
                    if (num1 > num3)
                    {
                        Console.WriteLine("El segundo numero es {0}", num1);
                        Console.WriteLine("El numero menor es {0}", num3);
                        Console.WriteLine("============================================");
                        Console.WriteLine("numeros en orden ascendente {0}, {1}, {2}", num3, num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("El segundo numero es {0}", num3);
                        Console.WriteLine("El segundo menor es {0}", num1);
                        Console.WriteLine("============================================");
                        Console.WriteLine("numeros en orden ascendente {0}, {1}, {2}", num1, num3, num2);
                    }
                }
                else
                {
                    Console.WriteLine("El numero mayor es {0}", num3);
                    if (num1>num2)
                    {
                        Console.WriteLine("El segundo numero es {0}", num1);
                        Console.WriteLine("El segundo menor es {0}", num2);
                        Console.WriteLine("============================================");
                        Console.WriteLine("numeros en orden ascendente {0}, {1}, {2}", num2, num1, num3);
                    }
                    else
                    {
                        Console.WriteLine("El segundo numero es {0}", num2);
                        Console.WriteLine("El segundo menor es {0}", num1);
                        Console.WriteLine("============================================");
                        Console.WriteLine("numeros en orden ascendente {0}, {1}, {2}", num1, num2, num3);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
