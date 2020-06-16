using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Graph_.methods
{
    class Graph_methods
    {
        public string[] MemoryGrafo(string file)
        {
            string path = Directory.GetCurrentDirectory();
            string[] graph = System.IO.File.ReadAllText($@"{path}\..\..\..\{file}").Split('\n');

            return graph;
        }

        public void ReadPrintGrafo(string[] graph)
        {
            for (int i = 0; i < graph.Length; i++)
            {
                int countVertice = 0;
                var splitVertice = graph[i].Split();
                if (!string.IsNullOrWhiteSpace(splitVertice[0]))
                {
                    Console.Write($"{splitVertice[0]}: ");
                    for (int j = 1; j < splitVertice.Length; j++)
                    {
                        Console.Write(splitVertice[j] + " ");
                        if (!string.IsNullOrWhiteSpace(splitVertice[j]))
                        {
                            countVertice += 1;
                        }
                    }
                    Console.Write($"(quantidade de vertices adjacentes: {countVertice} )\n");
                }
                Console.WriteLine();
            }
        }

        public void CountAresta(string[] Graph)
        {
            int numAresta = 0;
            for (int i = 0; i < Graph.Length; i++)
            {
                var splitGraph = Graph[i].Split();
                for (int j = 1; j < splitGraph.Length; j++)
                {
                    if (!string.IsNullOrWhiteSpace(splitGraph[j]))
                    {
                        numAresta += 1;
                    }
                }
            }

            if (numAresta == 0)
            {
                Console.WriteLine("Este Grafo é Nulo!\n\n");
            }
            else
            {
                Console.WriteLine($"Este Grafo possui {numAresta} arestas\n\n");
            }
        }

        public string[][] StartMatriz(int tamanho)
        {
            string[][] matriz = new string[tamanho][];
            for (int i = 0; i < tamanho; i++)
            {
                matriz[i] = new string[tamanho];
                for (int j = 0; j < tamanho; j++)
                {
                    matriz[i][j] = "0";
                }
            }

            return matriz;
        }

        public void MatrizAdjacencia(string[] Graph)
        {
            List<string> vertices = new List<string>();
            for (int i = 0; i < Graph.Length; i++)
            {
                var splitVertice = Graph[i].Split();
                foreach (var item in splitVertice)
                {
                    if (!vertices.Contains(item) && !string.IsNullOrWhiteSpace(item))
                    {
                        vertices.Add(item);
                    }
                }
            }

            var matriz = StartMatriz(vertices.Count);
            Console.Write("    ");
            foreach (var item in vertices)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            for (int i = 0; i < vertices.Count; i++)
            {
                var splitVertices = Graph[i].Split();
                Console.Write(vertices[i]);
                for (int j = 0; j < vertices.Count; j++)
                {
                    if (splitVertices.Contains(vertices[j]) && vertices[j] != vertices[i])
                    {
                        matriz[i][j] = "X";
                    }
                    Console.Write($"  {matriz[i][j]}  ");
                }
                Console.WriteLine();
            }
        }

        public float complexityGraph(string[] Graph)
        {
            int numVertice = 0;
            int numAresta = 0;
            for (int i = 0; i < Graph.Length; i++)
            {
                var splitVertice = Graph[i].Split();
                numVertice += 1;
                for (int j = 1; j < splitVertice.Length; j++)
                {
                    if (!string.IsNullOrWhiteSpace(splitVertice[j]))
                    {
                        numAresta += 1;
                    }
                }
            }
            return numVertice + numAresta;
        }
    }
}
