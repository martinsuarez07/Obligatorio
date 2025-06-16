using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ocacional : Cliente
    {
        private string _ci;
        private string _nombre;
        private string _correo;
        private string _password;
        private string _nacionalidad;
        private bool _regalos;


        public string Ci
        {
            get { return base.Ci; }
        }
        public string Nombre
        {
            get { return base.Nombre; }
        }
        public string Correo
        {
            get { return base.Correo; }
        }
        public string Password
        {
            get { return base.Password; }
        }
        public string Nacionalidad
        {
            get { return base.Nacionalidad; }
        }
        public bool Regalos
        {
            get { return _regalos; }
        }
        public Ocacional(string ci, string nombre, string correo, string password, string nacionalidad) : base(ci, nombre, correo, password, nacionalidad)
        {


            _regalos = GenerarElegibilidadRegalos();
        }
        public override void Validar()
        {
            base.Validar();
            if (_regalos != true && _regalos != false)
            {
                throw new Exception("El valor de regalos es inválido");
            }
        }

        public override string ToString()
        {
            string regalo = "no";
            if (_regalos) {
                regalo = "si";
            }
            return base.ToString() +$" Tiene regalo: { regalo}";
        }

        //nuevo verificar
        private bool GenerarElegibilidadRegalos()
        {
            Random rand = new Random();
            return rand.Next(2) == 0; // Devuelve 'true' o 'false' aleatoriamente
        }

        public void CambiarEstadoRegalo()
        {
            _regalos = !_regalos;
        }

    }
}
