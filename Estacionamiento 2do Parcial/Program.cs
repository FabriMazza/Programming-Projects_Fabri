using System;
using System.Collections.Generic;

namespace Estacionamiento
{
    internal class Program
    {
        static List<string> chapas = new List<string>();
        static List<string> tipos = new List<string>();
        static List<string> ver_tipos = new List<string>();
        static List<DateTime> horas_ingreso = new List<DateTime>();

        static int cant_auto = 0;
        static int cant_moto = 0;
        static int cant_camioneta = 0;
        static int rec_total = 0;
        static int rec_auto = 0;
        static int rec_moto = 0;
        static int rec_camioneta = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("ESTACIONAMIENTO RIVADAVIA");
            Console.WriteLine("=========================");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("MENÚ DE OPCIONES:");
                Console.WriteLine();
                Console.WriteLine("1. Ingresar Vehículo");
                Console.WriteLine("2. Buscar Vehículo por Chapa");
                Console.WriteLine("3. Ver Cantidad de Vehículos por Tipo");
                Console.WriteLine("4. Ver Vehículos Ordenados por Hora de Ingreso");
                Console.WriteLine("5. Dar Salida a Vehículo");
                Console.WriteLine("6. Ver Recaudación");
                Console.WriteLine("7. Ver Todas las Chapas y Tipos Ingresados");
                Console.WriteLine("8. Salir");
                Console.WriteLine();
                Console.Write("Seleccione una opción: ");
                var opcion = Console.ReadLine();

                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        IngresarVehiculo();
                        break;
                    case "2":
                        Console.Clear();
                        BuscarVehiculo();
                        break;
                    case "3":
                        Console.Clear();
                        VerCantidadVehiculosPorTipo();
                        break;
                    case "4":
                        Console.Clear();
                        VerVehiculosOrdenadosPorHoraIngreso();
                        break;
                    case "5":
                        Console.Clear();
                        DarSalidaVehiculo();
                        break;
                    case "6":
                        Console.Clear();
                        VerRecaudacion();
                        break;
                    case "7":
                        Console.Clear();
                        VerTodasLasChapas();
                        break;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        Console.WriteLine();
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        static void IngresarVehiculo()
        {
            Console.Write("Ingrese la chapa del vehículo (Ejemplo: AAA333): ");
            var chapa = Console.ReadLine();

            for (int i = 0; i < chapas.Count; i++)
            {
                if (chapas[i] == chapa)
                {
                    Console.WriteLine("ERROR: VEHICULO YA INGRESADO.");
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
            }

            {
                Console.Write("Ingrese el tipo de vehículo (1- Moto, 2- Auto, 3- Camioneta): ");
                var tipo = Console.ReadLine().ToLower();

                if (tipo != "1" && tipo != "2" && tipo != "3")
                {
                    Console.WriteLine("ERROR: Tipo de vehículo no válido. Debe ser Moto, Auto o Camioneta.");
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }

                if (tipo == "2")
                {
                    cant_auto = cant_auto + 1;
                    ver_tipos.Add("Auto");
                }
                if (tipo == "1")
                {
                    cant_moto = cant_moto + 1;
                    ver_tipos.Add("Moto");
                }
                if (tipo == "3")
                {
                    cant_camioneta = cant_camioneta + 1;
                    ver_tipos.Add("Camioneta");
                }

                chapas.Add(chapa);
                tipos.Add(tipo);
                horas_ingreso.Add(DateTime.Now);

                Console.WriteLine();
                Console.WriteLine("VEHICULO INGRESADO CORRECTAMENTE.");
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void BuscarVehiculo()
        {
            if (cant_moto > 0 || cant_auto > 0 || cant_camioneta > 0)
            {
                Console.Write("Ingrese la chapa del vehículo a buscar: ");
                var chapa = Console.ReadLine();

                for (int i = 0; i < chapas.Count; i++)
                {
                    if (chapas[i] == chapa)
                    {
                    Console.WriteLine();
                    Console.WriteLine("VEHICULO ENCONTRADO: ");
                    Console.WriteLine();
                    Console.WriteLine("Chapa: " + chapa);
                    Console.WriteLine("Tipo: " + tipos[i]);
                    Console.WriteLine("Hora de Ingreso: " + horas_ingreso[i]);
                    Console.WriteLine();
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
            }
        }
                Console.WriteLine();
                Console.WriteLine("NO SE ENCONTRARON VEHICULOS.");
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
        }

        static void VerCantidadVehiculosPorTipo()
        {
            if (cant_moto > 0 || cant_auto > 0 || cant_camioneta > 0)
            {
                Console.WriteLine("Cantidad de vehículos por tipo:");
                Console.WriteLine();
                Console.WriteLine("Motos: " + cant_moto);
                Console.WriteLine("Autos: " + cant_auto);
                Console.WriteLine("Camionetas: " + cant_camioneta);
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("NO SE ENCONTRARON VEHICULOS.");
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void VerVehiculosOrdenadosPorHoraIngreso()
        {
            if (chapas.Count > 0)
            {
                var vehiculosOrdenados = new List<(string Chapa, string Tipo, DateTime HoraIngreso)>();

                for (int i = 0; i < chapas.Count; i++)
                {
                    vehiculosOrdenados.Add((chapas[i], ver_tipos[i], horas_ingreso[i]));
                }

                vehiculosOrdenados.Sort((x, y) => x.HoraIngreso.CompareTo(y.HoraIngreso));

                foreach (var vehiculo in vehiculosOrdenados)
                {
                    Console.WriteLine($"{vehiculo.Chapa} - {vehiculo.Tipo} - {vehiculo.HoraIngreso}");
                }

                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("NO SE ENCONTRARON VEHICULOS.");
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DarSalidaVehiculo()
        {
            Console.Write("Ingrese la chapa del vehículo a dar salida: ");
            var chapa = Console.ReadLine();

            int monto_a_pagar = 0;
            bool encontrado = false;

            for (int i = 0; i < chapas.Count; i++)
            {
                if (chapas[i] == chapa)
                {
                    encontrado = true;

                    string tipo = tipos[i];

                    DateTime horaIngreso = horas_ingreso[i];
                    DateTime horaSalida = DateTime.Now;
                    TimeSpan tiempoPermanencia = horaSalida - horaIngreso;

                    int cant_horas = (int)Math.Ceiling(tiempoPermanencia.TotalHours);

                    if (tipo == "1")
                    {
                        monto_a_pagar = cant_horas * 200;
                        cant_moto = cant_moto - 1;
                        rec_moto = rec_moto + monto_a_pagar;
                    }
                    else if (tipo == "2")
                    {
                        monto_a_pagar = cant_horas * 500;
                        cant_auto = cant_auto - 1;
                        rec_auto = rec_auto + monto_a_pagar;
                    }
                    else if (tipo == "3")
                    {
                        monto_a_pagar = cant_horas * 700;
                        cant_camioneta = cant_camioneta - 1;
                        rec_camioneta = rec_camioneta + monto_a_pagar;
                    }

                    Console.WriteLine();
                    Console.WriteLine($"El vehículo con chapa {chapa} salió del estacionamiento. Monto a pagar: ${monto_a_pagar}");

                    chapas.RemoveAt(i);
                    ver_tipos.RemoveAt(i);
                    horas_ingreso.RemoveAt(i);
                    tipos.RemoveAt(i);

                    Console.WriteLine();
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("VEHICULO NO ENCONTRADO.");
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void VerRecaudacion()
        {
            if (rec_moto > 0 || rec_auto > 0 || rec_camioneta > 0)
            {
                int rec_total = rec_auto + rec_moto + rec_camioneta;

                Console.WriteLine("RECAUDACION MOTOS: $" + rec_moto);
                Console.WriteLine("RECAUDACION AUTOS: $" + rec_auto);
                Console.WriteLine("RECAUDACION CAMIONETAS: $" + rec_camioneta);
                Console.WriteLine();
                Console.WriteLine("RECAUDACION TOTAL: $" + rec_total);
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("NO SE ENCONTRARON VEHICULOS.");
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void VerTodasLasChapas()
        {
            if (chapas.Count > 0)
            {
                Console.WriteLine("Chapas y Tipos ingresados:");
                Console.WriteLine();

                for (int i = 0; i < chapas.Count; i++)
                {
                    Console.WriteLine(chapas[i]+" - "+ver_tipos[i]);
                    
                }

                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("NO HAY VEHICULOS INGRESADOS.");
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
