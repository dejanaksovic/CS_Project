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
    internal class RemoveNodeCommand : CommandBase
    {
        Graph _graph;
        GraphControlViewModel _graphControlViewModel;

        public RemoveNodeCommand(GraphControlViewModel _graphControlViewModel, Graph GRAPH)
        {
            _graph = GRAPH;
            this._graphControlViewModel = _graphControlViewModel;
        }
        public override void Execute(object? parameter)
        {
            int tempId= new int();


            if (!(int.TryParse(_graphControlViewModel.CurrSelected, out tempId)))
            {
                return;
            }
            else
            {

                _graph.RemoveNode(tempId);
            }
           

            
        }
    }
}
