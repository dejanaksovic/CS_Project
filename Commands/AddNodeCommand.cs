using GraphVisual.Models;
using GraphVisual.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GraphVisual.Commands
{
    public class AddNodeCommand : CommandBase
    {
        private readonly Graph _graph;
        private readonly GraphControlViewModel _graphControlViewModel;

        public AddNodeCommand(GraphControlViewModel graphControlViewModel, Graph GRAPH)
        {
            _graph = GRAPH;
            this._graphControlViewModel = graphControlViewModel;
        }
        public override void Execute(object? parameter)
        {
            _graph.AddNode(_graphControlViewModel.NodeValue, 0, 0);           
        }
    }
}
