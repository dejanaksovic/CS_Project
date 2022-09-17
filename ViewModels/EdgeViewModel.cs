using GraphVisual.Commands;
using GraphVisual.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace GraphVisual.ViewModels
{
    public class EdgeViewModel
    {
        Edge currentEdge;

        public float PosXFirst => currentEdge.FirstNode.PosX+25;
        public float PosYFirst => currentEdge.FirstNode.PosY+25;

        public float PosXSecond => currentEdge.SecondNode.PosX+25;
        public float PosYSecond => currentEdge.SecondNode.PosY+25;

        public SolidColorBrush IsTree => currentEdge.isTree;

        public string NameFirst => currentEdge.FirstNode.Value;

        public string NameSecond => currentEdge.SecondNode.Value;
        public int Weight => currentEdge.weight;

        public ICommand SelectEdge { get; set; }

        public EdgeViewModel(Edge CURR_EDGE)
        {
            currentEdge = CURR_EDGE;
            SelectEdge = new SelectEdgeCommand(this, currentEdge);
            
        }
    }
}
