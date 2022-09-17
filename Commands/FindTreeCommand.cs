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
    internal class FindTreeCommand : CommandBase
    {
        private GraphControlViewModel graphControlViewModel;
        private Graph _graph;

        public FindTreeCommand(GraphControlViewModel graphControlViewModel, Graph gRAPH)
        {
            this.graphControlViewModel = graphControlViewModel;
            this._graph = gRAPH;
        }

        public override void  Execute(object? parameter)
        {
            _graph.FindTree();           
        }
    }
}
