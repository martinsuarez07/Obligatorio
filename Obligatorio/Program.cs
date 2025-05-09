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

            Console.WriteLine("\nListado de todos los clientes:\n");

            List<Cliente> lista = sistema.RetornarLista();

            if (lista == null || lista.Count == 0)
            {
                Console.WriteLine("No hay clientes cargados en el sistema.");
                return;
            }

            for (int i = 0; i < lista.Count; i++)
            {
                Cliente c = lista[i];
                Console.WriteLine(c.ToString()); // Método polimórfico
            }
        }
        public static void AltaClienteOcacional(Ocacional cliente)
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

    }
}

