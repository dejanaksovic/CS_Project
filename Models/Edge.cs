using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisual.Models
{
    public class Edge
    {
        public Node FirstNode { get; }

        public Node SecondNode { get; }

        int weight { get; }

        public Edge(Node FIRST, Node SECOND, int WEIGHT)
        {
            FirstNode = FIRST;
            SecondNode = SECOND;
            weight= WEIGHT;
        }
    }
}
