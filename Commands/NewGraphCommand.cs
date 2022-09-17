using GraphVisual.Models;
using GraphVisual.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisual.Commands
{
    internal class NewGraphCommand
    {
        private GraphControlViewModel graphControlViewModel;
        private Graph gRAPH;

        public NewGraphCommand(GraphControlViewModel graphControlViewModel, Graph gRAPH)
        {
            this.graphControlViewModel = graphControlViewModel;
            this.gRAPH = gRAPH;
        }
    }
}
