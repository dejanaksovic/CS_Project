using GraphVisual.Models;
using GraphVisual.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisual.Commands
{
    class ChangeNodeCommand : CommandBase
    { 
        Graph _graph { get; }
        GraphControlViewModel _graphControlViewModel { get; }

        public ChangeNodeCommand(GraphControlViewModel graphControlViewModel, Graph GRAPH)
        {
            _graph = GRAPH;
            _graphControlViewModel = graphControlViewModel;
        }

        public override void Execute(object? parameter)
        {
            _graph.OnNodeChanged(_graphControlViewModel.SelectedId, _graphControlViewModel.NodeValue);
        }
    }
}
