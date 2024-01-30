using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class Program
    {
        class Node //node = knot = uzel
        {
            private int index;
            private List<Node> neighbours;

            public Node(int index)
            {
                this.index = index;
                neighbours = new List<Node>();
            }
            public void AddNeighbour(Node node)
            {
                if (neighbours.Contains(node))
                {
                    Console.WriteLine($"Node {node.index} už je v seznamu");
                }
                else
                {
                    neighbours.Add(node);
                    //node.AddNeighbour(this); //rovnou automaticky když přidá jedničce čtyřku tak rovnou přidá čtyřce jedničku - nemusím to psát dvakrát dole
                    Console.WriteLine($"Node {node.index} byl přidán do seznamu");
                }
            }
            public int GetIndex()
            {
                return index;
            }
            public int[] GetNeighboursIndices()
            {
                int[] indices = new int[neighbours.Count];
                for (int i = 0; i < neighbours.Count; i++)
                {
                    indices[i] = neighbours[i].index;
                }
                return indices;
            }
            public Node MoveToNeighbour(int index)
            {
                foreach (Node neighbour in neighbours) 
                {
                    if (neighbour.index == index)
                    {
                        return neighbour;
                    }
                }
                Console.WriteLine($"Node{index} není neighbour {this.index}");
                return this;
            }
        }
        static void Main(string[] args)
        {
            //sousedi
            // 1 - 4, 6
            // 2 - 3, 5, 6
            // 3 - 2, 5
            // 4 - 1, 6
            // 5 - 2, 3
            // 6 - 1, 2, 4

            Node node1 = new Node(1); //vytvoření všech nodů/uzlů grafu
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            node1.AddNeighbour(node4); //přidání všech jeho sousedů ručně
            node1.AddNeighbour(node6);

            node2.AddNeighbour(node3);
            node2.AddNeighbour(node5);
            node2.AddNeighbour(node6);

            node3.AddNeighbour(node2);
            node3.AddNeighbour(node5);

            node4.AddNeighbour(node1);
            node4.AddNeighbour(node6);

            node5.AddNeighbour(node2);
            node5.AddNeighbour(node3);

            node6.AddNeighbour(node1);
            node6.AddNeighbour(node2);
            node6.AddNeighbour(node4);


            Node currentNode = node1;
            while (true)
            {

                Console.Write('\n');
                Console.WriteLine($"CurrentNode: {currentNode.GetIndex()}");
                Console.Write("Neigbours: ");
                foreach (int neighbourIndex in currentNode.GetNeighboursIndices())
                {
                    Console.Write(neighbourIndex + " ");
                }
                Console.Write('\n');
                Console.WriteLine("Choose where to go.");
                int desiredIndex = int.Parse(Console.ReadLine());
                currentNode = currentNode.MoveToNeighbour(desiredIndex);

            }    

        }
    }
}
