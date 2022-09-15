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

namespace GraphVisual.Views
{
    /// <summary>
    /// Interaction logic for Graph_space.xaml
    /// </summary>
    public partial class Graph_space : UserControl
    {

        public Graph_space()
        {
            InitializeComponent();
        }

        private void Node_MouseMove(object sender, MouseEventArgs e)
        {

            if(e.LeftButton==MouseButtonState.Pressed && sender is FrameworkElement frameworkElement)
            {
                DragDrop.DoDragDrop(frameworkElement, new DataObject(DataFormats.Serializable, frameworkElement.DataContext), DragDropEffects.Move);
            } 
        }

        private void Node_Drop(object sender, DragEventArgs e)
        {
            NodeViewModel Data = e.Data.GetData(DataFormats.Serializable) as NodeViewModel;
            Canvas canvas = sender as Canvas;

            Point myPoint = e.GetPosition(canvas);

            Data.sampleNode.ChangePos((float)myPoint.X, (float)myPoint.Y);

        }

    }
}
