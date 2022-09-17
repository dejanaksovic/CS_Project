using GraphVisual.Models;
using GraphVisual.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GraphVisual.Commands
{
    public class AddEdgeCommand : CommandBase
    {
        Graph _graph { get; }
        GraphControlViewModel _graphControlViewModel { get; }

        public AddEdgeCommand(GraphControlViewModel graphControlViewModel, Graph GRAPH)
        {
            _graph = GRAPH;
            _graphControlViewModel = graphControlViewModel;
        }

        public override void Execute(object? parameter)
        {
            //Lakse koriscenje try-parse-a umesto da prebacujem promenljivu samu u sebi (Citljivost za koji bajt memorije vise)
            int id_first=new int();
            int id_second=new int();
            int weight = new int();

            //Test za proveru id i vrednost (da su brojevi)
            if (!(int.TryParse(_graphControlViewModel.Id_First, out id_first) && int.TryParse(_graphControlViewModel.Id_Second, out id_second) && int.TryParse(_graphControlViewModel.EdgeValue, out weight)))
            {
                MessageBox.Show("Please enter integer formats for ids");
                return;
            }

            //Mora var jer Linq(Where) uvek vraca ICollection valjda (neki interfejs :D ) i kasnije stavljamo prve clanove u node (jer prvi i samo postoje)
            var TempFirst = _graph.Nodes.Where(item => item.ID == id_first);
            var TempSecond = _graph.Nodes.Where(item => item.ID == id_second);

            //Catch ovde esencijalno sluzi samo za hvatanja id-eva koji ne postoje (proverava da li su tempFirst i tempSecond null)
            //Moglo je kroz if-el ali hteo sam da iskoristim ovo kad smo vec naucili
            try
            {
                Node a = TempFirst.First();
                Node b = TempSecond.First();
                _graph.AddEdge(a, b, weight);
                
            }

            catch (Exception)
            {
                System.Windows.MessageBox.Show("One or both nodes with that id do not exist");
            }

            //Alternativa svim proverama--> Uraditi samo try catch i napisati nesto je poslo naopako, medjutim smanjena mogucnost debugovanja i razumevanja koristinka
            //gde je pogresio
        }
    }
}
