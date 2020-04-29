using System.Collections.Generic;

namespace StrategyTest.Models
{
    public class OrdenarNumeros
    {
        private List<int> _numeros;
        private IOrdenamiento _estrategiaOrdenamiento;

        public OrdenarNumeros(List<int> numeros, IOrdenamiento estrategiaOrdenamiento)
        {
            _numeros = numeros;
            _estrategiaOrdenamiento = estrategiaOrdenamiento;
        }

        public List<int> ListaOrdenada()
        {
            if (_numeros == null) return new List<int>();
            return _estrategiaOrdenamiento.Ordenar(_numeros);
        }
    }
}
