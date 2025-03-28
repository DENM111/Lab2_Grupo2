﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_Aeropuerto_Grupo_2
{
    class Validaciones
    {
        public static int LeerEntero(string mensaje)
        {
            int numero;
            while (true)
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out numero))
                    return numero;
                Console.WriteLine("Entrada no válida. Intente de nuevo.");
            }
        }

        public static string LeerTexto(string mensaje)
        {
            string entrada;
            while (true)
            {
                Console.Write(mensaje);
                entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("El texto no puede estar vacío.");
                    continue;
                }

                if (ContieneNumeros(entrada))
                {
                    Console.WriteLine("El texto no puede contener números.");
                    continue;
                }

                return entrada;
            }
        }

        private static bool ContieneNumeros(string texto)
        {
            return Regex.IsMatch(texto, @"\d");
        }
    }
}

