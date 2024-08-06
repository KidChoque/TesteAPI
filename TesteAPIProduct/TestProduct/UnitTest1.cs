using Moq;
using TesteAPIProduct.Domains;
using TesteAPIProduct.Interface;

namespace testApi
{
    public class ProductsTest
    {
        //Indica que o metodo e de teste de unidade
        [Fact]
        public void Get()
        {
            //Arranger : Organizar

            var products = new List<Products>
            {
                new Products {IdProduct = Guid.NewGuid() , Name = "Produto 1", Price= 10},
                new Products {IdProduct = Guid.NewGuid() , Name = "Produto 2", Price= 15},
                new Products {IdProduct = Guid.NewGuid() , Name = "Produto 3", Price= 20},
                new Products {IdProduct = Guid.NewGuid() , Name = "Produto 3", Price= 20},
            };

            //Cria um obj de simulacao do tipo IProductRepository
            var mockRepository = new Mock<IProductRepository>();

            //Configura o metodo Get para retornar a lista de produtos "mock"
            mockRepository.Setup(x => x.GetProducts()).Returns(products);

            //Act : Agir

            //Ele chama o metodo Get() e armazena o resultado em result
            var result = mockRepository.Object.GetProducts();

            //Assert : Provar

            //Prova se o resultado esperado e igual ao resultado obtido atraves da busca
            Assert.Equal(4, result.Count);
        }

      
    }
}