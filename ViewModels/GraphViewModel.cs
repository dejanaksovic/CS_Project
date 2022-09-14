using GraphVisual.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisual.ViewModels
{
    internal class GraphViewModel
    {
        public Graph _graph { get; }

        public GraphViewModel(Graph GRAPH)
        {
            _graph = GRAPH;
        }
    }
}
