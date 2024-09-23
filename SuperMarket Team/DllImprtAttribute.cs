using System;

namespace SuperMarket_Team
{
    internal class DllImprtAttribute : Attribute
    {
        private string v;

        public DllImprtAttribute(string v, string EntryPoint)
        {
            this.v = v;
            this.EntryPoint = EntryPoint;
        }

        public string EntryPoint { get; set; }
    }
}