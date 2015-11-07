namespace LargeCollection
{
    using System;

    internal class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return string.Format("Product {0} has price {1}", this.Name, this.Price);
        }
    }
}