using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Aeropuerto_Grupo_2.Objetos
{
    internal class Pasajero
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Documento { get; set; }
        public string Nacionalidad { get; set; }
        public string Asiento { get; set; }
        public string Numeroequipaje { get; set; }

        public Pasajero(string nombre, string apellido, int edad, string documento, string nacionalidad, string asiento, string numeroequipaje)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Documento = documento;
            Nacionalidad = nacionalidad;
            Asiento = asiento;
            Numeroequipaje = numeroequipaje;
        }

        public void MostrarInfo()=> Console.WriteLine ($"Pasajero: {Nombre} {Apellido}, Documento: {Documento}, Nacionalidad: {Nacionalidad}, Asiento: {Asiento}");
        public void CambiarAsiento(string nuevoAsiento) => Asiento = nuevoAsiento;
        public void MostrarBienvenida()
        {
            Console.WriteLine($"¡Bienvenido a bordo, {Nombre} {Apellido}!");
        }
    }
}
