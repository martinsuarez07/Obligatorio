using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vuelo
    {
        private string _numeroVuelo;
        private Ruta _ruta;
        private Avion _avion;
        private int _frecuencia;

        public string NumeroVuelo
        {
            get { return _numeroVuelo; }
            set { _numeroVuelo = value; }
        }
        public Ruta Ruta
        {
            get { return _ruta; }
            set { _ruta = value; }
        }
        public Avion Avion
        {
            get { return _avion; }
            set { _avion = value; }
        }
        public int Frecuencia
        {
            get { return _frecuencia; }
            set { _frecuencia = value; }
        }

        public Vuelo(string numeroVuelo, Ruta ruta, Avion avion, int frecuencia)
        {
            _numeroVuelo = numeroVuelo;
            _ruta = ruta;
            _avion = avion;
            _frecuencia = frecuencia;

        }
        public void Validar()
        {
            ValidarNumeroVuelo();
            ValidarRuta();
            ValidarAvion();
            ValidarFrecuencia();
        }

      

        private void ValidarNumeroVuelo()
        {
            if (string.IsNullOrEmpty(_numeroVuelo))
            {
                throw new Exception("No puede ser nulo");
            }
        }
        private void ValidarRuta()
        {
            if (_ruta == null)
            {
                throw new Exception("no puede ser nulo");
            }
        }
        private void ValidarAvion()
        {
            if(_avion== null)
            {
                throw new Exception("No puede ser nulo");
            }
        }
        private void ValidarFrecuencia()
        {
            if (_frecuencia == 0)
            {
                throw new Exception("No puede ser cero");
            }
        }
    }
}
