using ExtraEdgeMobile.Model;

namespace ExtraEdgeMobile.Service
{
    public interface IProductService
    {
        public interface IProductService
        {
            Task<IEnumerable<Product>> GetAllProductsAsync();
            Task<Product> GetProductByIdAsync(int productId);
            Task AddProductAsync(Product product);
            Task<Product> UpdateProductAsync(int productId, Product product);
            Task<Product> DeleteProductAsync(int productId);
        }

    }
}
