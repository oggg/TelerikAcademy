using System;

namespace Chef
{
    public abstract class Vegetables
    {
        public Vegetables()
        {
            this.IsPeeled = false;
            this.IsCut = false;
        }

        public bool IsPeeled { get; set; }
        public bool IsCut { get; set; }

        public void Cut()
        {
            this.IsCut = true;
        }

        public void Peel()
        {
            this.IsPeeled = true;
        }
    }
}
