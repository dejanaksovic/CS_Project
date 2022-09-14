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

        public ChangeNodeCommand(GraphControlViewModel graphControlViewModel, Graph GRAPH)
        {
            _graph = GRAPH;
        }

        public override void Execute(object? parameter)
        {
            
        }
    }
}
