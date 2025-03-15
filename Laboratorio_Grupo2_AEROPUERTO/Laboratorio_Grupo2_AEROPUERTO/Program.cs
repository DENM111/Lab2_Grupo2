using System;
using System.Collections.Generic;

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
            List<Equipaje> maletas = new List<Equipaje>();
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
                        AgregarL(aviones, pasajeros, boletos, facturas, maletas, empleados);
                        break;
                    case 2:
                        Buscar(aviones, pasajeros, boletos, facturas, maletas, empleados);
                        break;
                    case 3:
                        Listar(aviones, pasajeros, boletos, facturas, maletas, empleados);
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

        private static void AgregarL(List<Avion> aviones, List<Pasajero> pasajeros, List<Boleto> boletos, List<Factura> facturas, List<Equipaje> maletas, List<Empleado> empleados)
        {
            Console.Clear();
            Console.WriteLine("Seleccione qué desea agregar:");
            Console.WriteLine("1. Avión");
            Console.WriteLine("2. Pasajero");
            Console.WriteLine("3. Boleto");
            Console.WriteLine("4. Factura");
            Console.WriteLine("5. Maleta");
            Console.WriteLine("6. Empleado");
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
                    if (!Validaciones.ValidarRango(capacidad, 1, int.MaxValue))
                    {
                        Console.WriteLine("Capacidad no válida. Debe ser un número mayor que 0.");
                        Console.ReadLine();
                        return;
                    }
                    Console.Write("Aerolínea: ");
                    string aerolinea = Console.ReadLine();
                    Console.Write("Tipo (comercial o privado): ");
                    string tipo = Console.ReadLine();
                    Console.Write("Año de fabricación: ");
                    int añoFabricacion = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Peso Máximo: ");
                    int pesoMaximo = Convert.ToInt32(Console.ReadLine());
                    if (!Validaciones.ValidarRango(pesoMaximo, 200, 1500))
                    {
                        Console.WriteLine("Peso no válido. Debe ser un número entre 200 y 1500.");
                        Console.ReadLine();
                        return;
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
                    if (!Validaciones.ValidarRango(edad, 1, 120))
                    {
                        Console.WriteLine("Edad no válida. Debe ser un número entre 1 y 120.");
                        Console.ReadLine();
                        return;
                    }
                    Console.Write("Pasaporte: ");
                    string pasaporte = Console.ReadLine();
                    Console.Write("Nacionalidad: ");
                    string nacionalidad = Console.ReadLine();
                    Console.Write("Asiento: ");
                    string asiento = Console.ReadLine();
                    Console.Write("Número de maletas: ");
                    int numeroMaletas = Convert.ToInt32(Console.ReadLine());
                    pasajeros.Add(new Pasajero(nombre, apellido, edad, pasaporte, nacionalidad, asiento, numeroMaletas));
                    break;

                case 3:
                    Console.Write("Número de Boleto: ");
                    int numeroBoleto = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nombre del Pasajero: ");
                    string nombrePasajero = Console.ReadLine();
                    Console.Write("Origen: ");
                    string origen = Console.ReadLine();
                    Console.Write("Destino: ");
                    string destino = Console.ReadLine();
                    Console.Write("Fecha de Vuelo (YYYY-MM-DD): ");
                    string fechaVuelo = Console.ReadLine();
                    Console.Write("Precio: ");
                    double precio = Convert.ToDouble(Console.ReadLine());
                    if (!Validaciones.ValidarRango(precio, 1, double.MaxValue))
                    {
                        Console.WriteLine("Precio no válido. Debe ser un número mayor que 0.");
                        Console.ReadLine();
                        return;
                    }
                    Console.Write("Clase: ");
                    string clase = Console.ReadLine();
                    boletos.Add(new Boleto(numeroBoleto, nombrePasajero, origen, destino, fechaVuelo, precio, clase));
                    break;

                case 4:
                    Console.Write("Número de Factura: ");
                    int numeroFactura = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nombre del Cliente: ");
                    string cliente = Console.ReadLine();
                    Console.Write("Fecha de Emisión (YYYY-MM-DD): ");
                    string fechaCreacion = Console.ReadLine();
                    Console.Write("Monto Total: ");
                    double montoTotal = Convert.ToDouble(Console.ReadLine());
                    if (!Validaciones.ValidarRango(montoTotal, 1, double.MaxValue))
                    {
                        Console.WriteLine("Monto no válido. Debe ser un número mayor que 0.");
                        Console.ReadLine();
                        return;
                    }
                    Console.Write("Método de pago: ");
                    string metodoPago = Console.ReadLine();
                    Console.Write("Por concepto: ");
                    string concepto = Console.ReadLine();
                    Console.Write("Pagado (true/false): ");
                    bool pagado = Convert.ToBoolean(Console.ReadLine());
                    facturas.Add(new Factura(numeroFactura, cliente, fechaCreacion, montoTotal, metodoPago, concepto, pagado));
                    break;

                case 5:
                    Console.Write("ID Maleta: ");
                    int idMaleta = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Dueño: ");
                    string propietario = Console.ReadLine();
                    Console.Write("Peso (kg): ");
                    double peso = Convert.ToDouble(Console.ReadLine());
                    if (!Validaciones.ValidarRango(peso, 1, 23))
                    {
                        Console.WriteLine("Peso no válido. Debe ser un número entre 1 y 23.");
                        Console.ReadLine();
                        return;
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
                    int idEmpleado = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nombre: ");
                    string nombreEmpleado = Console.ReadLine();
                    Console.Write("Apellido: ");
                    string apellidoEmpleado = Console.ReadLine();
                    Console.Write("Cargo: ");
                    string cargo = Console.ReadLine();
                    Console.Write("Salario: ");
                    double salario = Convert.ToDouble(Console.ReadLine());
                    if (!Validaciones.ValidarRango(salario, 1, double.MaxValue))
                    {
                        Console.WriteLine("Salario no válido. Debe ser un número mayor que 0.");
                        Console.ReadLine();
                        return;
                    }
                    Console.Write("Fecha de Contratación (YYYY-MM-DD): ");
                    string fechaIngreso = Console.ReadLine();
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

        private static void Listar(List<Avion> aviones, List<Pasajero> pasajeros, List<Boleto> boletos, List<Factura> facturas, List<Equipaje> maletas, List<Empleado> empleados)
        {
            Console.Clear();
            Console.WriteLine("===== LISTA DE REGISTROS =====");
            Console.WriteLine($"Aviones: {aviones.Count}");
            Console.WriteLine($"Pasajeros: {pasajeros.Count}");
            Console.WriteLine($"Boletos: {boletos.Count}");
            Console.WriteLine($"Facturas: {facturas.Count}");
            Console.WriteLine($"Maletas: {maletas.Count}");
            Console.WriteLine($"Empleados: {empleados.Count}");
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
        }

        private static void Buscar(List<Avion> aviones, List<Pasajero> pasajeros, List<Boleto> boletos, List<Factura> facturas, List<Equipaje> maletas, List<Empleado> empleados)
        {
            Console.Clear();
            Console.Write("Ingrese el criterio de búsqueda (Ejemplo: Matrícula, Nombre, ID): ");
            string criterio = Console.ReadLine().ToLower();

            foreach (var avion in aviones)
                if (avion.Matricula.ToLower().Contains(criterio) || avion.Modelo.ToLower().Contains(criterio))
                    Console.WriteLine($"Avión encontrado: {avion.Modelo}, Matrícula: {avion.Matricula}");

            foreach (var pasajero in pasajeros)
                if (pasajero.Nombre.ToLower().Contains(criterio) || pasajero.Pasaporte.ToLower().Contains(criterio))
                    Console.WriteLine($"Pasajero encontrado: {pasajero.Nombre} {pasajero.Apellido}");

            foreach (var boleto in boletos)
                if (boleto.NumeroBoleto.ToString().Contains(criterio) || boleto.NombrePasajero.ToLower().Contains(criterio))
                    Console.WriteLine($"Boleto encontrado: {boleto.NumeroBoleto}, Pasajero: {boleto.NombrePasajero}");

            foreach (var factura in facturas)
                if (factura.NumeroFactura.ToString().Contains(criterio) || factura.Cliente.ToLower().Contains(criterio))
                    Console.WriteLine($"Factura encontrada: {factura.NumeroFactura}, Cliente: {factura.Cliente}");

            foreach (var maleta in maletas)
                if (maleta.IdMaleta.ToString().Contains(criterio) || maleta.Propietario.ToLower().Contains(criterio))
                    Console.WriteLine($"Maleta encontrada: {maleta.IdMaleta}, Dueño: {maleta.Propietario}");

            foreach (var empleado in empleados)
                if (empleado.IdEmpleado.ToString().Contains(criterio) || empleado.Nombre.ToLower().Contains(criterio))
                    Console.WriteLine($"Empleado encontrado: {empleado.IdEmpleado}, Nombre: {empleado.Nombre} {empleado.Apellido}");

            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
        }

        public static class Validaciones
        {
            public static bool ValidarRango(int valor, int minimo, int maximo)
            {
                return valor >= minimo && valor <= maximo;
            }

            public static bool ValidarRango(double valor, double minimo, double maximo)
            {
                return valor >= minimo && valor <= maximo;
            }
        }
    }
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre} {Apellido}, Edad: {Edad}");
        }
    }
    public class Pasajero : Persona
    {
        public string Pasaporte { get; set; }
        public string Nacionalidad { get; set; }
        public string Asiento { get; set; }
        public int NumeroMaletas { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Pasaporte: {Pasaporte}, Nacionalidad: {Nacionalidad}, Asiento: {Asiento}, Maletas: {NumeroMaletas}");
        }

        public void Abordar()
        {
            Console.WriteLine($"El pasajero {Nombre} {Apellido} está abordando el avión.");
        }

        public void ReclamarEquipaje()
        {
            Console.WriteLine($"El pasajero {Nombre} {Apellido} está reclamando su equipaje.");
        }
    }
    public class Empleado : Persona
    {
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public string FechaIngreso { get; set; }
        public string Turno { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Cargo: {Cargo}, Salario: {Salario}, Fecha de Ingreso: {FechaIngreso}, Turno: {Turno}");
        }

        public void Trabajar()
        {
            Console.WriteLine($"El empleado {Nombre} {Apellido} está trabajando.");
        }

        public void Descansar()
        {
            Console.WriteLine($"El empleado {Nombre} {Apellido} está descansando.");
        }
    }

    public class Avion
    {
        public string Modelo { get; set; }
        public string Matricula { get; set; }
        public int Capacidad { get; set; }
        public string Aerolinea { get; set; }
        public string Tipo { get; set; }
        public int AñoFabricacion { get; set; }
        public int PesoMaximo { get; set; }
        public void Despegar()
        {
            Console.WriteLine($"El avión {Modelo} está despegando.");
        }
        public void Aterrizar()
        {
            Console.WriteLine($"El avión {Modelo} está aterrizando.");
        }
        public void VerificarMantenimiento()
        {
            Console.WriteLine($"Verificando mantenimiento del avión {Modelo}.");
        }
    }
    public class Boleto
    {
        public int NumeroBoleto { get; set; }
        public string NombrePasajero { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string FechaVuelo { get; set; }
        public double Precio { get; set; }
        public string Clase { get; set; }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Boleto #{NumeroBoleto}: {NombrePasajero}, {Origen} -> {Destino}, Fecha: {FechaVuelo}, Precio: {Precio}, Clase: {Clase}");
        }
        public void Cancelar()
        {
            Console.WriteLine($"El boleto #{NumeroBoleto} ha sido cancelado.");
        }

        public void CambiarFecha(string nuevaFecha)
        {
            FechaVuelo = nuevaFecha;
            Console.WriteLine($"La fecha del boleto #{NumeroBoleto} ha sido cambiada a {nuevaFecha}.");
        }
    }
    public class Factura
    {
        public int NumeroFactura { get; set; }
        public string Cliente { get; set; }
        public string FechaCreacion { get; set; }
        public double MontoTotal { get; set; }
        public string MetodoPago { get; set; }
        public string Concepto { get; set; }
        public bool Pagado { get; set; }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Factura #{NumeroFactura}: Cliente: {Cliente}, Monto: {MontoTotal}, Método de Pago: {MetodoPago}, Pagado: {Pagado}");
        }
        public void Pagar()
        {
            Pagado = true;
            Console.WriteLine($"La factura #{NumeroFactura} ha sido pagada.");
        }

        public void Anular()
        {
            Console.WriteLine($"La factura #{NumeroFactura} ha sido anulada.");
        }
    }
    public class Equipaje
    {
        public int IdMaleta { get; set; }
        public string Propietario { get; set; }
        public double Peso { get; set; }
        public string Prioridad { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Maleta #{IdMaleta}: Dueño: {Propietario}, Peso: {Peso} kg, Prioridad: {Prioridad}");
        }

        public void VerificarPeso()
        {
            if (Peso > 23)
                Console.WriteLine($"La maleta #{IdMaleta} excede el peso permitido.");
            else
                Console.WriteLine($"La maleta #{IdMaleta} está dentro del límite de peso.");
        }
        public void CambiarPrioridad(string nuevaPrioridad)
        {
            Prioridad = nuevaPrioridad;
            Console.WriteLine($"La prioridad de la maleta #{IdMaleta} ha sido cambiada a {nuevaPrioridad}.");
        }
    }
}