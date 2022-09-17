using GraphVisual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisual.ViewModels
{
    public class TreeViewModel : ViewModelBase
    {
        Graph _graph;

        List<Edge> TreeEdges;
        public TreeViewModel(Graph GRAPH)
        {
            _graph = GRAPH;
            TreeEdges = new List<Edge>();
        }
    }
}
