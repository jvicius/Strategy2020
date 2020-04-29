using StrategyTest.Models;
using System;
using System.Collections.Generic;

namespace StrategyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros = new List<int> {
                5,8,7,99,10,0,4,374,88,1
            };

            Console.WriteLine("1. Ascendente");
            Console.WriteLine("2. Descendente");
            var respuesta = Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");
            IOrdenamiento estrategia = null; ;

            switch(respuesta.KeyChar)
            {
                case '1':
                    estrategia = new Ascendete();
                    break;
                case '2':
                    estrategia = new Descendente();
                    break;
                default:
                    Console.WriteLine("Opcion Incorrecta");
                    return;                    
            }

            var ordenarNumeros = new OrdenarNumeros(numeros, estrategia);
            var resultado = ordenarNumeros.ListaOrdenada();

            foreach(var elemento in resultado)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
