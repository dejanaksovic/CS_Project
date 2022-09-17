using GraphVisual.Models;
using GraphVisual.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisual.Commands
{
    public class SelectEdgeCommand : CommandBase
    {
        private EdgeViewModel edgeViewModel;
        private Edge currentEdge;

        public SelectEdgeCommand(EdgeViewModel edgeViewModel, Edge currentEdge)
        {
            this.edgeViewModel = edgeViewModel;
            this.currentEdge = currentEdge;
        }

        public override void Execute(object? parameter)
        {
            currentEdge.EdgeClicked();
        }
    }
}
