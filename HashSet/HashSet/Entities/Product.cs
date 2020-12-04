

namespace HashSets.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Preco { get; set; }
        
        public Product(string name, double preco)
        {
            Name = name;
            Preco = preco;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Preco.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product))
            {
                return false;
            }
            Product other = obj as Product;
            return Name.Equals(other.Name) && Preco.Equals(other.Preco);
        }
    }
}
