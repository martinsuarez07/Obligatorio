using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Administrador: Usuario
    {
        private string _apodo;
        


        public string Apodo
        {
            get { return _apodo; }
        }
        public string Correo
        {
            get { return base.Correo; }
        }
        public string Password
        {
            get { return base.Password; }
        }


        public Administrador(string apodo, string correo, string password): base( correo, password)
        {
            _apodo = apodo.ToLower();
           
        }


        public void Validar()
        {
            ValidarApodo();
            ValidarCorreo();
            ValidarPassword();
        }
        public void ValidarApodo()
        {
            if (string.IsNullOrEmpty(_apodo))
            {
                throw new Exception("El apodo no puede ser nulo");
            }
        }
        public void ValidarCorreo()
        {
            if (string.IsNullOrEmpty(base.Correo))
            {
                throw new Exception("El correo no puede nulo");
            }

        }
        public void ValidarPassword()
        {
            if (string.IsNullOrEmpty(base.Password))
            {
                throw new Exception("La contraseña no puede ser nula");
            }
        }
    }
}

