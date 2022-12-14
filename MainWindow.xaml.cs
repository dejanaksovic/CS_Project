using GraphVisual.Models;
using GraphVisual.Utilities;
using GraphVisual.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GraphVisual
{
    public partial class MainWindow : Window
    {
        private readonly Graph myGraph;
        public MainWindow()
        {
            myGraph = new Graph("TestGraph", Helper.GetIdFromGraph());

            InitializeComponent();
            DataContext = new MainViewModel(myGraph);

        }
    }
}
