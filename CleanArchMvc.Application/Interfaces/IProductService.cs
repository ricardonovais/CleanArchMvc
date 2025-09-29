using AutoMapper;
using CleanArchMvc.Application.Dtos;
using CleanArchMvc.Domain.Interfaces;

namespace CleanArchMvc.Application.Interfaces;

public interface IProductService
{
    Task<IEnumerable<ProductDto>> GetProductsAsync();
    Task<ProductDto> GetByIdAsync(int? id);
    Task AddAsync(ProductDto productDto);
    Task UpdateAsync(ProductDto productDto);
    Task RemoveAsync(int? id);
}