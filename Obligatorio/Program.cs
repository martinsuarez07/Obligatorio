using Dominio;

namespace Obligatorio
{
    internal class Program
    {
        static Sistema sistema = new Sistema();
        static void Main(string[] args)
        {
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
                            //METODO 1
                            break;
                        case 2:
                            //METODO 2
                            break;
                        case 3:
                            //METODO 3
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
    }
}
