using ProjetoDDD.Domain.Interfaces.ProductsInterfaces;
using ProjetoDDD.Entities.Entities;
using ProjetoDDD.Infra.Repository.Generics;

namespace ProjetoDDD.Infra.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProduct
    {
    }
}
