using System.Collections.Generic;

namespace StrategyTest.Models
{
    public class Descendente : IOrdenamiento
    {
        public List<int> Ordenar(List<int> numeros)
        {
            numeros.Sort();
            numeros.Reverse();
            return numeros;
        }
    }
}
