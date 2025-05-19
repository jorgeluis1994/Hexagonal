 using Inventario.Service.Domain.Models;
namespace Inventario.Service.Domain.Interfaces
{
    /// <summary>
    /// Interface for Product Repository
    /// </summary>
    /// <remarks>
    /// This interface defines the contract for the Product repository, which includes methods for CRUD operations.
    /// </remarks>
    public interface IProductRepository
    {
         IEnumerable<Product> GetAll();
         Product GetById(int id);
         void Add(Product product);
         void Update(Product product);
         void Delete(int id);
    }
}