using GraphVisual.Commands;
using GraphVisual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GraphVisual.ViewModels
{
    class NodeViewModel : ViewModelBase
    {
        Node sampleNode;

        public ICommand ClickedNodeCommand { get; }

        public float PosX => sampleNode.PosX;

        public float PosY => sampleNode.PosY;

        public string Value => sampleNode.Value;

        public string ID => sampleNode.ID.ToString();

        public NodeViewModel(Node INITIAL_NODE)
        {
            sampleNode= INITIAL_NODE;
            ClickedNodeCommand = new ClickedNodeCommand(sampleNode);
        }
        
    }
}
