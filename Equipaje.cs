using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Aeropuerto_Grupo_2.Objetos
{
    class Equipaje
    {
        public string IdMaleta { get; set; }
        public string Propietario { get; set; }
        public double Peso { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string Marca { get; set; }
        public  string Prioridad { get; set; }
    
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
