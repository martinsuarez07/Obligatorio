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
        public static Sistema _instancia;
        private List<Administrador> _administradores = new List<Administrador>();
        private List<Cliente> _clientes = new List<Cliente>();
        private List<Aeropuerto> _aeropuertos = new List<Aeropuerto>();
        private List<Avion> _aviones = new List<Avion>();
        private List<Pasaje> _pasajes = new List<Pasaje>();
        private List<Ruta> _rutas = new List<Ruta>();
        private List<Vuelo> _vuelos = new List<Vuelo>();
        private List<Usuario> _usuarios = new List<Usuario>();

        private Sistema()
        {
            PrecargarDatos();
        }

        public List<Administrador> Administrador { get { return new List<Administrador>(_administradores); } }
        public List<Cliente> Cliente { get { return new List<Cliente>(_clientes); } }
        public List<Aeropuerto> Aeropuerto { get { return new List<Aeropuerto>(_aeropuertos); } }
        public List<Avion> Avion { get { return new List<Avion>(_aviones); } }

        public List<Pasaje> Pasaje { get { return new List<Pasaje>(_pasajes); } }
        public List<Ruta> Ruta { get { return new List<Ruta>(_rutas); } }
        public List<Vuelo> Vuelo { get { return new List<Vuelo>(_vuelos); } }
        public List<Usuario> Usuario { get { return new List<Usuario>(_usuarios); } }
        public static Sistema Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Sistema();
                }
                return _instancia;
            }
        }


        //-------------------------------------------- PRECARGAS------------------------------------------------------
        public void PrecargarDatos()
        {
            PrecargarClientes();
            PrecargarAdmin();
            PrecargarAeropuerto();
            PrecargarRutas();

            PrecargarAviones();
            PrecargarVuelos();
            PrecargarPasaje();
        }



        private void PrecargarClientes()
        {
            Ocacional o1 = new Ocacional("51244125", "Jorge", "jorge@gmail.com", "abc123", "Uruguayo");
            AgregarCliente(o1);

            Ocacional o2 = new Ocacional("51244126", "Ana", "ana@gmail.com", "def456", "Argentina");
            AgregarCliente(o2);

            Ocacional o3 = new Ocacional("51244127", "Carlos", "carlos@gmail.com", "ghi789", "Chileno");
            AgregarCliente(o3);

            Ocacional o4 = new Ocacional("51244128", "Luisa", "luisa@gmail.com", "jkl012", "Peruana");
            AgregarCliente(o4);

            Ocacional o5 = new Ocacional("51244129", "Felipe", "felipe@gmail.com", "mno345", "Colombiano");
            AgregarCliente(o5);

            Premium p1 = new Premium("61244125", "Martín", "martin@gmail.com", "xyz123", "Uruguayo", 150);
            AgregarCliente(p1);

            Premium p2 = new Premium("61244126", "Laura", "laura@gmail.com", "abc789", "Argentina", 200);
            AgregarCliente(p2);

            Premium p3 = new Premium("61244127", "Ricardo", "ricardo@gmail.com", "def456", "Chileno", 250);
            AgregarCliente(p3);

            Premium p4 = new Premium("61244128", "Sofia", "sofia@gmail.com", "ghi012", "Peruana", 300);
            AgregarCliente(p4);

            Premium p5 = new Premium("61244129", "Esteban", "esteban@gmail.com", "jkl345", "Colombiano", 400);
            AgregarCliente(p5);
        }

        private void PrecargarAdmin()
        {
            Administrador a1 = new Administrador("Nano", "nano1891@gmail.com", "abc321");
            AgregarAdmin(a1);
            Administrador a2 = new Administrador("Titi", "titi@gmail.com", "abc123");
            AgregarAdmin(a2);
        }

        private void PrecargarAeropuerto()
        {
            Aeropuerto ap1 = new Aeropuerto("mv2", "Montevideo", 4000, 120);
            AgregarAeropuerto(ap1);
            Aeropuerto ap2 = new Aeropuerto("ba1", "Buenos Aires", 5000, 150);
            AgregarAeropuerto(ap2);

            Aeropuerto ap3 = new Aeropuerto("scl", "Santiago", 6000, 180);
            AgregarAeropuerto(ap3);

            Aeropuerto ap4 = new Aeropuerto("bog", "Bogotá", 5500, 160);
            AgregarAeropuerto(ap4);

            Aeropuerto ap5 = new Aeropuerto("lim", "Lima", 4500, 140);
            AgregarAeropuerto(ap5);

            Aeropuerto ap6 = new Aeropuerto("ccs", "Caracas", 4000, 130);
            AgregarAeropuerto(ap6);

            Aeropuerto ap7 = new Aeropuerto("qro", "Querétaro", 3800, 110);
            AgregarAeropuerto(ap7);

            Aeropuerto ap8 = new Aeropuerto("rio", "Río de Janeiro", 4900, 145);
            AgregarAeropuerto(ap8);

            Aeropuerto ap9 = new Aeropuerto("grs", "Granada", 4700, 135);
            AgregarAeropuerto(ap9);

            Aeropuerto ap10 = new Aeropuerto("mex", "México DF", 7000, 200);
            AgregarAeropuerto(ap10);

            Aeropuerto ap11 = new Aeropuerto("sao", "São Paulo", 6500, 190);
            AgregarAeropuerto(ap11);

            Aeropuerto ap12 = new Aeropuerto("mar", "Maracaibo", 3800, 100);
            AgregarAeropuerto(ap12);

            Aeropuerto ap13 = new Aeropuerto("sdu", "São Duprat", 4000, 120);
            AgregarAeropuerto(ap13);

            Aeropuerto ap14 = new Aeropuerto("mzt", "Mazatlán", 3600, 115);
            AgregarAeropuerto(ap14);

            Aeropuerto ap15 = new Aeropuerto("asr", "Asunción", 4200, 125);
            AgregarAeropuerto(ap15);

            Aeropuerto ap16 = new Aeropuerto("gua", "Guatemala", 4600, 145);
            AgregarAeropuerto(ap16);

            Aeropuerto ap17 = new Aeropuerto("bvs", "Boca del Río", 3900, 110);
            AgregarAeropuerto(ap17);

            Aeropuerto ap18 = new Aeropuerto("mcz", "Macapá", 3500, 100);
            AgregarAeropuerto(ap18);

            Aeropuerto ap19 = new Aeropuerto("mde", "Medellín", 4800, 160);
            AgregarAeropuerto(ap19);

            Aeropuerto ap20 = new Aeropuerto("cdr", "Córdoba", 4200, 120);
            AgregarAeropuerto(ap20);

        }
        private void PrecargarRutas()
        {
            Ruta ruta1 = new Ruta(1, _aeropuertos[0], _aeropuertos[1], 3200);
            AgregarRuta(ruta1);
            Ruta ruta2 = new Ruta(2, _aeropuertos[1], _aeropuertos[2], 3300);
            AgregarRuta(ruta2);
            Ruta ruta3 = new Ruta(3, _aeropuertos[2], _aeropuertos[3], 3500);
            AgregarRuta(ruta3);
            Ruta ruta4 = new Ruta(4, _aeropuertos[3], _aeropuertos[4], 3700);
            AgregarRuta(ruta4);
            Ruta ruta5 = new Ruta(5, _aeropuertos[4], _aeropuertos[5], 3000);
            AgregarRuta(ruta5);
            Ruta ruta6 = new Ruta(6, _aeropuertos[5], _aeropuertos[6], 3100);
            AgregarRuta(ruta6);
            Ruta ruta7 = new Ruta(7, _aeropuertos[6], _aeropuertos[7], 2950);
            AgregarRuta(ruta7);
            Ruta ruta8 = new Ruta(8, _aeropuertos[7], _aeropuertos[8], 3400);
            AgregarRuta(ruta8);
            Ruta ruta9 = new Ruta(9, _aeropuertos[8], _aeropuertos[9], 3300);
            AgregarRuta(ruta9);
            Ruta ruta10 = new Ruta(10, _aeropuertos[9], _aeropuertos[10], 3600);
            AgregarRuta(ruta10);
            Ruta ruta11 = new Ruta(11, _aeropuertos[10], _aeropuertos[11], 3900);
            AgregarRuta(ruta11);
            Ruta ruta12 = new Ruta(12, _aeropuertos[11], _aeropuertos[12], 2800);
            AgregarRuta(ruta12);
            Ruta ruta13 = new Ruta(13, _aeropuertos[12], _aeropuertos[13], 3100);
            AgregarRuta(ruta13);
            Ruta ruta14 = new Ruta(14, _aeropuertos[13], _aeropuertos[14], 2700);
            AgregarRuta(ruta14);
            Ruta ruta15 = new Ruta(15, _aeropuertos[14], _aeropuertos[15], 2900);
            AgregarRuta(ruta15);
            Ruta ruta16 = new Ruta(16, _aeropuertos[15], _aeropuertos[16], 3500);
            AgregarRuta(ruta16);
            Ruta ruta17 = new Ruta(17, _aeropuertos[16], _aeropuertos[17], 2800);
            AgregarRuta(ruta17);
            Ruta ruta18 = new Ruta(18, _aeropuertos[17], _aeropuertos[18], 2600);
            AgregarRuta(ruta18);
            Ruta ruta19 = new Ruta(19, _aeropuertos[18], _aeropuertos[19], 3700);
            AgregarRuta(ruta19);
            Ruta ruta20 = new Ruta(20, _aeropuertos[19], _aeropuertos[0], 3000);
            AgregarRuta(ruta20);
            Ruta ruta21 = new Ruta(21, _aeropuertos[0], _aeropuertos[2], 3400);
            AgregarRuta(ruta21);
            Ruta ruta22 = new Ruta(22, _aeropuertos[1], _aeropuertos[3], 3300);
            AgregarRuta(ruta22);
            Ruta ruta23 = new Ruta(23, _aeropuertos[2], _aeropuertos[4], 3500);
            AgregarRuta(ruta23);
            Ruta ruta24 = new Ruta(24, _aeropuertos[3], _aeropuertos[5], 3100);
            AgregarRuta(ruta24);
            Ruta ruta25 = new Ruta(25, _aeropuertos[4], _aeropuertos[6], 3700);
            AgregarRuta(ruta25);
            Ruta ruta26 = new Ruta(26, _aeropuertos[5], _aeropuertos[7], 2800);
            AgregarRuta(ruta26);
            Ruta ruta27 = new Ruta(27, _aeropuertos[6], _aeropuertos[8], 3000);
            AgregarRuta(ruta27);
            Ruta ruta28 = new Ruta(28, _aeropuertos[7], _aeropuertos[9], 3600);
            AgregarRuta(ruta28);
            Ruta ruta29 = new Ruta(29, _aeropuertos[8], _aeropuertos[10], 3100);
            AgregarRuta(ruta29);
            Ruta ruta30 = new Ruta(30, _aeropuertos[9], _aeropuertos[11], 3300);
            AgregarRuta(ruta30);
        }
        private void PrecargarAviones()
        {
            Avion av1 = new Avion("Agustin", "ax1", 23, 300000, 150000);
            AgregarAvion(av1);

            Avion av2 = new Avion("Belgrano", "bx1", 30, 3500000, 180000);
            AgregarAvion(av2);

            Avion av3 = new Avion("Libertad", "cx1", 40, 4000000, 200000);
            AgregarAvion(av3);

            Avion av4 = new Avion("Condor", "dx1", 50, 45000000, 250000);
            AgregarAvion(av4);
        }
        private void PrecargarVuelos()
        {


            Vuelo vuelo1 = new Vuelo("VN001", _rutas[1], _aviones[1], new List<DayOfWeek> { DayOfWeek.Monday });
            AgregarVuelo(vuelo1);
            Vuelo vuelo2 = new Vuelo("VD002", _rutas[2], _aviones[1], new List<DayOfWeek> { DayOfWeek.Tuesday });
            AgregarVuelo(vuelo2);
            Vuelo vuelo3 = new Vuelo("VG003", _rutas[3], _aviones[2], new List<DayOfWeek> { DayOfWeek.Wednesday });
            AgregarVuelo(vuelo3);
            Vuelo vuelo4 = new Vuelo("VA004", _rutas[4], _aviones[1], new List<DayOfWeek> { DayOfWeek.Thursday });
            AgregarVuelo(vuelo4);
            Vuelo vuelo5 = new Vuelo("VS005", _rutas[5], _aviones[2], new List<DayOfWeek> { DayOfWeek.Friday });
            AgregarVuelo(vuelo5);
            Vuelo vuelo6 = new Vuelo("VE006", _rutas[6], _aviones[0], new List<DayOfWeek> { DayOfWeek.Saturday });
            AgregarVuelo(vuelo6);
            Vuelo vuelo7 = new Vuelo("VT007", _rutas[7], _aviones[2], new List<DayOfWeek> { DayOfWeek.Sunday });
            AgregarVuelo(vuelo7);
            Vuelo vuelo8 = new Vuelo("VY008", _rutas[3], _aviones[0], new List<DayOfWeek> { DayOfWeek.Monday });
            AgregarVuelo(vuelo8);
            Vuelo vuelo9 = new Vuelo("VU009", _rutas[2], _aviones[1], new List<DayOfWeek> { DayOfWeek.Tuesday });
            AgregarVuelo(vuelo9);
            Vuelo vuelo10 = new Vuelo("VI010", _rutas[0], _aviones[1], new List<DayOfWeek> { DayOfWeek.Wednesday });
            AgregarVuelo(vuelo10);
            Vuelo vuelo11 = new Vuelo("VA011", _rutas[1], _aviones[2], new List<DayOfWeek> { DayOfWeek.Thursday });
            AgregarVuelo(vuelo11);
            Vuelo vuelo12 = new Vuelo("VB012", _rutas[2], _aviones[0], new List<DayOfWeek> { DayOfWeek.Friday });
            AgregarVuelo(vuelo12);
            Vuelo vuelo13 = new Vuelo("VB013", _rutas[6], _aviones[1], new List<DayOfWeek> { DayOfWeek.Saturday });
            AgregarVuelo(vuelo13);
            Vuelo vuelo14 = new Vuelo("VA014", _rutas[6], _aviones[2], new List<DayOfWeek> { DayOfWeek.Sunday });
            AgregarVuelo(vuelo14);
            Vuelo vuelo15 = new Vuelo("VA015", _rutas[8], _aviones[0], new List<DayOfWeek> { DayOfWeek.Monday });
            AgregarVuelo(vuelo15);
            Vuelo vuelo16 = new Vuelo("VA016", _rutas[10], _aviones[2], new List<DayOfWeek> { DayOfWeek.Tuesday });
            AgregarVuelo(vuelo16);
            Vuelo vuelo17 = new Vuelo("VA017", _rutas[11], _aviones[0], new List<DayOfWeek> { DayOfWeek.Wednesday });
            AgregarVuelo(vuelo17);
            Vuelo vuelo18 = new Vuelo("VA018", _rutas[12], _aviones[1], new List<DayOfWeek> { DayOfWeek.Thursday });
            AgregarVuelo(vuelo18);
            Vuelo vuelo19 = new Vuelo("VA019", _rutas[0], _aviones[0], new List<DayOfWeek> { DayOfWeek.Friday });
            AgregarVuelo(vuelo19);
            Vuelo vuelo20 = new Vuelo("VA020", _rutas[1], _aviones[1], new List<DayOfWeek> { DayOfWeek.Saturday });
            AgregarVuelo(vuelo20);
            Vuelo vuelo21 = new Vuelo("VA021", _rutas[2], _aviones[2], new List<DayOfWeek> { DayOfWeek.Sunday });
            AgregarVuelo(vuelo21);
            Vuelo vuelo22 = new Vuelo("VA022", _rutas[22], _aviones[1], new List<DayOfWeek> { DayOfWeek.Monday });
            AgregarVuelo(vuelo22);
            Vuelo vuelo23 = new Vuelo("VA023", _rutas[23], _aviones[2], new List<DayOfWeek> { DayOfWeek.Tuesday });
            AgregarVuelo(vuelo23);
            Vuelo vuelo24 = new Vuelo("VA024", _rutas[24], _aviones[0], new List<DayOfWeek> { DayOfWeek.Wednesday });
            AgregarVuelo(vuelo24);
            Vuelo vuelo25 = new Vuelo("VA025", _rutas[26], _aviones[2], new List<DayOfWeek> { DayOfWeek.Thursday });
            AgregarVuelo(vuelo25);
            Vuelo vuelo26 = new Vuelo("VA026", _rutas[26], _aviones[0], new List<DayOfWeek> { DayOfWeek.Friday });
            AgregarVuelo(vuelo26);
            Vuelo vuelo27 = new Vuelo("VA027", _rutas[27], _aviones[1], new List<DayOfWeek> { DayOfWeek.Saturday });
            AgregarVuelo(vuelo27);
            Vuelo vuelo28 = new Vuelo("VA028", _rutas[28], _aviones[0], new List<DayOfWeek> { DayOfWeek.Sunday });
            AgregarVuelo(vuelo28);
            Vuelo vuelo29 = new Vuelo("VA029", _rutas[29], _aviones[1], new List<DayOfWeek> { DayOfWeek.Monday });
            AgregarVuelo(vuelo29);
            Vuelo vuelo30 = new Vuelo("VA030", _rutas[29], _aviones[2], new List<DayOfWeek> { DayOfWeek.Tuesday });
            AgregarVuelo(vuelo30);

        }

        private void PrecargarPasaje()
        {
            Pasaje pasaje1 = new Pasaje(1, _vuelos[0], new DateTime(2025, 3, 31), (Cliente)_usuarios[1], TipoEquipaje.cabina, 12);
            AgregarPasaje(pasaje1);
            Pasaje pasaje2 = new Pasaje(2, _vuelos[1], new DateTime(2025, 4, 1), (Cliente)_usuarios[1], TipoEquipaje.bodega, 14);
            AgregarPasaje(pasaje2);
            Pasaje pasaje3 = new Pasaje(3, _vuelos[2], new DateTime(2025, 4, 2), (Cliente)_usuarios[2], TipoEquipaje.ligth, 11);
            AgregarPasaje(pasaje3);
            Pasaje pasaje4 = new Pasaje(4, _vuelos[3], new DateTime(2025, 4, 3), (Cliente)_usuarios[3], TipoEquipaje.bodega, 10);
            AgregarPasaje(pasaje4);
            Pasaje pasaje5 = new Pasaje(5, _vuelos[4], new DateTime(2025, 4, 4), (Cliente)_usuarios[4], TipoEquipaje.cabina, 13);
            AgregarPasaje(pasaje5);
            Pasaje pasaje6 = new Pasaje(6, _vuelos[5], new DateTime(2025, 4, 5), (Cliente)_usuarios[5], TipoEquipaje.ligth, 15);
            AgregarPasaje(pasaje6);
            Pasaje pasaje7 = new Pasaje(7, _vuelos[6], new DateTime(2025, 4, 6), (Cliente)_usuarios[6], TipoEquipaje.cabina, 12);
            AgregarPasaje(pasaje7);
            Pasaje pasaje8 = new Pasaje(8, _vuelos[7], new DateTime(2025, 4, 7), (Cliente)_usuarios[7], TipoEquipaje.bodega, 16);
            AgregarPasaje(pasaje8);
            Pasaje pasaje9 = new Pasaje(9, _vuelos[8], new DateTime(2025, 4, 8), (Cliente)_usuarios[8], TipoEquipaje.ligth, 13);
            AgregarPasaje(pasaje9);
            Pasaje pasaje10 = new Pasaje(10, _vuelos[9], new DateTime(2025, 4, 9), (Cliente)_usuarios[9], TipoEquipaje.bodega, 11);
            AgregarPasaje(pasaje10);
            Pasaje pasaje11 = new Pasaje(11, _vuelos[10], new DateTime(2025, 4, 10), (Cliente)_usuarios[0], TipoEquipaje.cabina, 14);
            AgregarPasaje(pasaje11);
            Pasaje pasaje12 = new Pasaje(12, _vuelos[11], new DateTime(2025, 4, 11), (Cliente)_usuarios[1], TipoEquipaje.ligth, 10);
            AgregarPasaje(pasaje12);
            Pasaje pasaje13 = new Pasaje(13, _vuelos[12], new DateTime(2025, 4, 12), (Cliente)_usuarios[2], TipoEquipaje.cabina, 15);
            AgregarPasaje(pasaje13);
            Pasaje pasaje14 = new Pasaje(14, _vuelos[13], new DateTime(2025, 4, 13), (Cliente)_usuarios[3], TipoEquipaje.bodega, 13);
            AgregarPasaje(pasaje14);
            Pasaje pasaje15 = new Pasaje(15, _vuelos[14], new DateTime(2025, 4, 14), (Cliente)_usuarios[4], TipoEquipaje.ligth, 12);
            AgregarPasaje(pasaje15);
            Pasaje pasaje16 = new Pasaje(16, _vuelos[15], new DateTime(2025, 4, 15), (Cliente)_usuarios[5], TipoEquipaje.bodega, 14);
            AgregarPasaje(pasaje16);
            Pasaje pasaje17 = new Pasaje(17, _vuelos[16], new DateTime(2025, 4, 16), (Cliente)_usuarios[6], TipoEquipaje.ligth, 11);
            AgregarPasaje(pasaje17);
            Pasaje pasaje18 = new Pasaje(18, _vuelos[17], new DateTime(2025, 4, 17), (Cliente)_usuarios[7], TipoEquipaje.bodega, 10);
            AgregarPasaje(pasaje18);
            Pasaje pasaje19 = new Pasaje(19, _vuelos[18], new DateTime(2025, 4, 18), (Cliente)_usuarios[8], TipoEquipaje.cabina, 13);
            AgregarPasaje(pasaje19);
            Pasaje pasaje20 = new Pasaje(20, _vuelos[19], new DateTime(2025, 4, 19), (Cliente)_usuarios[9], TipoEquipaje.bodega, 12);
            AgregarPasaje(pasaje20);
            Pasaje pasaje21 = new Pasaje(21, _vuelos[20], new DateTime(2025, 4, 20), (Cliente)_usuarios[5], TipoEquipaje.ligth, 10);
            AgregarPasaje(pasaje21);
            Pasaje pasaje22 = new Pasaje(22, _vuelos[21], new DateTime(2025, 4, 21), (Cliente)_usuarios[1], TipoEquipaje.bodega, 14);
            AgregarPasaje(pasaje22);
            Pasaje pasaje23 = new Pasaje(23, _vuelos[22], new DateTime(2025, 4, 22), (Cliente)_usuarios[2], TipoEquipaje.cabina, 11);
            AgregarPasaje(pasaje23);
            Pasaje pasaje24 = new Pasaje(24, _vuelos[23], new DateTime(2025, 4, 23), (Cliente)_usuarios[3], TipoEquipaje.bodega, 13);
            AgregarPasaje(pasaje24);
            Pasaje pasaje25 = new Pasaje(25, _vuelos[24], new DateTime(2025, 4, 24), (Cliente)_usuarios[4], TipoEquipaje.ligth, 12);
            AgregarPasaje(pasaje25);

            //vuelo.Frecuencia.conteins(pasaje.fecha.dayoftheweek)
        }


        //---------------------------------- FIN PRECARGAS------------------------------------------------------

        //  --------------------------------METODOS AGREGAR --------------------------------------------------
        public void AgregarCliente(Cliente cliente)
        {
            if (cliente is Ocacional ocacional)
            {
                ocacional.Validar();
            }
            else
            {
                Premium premium = (Premium)cliente;
                premium.Validar();
            }
            if (_usuarios.Contains(cliente))
            {
                throw new Exception("Ya existe ese cliente");
            }
            _usuarios.Add(cliente);
        }

        public void AgregarAdmin(Administrador admin)
        {
            if (admin == null)
            {
                throw new Exception("No puede ser nulo");
            }
            admin.Validar();
            if (_usuarios.Contains(admin))
            {
                throw new Exception("El admin ya existe");
            }
            _usuarios.Add(admin);
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

        public void AgregarAeropuerto(Aeropuerto aeropuerto)
        {
            if (aeropuerto == null)
            {
                throw new Exception("No puede ser nulo");
            }
            aeropuerto.Validar();
            if (_aeropuertos.Contains(aeropuerto))
            {
                throw new Exception("Ya existe");
            }
            _aeropuertos.Add(aeropuerto);
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
        // public void AgregarClienteOcacional(Ocacional ocacional)
        //{

        //}

        //---------------------------------------- FIN METODOS AGREGAR //-------


        public List<Cliente> RetornarLista()
        {
            return _clientes;
        }

        public List<Vuelo> VuelosFiltrados(string codIATA)
        {
            List<Vuelo> resultado = new List<Vuelo>();

            foreach (Vuelo v in _vuelos)
            {
                if (v.ContieneAeropuerto(codIATA.ToLower()))
                {
                    resultado.Add(v);
                }

            }

            return resultado;
        }

        public List<Pasaje> ObtenerPasajes()
        {
            return _pasajes; // donde _pasajes es la lista interna de pasajes
        }
        //averiguar bien estemetodo 



        public Cliente ObtenerCliente(string correo)
        {
            foreach (Cliente cliente in _usuarios)
            {

                if (cliente.Correo == correo)
                {
                    return cliente;
                }
            }
            return null;
        }
        public List<Administrador> GetAdministradores()
        {
            List<Administrador> retorno = new List<Administrador>();
            foreach (Usuario u in _usuarios)
            {
                if (u is Administrador a)
                {
                    retorno.Add(a);
                }
            }
            return retorno;
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> retornoC = new List<Cliente>();
            foreach (Usuario u in _usuarios)
            {
                if (u is Cliente c)
                {
                    retornoC.Add(c);
                }
            }
            return retornoC;
        }
        public Usuario LoguinRetUsuario(string pass, string email)
        {
            Usuario retorno = null;
            foreach (Usuario c in _usuarios)
            {
                if (Login(c, pass, email))
                {
                    retorno = c;
                }
            }
            return retorno;
        }

        private bool Login(Usuario u, string pass, string email)
        {
            return (u.Correo.Equals(email) && u.Password.Equals(pass));
        }
        public Cliente ObtenerClientes(object correo, object password)
        {
            throw new NotImplementedException();
        }

        //AGREGUE ESTE METODO
        public List<Vuelo> BuscarVuelosPorRuta(string codOrigen, string codDestino)
        {
            List<Vuelo> resultado = new List<Vuelo>();

            for (int i = 0; i < _vuelos.Count; i++)
            {
                Vuelo v = _vuelos[i];
                Ruta r = v.Ruta;
                Aeropuerto origen = r.AeropuertoOrigen;
                Aeropuerto destino = r.AeropuertoDestino;

                string codO = origen.DevolverCodIATA();
                string codD = destino.DevolverCodIATA();

                bool coincideOrigen = string.IsNullOrEmpty(codOrigen) || codO == codOrigen;
                bool coincideDestino = string.IsNullOrEmpty(codDestino) || codD == codDestino;

                if (coincideOrigen && coincideDestino)
                {
                    resultado.Add(v);
                }
            }

            return resultado;
        }
        public List<Cliente> ObtenerClientes()
        {
            return _clientes; // o como tengas almacenada la lista en Sistema
        }

        public List<Pasaje> PasajesOrdenadosDescPrecio()
        {
            List<Pasaje> pasajes = new List<Pasaje>(Pasaje);
            pasajes.Sort();
            return pasajes;
        }
    }

}



