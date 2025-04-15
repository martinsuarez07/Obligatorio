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

        //-------------------------------------------- PRECARGAS------------------------------------------------------
        public void PrecargarDatos()
        {
            PrecargarClientes();
            PrecargarAdmin();
            PrecargarVuelos();
            PrecargarPasaje();
            PrecargarRutas();
            PrecargarAviones();
            PrecargarAeropuerto();
        }

        

        private void PrecargarClientes()
        {
            Ocacional o1 = new Ocacional("51244125", "Jorge", "jorge@gmail.com","abc123","Uruguayo",true);
            AgregarCliente(o1);

            Ocacional o2 = new Ocacional("51244126", "Ana", "ana@gmail.com", "def456", "Argentina", false);
            AgregarCliente(o2);

            Ocacional o3 = new Ocacional("51244127", "Carlos", "carlos@gmail.com", "ghi789", "Chileno", true);
            AgregarCliente(o3);

            Ocacional o4 = new Ocacional("51244128", "Luisa", "luisa@gmail.com", "jkl012", "Peruana", false);
            AgregarCliente(o4);

            Ocacional o5 = new Ocacional("51244129", "Felipe", "felipe@gmail.com", "mno345", "Colombiano", true);
            AgregarCliente(o5);

            Premium p1 = new Premium("61244125", "Martín", "martin@gmail.com", "xyz123", "Uruguayo",  150);
            AgregarCliente(p1);

            Premium p2 = new Premium("61244126", "Laura", "laura@gmail.com", "abc789", "Argentina", 200);
            AgregarCliente(p2);

            Premium p3 = new Premium("61244127", "Ricardo", "ricardo@gmail.com", "def456", "Chileno", 250);
            AgregarCliente(p3);

            Premium p4 = new Premium("61244128", "Sofia", "sofia@gmail.com", "ghi012", "Peruana",  300);
            AgregarCliente(p4);

            Premium p5 = new Premium("61244129", "Esteban", "esteban@gmail.com", "jkl345", "Colombiano",  400);
            AgregarCliente(p5);
        }

        private void PrecargarAdmin()
        {
            Administrador a1 = new Administrador("Nano","nano1891@gmail.com","abc321");
            AgregarAdmin(a1);
            Administrador a2 = new Administrador("Titi", "titi@gmail.com", "abc123");
            AgregarAdmin(a2);
        }

        private void PrecargarAeropuerto()
        {
            Aeropuerto ap1 = new Aeropuerto("mv2","Montevideo",4000,120);
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
            Ruta ruta1 = new Ruta(1, new Aeropuerto("mv2", "Montevideo", 4000, 120), 1500);
            AgregarRuta(ruta1);

            Ruta ruta2 = new Ruta(2, new Aeropuerto("ba1", "Buenos Aires", 5000, 150), 300);
            AgregarRuta(ruta2);

            Ruta ruta3 = new Ruta(3, new Aeropuerto("scl", "Santiago", 6000, 180), 2000);
            AgregarRuta(ruta3);

            Ruta ruta4 = new Ruta(4, new Aeropuerto("bog", "Bogotá", 5500, 160), 4000);
            AgregarRuta(ruta4);

            Ruta ruta5 = new Ruta(5, new Aeropuerto("lim", "Lima", 4500, 140), 2500);
            AgregarRuta(ruta5);

            Ruta ruta6 = new Ruta(6, new Aeropuerto("ccs", "Caracas", 4000, 130), 3500);
            AgregarRuta(ruta6);

            Ruta ruta7 = new Ruta(7, new Aeropuerto("qro", "Querétaro", 3800, 110), 1500);
            AgregarRuta(ruta7);

            Ruta ruta8 = new Ruta(8, new Aeropuerto("rio", "Río de Janeiro", 4900, 145), 3500);
            AgregarRuta(ruta8);

            Ruta ruta9 = new Ruta(9, new Aeropuerto("grs", "Granada", 4700, 135), 4500);
            AgregarRuta(ruta9);

            Ruta ruta10 = new Ruta(10, new Aeropuerto("mex", "México DF", 7000, 200), 5000);
            AgregarRuta(ruta10);

            Ruta ruta11 = new Ruta(11, new Aeropuerto("sao", "São Paulo", 6500, 190), 6000);
            AgregarRuta(ruta11);

            Ruta ruta12 = new Ruta(12, new Aeropuerto("mar", "Maracaibo", 3800, 100), 1500);
            AgregarRuta(ruta12);

            Ruta ruta13 = new Ruta(13, new Aeropuerto("sdu", "São Duprat", 4000, 120), 2000);
            AgregarRuta(ruta13);

            Ruta ruta14 = new Ruta(14, new Aeropuerto("mzt", "Mazatlán", 3600, 115), 2500);
            AgregarRuta(ruta14);

            Ruta ruta15 = new Ruta(15, new Aeropuerto("asr", "Asunción", 4200, 125), 3000);
            AgregarRuta(ruta15);

            Ruta ruta16 = new Ruta(16, new Aeropuerto("gua", "Guatemala", 4600, 145), 4000);
            AgregarRuta(ruta16);

            Ruta ruta17 = new Ruta(17, new Aeropuerto("bvs", "Boca del Río", 3900, 110), 2500);
            AgregarRuta(ruta17);

            Ruta ruta18 = new Ruta(18, new Aeropuerto("mcz", "Macapá", 3500, 100), 3500);
            AgregarRuta(ruta18);

            Ruta ruta19 = new Ruta(19, new Aeropuerto("mde", "Medellín", 4800, 160), 4000);
            AgregarRuta(ruta19);

            Ruta ruta20 = new Ruta(20, new Aeropuerto("cdr", "Córdoba", 4200, 120), 3000);
            AgregarRuta(ruta20);

            Ruta ruta21 = new Ruta(21, new Aeropuerto("grb", "Gran Buenos Aires", 4600, 140), 3200);
            AgregarRuta(ruta21);

            Ruta ruta22 = new Ruta(22, new Aeropuerto("bqq", "Buenos Aires Quilmes", 5500, 170), 3300);
            AgregarRuta(ruta22);

            Ruta ruta23 = new Ruta(23, new Aeropuerto("mon", "Montevideo Oeste", 3900, 120), 1000);
            AgregarRuta(ruta23);

            Ruta ruta24 = new Ruta(24, new Aeropuerto("fsa", "Foz do Iguaçu", 4800, 150), 2600);
            AgregarRuta(ruta24);

            Ruta ruta25 = new Ruta(25, new Aeropuerto("mcd", "Mar del Plata", 3800, 110), 2000);
            AgregarRuta(ruta25);

            Ruta ruta26 = new Ruta(26, new Aeropuerto("clo", "Córdoba Norte", 4200, 125), 2200);
            AgregarRuta(ruta26);

            Ruta ruta27 = new Ruta(27, new Aeropuerto("sal", "Salta", 4500, 130), 1800);
            AgregarRuta(ruta27);

            Ruta ruta28 = new Ruta(28, new Aeropuerto("mzo", "Mendoza", 4600, 135), 2500);
            AgregarRuta(ruta28);

            Ruta ruta29 = new Ruta(29, new Aeropuerto("rsp", "Rosario", 4300, 140), 3000);
            AgregarRuta(ruta29);

            Ruta ruta30 = new Ruta(30, new Aeropuerto("tuc", "Tucumán", 4400, 145), 2800);
            AgregarRuta(ruta30);
        }
        private void PrecargarAviones()
        {
            Avion av1 = new Avion("Agustin", "ax1", 23, 3000, 15000);
            AgregarAvion(av1);

            Avion av2 = new Avion("Belgrano", "bx1", 30, 3500, 18000);
            AgregarAvion(av2);

            Avion av3 = new Avion("Libertad", "cx1", 40, 4000, 20000);
            AgregarAvion(av3);

            Avion av4 = new Avion("Condor", "dx1", 50, 4500, 25000);
            AgregarAvion(av4);
        }
        private void PrecargarVuelos()
        {

        
            Vuelo vuelo1 = new Vuelo("V001", new Ruta(1, new Aeropuerto("mv2", "Montevideo", 4000, 120), 1500), new Avion("Agustin", "ax1", 23, 3000, 15000), 5);
            AgregarVuelo(vuelo1);

            Vuelo vuelo2 = new Vuelo("V002", new Ruta(2, new Aeropuerto("ba1", "Buenos Aires", 5000, 150), 300), new Avion("Carlos", "bx1", 25, 3200, 20000), 7);
            AgregarVuelo(vuelo2);

            Vuelo vuelo3 = new Vuelo("V003", new Ruta(3, new Aeropuerto("scl", "Santiago", 6000, 180), 2000), new Avion("Lucas", "cx1", 22, 2800, 18000), 4);
            AgregarVuelo(vuelo3);

            Vuelo vuelo4 = new Vuelo("V004", new Ruta(4, new Aeropuerto("bog", "Bogotá", 5500, 160), 4000), new Avion("Maria", "dx1", 24, 3500, 22000), 6);
            AgregarVuelo(vuelo4);

            Vuelo vuelo5 = new Vuelo("V005", new Ruta(5, new Aeropuerto("lim", "Lima", 4500, 140), 2500), new Avion("Juan", "ex1", 21, 2600, 16000), 3);
            AgregarVuelo(vuelo5);

            Vuelo vuelo6 = new Vuelo("V006", new Ruta(6, new Aeropuerto("ccs", "Caracas", 4000, 130), 3500), new Avion("Ricardo", "fx1", 20, 3100, 19500), 8);
            AgregarVuelo(vuelo6);

            Vuelo vuelo7 = new Vuelo("V007", new Ruta(7, new Aeropuerto("qro", "Querétaro", 3800, 110), 1500), new Avion("Diego", "gx1", 26, 2900, 17000), 2);
            AgregarVuelo(vuelo7);

            Vuelo vuelo8 = new Vuelo("V008", new Ruta(8, new Aeropuerto("rio", "Río de Janeiro", 4900, 145), 3500), new Avion("Andrés", "hx1", 28, 3300, 21000), 6);
            AgregarVuelo(vuelo8);

            Vuelo vuelo9 = new Vuelo("V009", new Ruta(9, new Aeropuerto("grs", "Granada", 4700, 135), 4500), new Avion("Sofia", "ix1", 22, 3400, 20000), 5);
            AgregarVuelo(vuelo9);

            Vuelo vuelo10 = new Vuelo("V010", new Ruta(10, new Aeropuerto("mex", "México DF", 7000, 200), 5000), new Avion("Gabriel", "jx1", 25, 3600, 23000), 7);
            AgregarVuelo(vuelo10);

            Vuelo vuelo11 = new Vuelo("V011", new Ruta(11, new Aeropuerto("sao", "São Paulo", 6500, 190), 6000), new Avion("Fernanda", "kx1", 24, 3400, 20500), 4);
            AgregarVuelo(vuelo11);

            Vuelo vuelo12 = new Vuelo("V012", new Ruta(12, new Aeropuerto("mar", "Maracaibo", 3800, 100), 1500), new Avion("Pedro", "lx1", 23, 2800, 17500), 8);
            AgregarVuelo(vuelo12);

            Vuelo vuelo13 = new Vuelo("V013", new Ruta(13, new Aeropuerto("sdu", "São Duprat", 4000, 120), 2000), new Avion("Carolina", "mx1", 22, 2900, 18000), 5);
            AgregarVuelo(vuelo13);

            Vuelo vuelo14 = new Vuelo("V014", new Ruta(14, new Aeropuerto("mzt", "Mazatlán", 3600, 115), 2500), new Avion("Javier", "nx1", 21, 2700, 16000), 3);
            AgregarVuelo(vuelo14);

            Vuelo vuelo15 = new Vuelo("V015", new Ruta(15, new Aeropuerto("asr", "Asunción", 4200, 125), 3000), new Avion("Lucía", "ox1", 26, 3200, 21000), 6);
            AgregarVuelo(vuelo15);

            Vuelo vuelo16 = new Vuelo("V016", new Ruta(16, new Aeropuerto("gua", "Guatemala", 4600, 145), 4000), new Avion("Antonio", "px1", 27, 3100, 20000), 7);
            AgregarVuelo(vuelo16);

            Vuelo vuelo17 = new Vuelo("V017", new Ruta(17, new Aeropuerto("bvs", "Boca del Río", 3900, 110), 2500), new Avion("Claudia", "qx1", 29, 3300, 21500), 2);
            AgregarVuelo(vuelo17);

            Vuelo vuelo18 = new Vuelo("V018", new Ruta(18, new Aeropuerto("mcz", "Macapá", 3500, 100), 3500), new Avion("Esteban", "rx1", 20, 2700, 16000), 4);
            AgregarVuelo(vuelo18);

            Vuelo vuelo19 = new Vuelo("V019", new Ruta(19, new Aeropuerto("mde", "Medellín", 4800, 160), 4000), new Avion("Martín", "sx1", 24, 3200, 21000), 5);
            AgregarVuelo(vuelo19);

            Vuelo vuelo20 = new Vuelo("V020", new Ruta(20, new Aeropuerto("cdr", "Córdoba", 4200, 120), 3000), new Avion("Ricardo", "tx1", 23, 3300, 20000), 8);
            AgregarVuelo(vuelo20);

            Vuelo vuelo21 = new Vuelo("V021", new Ruta(21, new Aeropuerto("grb", "Gran Buenos Aires", 4600, 140), 3200), new Avion("Gustavo", "ux1", 28, 3100, 19000), 6);
            AgregarVuelo(vuelo21);

            Vuelo vuelo22 = new Vuelo("V022", new Ruta(22, new Aeropuerto("bqq", "Buenos Aires Quilmes", 5500, 170), 3300), new Avion("Marta", "vx1", 24, 3300, 21000), 7);
            AgregarVuelo(vuelo22);

            Vuelo vuelo23 = new Vuelo("V023", new Ruta(23, new Aeropuerto("mon", "Montevideo Oeste", 3900, 120), 1000), new Avion("David", "wx1", 26, 2800, 17500), 3);
            AgregarVuelo(vuelo23);

            Vuelo vuelo24 = new Vuelo("V024", new Ruta(24, new Aeropuerto("fsa", "Foz do Iguaçu", 4800, 150), 2600), new Avion("Julia", "yx1", 21, 2900, 18000), 4);
            AgregarVuelo(vuelo24);

            Vuelo vuelo25 = new Vuelo("V025", new Ruta(25, new Aeropuerto("mcd", "Mar del Plata", 3800, 110), 2000), new Avion("Beatriz", "zz1", 23, 2600, 17000), 5);
            AgregarVuelo(vuelo25);

            Vuelo vuelo26 = new Vuelo("V026", new Ruta(26, new Aeropuerto("clo", "Córdoba Norte", 4200, 125), 2200), new Avion("Raúl", "a01", 25, 3000, 18500), 6);
            AgregarVuelo(vuelo26);

            Vuelo vuelo27 = new Vuelo("V027", new Ruta(27, new Aeropuerto("sal", "Salta", 4500, 130), 1800), new Avion("Adriana", "b01", 27, 3200, 19000), 4);
            AgregarVuelo(vuelo27);

            Vuelo vuelo28 = new Vuelo("V028", new Ruta(28, new Aeropuerto("mzo", "Mendoza", 4600, 135), 2500), new Avion("Carlos", "c01", 29, 3300, 20000), 8);
            AgregarVuelo(vuelo28);

            Vuelo vuelo29 = new Vuelo("V029", new Ruta(29, new Aeropuerto("rsp", "Rosario", 4300, 140), 3000), new Avion("Lorena", "d01", 24, 3100, 19500), 7);
            AgregarVuelo(vuelo29);

            Vuelo vuelo30 = new Vuelo("V030", new Ruta(30, new Aeropuerto("tuc", "Tucumán", 4400, 145), 2800), new Avion("Elena", "e01", 25, 3400, 21000), 6);
            AgregarVuelo(vuelo30);

        }
       
        private void PrecargarPasaje()
        {
            Pasaje pasaje1 = new Pasaje(1, new Vuelo("V001", new Ruta(1, new Aeropuerto("mv2", "Montevideo", 4000, 120), 1500), new Avion("Agustin", "ax1", 23, 3000, 15000), 5), new DateTime(2025, 4, 15), new Ocacional("51244125", "Jorge", "jorge@gmail.com", "abc123", "Uruguayo", true), TipoEquipaje.ligth, 1500);
            AgregarPasaje(pasaje1);

            Pasaje pasaje2 = new Pasaje(2, new Vuelo("V002", new Ruta(2, new Aeropuerto("ba1", "Buenos Aires", 5000, 150), 300), new Avion("Carlos", "bx1", 25, 3200, 20000), 7), new DateTime(2025, 4, 16), new Premium("61234456", "Ana", "ana@gmail.com", "def123", "Argentina", "Descuento", 1200), TipoEquipaje.cabina, 3000);
            AgregarPasaje(pasaje2);

            Pasaje pasaje3 = new Pasaje(3, new Vuelo("V003", new Ruta(3, new Aeropuerto("scl", "Santiago", 6000, 180), 2000), new Avion("Lucas", "cx1", 22, 2800, 18000), 4), new DateTime(2025, 4, 17), new Ocacional("43214567", "Pedro", "pedro@gmail.com", "ghi123", "Chileno", true), TipoEquipaje.bodega, 2000);
            AgregarPasaje(pasaje3);

            Pasaje pasaje4 = new Pasaje(4, new Vuelo("V004", new Ruta(4, new Aeropuerto("bog", "Bogotá", 5500, 160), 4000), new Avion("Maria", "dx1", 24, 3500, 22000), 6), new DateTime(2025, 4, 18), new Premium("71234467", "Carlos", "carlos@gmail.com", "jkl123", "Colombiano", "Acceso VIP", 1500), TipoEquipaje.cabina, 3500);
            AgregarPasaje(pasaje4);

            Pasaje pasaje5 = new Pasaje(5, new Vuelo("V005", new Ruta(5, new Aeropuerto("lim", "Lima", 4500, 140), 2500), new Avion("Juan", "ex1", 21, 2600, 16000), 3), new DateTime(2025, 4, 19), new Ocacional("81234478", "Luis", "luis@gmail.com", "mno123", "Peruano", false), TipoEquipaje.ligth, 2500);
            AgregarPasaje(pasaje5);

            Pasaje pasaje6 = new Pasaje(6, new Vuelo("V006", new Ruta(6, new Aeropuerto("ccs", "Caracas", 4000, 130), 3500), new Avion("Ricardo", "fx1", 20, 3100, 19500), 8), new DateTime(2025, 4, 20), new Premium("91234489", "Sofia", "sofia@gmail.com", "pqr123", "Venezolana", "Prioridad", 2000), TipoEquipaje.bodega, 2000);
            AgregarPasaje(pasaje6);

            Pasaje pasaje7 = new Pasaje(7, new Vuelo("V007", new Ruta(7, new Aeropuerto("qro", "Querétaro", 3800, 110), 1500), new Avion("Diego", "gx1", 26, 2900, 17000), 2), new DateTime(2025, 4, 21), new Ocacional("31234490", "Mariana", "mariana@gmail.com", "stu123", "Mexicana", true), TipoEquipaje.ligth, 1500);
            AgregarPasaje(pasaje7);

            Pasaje pasaje8 = new Pasaje(8, new Vuelo("V008", new Ruta(8, new Aeropuerto("ba1", "Buenos Aires", 5000, 150), 3500), new Avion("Andrés", "hx1", 28, 3300, 21000), 6), new DateTime(2025, 4, 22), new Premium("11234491", "Lucía", "lucia@gmail.com", "vwx123", "Brasileña", "Beneficio extra", 1800), TipoEquipaje.cabina, 3000);
            AgregarPasaje(pasaje8);

            Pasaje pasaje9 = new Pasaje(9, new Vuelo("V009", new Ruta(9, new Aeropuerto("grs", "Granada", 4700, 135), 4500), new Avion("Sofia", "ix1", 22, 3400, 20000), 5), new DateTime(2025, 4, 23), new Ocacional("51234502", "Ignacio", "ignacio@gmail.com", "abc987", "Español", false), TipoEquipaje.bodega, 2200);
            AgregarPasaje(pasaje9);

            Pasaje pasaje10 = new Pasaje(10, new Vuelo("V010", new Ruta(10, new Aeropuerto("mex", "México DF", 7000, 200), 5000), new Avion("Gabriel", "jx1", 25, 3600, 23000), 7), new DateTime(2025, 4, 24), new Premium("21234493", "Esteban", "esteban@gmail.com", "abc123", "Mexicano", "Asientos premium", 2500), TipoEquipaje.cabina, 3500);
            AgregarPasaje(pasaje10);

            Pasaje pasaje11 = new Pasaje(11, new Vuelo("V011", new Ruta(11, new Aeropuerto("sao", "São Paulo", 6500, 190), 6000), new Avion("Fernanda", "kx1", 24, 3400, 20500), 4), new DateTime(2025, 4, 25), new Ocacional("91234504", "Camila", "camila@gmail.com", "ghi345", "Brasileña", true), TipoEquipaje.ligth, 2300);
            AgregarPasaje(pasaje11);

            Pasaje pasaje12 = new Pasaje(12, new Vuelo("V012", new Ruta(12, new Aeropuerto("mar", "Maracaibo", 3800, 100), 1500), new Avion("Pedro", "lx1", 23, 2800, 17500), 8), new DateTime(2025, 4, 26), new Premium("61234505", "Ricardo", "ricardo@gmail.com", "jkl456", "Venezolano", "Fast track", 2200), TipoEquipaje.bodega, 2700);
            AgregarPasaje(pasaje12);

            Pasaje pasaje13 = new Pasaje(13, new Vuelo("V013", new Ruta(13, new Aeropuerto("sdu", "São Duprat", 4000, 120), 2000), new Avion("Carolina", "mx1", 22, 2900, 18000), 5), new DateTime(2025, 4, 27), new Ocacional("31234506", "Julian", "julian@gmail.com", "stu789", "Argentino", false), TipoEquipaje.ligth, 2400);
            AgregarPasaje(pasaje13);

            Pasaje pasaje14 = new Pasaje(14, new Vuelo("V014", new Ruta(14, new Aeropuerto("mzt", "Mazatlán", 3600, 115), 2500), new Avion("Javier", "nx1", 21, 2700, 16000), 3), new DateTime(2025, 4, 28), new Premium("11234507", "Rosa", "rosa@gmail.com", "uvw123", "Mexicana", "Maletero prioritario", 2700), TipoEquipaje.cabina, 3000);
            AgregarPasaje(pasaje14);

            Pasaje pasaje15 = new Pasaje(15, new Vuelo("V015", new Ruta(15, new Aeropuerto("luc", "Lucía", 4200, 125), 3000), new Avion("Ricardo", "tx1", 23, 3300, 20000), 6), new DateTime(2025, 4, 29), new Ocacional("51234508", "Joaquín", "joaquin@gmail.com", "xyz123", "Paraguayo", true), TipoEquipaje.bodega, 2600);
            AgregarPasaje(pasaje15);

            Pasaje pasaje16 = new Pasaje(16, new Vuelo("V016", new Ruta(16, new Aeropuerto("gua", "Guatemala", 4600, 145), 4000), new Avion("Antonio", "px1", 27, 3100, 20000), 7), new DateTime(2025, 4, 30), new Premium("71234509", "Carlos", "carlos@gmail.com", "rst789", "Guatemalteco", "WiFi gratis", 1900), TipoEquipaje.cabina, 2500);
            AgregarPasaje(pasaje16);

            Pasaje pasaje17 = new Pasaje(17, new Vuelo("V017", new Ruta(17, new Aeropuerto("bvs", "Boca del Río", 3900, 110), 2500), new Avion("Claudia", "qx1", 29, 3300, 21500), 2), new DateTime(2025, 5, 1), new Ocacional("31234510", "Teresa", "teresa@gmail.com", "opq123", "Argentina", false), TipoEquipaje.ligth, 2200);
            AgregarPasaje(pasaje17);

            Pasaje pasaje18 = new Pasaje(18, new Vuelo("V018", new Ruta(18, new Aeropuerto("pcm", "Punta Cana", 5000, 160), 3500), new Avion("Martín", "tx2", 20, 3100, 18000), 4), new DateTime(2025, 5, 2), new Premium("51234511", "Patricia", "patricia@gmail.com", "stu432", "Dominicana", "Prioridad de embarque", 2800), TipoEquipaje.bodega, 3000);
            AgregarPasaje(pasaje18);

            Pasaje pasaje19 = new Pasaje(19, new Vuelo("V019", new Ruta(19, new Aeropuerto("mty", "Monterrey", 4200, 130), 3000), new Avion("Alfredo", "ax2", 26, 3200, 20000), 5), new DateTime(2025, 5, 3), new Ocacional("31234512", "Fernando", "fernando@gmail.com", "hij789", "Mexicano", true), TipoEquipaje.ligth, 2500);
            AgregarPasaje(pasaje19);

            Pasaje pasaje20 = new Pasaje(20, new Vuelo("V020", new Ruta(20, new Aeropuerto("rga", "Rosario", 4600, 170), 3500), new Avion("Eduardo", "bx2", 24, 3300, 21000), 3), new DateTime(2025, 5, 4), new Premium("61234513", "Julieta", "julieta@gmail.com", "klm123", "Argentina", "Asientos exclusivos", 3000), TipoEquipaje.cabina, 3200);
            AgregarPasaje(pasaje20);

            Pasaje pasaje21 = new Pasaje(21, new Vuelo("V021", new Ruta(21, new Aeropuerto("ccl", "Curitiba", 4300, 140), 3000), new Avion("Paula", "lz1", 27, 3300, 21500), 6), new DateTime(2025, 5, 5), new Ocacional("51234514", "Marta", "marta@gmail.com", "pqr123", "Brasilera", true), TipoEquipaje.bodega, 2600);
            AgregarPasaje(pasaje21);

            Pasaje pasaje22 = new Pasaje(22, new Vuelo("V022", new Ruta(22, new Aeropuerto("equ", "Ecuador", 4000, 125), 2000), new Avion("Ricardo", "ux1", 29, 3100, 21000), 5), new DateTime(2025, 5, 6), new Premium("71234515", "Gabriela", "gabriela@gmail.com", "abc234", "Ecuatoriana", "Exclusivo", 3500), TipoEquipaje.ligth, 2700);
            AgregarPasaje(pasaje22);

            Pasaje pasaje23 = new Pasaje(23, new Vuelo("V023", new Ruta(23, new Aeropuerto("bja", "Bahía Blanca", 4600, 130), 4000), new Avion("Gabriel", "ey1", 24, 3200, 20500), 2), new DateTime(2025, 5, 7), new Ocacional("91234516", "Hernán", "hernan@gmail.com", "rst890", "Argentino", false), TipoEquipaje.bodega, 2500);
            AgregarPasaje(pasaje23);

            Pasaje pasaje24 = new Pasaje(24, new Vuelo("V024", new Ruta(24, new Aeropuerto("mtv", "Montevideo", 4200, 150), 3500), new Avion("Carla", "zx1", 22, 3000, 19500), 4), new DateTime(2025, 5, 8), new Premium("11234517", "Javier", "javier@gmail.com", "opq567", "Uruguayo", "Pasaporte rápido", 2900), TipoEquipaje.ligth, 2800);
            AgregarPasaje(pasaje24);

            Pasaje pasaje25 = new Pasaje(25, new Vuelo("V025", new Ruta(25, new Aeropuerto("rcu", "Río Cuarto", 4700, 180), 2000), new Avion("Natalia", "zx2", 25, 3100, 22000), 6), new DateTime(2025, 5, 9), new Ocacional("31234518", "Miguel", "miguel@gmail.com", "rst789", "Argentino", true), TipoEquipaje.bodega, 2600);
            AgregarPasaje(pasaje25);
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
            if (_clientes.Contains(cliente))
            {
                throw new Exception("Ya existe ese cliente");
            }
            _clientes.Add(cliente);
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

        //---------------------------------------- FIN METODOS AGREGAR----------------------------------------------
    }
}



