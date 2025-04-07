using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
     public abstract class  Usuario
    {

        private string _correo;
        private string _password;


        public string Correo
        {
            get { return _correo; }
        }
        public string Password
        {
            get { return _password; }
        }



        public Usuario( string correo , string password)
        {
            _correo = correo;
            _password = password;
        }


        public  void Validar()
        {
            ValidarCorreo();
            ValidarPassword();
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


    }
}
