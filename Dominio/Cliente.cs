using System;

namespace Dominio
{
    public abstract class Cliente : Usuario, IComparable<Cliente>
    {
        private string _ci;
        private string _nombre;
        private string _nacionalidad;

        public string Ci => _ci;
        public string Nombre => _nombre;
        public string Correo => base.Correo;
        public string Password => base.Password;
        public string Nacionalidad => _nacionalidad;

        public Cliente(string ci, string nombre, string correo, string password, string nacionalidad)
            : base(correo, password)
        {
            _ci = ci;
            _nombre = nombre.ToLower();
            _nacionalidad = nacionalidad;
        }

        public virtual void Validar()
        {
            if (string.IsNullOrEmpty(_ci) || _ci.Length != 8)
                throw new Exception("La cédula es incorrecta, ingrésela nuevamente");

            if (string.IsNullOrEmpty(_nombre))
                throw new Exception("Ingrese nombre");

            if (string.IsNullOrEmpty(_nacionalidad))
                throw new Exception("Ingrese nacionalidad");
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Correo: {Correo}, Nacionalidad: {Nacionalidad}";
        }

        public override bool Equals(object? obj)
        {
            Cliente cliente = obj as Cliente;
            return cliente != null && _ci == cliente.Ci;
        }

        //  Implementación para ordenar por cédula
        public int CompareTo(Cliente otro)
        {
        
            if (otro == null) return 1;
            return this.Ci.CompareTo(otro.Ci);
        }

    }
}
