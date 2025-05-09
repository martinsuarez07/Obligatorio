using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pasaje
    {
        private int _id;
        private Vuelo _vuelo;
        private DateTime _fecha;
        private Cliente _cliente;
        private TipoEquipaje _tipoEquipaje;
        private decimal _precio;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Vuelo Vuelo
        {
            get { return _vuelo; }
        }
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        public Cliente Cliente
        {
            get { return _cliente; }
        }
        public TipoEquipaje TipoEquipaje
        {
            get { return _tipoEquipaje; }
            set { _tipoEquipaje = value; }
        }
        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public Pasaje(int id, Vuelo vuelo, DateTime fecha, Cliente cliente, TipoEquipaje tipo, decimal precio)
        {
            _id = id;
            _vuelo = vuelo;
            _fecha = fecha;
            _cliente = cliente;
            _tipoEquipaje = tipo;
            _precio = precio;
        }

        public void Validar()
        {
            ValidarId();
            ValidarVuelo();
            ValidarFecha();
            ValidarCliente();
            ValidarTipo();
            ValidarPrecio();
            //ValidarFrecuenciaVuelo();
        }
       
        private void ValidarId()
        {
          if(_id < 0 )
            {
                throw new Exception("El id no puede ser menor que 0 ");
            }
        }
        private void ValidarVuelo()
        {
            if(_vuelo == null)
            {
                throw new Exception("No puede ser nulo ");
            }
        }
        private void ValidarFecha()
        {
            if (_fecha == null)
            {
                throw new Exception("No puede ser nulo ");
            }
        }
        private void ValidarCliente()
        {
            if(_cliente == null)
            {
                throw new Exception("No puede ser nulo ");
            }
        }

        private void ValidarTipo()
        {
            if (_tipoEquipaje == null)
            {
                throw new Exception("No puede ser nulo ");
            }
        }
        private void ValidarPrecio()
        {
            if (_precio<=0)
            {
                throw new Exception("El precio no puede ser cero ");
            }
        }

        //nuevo
        public void ValidarFrecuenciaVuelo()
        {
            if (!_vuelo.contieneFrecuencia(_fecha.DayOfWeek))
            {
                throw new Exception("La fecha seleccionada no coincide con la frecuencia del vuelo.");
            }
        }

    }
}
