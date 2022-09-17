using GraphVisual.Models;
using GraphVisual.Utilities;
using GraphVisual.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;

namespace GraphVisual.Commands
{
    public class InsertGraphCommand : CommandBase
    {
        private GraphControlViewModel graphControlViewModel;
        private Graph gRAPH;

        public InsertGraphCommand(GraphControlViewModel graphControlViewModel, Graph gRAPH)
        {
            this.graphControlViewModel = graphControlViewModel;
            this.gRAPH = gRAPH;
        }

        public override void Execute(object? parameter)
        {
            gRAPH = new Graph("Test ime", Helper.ID);
        }
    }
}
