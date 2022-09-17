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
    public class RemoveEdgeCommand : CommandBase
    {
        private GraphControlViewModel graphControlViewModel;
        private Graph gRAPH;

        public RemoveEdgeCommand(GraphControlViewModel graphControlViewModel, Graph gRAPH)
        {
            this.graphControlViewModel = graphControlViewModel;
            this.gRAPH = gRAPH;
        }

        public override void Execute(object? parameter)
        {
            try
            {
                gRAPH.RemoveEdge(gRAPH.SelectedEdge);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
