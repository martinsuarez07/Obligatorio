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

        public List<Administrador> Administrador { get { return new List<Administrador>(_administradores); } }
        public List<Cliente> Cliente { get { return new List<Cliente>(_clientes); } }
        public List<Aeropuerto> Aeropuerto { get { return new List<Aeropuerto>(_aeropuertos); } }
        public List<Avion> Avion { get { return new List<Avion>(_aviones); } }

        public List<Pasaje> Pasaje { get { return new List<Pasaje>(_pasajes); } }
        public List<Ruta> Ruta { get { return new List<Ruta>(_rutas); } }
        public List<Vuelo> Vuelo { get { return new List<Vuelo>(_vuelos); } }

       
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
            if (cliente == null)
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

        public void AgregarAdmin(Administrador admin)
        {
            if( admin == null)
            {
                throw new Exception("No puede ser nulo");
            }
            admin.Validar();
            if (_administradores.Contains(admin))
            {
                throw new Exception("El admin ya existe");
            }
            _administradores.Add(admin);
        }
    }
}



