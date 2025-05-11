using Dominio;

namespace Obligatorio
{
    internal class Program
    {
        static Sistema sistema = new Sistema();
        static void Main(string[] args)
        {
            sistema.PrecargarDatos();
            int opcion;
            bool flag = false;
            while (!flag)
            {

                OpcionesMenu();

                opcion = SolicitarNumero();
                try
                {
                    switch (opcion)
                    {
                        case 0:
                            flag = true;
                            break;
                        case 1:
                            ListarClientes();
                            break;
                        case 2:
                            EjecutarConsultaRutasPorCodigoIATA();
                            break;
                        case 3:
                            //Nuevo ayuda de chat nano 07/05/1:21am VER
                            Ocacional nuevoCliente = CrearClienteOcacional();
                            AltaClienteOcacional(nuevoCliente);
                            Console.WriteLine("Cliente ocasional agregado con éxito.");
                            break;

                        case 4:
                            //METODO 4
                            ListarPasajesEntreFechas();
                            break;

                        default:
                            Console.WriteLine("La opcion seleccionada no existe\n");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menu");
                    Console.ReadKey();
                }

                Console.Clear();
            }
        }



        public static void OpcionesMenu()
        {
            Console.WriteLine("Menu\n");
            Console.WriteLine("1 -Listado de todos los clientes");
            Console.WriteLine("2 - Codigo de Aeropuerto");
            Console.WriteLine("3 - Alta de cliente ocasional");
            Console.WriteLine("4 - Ingrese dos fechas");
            Console.WriteLine("Ingrese 0 para salir\n");

        }
        private static int SolicitarNumero()
        {
            int numero = 0;
            bool seleccionoNumero = false;
            Console.WriteLine("Ingrese un valor\n");
            while (!seleccionoNumero)
            {

                try
                {

                    numero = int.Parse(Console.ReadLine());
                    seleccionoNumero = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ingrese un numero");
                }
            }


            return numero;
        }

        private static void ListarClientes()
        {
            try
            {
                Console.WriteLine("\nListado de todos los clientes:\n");

                List<Cliente> lista = sistema.RetornarLista();

                if (lista == null || lista.Count == 0)
                {
                    Console.WriteLine("No hay clientes cargados en el sistema.");

                }
                else
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        Cliente c = lista[i];
                        Console.WriteLine(c.ToString()); // Método polimórfico
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void AltaClienteOcacional(Ocacional cliente)
        {
            try
            {

                List<Cliente> lista = sistema.RetornarLista();
                if (cliente == null)
                {
                    throw new Exception("el cliente no puede ser nulo");
                }
                cliente.Validar();
                if (lista.Contains(cliente))
                {
                    throw new Exception("el cliente ya existe");
                }
                lista.Add(cliente);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
            
    
       
        //Nuevo ayuda de chat nano 07/05/1:21am VER


        private static Ocacional CrearClienteOcacional()
        {
            
            Console.WriteLine("Ingrese cédula:");
            string ci = Console.ReadLine();

            Console.WriteLine("Ingrese nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese correo electrónico:");
            string correo = Console.ReadLine();

            Console.WriteLine("Ingrese contraseña:");
            string password = Console.ReadLine();

            Console.WriteLine("Ingrese nacionalidad:");
            string nacionalidad = Console.ReadLine();

            if (string.IsNullOrEmpty(ci)|| string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(nacionalidad))
            {
                throw new Exception("Datos no validados");
            }


                return new Ocacional(ci, nombre, correo, password, nacionalidad);
        }

        //public static void  listarPasajeEntreFechas()
        //{
        //    Console.WriteLine("Fecha Inicio");
        //    DateTime fecha1 = Console.ReadLine();

        //    Console.WriteLine("Fecha Inicio");
        //    DateTime fecha2 = Console.ReadLine();
        //    try
        //    {
        //        if ()
        //        {

        //        }
        //    }
        //    return new Pasaje(id ,  vuelo,fecha, cliente,precio);
        //}

        // dado un codigo de aeropuerto listar todos los codigos que lo incluyen codIATA 
        private static void EjecutarConsultaRutasPorCodigoIATA()
        {
            Console.WriteLine("Ingrese el código IATA del aeropuerto:");
            string cod = Console.ReadLine();

            try
            {
                if (string.IsNullOrEmpty(cod))
                {

                    throw new Exception("Debe ingresar un codigo.");
                }

                List<Vuelo> vuelos = sistema.VuelosFiltrados(cod);

                if (vuelos.Count == 0)
                {
                    Console.WriteLine("No se encontraron vuelos para el código IATA ingresado.");
                }
                else
                {
                    Console.WriteLine("Rutas encontradas:");
                    foreach (Vuelo v in vuelos)
                    {
                        Console.WriteLine(v);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }

        }
        private static void ListarPasajesEntreFechas()
        {
            try
            {
                Console.WriteLine("Ingrese la fecha de inicio (formato: dd/mm/yyyy):");
                 DateTime.TryParse(Console.ReadLine(), out DateTime fechaInicio);

                Console.WriteLine("Ingrese la fecha de fin (formato: dd/mm/yyyy):");
                
                    DateTime.TryParse(Console.ReadLine(), out DateTime fechaFin);
                if(fechaInicio == new DateTime() || fechaFin == new DateTime())
                {
                    throw new Exception("Fecha no valida.");
                }

                if (fechaInicio > fechaFin)
                {
                    throw new Exception("La fecha de inicio no puede ser posterior a la fecha de fin.");
                }


                List<Pasaje> todosLosPasajes = sistema.ObtenerPasajes();
                List<Pasaje> pasajesFiltrados = new List<Pasaje>();

                foreach (Pasaje pasaje in todosLosPasajes)
                {
                    if (pasaje.Fecha.Date >= fechaInicio.Date && pasaje.Fecha.Date <= fechaFin.Date)
                    {
                        pasajesFiltrados.Add(pasaje);
                    }
                }

                if (pasajesFiltrados.Count == 0)
                {
                    Console.WriteLine("No se encontraron pasajes en el rango de fechas ingresado.");
                    
                }

                Console.WriteLine("\nPasajes encontrados:");
                foreach (Pasaje p in pasajesFiltrados)
                {
                    Console.WriteLine(p);
                }
            }
           
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}

