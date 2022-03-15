using ETicaretAPI.Application.Abstract;
using ETicaretAPI.Domain.Entities;

namespace ETicaretAPI.Persistence.Concrete
{
    public class ProductServices : IProductService
    {
        public List<Product> GetProducts()
      => new() { 
      new () { ID=Guid.NewGuid(),Name="Product 1,",Price=100,Stock=10  },
      new () { ID=Guid.NewGuid(),Name="Product 2,",Price=200,Stock=20  },
      new () { ID=Guid.NewGuid(),Name="Product 3,",Price=300,Stock=30  },
      new () { ID=Guid.NewGuid(),Name="Product 4,",Price=100,Stock=20  },
      new () { ID=Guid.NewGuid(),Name="Product 5,",Price=500,Stock=15  },
      };
    }
}
