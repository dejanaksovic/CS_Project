using GraphVisual.Commands;
using GraphVisual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace GraphVisual.ViewModels
{
    class NodeViewModel : ViewModelBase
    {
        public Node sampleNode;

        public ICommand ClickedNodeCommand { get; }

        public float PosX { get; set; }

        public float PosY { get; set; }

        public string Value => sampleNode.Value;

        public SolidColorBrush IsSelected => sampleNode.isSelected;
        

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
