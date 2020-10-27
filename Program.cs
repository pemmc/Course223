using System;

using System.Collections.Generic;

using Predicate.Entities;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Products> list = new List<Products>();
            list.Add(new Products("Tv", 900.00));
            list.Add(new Products("Mouse", 50.00));
            list.Add(new Products("Tablet", 350.50));
            list.Add(new Products("HD Case", 80.90));

            //PREDICATO...
            //É uma função que recebe um objeto e retorna um bool
            list.RemoveAll(ProducTest);

            //funciona tb assim com a FUNCAO LAMBDA
            //list.RemoveAll(p => p.Price >= 100.0);

            Console.WriteLine("--- LISTA DE PRODUTOS COM VALORES ACIMA DE 100.0---");
            foreach (Products p in list)
            {
                Console.WriteLine(p);

            }

            
        }

        //PREDICATE é uma função que recebe um objeto e retorna um bool
        public static bool ProducTest(Products p)
        {
            //aqui tá a funcao lambda
            return p.Price >= 100.0;

        }

    }
}
