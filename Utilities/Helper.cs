using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphVisual.Models;
using System.Windows.Automation.Peers;

namespace GraphVisual.Utilities
{
    public static class Helper
    {

        public static int id;

        public static int ID
        {
            get
            {
                return id++;
            }

            set
            {
                id = value;
            }
        }

        public static string Connectinon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Desktop\\Repos\\CS_Project\\DataBase\\Database1.mdf;Integrated Security=True";

        public static SqlConnection getConnection()
        {
            SqlConnection Connection = new SqlConnection(Connectinon);
            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }

            return Connection;
        }

      
        public static DataTable getDataGraph(string Querry, int ID)
        {
            DataTable returnTable = new DataTable();
            SqlConnection conn = getConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(Querry, conn);
            adapter.Fill(returnTable);

            conn.Close();

            return returnTable;
        }

        public static void InsertGraph(Graph GRAPH)
        {
            SqlConnection conn= getConnection();
            SqlCommand Command = new SqlCommand();
            Command.Connection = conn;
            Command.CommandText = $"INSERT INTO Graphs VALUES ({GRAPH.ID}, '{GRAPH.Name}')";
            Command.ExecuteNonQuery();

            foreach (var item in GRAPH.Nodes)
            {
                Command.CommandText = $"INSERT INTO Node VALUES ({item.ID}, {item.graph_id}, '{item.Value}', {item.PosX}, {item.PosY})";
                Command.ExecuteNonQuery();
            }

            foreach (var itme in GRAPH.Edges)
            {
                Command.CommandText = $"INSERT INTO Edge VALUES ({itme.FirstNode.graph_id}, {itme.FirstNode.ID}, {itme.SecondNode.ID}, {itme.weight})";
            }
            conn.Close();
        }

        public static void GetFromGraph()
        {
            SqlConnection conn = getConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Graphs";
            DataTable Grafovi = new DataTable();
        }
    }
}
