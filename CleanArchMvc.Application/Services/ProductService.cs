using AutoMapper;
using CleanArchMvc.Application.Dtos;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;

namespace CleanArchMvc.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }
    public async Task<ProductDto> GetByIdAsync(int? id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        return _mapper.Map<ProductDto>(product);
    }
    public async Task<IEnumerable<ProductDto>> GetProductsAsync()
    {
        var products = await _productRepository.GetProductsAsync();
        return _mapper.Map<IEnumerable<ProductDto>>(products);
    }
    public async Task AddAsync(ProductDto productDto)
    {
        var product = _mapper.Map<Product>(productDto);
        await _productRepository.CreateAsync(product); 
    }
    public async Task UpdateAsync(ProductDto productDto)
    {
        var product = _mapper.Map<Product>(productDto);
        await _productRepository.UpdateAsync(product);
    }
    public async Task RemoveAsync(int? id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        await _productRepository.RemoveAsync(product);
    }
}
