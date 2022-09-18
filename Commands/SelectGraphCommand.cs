using GraphVisual.Models;
using GraphVisual.Utilities;
using GraphVisual.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GraphVisual.Commands
{
    internal class SelectGraphCommand : CommandBase
    {
        private GraphControlViewModel graphControlViewModel;
        private Graph gRAPH;

        public SelectGraphCommand(GraphControlViewModel graphControlViewModel, Graph gRAPH)
        {
            this.graphControlViewModel = graphControlViewModel;
            this.gRAPH = gRAPH;
        }

        public override void Execute(object? parameter)
        {

            string IdToSel = Microsoft.VisualBasic.Interaction.InputBox(Helper.ReturnGraphRepresent(), "Unesite jedan od sledecih id-jeva", null, -1, -1);

            try
            {
                gRAPH.ResetNew(Helper.SelectGraph(int.Parse(IdToSel)));
            }

            catch (Exception)
            {
                MessageBox.Show("That graph doesnt exist, please try again with different input (FOLLOW THE RULES!)");
            }
            

        }
    }
}
