using GraphVisual.Commands;
using GraphVisual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace GraphVisual.ViewModels
{
    class NodeViewModel : ViewModelBase
    {
        public Node sampleNode;

        public static readonly DependencyProperty DragDropCommandDepend = DependencyProperty.Register("DragDropCommand", typeof(ICommand), typeof(NodeViewModel));
        public ICommand ClickedNodeCommand { get; }

        public float PosX { get; set; }

        public float PosY { get; set; }

        public string Value => sampleNode.Value;

        public string ID => sampleNode.ID.ToString();

        public NodeViewModel(Node INITIAL_NODE)
        {
            sampleNode= INITIAL_NODE;
            PosX = sampleNode.PosX;
            PosY = sampleNode.PosY;
            ClickedNodeCommand = new ClickedNodeCommand(sampleNode);         
        }
        
    }
}
