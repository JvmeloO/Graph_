using System;
using System.Collections.Generic;
using System.Text;
using Graph_.methods;

namespace Graph_
{
    class Graph_main
    {
        static void Main(string[] args)
        {
            var graph_Methods = new Graph_methods();
            string graph = "graph-5000.txt";
            string graph_short = "graph-short.txt";

            //Carregando o grafo em memória
            string[] Graph = graph_Methods.MemoryGrafo(graph);
            string[] GraphShort = graph_Methods.MemoryGrafo(graph_short); 

            Console.WriteLine("Grafo como Lista de adjacências: \n");
            //Lendo e imprimindo o grafo como lista de adjacências
            graph_Methods.ReadPrintGrafo(Graph);

            Console.WriteLine("Complexidade do Grafo: \n");
            //Analisando a complexidade do Grafo
            float complexy = graph_Methods.complexityGraph(Graph);
            Console.WriteLine($"A complexidade do grafo é: {complexy}\n\n");

            Console.WriteLine("Quantidade de arestas: \n");
            //Contando a quantidade de arestas
            graph_Methods.CountAresta(Graph);

            Console.WriteLine("Exibindo o grafo como matriz de adjacencia utilizando um grafo pequeno: \n");
            //Matriz de adjacência utilizando um grafo pequeno, o grafo utilizado para a lista de adjacência
            //é muito grande implementar como matriz de adjacência
            //Use esse método para grafos pequenos
            graph_Methods.MatrizAdjacencia(GraphShort);
        }
    }
}
