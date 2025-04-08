using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Dominio
{
    public class Sistema

    {
        private List<Administrador> _administradores;
        private List<Cliente> _clientes;
        private List<Aeropuerto> _aeropuertos;
        private List<Avion> _aviones;
        private List<Pasaje> _pasajes;
        private List<Ruta> _rutas;
        private List<Vuelo> _vuelos;



         private void PrecargarDatos()
        {
            PrecargarClientes();
            PrecargarAdmin();
            PrecargarVuelos();
            PrecargarPasaje();
            PrecargarRutas();
            PrecargarAviones();
        }

        private void PrecargarClientes()
        {


        }
        private void PrecargarAdmin()
        {
        }
        private void PrecargarVuelos()
        {
        }
        private void PrecargarAviones()
        {
        }
        private void PrecargarPasaje()
        {
        }
        private void PrecargarRutas()
        {
        }

        public void AgregarCliente(Cliente cliente)
        {
            if(cliente == null)
            {
                throw new Exception("No puede ser nulo");
            }
            cliente.Validar();
            if (_clientes.Contains(cliente))
            {
                throw new Exception("El cliente ya existe");
            }
            _clientes.Add(cliente);
        }
    }
}



