using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
     public class Premium : Cliente
    {

       
        private int _puntos;


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
       
        public int Punto
        {
            get { return _puntos; }
        }

        public Premium(string ci, string nombre, string correo, string password, string nacionalidad, int punto) : base(ci, nombre, correo, password, nacionalidad)
        {
          
            _puntos = punto;
        }
        public override void Validar()
        {
            base.Validar();
            if (_puntos <= 0)
            {
                throw new Exception("Los puntos  deben ser mayor a 0");
            }
        }
        public override string ToString()
        {
         
            return base.ToString() + $" Puntos {_puntos}";
        }
        public void EditarPuntos(int nuevosPuntos)
        {
            if (nuevosPuntos <= 0)
            {
                throw new Exception("Los puntos deben ser mayores a 0.");
            }
            _puntos = nuevosPuntos;
        }

    }
}
