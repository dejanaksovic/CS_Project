using GraphVisual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisual.ViewModels
{
    class EdgeViewModel
    {
        Edge currentEdge;

        public float PosXFirst => currentEdge.FirstNode.PosX + 15;
        public float PosYFirst => currentEdge.FirstNode.PosY + 15;

        public float PosXSecond => currentEdge.SecondNode.PosX + 15;
        public float PosYSecond => currentEdge.SecondNode.PosY + 15;

        public EdgeViewModel(Edge CURR_EDGE)
        {
            currentEdge = CURR_EDGE;
        }
    }
}
