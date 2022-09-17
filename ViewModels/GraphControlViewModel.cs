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

        public string GraphName => _graph.Name;

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

        public ICommand AddNode { get; }
        public ICommand ChangeNode { get; }
        public ICommand AddEdge { get; }
        public ICommand FindTree { get; }

        public ICommand RemoveNode { get; }

        public GraphControlViewModel(Graph GRAPH)
        {
            _graph = GRAPH;
            _graph.IChanged += OnGraphChanged;
            CurrSelected = "";

            AddNode = new AddNodeCommand(this, GRAPH);
            ChangeNode = new ChangeNodeCommand(this, GRAPH);
            AddEdge = new AddEdgeCommand(this, GRAPH);
            FindTree = new FindTreeCommand(this, GRAPH);
            RemoveNode = new RemoveNodeCommand(this, GRAPH)
        }

        public void OnGraphChanged(Graph sender)
        {
            CurrSelected = _graph.CurrentSelected.ID.ToString();
            SelectedId = _graph.CurrentSelected.ID;
        }
    }
}
