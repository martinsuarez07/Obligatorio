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
            _correo = correo.ToLower();
            _password = password;
        }


        public virtual void Validar()
        {
            ValidarCorreo();
            ValidarPassword();
        }
        public virtual void ValidarCorreo()
        {
            if (string.IsNullOrEmpty(_correo))
            {
                throw new Exception("Ingrese correo");
            }
        }
        public virtual void ValidarPassword()
        {
            if (string.IsNullOrEmpty(_password))
            {
                throw new Exception("Ingrese password");
            }
        }
        public override bool Equals(object? obj)
        {
            Usuario usu = obj as Usuario;
            return usu != null && _correo.Equals(usu.Correo);
        }


    }
}
