using GraphVisual.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace GraphVisual.ViewModels
{
    class EdgeViewModel
    {
        Edge currentEdge;

        public float PosXFirst => currentEdge.FirstNode.PosX+25;
        public float PosYFirst => currentEdge.FirstNode.PosY+25;

        public float PosXSecond => currentEdge.SecondNode.PosX+25;
        public float PosYSecond => currentEdge.SecondNode.PosY+25;

        public float Width { get; set; }
        public float Height { get; set; }

        public Thickness Margins { get; set; }

        public float PosOffsetX { get; set; }
        public float PosOffsetY { get; set; }

        public SolidColorBrush IsTree => currentEdge.isTree;

        public int Weight => currentEdge.weight;

        public EdgeViewModel(Edge CURR_EDGE)
        {
            currentEdge = CURR_EDGE;
            float LeftMargin;
            float MarginTop;
            if (PosXFirst > PosXSecond)
            {
                LeftMargin = PosXSecond;
                Width = PosXFirst - PosXSecond;
  
            }
            else
            {
                LeftMargin = PosXFirst;
                Width = PosXSecond - PosXFirst;
            }

            if (PosYFirst > PosYSecond)
            {
                MarginTop = PosYSecond;
                Height = PosYFirst - PosYSecond;
            }

            else
            {
                MarginTop = PosYFirst;
                Height = PosYSecond - PosYFirst;
            }

            Margins = new Thickness(LeftMargin, MarginTop, 0, 0);
            
        }
    }
}
