using GraphVisual.Models;
using GraphVisual.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisual.Commands
{
    internal class RemoveNodeCommand : CommandBase
    {
        Graph _graph;
        GraphControlViewModel _graphControlViewModel;

        public RemoveNodeCommand(GraphControlViewModel _graphControlViewModel, Graph GRAPH)
        {
            _graph = GRAPH;
            _graphControlViewModel = _graphControlViewModel;
        }
        public override void Execute(object? parameter)
        {
            
        }
    }
}
