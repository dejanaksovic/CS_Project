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
    public class AddEdgeCommand : CommandBase
    {
        Graph _graph { get; }
        GraphControlViewModel _graphControlViewModel { get; }
        public AddEdgeCommand(GraphControlViewModel graphControlViewModel, Graph GRAPH)
        {
            _graph = GRAPH;
            _graphControlViewModel = graphControlViewModel;
        }
        public override void Execute(object? parameter)
        {
            var TempFirst = _graph.Nodes.Where(item => item.ID == _graphControlViewModel.Id_First);
            var TempSecond = _graph.Nodes.Where(item => item.ID == _graphControlViewModel.Id_Second);

            Node a = TempFirst.First();
            Node b = TempSecond.First();

            //Mrak -> Nista ne radi, Popravi!
            try
            {
                _graph.AddEdge(a, b, _graphControlViewModel.EdgeValue);
            }
            catch (Exception)
            {
                MessageBox.Show("Proverite ponovo id-jeve ili postoji mogucnost da ta veza vec postoji");
            }
        }
    }
}
