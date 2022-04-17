namespace WebApiDemo.Model
{
    public static class ProductService
    {
        //public static List<Product> Products = new List<Product>
        //{
        //    new Product { Id = 1, Name = "Mazda"},
        //    new Product { Id = 1, Name = "Honda city"},
        //    new Product { Id = 1, Name = "Kia morning"}
        //}; //database

        public static List<Product> GetProductsFromDatabase()
        {
            return new List<Product>
                {
                    new Product { Id = 1, Name = "Mazda"},
                    new Product { Id = 1, Name = "Honda city"},
                    new Product { Id = 1, Name = "Kia morning"}
                }; //database
        }
    }
}
