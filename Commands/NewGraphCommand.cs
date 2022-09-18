using GraphVisual.Models;
using GraphVisual.Utilities;
using GraphVisual.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisual.Commands
{
    public class NewGraphCommand : CommandBase
    {
        private GraphControlViewModel graphControlViewModel;
        private Graph gRAPH;

        public NewGraphCommand(GraphControlViewModel graphControlViewModel, Graph gRAPH)
        {
            this.gRAPH = gRAPH;
            this.graphControlViewModel = graphControlViewModel;
        }

        public override void Execute(object? parameter)
        {
            string name= Microsoft.VisualBasic.Interaction.InputBox("Unesite ime grafa", "GraphWizard", "", -1, -1);
            gRAPH.Reset(name);
        }
    }
}
