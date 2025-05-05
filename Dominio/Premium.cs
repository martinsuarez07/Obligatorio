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
        //    public void Validar()
        //    {
        //        ValidarCi();
        //        ValidarNombre();
        //        ValidarCorreo();
        //        ValidarPassword();
        //        ValidarNacionalidad();
        //        ValidarVentaja();
        //        ValidarPuntos();
        //    }
        //    private void ValidarCi()
        //    {
        //        if (string.IsNullOrEmpty(_ci) || _ci.Length > 8)
        //        {
        //            throw new Exception("La cedula es incorrecta , ingresela nuevamente");
        //        }
        //    }
        //    private void ValidarNombre()
        //    {
        //        if (string.IsNullOrEmpty(_nombre))
        //        {
        //            throw new Exception("Ingrese nombre");
        //        }
        //    }

        //    private void ValidarCorreo()
        //    {
        //        if (string.IsNullOrEmpty(_correo))
        //        {
        //            throw new Exception("Ingrese correo");
        //        }
        //    }
        //    private void ValidarPassword()
        //    {
        //        if (string.IsNullOrEmpty(_password))
        //        {
        //            throw new Exception("Ingrese password");
        //        }
        //    }
        //    private void ValidarNacionalidad()
        //    {
        //        if (string.IsNullOrEmpty(_nacionalidad))
        //        {
        //            throw new Exception("Ingrese nacionalidad");
        //        }
        //    }
        //     private void ValidarVentaja()
        //    {
        //        if (string.IsNullOrEmpty(Ventaja))
        //        {
        //            throw new Exception("No puede ser nulo");
        //        }
        //    }
        //     private void ValidarPuntos()
        //    {
        //        if(_puntos == 0)
        //        {
        //            throw new Exception("Tiene 0 puntos");
        //        }
        //    }

    }
}
