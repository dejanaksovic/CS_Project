using GraphVisual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisual.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get;}

        public ViewModelBase GraphSpace { get; }
        public ViewModelBase GraphControl { get; }

        public MainViewModel(Graph GRAPH)
        {
            ViewModelBase CurrViewModel = new ViewModelBase();

            GraphControl = new GraphControlViewModel(GRAPH);
            GraphSpace = new GraphSpaceViewModel(GRAPH);

            CurrViewModel = GraphControl;
        }
    }
}
