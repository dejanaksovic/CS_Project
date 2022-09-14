using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GraphVisual.Models
{
    public class Graph
    {
        public delegate void ChangeNodeHandler(int ID, string VALUE);
        public event ChangeNodeHandler NodeChanged;

        int currId = 0;

        public List<Node> Nodes { get; } = new List<Node>();

        public List<Edge> Edges { get; } = new List<Edge>();

        public string Name { get; set; }

        public Graph(string Name)
        {
            this.Name = Name;
        }

        public void AddNode(string VALUE, float POSX, float POSY)
        {
            Node temp = new Node(currId++, VALUE, POSX, POSY);
            NodeChanged += temp.HandleChange;
            Nodes.Add(temp);
        }

        public void AddEdge(Node FIRST_EDGE, Node SECOND_EDGE, int WEIGHT)
        {
            Edges.Add(new Edge(FIRST_EDGE, SECOND_EDGE, WEIGHT));
        }

        public void OnNodeChanged(int ID, string VALUE)
        {
            NodeChanged?.Invoke(ID, VALUE);
        }
    }
}
