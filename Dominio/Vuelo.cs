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
        private List<DayOfWeek> _frecuencia;

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
        public List<DayOfWeek> Frecuencia
        {
           get { return _frecuencia; }
            set { _frecuencia = value; }
        }

        public Vuelo(string numeroVuelo, Ruta ruta, Avion avion, List<DayOfWeek> frecuencia)
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
            ValidarDistanciaAvion();
        }


        
        private void ValidarNumeroVuelo()
        {
            if (string.IsNullOrEmpty(_numeroVuelo))
            {
                throw new Exception("No puede ser nulo");
            }
            var regex = new System.Text.RegularExpressions.Regex(@"^[A-Z]{2}\d{1,4}$");
             if (!regex.IsMatch(_numeroVuelo))
            {
                throw new Exception("El número de vuelo debe tener 2 letras seguidas de 1 a 4 dígitos.");
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
        private void ValidarDistanciaAvion()
        {
            if (_ruta != null && _avion.Alcance < _ruta.Distancia)
            {
                throw new Exception("El avión no tiene el alcance necesario para cubrir la ruta.");
            }
        }
        private void ValidarFrecuencia()
        {
            //if (_frecuencia<=0)
            //{
            //    throw new Exception("La frecuencia debe ser mayor a 0");
            //}
        }

        public decimal CalcularCostoPorAsiento()
        {
            if (_ruta == null || _avion == null)
            {
                throw new Exception("La ruta o el avión no pueden ser nulos.");
            }

            // Cálculo del costo por asiento
            decimal costoOperacionRuta = _ruta.costoOperacion();
            decimal costoPorKmAvion = _avion.CostoPorKM * _ruta.Distancia;

            decimal costoTotal = costoPorKmAvion + costoOperacionRuta;
            decimal costoPorAsiento = costoTotal / _avion.CantidadAsientos;

            return costoPorAsiento;
        }
    }
}
