using CleanArchMvc.Domain.Entities;

namespace CleanArchMvc.Domain.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetProductsAsync();
    Task<Product> GetByIdAsync(int? id);
    Task<IEnumerable<Product>> GetProductsCategoryAsync(int? id);
    Task CreateAsync(Product product);
    Task UpdateAsync(Product product);
    Task RemoveAsync(Product product);
}
