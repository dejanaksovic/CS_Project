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

        public int weight { get; set; }

        public Edge(Node FIRST, Node SECOND, int WEIGHT)
        {
            FirstNode = FIRST;
            SecondNode = SECOND;
            weight = WEIGHT;
        }

        void UpdateWeight(int WEIGHT)
        {
            weight = WEIGHT;
        }

        public void HandleChange(int ID_FIRST, int ID_SECOND, int WEIGHT)
        {
            if (ID_FIRST == FirstNode.ID && ID_SECOND == SecondNode.ID)
            {
                UpdateWeight(WEIGHT);
            }
        }


        public static bool operator ==(Edge first, Edge second)
        {
            if (first.FirstNode == second.FirstNode && first.SecondNode == second.SecondNode)
                return true;

            return false;
        }

        public static bool operator !=(Edge first, Edge second)
        {
            return !(first == second);
        }

        public static bool operator >(Edge first, Edge second)
        {
            if (first.weight > second.weight)
                return true;
            return false;
        }

        public static bool operator <(Edge first, Edge second)
        {
            return !(first > second);
        }

        public static bool operator <=(Edge left, Edge right)
        {
            if (left < right || left == right)
                return true;

            return false;
        }

        public static bool operator >=(Edge left, Edge right)
        {
            if (left > right || left == right)
                return true;

            return false;
        }
    }
}
