using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public  abstract class Cliente :Usuario
    {
        private string _ci;
        private string _nombre;
     
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
            get { return base.Correo; }
        }
        public string Password
        {
            get { return base.Password; }
        }
        public string Nacionalidad
        {
            get { return _nacionalidad; }
        }

        public Cliente(string ci, string nombre, string correo, string password, string nacionalidad) : base(correo, password)
        {
            _ci = ci;
            _nombre = nombre.ToLower();
            _nacionalidad = nacionalidad;
        }

        public virtual void Validar()
        {
            if (string.IsNullOrEmpty(_ci) || _ci.Length != 8)
            {
              throw new Exception("La cedula es incorrecta , ingresela nuevamente");
            }
            if (string.IsNullOrEmpty(_nombre))
            {
                throw new Exception("Ingrese nombre");
           }
            if (string.IsNullOrEmpty(_nacionalidad))
           {
              throw new Exception("Ingrese nacionalidad");
          }
        }


        public override string ToString()
        {
            return $"Nombre: {Nombre}, Correo: {Correo}, Nacionalidad: {Nacionalidad} ,";
        }
        public override bool Equals(object? obj)
        {
            Cliente cliente = obj as Cliente;
            return cliente != null && _ci == cliente.Ci;
        }

    }
}
