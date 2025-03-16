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
                Console.WriteLine("    MENÚ PRINCIPAL ");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Buscar");
                Console.WriteLine("3. Listar");
                Console.WriteLine("4. Salir");
                int opcion = Validaciones.LeerEntero("Seleccione una opción: ");

                switch (opcion)
                {
                    case 1:
                        AgregarElemento(aviones, pasajeros, boletos, facturas, equipajes, empleados);
                        break;
                    case 2:
                        BuscarElemento(aviones, pasajeros, boletos, facturas, equipajes, empleados);
                        break;
                    case 3:
                        ListarElementos(aviones, pasajeros, boletos, facturas, equipajes, empleados);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadLine();
            }
        }

        static void AgregarElemento(List<Avion> aviones, List<Pasajero> pasajeros, List<Boleto> boletos, List<Factura> facturas, List<Equipaje> equipajes, List<Empleado> empleados)
        {
            Console.Clear();
            Console.WriteLine("   AGREGAR ");
            Console.WriteLine("1. Avión");
            Console.WriteLine("2. Pasajero");
            Console.WriteLine("3. Boleto");
            Console.WriteLine("4. Factura");
            Console.WriteLine("5. Equipaje");
            Console.WriteLine("6. Empleado");
            int opcion = Validaciones.LeerEntero("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    aviones.Add(CrearAvion());
                    Console.WriteLine("Avión agregado con éxito.");
                    break;
                case 2:
                    pasajeros.Add(CrearPasajero());
                    Console.WriteLine("Pasajero agregado con éxito.");
                    break;
                case 3:
                    boletos.Add(CrearBoleto());
                    Console.WriteLine("Boleto agregado con éxito.");
                    break;
                case 4:
                    facturas.Add(CrearFactura());
                    Console.WriteLine("Factura agregada con éxito.");
                    break;
                case 5:
                    equipajes.Add(CrearEquipaje());
                    Console.WriteLine("Equipaje agregado con éxito.");
                    break;
                case 6:
                    empleados.Add(CrearEmpleado());
                    Console.WriteLine("Empleado agregado con éxito.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static void BuscarElemento(List<Avion> aviones, List<Pasajero> pasajeros, List<Boleto> boletos, List<Factura> facturas, List<Equipaje> equipajes, List<Empleado> empleados)
        {
            Console.Clear();
            Console.WriteLine("   BUSCAR ");
            Console.WriteLine("1. Avión");
            Console.WriteLine("2. Pasajero");
            Console.WriteLine("3. Boleto");
            Console.WriteLine("4. Factura");
            Console.WriteLine("5. Equipaje");
            Console.WriteLine("6. Empleado");
            int opcion = Validaciones.LeerEntero("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    BuscarAvion(aviones);
                    break;
                case 2:
                    BuscarPasajero(pasajeros);
                    break;
                case 3:
                    BuscarBoleto(boletos);
                    break;
                case 4:
                    BuscarFactura(facturas);
                    break;
                case 5:
                    BuscarEquipaje(equipajes);
                    break;
                case 6:
                    BuscarEmpleado(empleados);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static void ListarElementos(List<Avion> aviones, List<Pasajero> pasajeros, List<Boleto> boletos, List<Factura> facturas, List<Equipaje> equipajes, List<Empleado> empleados)
        {
            Console.Clear();
            Console.WriteLine("   LISTAR ");
            Console.WriteLine("1. Aviones");
            Console.WriteLine("2. Pasajeros");
            Console.WriteLine("3. Boletos");
            Console.WriteLine("4. Facturas");
            Console.WriteLine("5. Equipajes");
            Console.WriteLine("6. Empleados");
            int opcion = Validaciones.LeerEntero("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    ListarAviones(aviones);
                    break;
                case 2:
                    ListarPasajeros(pasajeros);
                    break;
                case 3:
                    ListarBoletos(boletos);
                    break;
                case 4:
                    ListarFacturas(facturas);
                    break;
                case 5:
                    ListarEquipajes(equipajes);
                    break;
                case 6:
                    ListarEmpleados(empleados);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        // Métodos para crear objetos
        static Avion CrearAvion()
        {
            Console.WriteLine(" CREAR AVION  ");
            string modelo = Validaciones.LeerTexto("Modelo: ");
            string opcion = Validaciones.LeerTexto("Seleccione una opción: ");
            string matricula = Validaciones.LeerTexto("Matrícula: ");
            int capacidad = Validaciones.LeerEntero("Capacidad: ");
            string aerolinea = Validaciones.LeerTexto("Aerolínea: ");
            string tipo = Validaciones.LeerTexto("Tipo: ");
            int añoFabricacion = Validaciones.LeerEntero("Año de fabricación: ");
            double pesoMaximo = Validaciones.LeerEntero("Peso máximo: ");
            return new Avion(modelo, matricula, capacidad, aerolinea, tipo, añoFabricacion, pesoMaximo);
            
        }

        static Pasajero CrearPasajero()
        {
            Console.WriteLine("   CREAR PASAJERO ");
            string nombre = Validaciones.LeerTexto("Nombre: ");
            string apellido = Validaciones.LeerTexto("Apellido: ");
            int edad = Validaciones.LeerEntero("Edad: ");
            string documento = Validaciones.LeerTexto("Documento: ");
            string nacionalidad = Validaciones.LeerTexto("Nacionalidad: ");
            string asiento = Validaciones.LeerTexto("Asiento: ");
            string numeroEquipaje = Validaciones.LeerTexto("Número de equipaje: ");
            return new Pasajero(nombre, apellido, edad, documento, nacionalidad, asiento, numeroEquipaje);
        }

        static Boleto CrearBoleto()
        {
            Console.WriteLine("   CREAR BOLETO ");
            string numeroBoleto = Validaciones.LeerTexto("Número de boleto: ");
            string nombrePasajero = Validaciones.LeerTexto("Nombre del pasajero: ");
            string destino = Validaciones.LeerTexto("Destino: ");
            string origen = Validaciones.LeerTexto("Origen: ");
            string fechaVuelo = Validaciones.LeerTexto("Fecha de vuelo: ");
            double precio = Validaciones.LeerEntero("Precio: ");
            string clase = Validaciones.LeerTexto("Clase: ");
            return new Boleto(numeroBoleto, nombrePasajero, destino, origen, fechaVuelo, precio, clase);
        }

        static Factura CrearFactura()
        {
            Console.WriteLine("CREAR FACTURA ");
            int numeroFactura = Validaciones.LeerEntero("Número de factura: ");
            string cliente = Validaciones.LeerTexto("Cliente: ");
            string fechaCreacion = Validaciones.LeerTexto("Fecha de creación: ");
            double montoTotal = Validaciones.LeerEntero("Monto total: ");
            string metodoPago = Validaciones.LeerTexto("Método de pago: ");
            string concepto = Validaciones.LeerTexto("Concepto: ");
            bool pagado = Validaciones.LeerEntero("Pagado (1: Sí, 0: No): ") == 1;
            return new Factura(numeroFactura, cliente, fechaCreacion, montoTotal, metodoPago, concepto, pagado);
        }

        static Equipaje CrearEquipaje()
        {
            Console.WriteLine("   CREAR EQUIPAJE  ");
            string idMaleta = Validaciones.LeerTexto("ID de la maleta: ");
            string propietario = Validaciones.LeerTexto("Propietario: ");
            double peso = Validaciones.LeerEntero("Peso: ");
            string color = Validaciones.LeerTexto("Color: ");
            string material = Validaciones.LeerTexto("Material: ");
            string marca = Validaciones.LeerTexto("Marca: ");
            string prioridad = Validaciones.LeerTexto("Prioridad: ");
            return new Equipaje(idMaleta, propietario, peso, color, material, marca, prioridad);
        }

        static Empleado CrearEmpleado()
        {
            Console.WriteLine("  CREAR EMPLEADO ");
            string idEmpleado = Validaciones.LeerTexto("ID del empleado: ");
            string nombre = Validaciones.LeerTexto("Nombre: ");
            string apellido = Validaciones.LeerTexto("Apellido: ");
            string cargo = Validaciones.LeerTexto("Cargo: ");
            double salario = Validaciones.LeerEntero("Salario: ");
            string fechaIngreso = Validaciones.LeerTexto("Fecha de ingreso: ");
            string turno = Validaciones.LeerTexto("Turno: ");
            return new Empleado(idEmpleado, nombre, apellido, cargo, salario, fechaIngreso, turno);
        }

        // Métodos para buscar objetos
        static void BuscarAvion(List<Avion> aviones)
        {
            string matricula = Validaciones.LeerTexto("Ingrese la matrícula del avión: ");
            var avion = aviones.Find(a => a.Matricula == matricula);
            if (avion != null)
                avion.MostrarInformacion();
            else
                Console.WriteLine("Avión no encontrado.");
        }

        static void BuscarPasajero(List<Pasajero> pasajeros)
        {
            string documento = Validaciones.LeerTexto("Ingrese el documento del pasajero: ");
            var pasajero = pasajeros.Find(p => p.Documento == documento);
            if (pasajero != null)
                pasajero.MostrarInfo();
            else
                Console.WriteLine("Pasajero no encontrado.");
        }

        static void BuscarBoleto(List<Boleto> boletos)
        {
            string numeroBoleto = Validaciones.LeerTexto("Ingrese el número de boleto: ");
            var boleto = boletos.Find(b => b.NumeroBoleto == numeroBoleto);
            if (boleto != null)
                boleto.MostrarBoleto();
            else
                Console.WriteLine("Boleto no encontrado.");
        }

        static void BuscarFactura(List<Factura> facturas)
        {
            int numeroFactura = Validaciones.LeerEntero("Ingrese el número de factura: ");
            var factura = facturas.Find(f => f.NumeroFactura == numeroFactura);
            if (factura != null)
                factura.MostrarFactura();
            else
                Console.WriteLine("Factura no encontrada.");
        }

        static void BuscarEquipaje(List<Equipaje> equipajes)
        {
            string idMaleta = Validaciones.LeerTexto("Ingrese el ID de la maleta: ");
            var equipaje = equipajes.Find(e => e.IdMaleta == idMaleta);
            if (equipaje != null)
                equipaje.MostrarMaleta();
            else
                Console.WriteLine("Equipaje no encontrado.");
        }

        static void BuscarEmpleado(List<Empleado> empleados)
        {
            string idEmpleado = Validaciones.LeerTexto("Ingrese el ID del empleado: ");
            var empleado = empleados.Find(e => e.IdEmpleado == idEmpleado);
            if (empleado != null)
                empleado.MostrarInformacion();
            else
                Console.WriteLine("Empleado no encontrado.");
        }

        // Métodos para listar objetos
        static void ListarAviones(List<Avion> aviones)
        {
            foreach (var avion in aviones)
                avion.MostrarInformacion();
        }

        static void ListarPasajeros(List<Pasajero> pasajeros)
        {
            foreach (var pasajero in pasajeros)
                pasajero.MostrarInfo();
        }

        static void ListarBoletos(List<Boleto> boletos)
        {
            foreach (var boleto in boletos)
                boleto.MostrarBoleto();
        }

        static void ListarFacturas(List<Factura> facturas)
        {
            foreach (var factura in facturas)
                factura.MostrarFactura();
        }

        static void ListarEquipajes(List<Equipaje> equipajes)
        {
            foreach (var equipaje in equipajes)
                equipaje.MostrarMaleta();
        }

        static void ListarEmpleados(List<Empleado> empleados)
        {
            foreach (var empleado in empleados)
                empleado.MostrarInformacion();
        }
    }
}
