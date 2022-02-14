using Moq;
using NetCoreUnitTest.Web.Controllers;
using NetCoreUnitTest.Web.Models;
using NetCoreUnitTest.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreUnitTest.Test
{   
    public class ProductsControllerTest
    {
        private readonly Mock<IRepository<Product>> _mockRepo;
        private readonly ProductsController _controller;

        private List<Product> products;

        public ProductsControllerTest()
        {
            _mockRepo = new Mock<IRepository<Product>>();
            _controller = new ProductsController(_mockRepo.Object);

            products = new List<Product>() {
                new Product { Id = 1, Name="Pencil", Price=100, Stock=50, Color="Red" },
                new Product { Id = 2, Name="Easer", Price=25, Stock=60, Color="Yellow" }
            };
        }



    }
}
