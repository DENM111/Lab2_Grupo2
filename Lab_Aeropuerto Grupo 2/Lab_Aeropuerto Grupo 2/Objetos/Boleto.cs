using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Aeropuerto_Grupo_2.Objetos
{
    internal class Boleto
    {
        public string NumeroBoleto { get; set; }
        public string NombrePasajero { get; set; }
        public string Destino { get; set; }
        public string Origen { get; set; }
        public string FechaVuelo { get; set; }
        public double Precio { get; set; }
        public string Clase { get; set; }

        public Boleto(string numeroBoleto, string nombrePasajero, string destino, string origen, string fechaVuelo, double precio, string clase)
        {
            NumeroBoleto = numeroBoleto;
            NombrePasajero = nombrePasajero;
            Destino = destino;
            Origen = origen;
            FechaVuelo = fechaVuelo;
            Precio = precio;
            Clase = clase;
        }


        public void MostrarBoleto() => Console.WriteLine($"Boleto {NumeroBoleto}: {NombrePasajero} viaja de {Origen} a {Destino} el {FechaVuelo}");
        public void CambiarClase(string nuevaClase) => Clase = nuevaClase;
        public void AplicarDescuento(double porcentaje) => Precio -= Precio * (porcentaje / 100);
    }
}
