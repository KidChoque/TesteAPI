using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAPIProduct.Domains;

namespace TestProduct
{
    public class DeleteTest
    {
        [Fact]

        public void Delete()
        {

           //Arranje
             var productDelete = new Products { IdProduct = Guid.NewGuid(),Name="Copao de Cerveja",Price=75 };

             var productList = new List<Products>();
            
            var mock

            //Act


            //Assert
        }
    }
}
