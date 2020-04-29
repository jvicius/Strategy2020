using System.Collections.Generic;

namespace StrategyTest.Models
{
    public class Ascendete : IOrdenamiento
    {
        public List<int> Ordenar(List<int> numeros)
        {
            numeros.Sort();
            return numeros;
        }
    }
}
