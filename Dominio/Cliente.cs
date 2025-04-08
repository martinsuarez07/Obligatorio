using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public  abstract class Cliente
    {
        private string _ci;
        private string _nombre;
        private string _correo;
        private string _password;
        private string _nacionalidad;


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

        public Cliente(string ci, string nombre, string correo, string password, string nacionalidad)
        {
            _ci = ci;
            _nombre = nombre;
            _correo = correo;
            _password = password;
            _nacionalidad = nacionalidad;
        }
        public void Validar()
        {
            ValidarCi();
            ValidarNombre();
            ValidarCorreo();
            ValidarPassword();
            ValidarNacionalidad();
        }
         private void ValidarCi()
        {
            if (string.IsNullOrEmpty(_ci) || _ci.Length > 8)
            {
                throw new Exception("La cedula es incorrecta , ingresela nuevamente");
            }
        }
        private  void ValidarNombre()
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

        public override bool Equals(object? obj)
        {
            Cliente cliente = obj as Cliente;
            return cliente != null && _ci == cliente.Ci;
        }
    }
}
