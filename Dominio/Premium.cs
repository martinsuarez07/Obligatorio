using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
     public class Premium : Cliente
    {

        private string _ci;
        private string _nombre;
        private string _correo;
        private string _password;
        private string _nacionalidad;
        private string _ventaja;
        private int _puntos;


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
        public string Ventaja
        {
            get { return _ventaja; }
        }
        public int Punto
        {
            get { return _puntos; }
        }

        public Premium(string ci, string nombre, string correo, string password, string nacionalidad, string ventaja, int punto) : base(ci, nombre, correo, password, nacionalidad)
        {
          
            _ventaja = ventaja;
            _puntos = punto;
        }

        public void Validar()
        {
            ValidarCi();
            ValidarNombre();
            ValidarCorreo();
            ValidarPassword();
            ValidarNacionalidad();
            ValidarVentaja();
            ValidarPuntos();
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
         private void ValidarVentaja()
        {
            if (string.IsNullOrEmpty(Ventaja))
            {
                throw new Exception("No puede ser nulo");
            }
        }
         private void ValidarPuntos()
        {
            if(_puntos == 0)
            {
                throw new Exception("Tiene 0 puntos");
            }
        }

    }
}
