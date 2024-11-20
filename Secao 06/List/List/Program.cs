using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciação da lista:
            List<string> list = new List<string>();

            //Adicionando itens na lista:
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            //Inserindo um valor através de um index:
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------------------------------");

            //Contabilizar itens dentro de uma lista:
            Console.WriteLine($"Intens dentro da lista: {list.Count}");

            Console.WriteLine("-------------------------------------------------------");

            //Encontrar primeiro elemento da lista que satisfaça um predicado:
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine($"Primeiro valor com a letra A na lista: {s1}");

            Console.WriteLine("-------------------------------------------------------");

            //Encontrar ultimo elemento da lista que satisfaça um predicado:
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Ultimo valor com a letra A na lista: {s2}");

            Console.WriteLine("-------------------------------------------------------");



            //Encontrar primeiro elemento da lista que satisfaça um predicado(retorna o index):
            int posicao1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"Primeiro index com a letra A na lista: {posicao1}");

            Console.WriteLine("-------------------------------------------------------");

            //Encontrar ultimo elemento da lista que satisfaça um predicado (retorna o index):
            int posicao2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Ultimo index com a letra A na lista: {posicao2}");

            Console.WriteLine("-------------------------------------------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Removendo item da lista 1:");

            /*
            // Remove pelo index:
            list.RemoveAt(1);
            Console.WriteLine("----------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            */

            /*
            // Remove pelo valor:
            list.Remove("Alex");
            Console.WriteLine("----------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            */

            // Remove os elementos de uma faixa Ex: RemoveRange(a partir da posição, remova (Quantidade que deseja)
            list.RemoveRange(2 , 2);
            Console.WriteLine("----------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            Console.WriteLine("---------------------------------------------------------------");

            //Remove todos se baseando pelo um predicado:
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}