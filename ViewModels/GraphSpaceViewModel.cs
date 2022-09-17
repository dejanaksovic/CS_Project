using GraphVisual.Commands;
using GraphVisual.Models;
using GraphVisual.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace GraphVisual.ViewModels
{
    class GraphSpaceViewModel : ViewModelBase
    {
        Graph _graph { set; get; }

        public ObservableCollection<NodeViewModel> ElipsesO { get; } = new ObservableCollection<NodeViewModel>();

        public ObservableCollection<EdgeViewModel> EdgesO { get; } = new ObservableCollection<EdgeViewModel>();

        public GraphSpaceViewModel(Graph GRAPH)
        {
            _graph = GRAPH;
            _graph.IChanged += GraphChanged;
            ReloadNodes(_graph);
        }

        public void GraphChanged(Graph sender)
        {
            ReloadNodes(sender);
        }

        public void ReloadNodes(Graph test)
        {
            ElipsesO.Clear();
            EdgesO.Clear();

            foreach (var item in test.Nodes)
            {
                ElipsesO.Add(new NodeViewModel(item));
            }

            foreach (var item in test.Edges)
            {
                EdgesO.Add(new EdgeViewModel(item));
            }

        }

        
    }
}
