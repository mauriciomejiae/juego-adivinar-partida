using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego_adivinar_partida
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, i = 0, intento = 0, intento2 = 0, g1 = 0, g2 = 0;
            double inter;
            Console.Clear();//Clear es la funcion para limpiar pantalla.
            cabeza();
            Console.Write("\n\n  Ingrese cantidad de partidas: ");
            p = int.Parse(Console.ReadLine());
            do
            {
                i++;
                Console.Write("\n\n  PARTIDA No.{0}", i);

                inter = Math.Pow(-1, i);
                if (inter < 0)
                {
                    Console.Clear();//Clear es la funcion para limpiar pantalla.
                    cabeza();
                    Console.Write("\n\n  JUGADOR No. 1 A JUGAR");
                    Console.Write("\n\t Presione una tecla para continuar...");
                    Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
                    intento = adivina();
                    Console.Clear();//Clear es la funcion para limpiar pantalla.
                    cabeza();
                    Console.Write("\n\n  JUGADOR No. 2 A JUGAR");
                    Console.Write("\n\t Presione una tecla para continuar...");
                    Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
                    intento2 = adivina();

                }
                else
                {
                    Console.Clear();//Clear es la funcion para limpiar pantalla.
                    cabeza();
                    Console.Write("\n\n  JUGADOR No. 2 A JUGAR");
                    Console.Write("\n\t Presione una tecla para continuar...");
                    Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
                    intento2 = adivina();
                    Console.Clear();//Clear es la funcion para limpiar pantalla.
                    cabeza();
                    Console.Write("\n\n  JUGADOR No. 1 A JUGAR");
                    Console.Write("\n\t Presione una tecla para continuar...");
                    Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
                    intento = adivina();
                }
                if (intento2 - intento > 0)
                {
                    Console.Write("\n\n  GANADOR DE LA PARTIDA JUGADOR No. 1");
                    Console.Write("\n\t Presione una tecla para continuar...");
                    Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
                    g1++;
                }
                else
                {
                    Console.Write("\n\n  GANADOR DE LA PARTIDA JUGADOR No. 2");
                    Console.Write("\n\t Presione una tecla para continuar...");
                    Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
                    g2++;
                }

            }
            while (p != i);

            if (g2 - g1 < 0)
            {
                Console.Clear();//Clear es la funcion para limpiar pantalla.
                cabeza();
                Console.Write("\n\n  GANADOR JUGADOR No. 1");
                Console.Write("\n\t Presione una tecla para continuar...");
                Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
                g1++;
            }
            else
            {
                Console.Clear();//Clear es la funcion para limpiar pantalla.
                cabeza();
                Console.Write("\n\n  GANADOR JUGADOR No. 2");
                Console.Write("\n\t Presione una tecla para continuar...");
                Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
                g2++;
            }

        }
        static int adivina()
        {
            int sw = 0, cont = 0, n, num;
            Random rnd = new Random();
            num = rnd.Next(0, 100);
            while (sw == 0)
            {
                Console.Clear();//Clear es la funcion para limpiar pantalla.
                cabeza();
                Console.Write("\n\n  Adivina el número, su número es: ");// se solicita el numero al usuario para comparar si es el que calculo la computadora
                n = int.Parse(Console.ReadLine()); //almacena valor en variable, la funcion Parse convierte el valor tipo caracter a numero entero.
                cont = cont + 1;// se cuentan los intentos
                if (n == num)
                {
                    sw = 1;
                }

                else
                {
                    if (num - 10 < n && n < num + 10)
                    {
                        Console.Write("\n  Caliente!");// se informa si va bien
                        Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
                    }
                    else
                    {
                        Console.Write("\n  Frio!");// se informa si va mal
                        Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.

                    }
                }

            }

            Console.Write("\n  Perfecto! lo adivino en {0} intentos", cont);// muestra el resultado
            Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
            return cont;
        }
        static void cabeza()//funcion para el encabezado del programa
        {
            Console.Clear();//Clear es la funcion para limpiar pantalla.
            Console.Write("\n       UNIVERSIDAD NACIONAL ABIERTA Y A DISTANCIA");//la funcion Write basicamente lo que hace es mostrar en la consola la cadena de caracteres.
            Console.Write("\n              Trabajo colaborativo: Fase 2");
            Console.Write("\n                       Algorítmos");
            Console.Write("\n                  Problema 11: fase 2");
        }
    }
}
