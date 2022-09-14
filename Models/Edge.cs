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

        int weight { get; set; }

        public Edge(Node FIRST, Node SECOND, int WEIGHT)
        {
            FirstNode = FIRST;
            SecondNode = SECOND;
            weight= WEIGHT;
        }

        void UpdateWeight(int WEIGHT)
        {
            weight = WEIGHT;
        }

        public void HandleChange(int ID_FIRST, int ID_SECOND, int WEIGHT)
        {
            if(ID_FIRST == FirstNode.ID && ID_SECOND == SecondNode.ID)
            {
                UpdateWeight(WEIGHT);
            }
        }
    }
}
