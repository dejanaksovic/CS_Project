using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphVisual.Models;
using System.Windows.Automation.Peers;
using System.Linq.Expressions;
using System.Windows;
using GraphVisual.Commands;

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

        public static string ReturnGraphRepresent()
        {
            SqlConnection conn = getConnection();
            DataTable dt = new DataTable();
            DataRow[] dr;
            string toRetString ="";

            SqlCommand command = conn.CreateCommand();

            command.CommandText = "SELECT * FROM Graphs";

            SqlDataAdapter a = new SqlDataAdapter(command);

            a.Fill(dt);
            dr = dt.Select();

            
            for(int i=0; i < dt.Rows.Count; i++)
            {
                toRetString+= dr[i]["Id"].ToString() + " : " + dr[i]["Name"].ToString() + "\n";
            }

            conn.Close();
            return toRetString;

        }

        public static void DeleteGraph(int ID)
        {
            SqlConnection conn = getConnection();

            SqlCommand command = conn.CreateCommand();

            command.CommandText = $"DELETE FROM Graphs WHERE Id={ID}";
            command.ExecuteNonQuery();

            command.CommandText = $"DELETE FROM Node WHERE Id_graph={ID}";
            command.ExecuteNonQuery();

            command.CommandText = $"DELETE FROM Edge WHERE Id_graph = {ID}";

            conn.Close();
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
                DeleteGraph(GRAPH.ID);

                SqlConnection conn = getConnection();
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
                Command.ExecuteNonQuery();
                }
  
                conn.Close();
        }

        public static int GetIdFromGraph()
        {
            DataTable dt= new DataTable();

            SqlConnection conn = getConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = $"SELECT * FROM Graphs";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt); 
            DataRow[] a= dt.Select();
            int ids = 1000;

            if (dt.Rows.Count == 0)
            {
                ids = 0;
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string c = a[i]["Id"].ToString();
                    int.TryParse(c, out ids);
                }
            }

            conn.Close();

            return ids+1;
        }

        public static Graph SelectGraph(int ID)
        {
            Graph retGraph;

            DataTable dtGrap = new DataTable();
            DataTable dtNodes = new DataTable();
            DataTable dtEdges = new DataTable();

            DataRow[] GraphRow;
            DataRow[] NodeRows;
            DataRow[] EdgeRows;

            SqlConnection con = getConnection();
            SqlCommand command = con.CreateCommand();

            command.CommandText = $"SELECT * FROM Graphs WHERE Id = {ID}";
            SqlDataAdapter adapte = new SqlDataAdapter(command);

            adapte.Fill(dtGrap);

            command.CommandText = $"SELECT * FROM Node WHERE Id_graph = {ID}";
            adapte.Fill(dtNodes);

            command.CommandText = $"SELECT * FROM Edge WHERE Id_graph = {ID}";
            adapte.Fill(dtEdges);

            GraphRow = dtGrap.Select();

            NodeRows = dtNodes.Select();

            EdgeRows = dtEdges.Select();

            retGraph = new Graph(GraphRow[0]["Name"].ToString(), int.Parse(GraphRow[0]["Id"].ToString()));

            for(int i= 0; i < dtNodes.Rows.Count; i++)
            {
                retGraph.AddNode(NodeRows[i]["Value"].ToString(), int.Parse(NodeRows[i]["PosX"].ToString()), int.Parse(NodeRows[i]["PosY"].ToString()));
            }

            for(int i=0; i < dtEdges.Rows.Count; i++)
            {
                int idFirst = int.Parse(EdgeRows[i]["Id_first"].ToString());
                int idSecond = int.Parse(EdgeRows[i]["Id_second"].ToString());
                int Weight = int.Parse(EdgeRows[i]["Weight"].ToString());

                Node FirstNode = retGraph.Nodes.Where(node=> node.ID == idFirst).First();
                Node Second = retGraph.Nodes.Where(node => node.ID == idSecond).First();

                retGraph.AddEdge(FirstNode, Second, Weight);
            }

            con.Close();

            return retGraph;
        }
    }
}
