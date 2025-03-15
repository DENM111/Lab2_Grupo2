using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Aeropuerto_Grupo_2.Objetos
{
    internal class Equipaje
    {
        private string IdMaleta { get; set; }
        private string Propietario { get; set; }
        private double Peso { get; set; }
        private string Color { get; set; }
        private string Material { get; set; }
        private string Marca { get; set; }
        private  string Prioridad { get; set; }
    
     public Equipaje(string idMaleta, string propietario, double peso, string color, string material, string marca , string prioridad)
     {
            IdMaleta = idMaleta;
            Propietario = propietario;
            Peso = peso;
            Prioridad = prioridad;
            Marca = marca;
            Color = color;
            Material = material;

     }

        public void MostrarMaleta() => Console.WriteLine($"Maleta {IdMaleta}: Propietario {Propietario}, Peso {Peso} kg, Color {Color}");
        public void CambiarPeso(double nuevoPeso) => Peso = nuevoPeso;
    }
}
