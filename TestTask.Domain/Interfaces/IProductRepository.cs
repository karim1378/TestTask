using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Domain.Entities;

namespace TestTask.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task AddProductAsync(Product product);

        Task UpdateProductAsync(Product product);

        Task DeleteProductAsync(int id);

        Task<Product> GetProductByIdAsync(int id);

        Task<IEnumerable<Product>> GetAllProductsAsync();

        Task<IEnumerable<Product>> GetProductsByAvailabilityAsync(bool isAvailable);

        Task<Product> GetProductByManufacturerNameAsync(string Name);
    }
}
