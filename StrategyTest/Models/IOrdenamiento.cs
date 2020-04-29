using System.Collections.Generic;

namespace StrategyTest.Models
{
    public interface IOrdenamiento
    {
        List<int> Ordenar(List<int> numeros);
    }
}