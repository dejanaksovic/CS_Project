using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisual.Models
{
    public class Node
    {
        public delegate void ClickedHandler(Node sender);
        public event ClickedHandler Clicked;

        private string value;
        public string Value
        {
            get { return value; }
            set { Value = value; }
        }

        public float PosX { get; set; }
        public float PosY { get; set; }

        public int ID { get; }

        public Node(int ID, string VALUE, float POSX, float POSY)
        {
            this.ID = ID;
            value = VALUE;

            PosX = POSX;
            PosY = POSY;
        }

        void ChangeNodeValue(string VALUE)
        {
            Value = VALUE;
        }

        public void HandleChange(int ID, string VALUE)
        {
            if(this.ID == ID) 
            ChangeNodeValue(VALUE);
        }

        public void OnClick()
        {
            Clicked?.Invoke(this);
        }

    }
}
