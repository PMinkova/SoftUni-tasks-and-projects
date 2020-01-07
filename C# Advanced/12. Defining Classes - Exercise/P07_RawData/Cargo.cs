using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        private int weigth;
        private string type;

        public Cargo(int weigth, string type)
        {
            this.Weigth = weigth;
            this.Type = type;
        }

        public int Weigth
        {
            get { return weigth; }
            set { weigth = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
