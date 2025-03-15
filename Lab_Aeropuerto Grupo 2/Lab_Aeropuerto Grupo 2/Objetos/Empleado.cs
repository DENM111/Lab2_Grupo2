using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Aeropuerto_Grupo_2.Objetos
{
    class Empleado
    {
        public string IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public string FechaIngreso { get; set; }
        public string Turno { get; set; }

        public Empleado(string idEmpleado, string nombre, string apellido, string cargo, double salario, string fechaIngreso, string turno)
        {
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Apellido = apellido;
            Cargo = cargo;
            Salario = salario;
            FechaIngreso= fechaIngreso;
            Turno = turno;
        }


        public void MostrarInformacion()
        {
            Console.WriteLine($"Empleado: {Nombre} {Apellido}, ID: {IdEmpleado}, Cargo: {Cargo}, Salario: {Salario:C}, Fecha de contratación: {FechaIngreso}, Turno: {Turno}");
        }

        public void AumentarSalario(double porcentaje)
        {
            Salario += Salario * (porcentaje / 100);
        }

        public void CambiarTurno(string nuevoTurno)
        {
            Turno = nuevoTurno;
        }

        public void AsignarCargo(string nuevoCargo, double nuevoSalario)
        {
            Cargo = nuevoCargo;
            Salario = nuevoSalario;
        }
    }
}
