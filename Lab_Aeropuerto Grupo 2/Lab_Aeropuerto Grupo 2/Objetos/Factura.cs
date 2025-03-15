using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Aeropuerto_Grupo_2.Objetos
{
    internal class Factura
    {
        public string NumeroFactura { get; set; }
        public string Cliente { get; set; }
        public string FechaCreacion { get; set; }
        public double MontoTotal { get; set; }
        public string MetodoPago { get; set; }
        public string Concepto { get; set; }
        public bool Pagado { get; set; }


        public Factura(string numeroFactura, string cliente, string fechaCreacion, double montoTotal, string metodoPago, string concepto, bool pagado)
        {
            NumeroFactura = numeroFactura;
            Cliente = cliente;
            FechaCreacion = fechaCreacion;
            MontoTotal = montoTotal;
            MetodoPago = metodoPago;
            Concepto = concepto;
            Pagado = pagado;
        }

        public void MostrarFactura() => Console.WriteLine($"Factura {NumeroFactura}: Cliente {Cliente}, Monto: {MontoTotal}, Pagado: {Pagado}");
        public void AplicarPago() => Pagado = true;
        public void ModificarMonto(double nuevoMonto) => MontoTotal = nuevoMonto;
    }
}
