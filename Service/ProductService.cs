using ExtraEdgeMobile.Data;
using ExtraEdgeMobile.Model;
using Microsoft.EntityFrameworkCore;

namespace ExtraEdgeMobile.Service
{
    public class ProductService : IProductService
    {
        private readonly MobileStoreDbContext _context;

        public ProductService(MobileStoreDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await _context.Products.FindAsync(productId);
        }

        public async Task AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> UpdateProductAsync(int productId, Product product)
        {
            var existingProduct = await _context.Products.FindAsync(productId);

            if (existingProduct == null)
            {
                return null; // Product not found
            }

            // Update existingProduct properties with values from the input product
            existingProduct.Name = product.Name;
            existingProduct.Brand = product.Brand;
            existingProduct.Price = product.Price;

            await _context.SaveChangesAsync();
            return existingProduct;
        }

        public async Task<Product> DeleteProductAsync(int productId)
        {
            var product = await _context.Products.FindAsync(productId);

            if (product == null)
            {
                return null; // Product not found
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }
    }

}
