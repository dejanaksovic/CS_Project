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
    public class ChangeEdgeWeightCommand : CommandBase
    {
        private GraphControlViewModel graphControlViewModel;
        private Graph gRAPH;

        public ChangeEdgeWeightCommand(GraphControlViewModel graphControlViewModel, Graph gRAPH)
        {
            this.graphControlViewModel = graphControlViewModel;
            this.gRAPH = gRAPH;
        }

        public override void Execute(object? parameter)
        {
            try
            {
                this.gRAPH.OnEdgeChanged(this.gRAPH.SelectedEdge.FirstNode.ID, this.gRAPH.SelectedEdge.SecondNode.ID, int.Parse(graphControlViewModel.EdgeValue));
            }

            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
