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
            //Mora var jer Linq uvek vraca ICollection valjda (neki interfejs :D ) i kasnije stavljamo prve clanove u node (jer prvi i samo postoje)
            var TempFirst = _graph.Nodes.Where(item => item.ID == _graphControlViewModel.Id_First);
            var TempSecond = _graph.Nodes.Where(item => item.ID == _graphControlViewModel.Id_Second);

            try
            {
                Node a = TempFirst.First();
                Node b = TempSecond.First();
                _graph.AddEdge(a, b, _graphControlViewModel.EdgeValue);
            }

            catch (Exception)
            {
                System.Windows.MessageBox.Show("One or both nodes with that id do not exist");
            }
        }
    }
}
