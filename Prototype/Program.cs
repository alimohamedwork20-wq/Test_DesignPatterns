namespace Prototype
{
    class Program
    {
        public static void Main(string[] strings)
        {
            var product1 = new Product
            {
                Name = "redmi note 12",
                Price = 7000
            };
            var product2 = (Product)product1.Clone();
            product2.Price = 12000;
            product2.Name = "redmi note 14 pro";
            Console.WriteLine(product1.Name);
            Console.WriteLine(product2.Name);
        }
    }
}