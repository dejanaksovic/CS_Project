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

        int _selectedName;

        public int SelectedName
        {
            get
            {
                return _selectedName;
            }

            set
            {
                _selectedName = value;
                OnPropertyChanged(nameof(SelectedName));
            }
        }

        public string NodeValue { get; set; }


        public ICommand AddNode { get; }
        public ICommand ChangeNode { get; }
        public ICommand AddEdge { get; }
        public ICommand FindTree { get; }

        public GraphControlViewModel(Graph GRAPH)
        {
            _graphName = GRAPH.Name;

            AddNode = new AddNodeCommand(this, GRAPH);
            ChangeNode = new ChangeNodeCommand(this, GRAPH);
        }
    }
}
