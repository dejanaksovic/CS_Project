using GraphVisual.Commands;
using GraphVisual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Navigation;
using GraphVisual.Utilities;

namespace GraphVisual.ViewModels
{
    public class GraphControlViewModel : ViewModelBase
    {
        Graph _graph;

        public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Desktop\\Repos\\CS_Project\\DataBase\\Database1.mdf;Integrated Security=True";

        string _graphName;
        public string GraphName
        {
            get
            {
                return _graphName;
            }
            set
            {
                _graphName = value;
                OnPropertyChanged(nameof(_graphName));
            }
        }

        string _currSelected;
        public string CurrSelected
        {
            set
            {
                _currSelected = value;
                OnPropertyChanged(nameof(CurrSelected));
            }

            get
            {
                return _currSelected;
            }
        }

        public string NodeValue { get; set; }

        public int SelectedId { get; set; }

        public string Id_First { get; set; }
        public string Id_Second { get; set; }

        public string EdgeValue { get; set; }

        public string SelectedEdge { set; get; }

        public ICommand AddNode { get; }
        public ICommand ChangeNode { get; }
        public ICommand RemoveNode { get; }

        public ICommand AddEdge { get; }
        public ICommand ChangeEdge { get; }
        public ICommand RemoveEdge { get; }

        public ICommand FindTree { get; }


        public ICommand NewGraph { get; }
        public ICommand InsertGraph { get; }
        public ICommand SelectGraph { get; }
        public ICommand DeleteGraph { get; }

        public GraphControlViewModel(Graph GRAPH)
        {
            _graph = GRAPH;
            _graph.IChanged += OnGraphChanged;
            CurrSelected =null;

            GraphName = GRAPH.Name;

            AddNode = new AddNodeCommand(this, GRAPH);
            ChangeNode = new ChangeNodeCommand(this, GRAPH);
            RemoveNode = new RemoveNodeCommand(this, GRAPH);

            AddEdge = new AddEdgeCommand(this, GRAPH);
            ChangeEdge = new ChangeEdgeWeightCommand(this, GRAPH);
            RemoveEdge = new RemoveEdgeCommand(this, GRAPH);

            FindTree = new FindTreeCommand(this, GRAPH);

            InsertGraph = new InsertGraphCommand(this, GRAPH);
            NewGraph = new NewGraphCommand(this, GRAPH);
            SelectGraph = new SelectGraphCommand(this, GRAPH);
            DeleteGraph = new DeleteGraphCommand(this, GRAPH);
        }

        public void OnGraphChanged(Graph sender)
        {
                GraphName = sender.Name;
                CurrSelected = _graph.CurrentSelected.ID.ToString();
                SelectedId = _graph.CurrentSelected.ID;
                SelectedEdge = _graph.SelectedEdge.FirstNode.Value + " " + _graph.SelectedEdge.SecondNode.Value;
               
        }

    }
}
