using TesteAPIProduct.Context;
using TesteAPIProduct.Domains;
using TesteAPIProduct.Interface;
using TesteAPIProduct.Migrations;

namespace TesteAPIProduct.Repositories
{
    public class ProductRepository : IProductRepository
    {

        public readonly ProductContext _productContext;

        public ProductRepository()
        {
            _productContext = new ProductContext();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetProducts()
        {
            try
            {
                return _productContext.Products.ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Products GetById(Guid id)
        {
            try
            {
                return _productContext.Products.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Post(Products product)
        {
            try
            {

                _productContext.Products.Add(product);

                _productContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Guid id, Products product)
        {
            throw new NotImplementedException();
        }
    }
}
