using System;

namespace GraphPlayground
{
    internal class Program
    {
        public static void DFS(Graph graph, Node startNode, Node targetNode = null)
        {
            Node currentNode = startNode;
            while(true)
            {
                Node neighbourToVisit = null;
                foreach(Node neighbour in currentNode.neighbors)
                {
                    if (!neighbour.visited)
                    {
                        neighbourToVisit = neighbour;
                        break;
                    }
                }
                if (neighbourToVisit == null) //všichni sousedi jsou už navštíveni
                {
                    if (currentNode == startNode)
                    {
                        Console.WriteLine("jsem ve startovacím uzlu a nemám kam jít");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"jsem ve slepé uličce, vracím se z uzlu {currentNode.index} do uzlu {currentNode.cameFrom.index}");
                        currentNode = currentNode.cameFrom;
                    }
                }
                else //mám nenavštíveného souseda kterého jdu navštívit
                {
                    Console.WriteLine($"jduz uzlu {currentNode.index} do uzlu {neighbourToVisit.index}");
                    neighbourToVisit.visited = true;
                    neighbourToVisit.cameFrom = currentNode;
                    currentNode = neighbourToVisit;
                }
            }
        }

        public static void BFS(Graph graph, Node startNode, Node targetNode = null) 
        {
            
        }

        static void Main(string[] args)
        {
            //Create and print the graph
            Graph graph = new Graph();
            graph.PrintGraph();
            graph.PrintGraphForVisualization();

            //Call both algorithms with a random starting node
            Random rng = new Random();
            DFS(graph, graph.nodes[rng.Next(0, graph.nodes.Count)]);
            BFS(graph, graph.nodes[rng.Next(0, graph.nodes.Count)]);

            Console.ReadKey();
        }
    }
}
