using GraphVisual.Models;
using GraphVisual.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisual.Commands
{
    internal class DragDropCommand : CommandBase
    {
        private NodeViewModel nodeViewModel;
        private Node sampleNode;

        public DragDropCommand(NodeViewModel nodeViewModel, Node sampleNode)
        {
            this.nodeViewModel = nodeViewModel;
            this.sampleNode = sampleNode;
        }

        public override void Execute(object? parameter)
        {
            System.Windows.MessageBox.Show($"{sampleNode.ID}");
        }
    }
}
