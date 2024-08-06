using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAPIProduct.Domains;
using TesteAPIProduct.Interface;

namespace TestProduct
{
    public class PostTest
    {
        [Fact]
        public void Post()
        {
            //Arranje
            var productAdd = new Products { IdProduct = Guid.NewGuid(),Name=  "Dualshock4",Price = 250 };

            var productList = new List<Products>();

            var mockRepository = new Mock<IProductRepository>();

            mockRepository.Setup(x => x.Post(productAdd)).Callback<Products>(x => productList.Add(productAdd));
            //Act
            mockRepository.Object.Post(productAdd);

            //Assert
            Assert.Contains(productAdd, productList);

        }
    }
}
