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
        public delegate void IChangedHandlr();

        public event ClickedHandler Clicked;
        public event IChangedHandlr IChanged;

        private string value;
        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public float PosX { get; set; }
        public float PosY { get; set; }

        public int ID { get; }

        public Node(int ID, string VALUE, float POSX, float POSY)
        {
            this.ID = ID;
            Value = VALUE;

            PosX = POSX;
            PosY = POSY;
        }

        void ChangeNodeValue(string VALUE)
        {
            Value = VALUE;
            OnIChanged();
        }

        public void HandleChange(int ID, string VALUE)
        {
            if (this.ID == ID)
                ChangeNodeValue(VALUE);
        }

        public void OnClick()
        {
            Clicked?.Invoke(this);
        }

        public void ChangePos(float X, float Y)
        {
            PosX = X;
            PosY = Y;
            OnIChanged();
        }

        public void OnIChanged()
        {
            IChanged?.Invoke();
        }

        public static bool operator ==(Node first, Node second){
            if (first.ID == second.ID)
                return true;

            return false;
        }

        public static bool operator !=(Node first, Node second)
        {
            return !(first == second);
        }
    }
}
