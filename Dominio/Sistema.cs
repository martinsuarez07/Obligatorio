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
        private List<Premium> _premiums;
        private List<Ocacional> _ocacionales;

        public List<Administrador> Administrador { get { return new List<Administrador>(_administradores); } }
        public List<Cliente> Cliente { get { return new List<Cliente>(_clientes); } }
        public List<Aeropuerto> Aeropuerto { get { return new List<Aeropuerto>(_aeropuertos); } }
        public List<Avion> Avion { get { return new List<Avion>(_aviones); } }

        public List<Pasaje> Pasaje { get { return new List<Pasaje>(_pasajes); } }
        public List<Ruta> Ruta { get { return new List<Ruta>(_rutas); } }
        public List<Vuelo> Vuelo { get { return new List<Vuelo>(_vuelos); } }

        public List<Premium> Premium { get { return new List<Premium>(_premiums); } }
        public List<Ocacional> Ocacional { get { return new List<Ocacional>(_ocacionales); } }


        private void PrecargarDatos()
        {
            PrecargarClientesPremium();
            PrecargarClientesOcacionales();
            PrecargarAdmin();
            PrecargarVuelos();
            PrecargarPasaje();
            PrecargarRutas();
            PrecargarAviones();
        }



        private void PrecargarClientesPremium()
        {
            try
            {
                AgregarClientePremium(new Premium("51233243", "Juan Pérez", "juan.perez@gmail.com", "abc123", "Uruguayo", "Ventaja", 1234));
                AgregarClientePremium(new Premium("51233252", "Ana López", "ana.lopez@gmail.com", "ana123", "Argentina", "ventaja", 2345));
                AgregarClientePremium(new Premium("51233262", "Carlos García", "carlos.garcia@gmail.com", "carlos123", "Paraguayo", "Ventaja", 3456));
                AgregarClientePremium(new Premium("51233271", "María Rodríguez", "maria.rodriguez@gmail.com", "maria123", "Chileno", "Ventaja", 4567));
                AgregarClientePremium(new Premium("51233281", "Luis Martínez", "luis.martinez@gmail.com", "luis123", "Peruano", "Ventaja", 5678));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar cliente: {ex.Message}");
            }
        }
        private void PrecargarClientesOcacionales()
        {
            try
            {
                AgregarClienteOcacional(new Ocacional("51233402", "Carlos Ruiz", "carlos.ruiz@gmail.com", "car123", "Uruguayo", true));
                AgregarClienteOcacional(new Ocacional("51233413", "Lucía González", "lucia.gonzalez@gmail.com", "lucia123", "Argentina", false));
                AgregarClienteOcacional(new Ocacional("51233442", "Martín López", "martin.lopez@gmail.com", "martin123", "Paraguayo", true));
                AgregarClienteOcacional(new Ocacional("51233432", "Valentina Pérez", "valentina.perez@gmail.com", "valentina123", "Chileno", false));
                AgregarClienteOcacional(new Ocacional("51233414", "José Rodríguez", "jose.rodriguez@gmail.com", "jose123", "Peruano", true));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar cliente: {ex.Message}");
            }
        }
        private void PrecargarAdmin()
        {
            AgregarAdmin(new Administrador("admin1", "admin1@empresa.com", "password123"));
            AgregarAdmin(new Administrador("admin2", "admin2@empresa.com", "password234"));
        }
        private void PrecargarVuelos()
        {
        }
        private void PrecargarAviones()
        {
            try
            {
                AgregarAvion(new Avion("Airbus", "A320", 180, 5000, 2.5m));
                AgregarAvion(new Avion("Boeing", "737", 200, 4500, 2.2m));
                AgregarAvion(new Avion("Airbus", "A350", 300, 9000, 3.0m));
                AgregarAvion(new Avion("Boeing", "787", 250, 7000, 2.8m));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar aviones: {ex.Message}");
            }
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

        public void AgregarClientePremium(Premium cliente)
        {
            if (cliente == null)
            {
                throw new Exception("No puede ser nulo");
            }
            cliente.Validar();
            if (_premiums.Contains(cliente))
            {
                throw new Exception("El cliente premium ya existe");
            }
            _premiums.Add(cliente);
        }

        public void AgregarClienteOcacional(Ocacional cliente)
        {
            if (cliente == null)
            {
                throw new Exception("No puede ser nulo");
            }
            cliente.Validar();
            if (_ocacionales.Contains(cliente))
            {
                throw new Exception("El cliente premium ya existe");
            }
            _ocacionales.Add(cliente);
        }

        public void AgregarAdmin(Administrador admin)
        {
            if (admin == null)
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
        public void AgregarAvion(Avion avion)
        {
            if (avion == null)
            {
                throw new Exception("El avion no puede ser nulo");
            }
            avion.Validar();
            if (_aviones.Contains(avion))
            {
                throw new Exception("El avion ya existe");
            }
            _aviones.Add(avion);
        }

        public void AgregarRuta(Ruta ruta)
        {
            if (ruta == null)
            {
                throw new Exception("No puede ser nulo");
            }
            ruta.Validar();
            if (_rutas.Contains(ruta))
            {
                throw new Exception("La ruta ya existe");
            }
            _rutas.Add(ruta);
        }

        public void AgregarVuelo(Vuelo vuelo)
        {
            if (vuelo == null)
            {
                throw new Exception("El vuelo no puede ser nulo");
            }
            vuelo.Validar();
            if (_vuelos.Contains(vuelo))
            {
                throw new Exception("El vuelo ya existe");
            }
            _vuelos.Add(vuelo);
        }

        public void AgregarPasaje(Pasaje pasaje)
        {
            if (pasaje == null)
            {
                throw new Exception("El pasaje no puede ser nulo");
            }
            pasaje.Validar();
            if (_pasajes.Contains(pasaje))
            {
                throw new Exception("Ya existe");
            }
            _pasajes.Add(pasaje);
        }
    }
}



