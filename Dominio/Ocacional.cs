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
            get { return _ci; }
        }
        public string Nombre
        {
            get { return _nombre; }
        }
        public string Correo
        {
            get { return _correo; }
        }
        public string Password
        {
            get { return _password; }
        }
        public string Nacionalidad
        {
            get { return _nacionalidad; }
        }
        public bool Regalos
        {
            get { return _regalos; }
        }
        public Ocacional(string ci, string nombre, string correo, string password, string nacionalidad, bool regalos) : base(ci, nombre, correo, password, nacionalidad)
        {


            _regalos = regalos;
        }


        public void Validar()
        {
            ValidarCi();
            ValidarNombre();
            ValidarCorreo();
            ValidarPassword();
            ValidarNacionalidad();
            ValidarRegalo();
        }
        private void ValidarCi()
        {
            if (string.IsNullOrEmpty(_ci) || _ci.Length > 8)
            {
                throw new Exception("La cedula es incorrecta , ingresela nuevamente");
            }
        }
        private void ValidarNombre()
        {
            if (string.IsNullOrEmpty(_nombre))
            {
                throw new Exception("Ingrese nombre");
            }
        }

        private void ValidarCorreo()
        {
            if (string.IsNullOrEmpty(_correo))
            {
                throw new Exception("Ingrese correo");
            }
        }
        private void ValidarPassword()
        {
            if (string.IsNullOrEmpty(_password))
            {
                throw new Exception("Ingrese password");
            }
        }
        private void ValidarNacionalidad()
        {
            if (string.IsNullOrEmpty(_nacionalidad))
            {
                throw new Exception("Ingrese nacionalidad");
            }
        }

        private void ValidarRegalo()
        {
            if (_regalos != true && _regalos != false)
            {
                throw new Exception("El valor de regalos es inválido");
            }
        }
    }
}
