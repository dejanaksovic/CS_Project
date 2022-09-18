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
    internal class DeleteGraphCommand : CommandBase
    {
        private GraphControlViewModel graphControlViewModel;
        private Graph gRAPH;

        public DeleteGraphCommand(GraphControlViewModel graphControlViewModel, Graph gRAPH)
        {
            this.graphControlViewModel = graphControlViewModel;
            this.gRAPH = gRAPH;
        }

        public override void Execute(object? parameter)
        {
            string idToDel = Microsoft.VisualBasic.Interaction.InputBox(Helper.ReturnGraphRepresent(), "Unesite jedan od sledecih id-jeva", null, -1, -1);
            Helper.DeleteGraph(int.Parse(idToDel));
            gRAPH.Reset("TestGraph");
        }
    }
}
