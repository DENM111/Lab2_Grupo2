using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Aeropuerto_Grupo_2.Objetos
{
    public class Avion
    {
        public string Modelo { get; set; }
        public string Matricula { get; set; }
        public int Capacidad { get; set; }
        public string Aerolinea { get; set; }
        public string Tipo { get; set; }
        public int AñoFabricacion { get; set; }
        public double PesoMaximo { get; set; }

        public Avion(string modelo, string matricula, int capacidad, string aerolinea, string tipo, int añoFabricacion, double pesoMaximo)
        {
            Modelo = modelo;
            Matricula = matricula;
            Capacidad = capacidad;
            Aerolinea = aerolinea;
            Tipo = tipo;
            AñoFabricacion = añoFabricacion;
            PesoMaximo = pesoMaximo;
        }

    

        public void Despegar() => Console.WriteLine($"El avión {Modelo} con matrícula {Matricula} ha despegado.");
        public void Aterrizar() => Console.WriteLine($"El avión {Modelo} con matrícula {Matricula} ha aterrizado.");
        public void MostrarInformacion() => Console.WriteLine($"Modelo: {Modelo}, Matrícula: {Matricula}, Capacidad: {Capacidad}, Aerolínea: {Aerolinea}, Tipo: {Tipo}, Año: {AñoFabricacion}, Peso Máximo: {PesoMaximo} kg.");
    }
}
