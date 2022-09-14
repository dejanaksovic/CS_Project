using GraphVisual.Commands;
using GraphVisual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace GraphVisual.ViewModels
{
    public class GraphControlViewModel : ViewModelBase
    {
        Graph _graph;

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
                OnPropertyChanged(nameof(GraphName));
            }
        }

        public string NodeValue { get; set; }

        public int SelectedId { get; set; }

        public int Id_First { get; set; }
        public int Id_Second { get; set; }

        public int EdgeValue { get; set; }

        public ICommand AddNode { get; }
        public ICommand ChangeNode { get; }
        public ICommand AddEdge { get; }
        public ICommand FindTree { get; }

        public GraphControlViewModel(Graph GRAPH)
        {
            _graph = GRAPH;
            _graphName = GRAPH.Name;
            _graph.IChanged += OnGraphChanged;


            AddNode = new AddNodeCommand(this, GRAPH);
            ChangeNode = new ChangeNodeCommand(this, GRAPH);
            AddEdge = new AddEdgeCommand(this, GRAPH);
        }

        public void OnGraphChanged(Graph sender)
        {
            
        }
    }
}
