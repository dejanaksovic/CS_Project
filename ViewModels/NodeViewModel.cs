using GraphVisual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisual.ViewModels
{
    class NodeViewModel : ViewModelBase
    {
        Node sampleNode;

        public float PosX => sampleNode.PosX;

        public float PosY => sampleNode.PosY;


        public NodeViewModel(Node INITIAL_NODE)
        {
            sampleNode= INITIAL_NODE; 
        }
        
    }
}
