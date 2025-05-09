
namespace Dominio
{
    public class Aeropuerto
    {
        private string _codigoIATA;
        private string _ciudad;
        private decimal _costoOperacion;
        private decimal _costoTasas;


        public string CodigoIATA
        {
            get { return _codigoIATA; }
            set { _codigoIATA = value; }
        }
        public string Ciudad
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }
        public decimal CostoOperacion
        {
            get { return _costoOperacion; }
            set { _costoOperacion = value; }
        }
        public decimal CostoTasas
        {
            get { return _costoTasas; }
            set { _costoTasas = value; }

        }


        public Aeropuerto(string codigoIATA, string ciudad, decimal costoOperacion , decimal costoTasas)
        {
            _codigoIATA= codigoIATA;
            _ciudad= ciudad;
            _costoOperacion= costoOperacion;
            _costoTasas = costoTasas;
        }

        public void Validar()
        {
            ValidarCodigoIATA();
            ValidarCiudad();
            ValidarCostoOperacion();
            ValidarCostoTasas();
        }

        private void ValidarCodigoIATA()
        {
            if(string.IsNullOrEmpty(_codigoIATA) || _codigoIATA.Length!=3)
            {
                throw new Exception("Error");
            }
        }
        private void ValidarCiudad()
        {
            if (string.IsNullOrEmpty(_ciudad))
            {
                throw new Exception("Error");
            }
        }
        private void ValidarCostoOperacion()
        {
            if(_costoOperacion <0)
            {
                throw new Exception("Error");
            }
        }

        private void ValidarCostoTasas()
        {
            if (_costoTasas < 0)
            {
                throw new Exception("Error");
            }
        }

        public string DevolverCodIATA() { return _codigoIATA; }    
    }
}