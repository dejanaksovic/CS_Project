using GraphVisual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisual.Commands
{
    internal class ClickedNodeCommand : CommandBase
    {
        Node _node;

        
        public ClickedNodeCommand(Node CLICKED_NODE)
        {
            _node = CLICKED_NODE;
        }
        public override void Execute(object? parameter)
        {
            _node.OnClick();
        }
    }
}
