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
            try
            {
                Products findProduct = _productContext.Products.Find(id)!;

                if (findProduct != null)
                {
                    _productContext.Products.Remove(findProduct);
                }
            }
            catch (Exception)
            {

                throw;
            }
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
            try
            {
                Products findProduct = _productContext.Products.Find(id);

                if (findProduct != null)
                {
                    findProduct.Name = product.Name;
                    findProduct.Price = product.Price;
                }

                _productContext.Products.Update(findProduct!);

                _productContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
