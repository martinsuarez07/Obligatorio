using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Avion
    {
        private string _fabricante;
        private string _modelo;
        private int _cantidadAsientos;
        private int _alcance;
        private decimal _costoPorKm;


        public string Fabricante
        {
            get { return _fabricante; }
        }
        public string Modelo
        {
            get { return _modelo; }
        }
        public int CantidadAsientos
        {
            get { return _cantidadAsientos; }

        }
        public int Alcance
        {
            get { return _alcance; }
        }
        public decimal CostoPorKM
        {
            get { return _costoPorKm; }
        }
        public Avion(string fabricante, string modelo, int cantidadAsientos, int alcance, decimal costoPorKm)
        {
            _fabricante = fabricante;
            _modelo = modelo;
            _cantidadAsientos = cantidadAsientos;
            _alcance = alcance;
            _costoPorKm = costoPorKm;
        }
        public void Validar()
        {
            ValidarFabricante();
            ValidarModelo();
            ValidarCantidadAsientos();
            ValidarAlcance();
            ValidarCostoPorKM();

        }

        private void ValidarFabricante()
        {
            if (string.IsNullOrEmpty(_fabricante))
            {
                throw new Exception("No puede ser nulo ");
            }
        }

        private void ValidarModelo()
        {
            if (string.IsNullOrEmpty(_modelo))
            {
                throw new Exception("No puede ser nulo ");
            }
        }

        private void ValidarCantidadAsientos()
        {
            if (_cantidadAsientos <=0)
            {
                throw new Exception("La cantidad de asientos debe ser mayor que cero.");
            }
        }

        private void ValidarAlcance()
        {
            if (_alcance<=0)
            {
                throw new Exception("El alcance del avión debe ser mayor que cero.");
            }
        }

        private void ValidarCostoPorKM()

        {
            if (_costoPorKm<=0)
            {
                throw new Exception("El costo por km debe ser mayor que cero.");
            }
        }
    }
}
