using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Aeropuerto_Grupo_2.Objetos;

namespace Lab_Aeropuerto_Grupo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Avion> aviones = new List<Avion>();
            List<Pasajero> pasajeros = new List<Pasajero>();
            List<Boleto> boletos = new List<Boleto>();
            List<Factura> facturas = new List<Factura>();
            List<Equipaje> equipajes = new List<Equipaje>();
            List<Empleado> empleados = new List<Empleado>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== MENÚ PRINCIPAL =====");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Buscar");
                Console.WriteLine("3. Listar");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Agregar(aviones, pasajeros, boletos, facturas, equipajes, empleados);
                        break;
                    case 2:
                        Buscar(aviones, pasajeros, boletos, facturas, equipajes, empleados);
                        break;
                    case 3:
                        Listar(aviones, pasajeros, boletos, facturas, equipajes, empleados);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Presione ENTER para continuar...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private static void Listar(List<Avion> aviones, List<Pasajero> pasajeros, List<Boleto> boletos, List<Factura> facturas, List<Equipaje> equipajes, List<Empleado> empleados)
        {
            throw new NotImplementedException();
        }

        private static void Buscar(List<Avion> aviones, List<Pasajero> pasajeros, List<Boleto> boletos, List<Factura> facturas, List<Equipaje> equipajes, List<Empleado> empleados)
        {
            throw new NotImplementedException();
        }

        private static void Agregar(List<Avion> aviones, List<Pasajero> pasajeros, List<Boleto> boletos, List<Factura> facturas, List<Equipaje> equipajes, List<Empleado> empleados)
        {
            throw new NotImplementedException();
        }

        static void AgregarL(List<Avion> aviones, List<Pasajero> pasajeros, List<Boleto> boletos, List<Factura> facturas, List<Equipaje> maletas, List<Empleado> empleados)
        {
            Console.Clear();
            Console.WriteLine("Seleccione qué desea agregar:");
            Console.WriteLine("1. Avión");
            Console.WriteLine("2. Pasajero");
            Console.WriteLine("3. Boleto");
            Console.WriteLine("4. Factura");
            Console.WriteLine("5. Maleta");
            Console.WriteLine("6. Vuelo");
            Console.WriteLine("7. Empleado");
            Console.Write("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Modelo: ");
                    string modelo = Console.ReadLine();
                    Console.Write("Matrícula: ");
                    string matricula = Console.ReadLine();
                    Console.Write("Capacidad: ");
                    int capacidad = Convert.ToInt32(Console.ReadLine());
                    if (Validaciones.ValidarRango(capacidad,1)
                    {
                        Console.WriteLine("Capacidad no valida. Debe ser un número mayor que 0");
                    }
                    Console.Write("Aerolínea: ");
                    string aerolinea = Console.ReadLine();
                    Console.Write("Tipo comercial o privado: ");
                    string tipo = Console.ReadLine();
                    Console.Write("Año de fabricacion: ");
                    int añoFabricacion = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Peso Maximo: ");
                    int pesoMaximo = Convert.ToInt32(Console.ReadLine());
                    if (Validaciones.ValidarRango(pesoMaximo, 200, 1500)
                    {
                        Console.WriteLine("Peso no valido. Debe ser un número mayor que 200 y menor que 1500");
                    }
                    aviones.Add(new Avion(modelo, matricula, capacidad, aerolinea, tipo, añoFabricacion, pesoMaximo));
                    break;
                case 2:
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Apellido: ");
                    string apellido = Console.ReadLine();
                    Console.Write("Edad: ");
                    int edad = Convert.ToInt32(Console.ReadLine());
                    if (Validaciones.ValidarRango(edad, 1)
                    {
                        Console.WriteLine("Edad no valida. Debe ser un número mayor que 0");
                    }
                    Console.Write("Pasaporte: ");
                    string pasaporte = Console.ReadLine();
                    Console.Write("Nacionalidad: ");
                    string nacionalidad = Console.ReadLine();
                    Console.Write("Asiento: ");
                    string asiento = Console.ReadLine();
                    Console.Write("Numeroequipaje: ");
                    int numeroequipaje = Console.ReadLine();
                    pasajeros.Add(new Pasajero(nombre, apellido, edad, pasaporte, nacionalidad, asiento, numeroequipaje));
                    break;
                case 3:
                    Console.Write("Número de Boleto: ");
                    int numeroBoleto = Console.ReadLine();
                    Console.Write("Nombre del Pasajero: ");
                    string nombrePasajero = Console.ReadLine();
                    Console.Write("Origen: ");
                    string origen = Console.ReadLine();
                    Console.Write("Destino: ");
                    string destino = Console.ReadLine();
                    Console.Write("Fecha de Vuelo (YYYY-MM-DD): ");
                    int fechaVuelo = Console.ReadLine();
                    Console.Write("Precio: ");
                    double precio = Convert.ToDouble(Console.ReadLine());
                    if (Validaciones.ValidarRango(precio, 1)
                    {
                        Console.WriteLine("Precio no valido. Debe ser un número mayor que 0");
                    }
                    Console.Write("Clase: ");
                    string clase = Console.ReadLine();
                    boletos.Add(new Boleto(numeroBoleto, nombrePasajero, origen, destino, fechaVuelo, precio, clase));
                    break;
                case 4:
                    Console.Write("Número de Factura: ");
                    int numeroFactura = Console.ReadLine();
                    Console.Write("Nombre del Cliente: ");
                    string cliente = Console.ReadLine();
                    Console.Write("Fecha de Emisión (YYYY-MM-DD): ");
                    int fechaCreacion = Console.ReadLine();
                    Console.Write("Monto Total: ");
                    double montoTotal = Convert.ToDouble(Console.ReadLine());
                    if (Validaciones.ValidarRango(montoTotal, 1)
                    {
                        Console.WriteLine("Monto no valido. Debe ser un número mayor que 0");
                    }
                    Console.Write("Metodo de pago: ");
                    string metodoPago = Console.ReadLine();
                    Console.Write("Por concepto: ");
                    string concepto = Console.ReadLine();
                    Console.Write("Pagado: ");
                    bool pagado = Convert.ToBoolean(Console.ReadLine());
                    facturas.Add(new Factura(numeroFactura, cliente, fechaCreacion, montoTotal, metodoPago, concepto, pagado));
                    break;
                case 5:
                    Console.Write("ID Maleta: ");
                    int idMaleta = Console.ReadLine();
                    Console.Write("Dueño: ");
                    string propietario = Console.ReadLine();
                    Console.Write("Peso (kg): ");
                    double peso = Convert.ToDouble(Console.ReadLine());
                    if (Validaciones.ValidarRango(capacidad, 1, 23)
                    {
                        Console.WriteLine("Peso no valido. Debe ser un número mayor que 0 y menor que 23");
                    }
                    Console.Write("Prioridad: ");
                    string prioridad = Console.ReadLine();
                    Console.Write("Marca: ");
                    string marca = Console.ReadLine();
                    Console.Write("Color: ");
                    string color = Console.ReadLine();
                    Console.Write("Material: ");
                    string material = Console.ReadLine();
                    maletas.Add(new Equipaje(idMaleta, propietario, peso, prioridad, marca, color, material));
                    break;

                case 6:
                    Console.Write("ID Empleado: ");
                    int idEmpleado = Console.ReadLine();
                    Console.Write("Nombre: ");
                    string nombreEmpleado = Console.ReadLine();
                    Console.Write("Apellido: ");
                    string apellidoEmpleado = Console.ReadLine();
                    Console.Write("Cargo: ");
                    string cargo = Console.ReadLine();
                    Console.Write("Salario: ");
                    double salario = Convert.ToDouble(Console.ReadLine());
                    if (Validaciones.ValidarRango(salario, 1)
                    {
                        Console.WriteLine("Salario no valido. Debe ser un número mayor que 0");
                    }
                    Console.Write("Fecha de Contratación (YYYY-MM-DD): ");
                    int fechaIngreso = Console.ReadLine();
                    Console.Write("Turno: ");
                    string turno = Console.ReadLine();
                    empleados.Add(new Empleado(idEmpleado, nombreEmpleado, apellidoEmpleado, cargo, salario, fechaIngreso, turno));
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("Registro agregado con éxito. Presione ENTER para continuar...");
            Console.ReadLine();
        }

        static void Listar(List<Avion> aviones, List<Pasajero> pasajeros, List<Boleto> boletos, List<Factura> facturas, List<Equipaje> maletas, List<Vuelo> vuelos, List<Empleado> empleados)
        {
            Console.Clear();
            Console.WriteLine("===== LISTA DE REGISTROS =====");
            Console.WriteLine($"Aviones: {aviones.Count}");
            Console.WriteLine($"Pasajeros: {pasajeros.Count}");
            Console.WriteLine($"Boletos: {boletos.Count}");
            Console.WriteLine($"Facturas: {facturas.Count}");
            Console.WriteLine($"Maletas: {maletas.Count}");
            Console.WriteLine($"Vuelos: {vuelos.Count}");
            Console.WriteLine($"Empleados: {empleados.Count}");
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
        }

        static void Buscar(List<Avion> aviones, List<Pasajero> pasajeros, List<Boleto> boletos, List<Factura> facturas, List<Equipaje> maletas, List<Empleado> empleados)
        {
            Console.Clear();
            Console.Write("Ingrese el criterio de búsqueda (Ejemplo: Matrícula, Nombre, ID): ");
            string criterio = Console.ReadLine().ToLower();

            foreach (var avion in aviones)
                if (avion.Matricula.ToLower().Contains(criterio))
                    Console.WriteLine($"Avión encontrado: {avion.Modelo}, Matrícula: {avion.Matricula}");

            foreach (var pasajero in pasajeros)
                if (pasajero.Nombre.ToLower().Contains(criterio))
                    Console.WriteLine($"Pasajero encontrado: {pasajero.Nombre} {pasajero.Apellido}");

            foreach (var boleto in boletos)
                if (boleto.numeroBoleto.ToLower().Contains(criterio))
                    Console.WriteLine($"Boleto encontrado: {boleto.numeroBoleto}, Nombre del Pasajero: {boleto.nombrePasajero}");
            
            foreach (var factura in facturas)
                if (factura.numeroFactura.ToLower().Contains(criterio))
                    Console.WriteLine($"Factura encontrada: {factura.numeroFactura}, Cliente: {factura.cliente}");

            foreach (var maleta in maletas)
                if (maleta.idMaleta.ToLower().Contains(criterio))
                    Console.WriteLine($"Maleta encontrada: {maleta.idMaleta}, Dueño: {maleta.propietario}");

            foreach (var empleado in empleados)
                if (empleado.idEmpleado.ToLower().Contains(criterio))
                    Console.WriteLine($"Empleado encontrada: {empleado.idEmpleado}, Nombre del Empleado: {empleado.nombreEmpleado}");

            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
        }
        public static class Validaciones
        {
            public static bool ValidarRango(int valor, int minimo, int maximo)
            {
                return valor >= minimo && valor <= maximo;
            }
        }
    }
    
}
