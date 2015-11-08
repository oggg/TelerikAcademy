namespace ArticleCollection
{
    using System;

    public class Article : IComparable<Article>
    {
        public int Barcode { get; set; }
        public string Vendor { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(Article other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return string.Format("Article {0} with price {1}", this.Title, this.Price);
        }
    }
}
