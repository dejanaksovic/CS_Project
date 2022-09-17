using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GraphVisual.Models
{
    public class Edge : IComparable
    {
        public delegate void IClickedHandler (Edge sender);
        public event IClickedHandler IClicked;
        public Node FirstNode { get; }

        public Node SecondNode { get; }

        public int weight { get; set; }

        public SolidColorBrush isTree { set; get; }

        public Edge(Node FIRST, Node SECOND, int WEIGHT)
        {
            FirstNode = FIRST;
            SecondNode = SECOND;
            weight = WEIGHT;
            isTree = new SolidColorBrush(Colors.Black);
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

        public int CompareTo(object? obj)
        {
            if (obj == null)
                return 1;

            Edge otherEdge = obj as Edge;
            if (otherEdge != null)
                return this.weight.CompareTo(otherEdge.weight);
            else
                throw new ArgumentException("Object is not an Edge");
        }

        public void EdgeClicked()
        {
            IClicked?.Invoke(this);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            Edge testEdge = obj as Edge;

            if(this.FirstNode.ID==testEdge.FirstNode.ID && this.SecondNode.ID == testEdge.SecondNode.ID)
            {
                return true;
            }

            return false;
        }

    }
}
