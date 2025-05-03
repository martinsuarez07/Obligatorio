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
        private Aeropuerto _aeropuerto;
        private int _distancia;

        public int Id
        {
            get { return _id; }
        }
        public Aeropuerto Aeropuerto
        {
            get { return _aeropuerto; }
        }
        public int Distancia
        {
            get { return _distancia; }
        }

        public Ruta(int id, Aeropuerto aeropuerto , int distancia)
        {
            _id = id;
            _aeropuerto=aeropuerto;
            _distancia = distancia;
        }
        public void Validar() {

            ValidarId();
            ValidarAeropuerto();
            ValidarDistancia();

        }
        private void ValidarId()
        {
            if(_id == null)
            {
                throw new Exception("Error");
            }
        }

        private void ValidarAeropuerto()
        {
            if (_aeropuerto == null)
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

      
    }
}
