using System;
using System.Collections.Generic;

namespace Chef
{
    public class Bowl
    {
        public Bowl()
        {
            this.Vegetables = new List<Vegetables>();
        }

        public List<Vegetables> Vegetables { get; set; }

        public void Add(Vegetables vegetable)
        {
            this.Vegetables.Add(vegetable);
        }
    }
}
