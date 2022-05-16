using ProjetoDDD.Application.Interfaces;
using ProjetoDDD.Domain.Interfaces.ProductsInterfaces;
using ProjetoDDD.Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoDDD.Application.OpenApp
{
    public class ProductApp : IProductApp
    {
        IProduct _IProduct;

        public ProductApp(IProduct IProduct)
        {
            _IProduct = IProduct;
        }

        public async Task Add(Product Objeto)
        {
            await _IProduct.Add(Objeto);
        }

        public async Task Delete(Product Objeto)
        {
            await _IProduct.Delete(Objeto);
        }

        public async Task<Product> GetEntityById(int Id)
        {
           return await _IProduct.GetEntityById(Id);
        }

        public async Task<List<Product>> List()
        {
            return await _IProduct.List();
        }

        public async Task Update(Product Objeto)
        {
            await _IProduct.Update(Objeto);
        }
    }
}
