namespace WebApiDemo.Model
{
    public class ProductService
    {
        public static List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Mazda"},
            new Product { Id = 2, Name = "Honda city"},
            new Product { Id = 3, Name = "Kia morning"}
        }; //database

        public List<Product> GetProductsFromDatabase()
        {
            return Products;
        }

        public Product? GetProductById(int id)
        {
            return Products.FirstOrDefault(x => x.Id == id);
        }

        public int AddProduct(AddProductModel product)
        {
            try
            {
                var newProduct = new Product();
                newProduct.Id = product.ProductId;
                newProduct.Name = product.Name;
                Products.Add(newProduct);
                return newProduct.Id;
            }
            catch (Exception e)
            {
                //Write log to track the error
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public int UpdateProduct(int id, UpdateProductModel updateProduct)
        {
            try
            {
                Product? product = Products[id];
                if (product == null)
                    return -1;
                product.Name = updateProduct.Name;
                return product.Id;
            }
            catch (Exception e)
            {
                //Write log to track the error
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public int DeleteProduct(int id)
        {
            try
            {
                Product? product = Products[id];
                if (product == null)
                    return -1;
                Products.Remove(product);
                return product.Id;
            }
            catch (Exception e)
            {
                //Write log to track the error
                Console.WriteLine(e.Message);
                return -1;
            }
        }

    }
}
