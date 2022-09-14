using GraphVisual.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisual.ViewModels
{
    class GraphSpaceViewModel : ViewModelBase
    {
        
        public ObservableCollection<NodeViewModel> ElipsesO { get; }

        public ObservableCollection<EdgeViewModel> EdgesO { get; }

        public GraphSpaceViewModel(Graph GRAPH)
        {
            
            Edge testEdge = new Edge( new Node(1, "da", 100, 150), new Node(1, "da", 180, 200), 1000);

            EdgeViewModel testModel = new EdgeViewModel(testEdge);

            EdgesO = new ObservableCollection<EdgeViewModel>();
            EdgesO.Add(testModel);

            ElipsesO = new ObservableCollection<NodeViewModel>();
            ElipsesO.Add(new NodeViewModel(new Node(1, "da", 100, 150)));
            ElipsesO.Add(new NodeViewModel(new Node(1, "da", 180, 200)));
        }

    }

}
