using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleString01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = null;
            string nombreMasCorto = "";
            string nombreMasLargo = "";
            int caracteresMasCorto = 100;
            int caracteresMasLargo = 0;
            int cantidadNombres = 0;
            do
            {
                IngresoDeNombre(ref nombre);
                if (nombre.Length > 0)
                {
                    cantidadNombres++;
                    AnalizarTexto(nombre);
                    ObtenerNombreMasLargo(nombre, ref nombreMasLargo, ref caracteresMasLargo);
                    ObtenerNombreMasCorto(nombre, ref nombreMasCorto, ref caracteresMasCorto);
                }
                else
                {

                    if (cantidadNombres>0)
                    {
                        Console.WriteLine($"Nombre mas corto:{nombreMasCorto}");
                        Console.WriteLine($"Caracteres:{caracteresMasCorto}");
                        Console.WriteLine($"Nombre mas largo:{nombreMasLargo}");
                        Console.WriteLine($"Caracteres:{caracteresMasLargo}");


                    }  
                    Console.WriteLine("Fin del ejercicio");
                    break;
                }

            } while (true);
            Console.ReadLine();
        }

        private static void ObtenerNombreMasCorto(string nombre, ref string nombreMasCorto, ref int caracteresMasCorto)
        {
            if (nombre.Length < caracteresMasCorto)
            {
                nombreMasCorto = nombre;
                caracteresMasCorto = nombre.Length;
            }
        }

        private static void ObtenerNombreMasLargo(string nombre, ref string nombreMasLargo, ref int caracteresMasLargo)
        {
            if (nombre.Length>caracteresMasLargo)
            {
                nombreMasLargo = nombre;
                caracteresMasLargo = nombre.Length;
            }
        }

        private static void AnalizarTexto(string nombre)
        {
            int cantidadCaracteres = nombre.Length;
            Console.WriteLine($"Comienza con {nombre[0]}");
            Console.WriteLine($"Termina con {nombre[cantidadCaracteres-1]}");
            Console.WriteLine($"Tiene {cantidadCaracteres} caracteres");
            int cantidadVocales = CantidadVocales(nombre);
            int cantidadConsonantes = CantidadConsonantes(nombre);
            Console.WriteLine($"Tiene {cantidadVocales} vocales");
            Console.WriteLine($"Tiene {cantidadConsonantes} consonantes");
            Console.WriteLine(nombre.ToUpper());
            Console.WriteLine(nombre.ToLower());
        }

        private static int CantidadConsonantes(string nombre)
        {
            string vocales = "aeiouáéíóú";
            var contadorConsonantes = 0;
            for (int i = 0; i < nombre.Length; i++)
            {
                if (!vocales.Contains(nombre[i].ToString().ToLower()))
                {
                    contadorConsonantes++;
                }
            }

            return contadorConsonantes;

        }

        private static int CantidadVocales(string nombre)
        {
            string vocales = "aeiouáéíóú";
            var contadorVocales = 0;
            for (int i = 0; i < nombre.Length; i++)
            {
                if (vocales.Contains(nombre[i].ToString().ToLower()))
                {
                    contadorVocales++;
                }
            }

            return contadorVocales;
        }

        private static void IngresoDeNombre(ref string nombre)
        {
            Console.Write("Ingrese un nombre <ENTER> para salir:");
            nombre = Console.ReadLine();
        }
    }
}
