using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Ruta
    {

        private int _id;
        private Aeropuerto _aeropuertoOrigen;
        private Aeropuerto _aeropuertoDestino;
        private int _distancia;

        public int Id
        {
            get { return _id; }
        }
        public Aeropuerto AeropuertoOrigen
        {
            get { return _aeropuertoOrigen; }
        }
        public Aeropuerto AeropuertoDestino
        {
            get { return _aeropuertoDestino; }
        }
        public int Distancia
        {
            get { return _distancia; }
        }

        public Ruta(int id, Aeropuerto aeropuertoOrigen,Aeropuerto aeropuertoDestino , int distancia)
        {
            _id = id;
            _aeropuertoOrigen=aeropuertoOrigen;
            _aeropuertoDestino=aeropuertoDestino;
            _distancia = distancia;
        }
        public void Validar() {

            ValidarId();
            ValidarAeropuertoDestino();
            ValidarDistancia();
            ValidarAeropuertoOrigen();
            ValidarAeropuertos();
        }

        private void ValidarAeropuertos()
        {
            if (_aeropuertoOrigen == _aeropuertoDestino)
            {
                throw new Exception("El aeropuerto de origen y destino no pueden ser el mismo.");
            }
        }

        private void ValidarId()
        {
            if(_id < 0)
            {
                throw new Exception("Debe ser mayor o igual a 0 ");
            }
        }

        private void ValidarAeropuertoDestino()
        {
            if (_aeropuertoDestino == null)
            {
                throw new Exception("El objeto no puede ser nulo");
            }
        }
        private void ValidarAeropuertoOrigen()
        {
            if (_aeropuertoOrigen == null)
            {
                throw new Exception("El objeto no puede ser nulo");
            }
        }

        private void ValidarDistancia()
        {
            if(_distancia <= 0  )
            {
                throw new Exception("Error");
            }
        }

      public decimal costoOperacion()
        {
            decimal costoOperacion = _aeropuertoOrigen.CostoOperacion + _aeropuertoDestino.CostoOperacion;
            return costoOperacion;
        }

        public bool ContieneAeropuerto(string codIata)
        {
            bool contiene= false;   
            if (_aeropuertoDestino.CodigoIATA == codIata || _aeropuertoOrigen.CodigoIATA == codIata)
            {
                contiene = true;    

            }
            return contiene;
        }
        public override string ToString()
        {
            return $"Ruta {_aeropuertoOrigen.CodigoIATA}-{_aeropuertoDestino.CodigoIATA}";
        }
    }
}
