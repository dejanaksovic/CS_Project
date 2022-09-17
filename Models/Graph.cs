using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace GraphVisual.Models
{
    public class Graph
    {
        public delegate void ChangeNodeHandler(int ID, string VALUE);
        public delegate void ChangeEdgeHandler(int ID_FIRST, int ID_SECOND, int WEIGHT);
        public delegate void IChangedHandler(Graph source);

        public event ChangeNodeHandler NodeChanged;
        public event ChangeEdgeHandler EdgeChanged;
        public event IChangedHandler IChanged;

        int currId = 0;

        public Node CurrentSelected { set; get; }

        public List<Node> Nodes { get; } = new List<Node>();

        public List<Edge> Edges { get; } = new List<Edge>();

        public string Name { get; set; }

        public Node? SelectedNode;

        public Graph(string Name)
        {
            this.Name = Name;
            CurrentSelected = new Node(31, "LMAO", 12, 12);
        }

        public void AddNode(string VALUE, float POSX, float POSY)
        {
            Node temp = new Node(currId++, VALUE, POSX, POSY);
            NodeChanged += temp.HandleChange;
            temp.Clicked += OnNodeClicked;
            temp.IChanged += OnIChanged;
            Nodes.Add(temp);

            OnIChanged();

        }

        public void RemoveNode(int ID)
        {
            try
            {
                Nodes.Remove(Nodes.Where(item => item.ID == ID).First());
                OnIChanged();
            }

            catch (Exception)
            {
                MessageBox.Show("Node with that id does not exist");
            }
        }

        public void OnNodeChanged(int ID, string VALUE)
        {
            NodeChanged?.Invoke(ID, VALUE);
            OnIChanged();
        }

        public void OnEdgeChanged(int ID_FIRST, int ID_SECOND, int WEIGHT)
        {
            EdgeChanged?.Invoke(ID_FIRST, ID_SECOND, WEIGHT);
            OnIChanged();
        }

        public void OnIChanged()
        {
            IChanged?.Invoke(this);   
        }

        public void AddEdge(Node FIRST_NODE, Node SECOND_NODE, int WEIGHT)
        {
            Edge temp = new Edge(FIRST_NODE, SECOND_NODE, WEIGHT);
            foreach(var item in Edges)
            {
                if (temp == item)
                {
                    System.Windows.MessageBox.Show("That edge already exists, please try other one");
                        return;
                }
            }
            
             EdgeChanged += temp.HandleChange;
             Edges.Add(temp);

             OnIChanged();
            
        }

        public void OnNodeClicked(Node sender)
        {
            CurrentSelected = sender;
            OnIChanged();
        }


        public async Task FindTree()
        {
            Edges.Sort();
            List<Node> InsideNodes = new List<Node>();


            foreach (var item in Edges)
            {
                if (InsideNodes.Contains(item.FirstNode) && InsideNodes.Contains(item.SecondNode))
                   continue;
                InsideNodes.Add(item.FirstNode);
                InsideNodes.Add(item.SecondNode);
                await Task.Delay(500);
                item.isTree.Color = Colors.Red;
                OnIChanged();
            }                   
        }
   
    }
}
