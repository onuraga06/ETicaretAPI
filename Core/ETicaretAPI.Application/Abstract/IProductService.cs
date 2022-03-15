using ETicaretAPI.Domain.Entities;

namespace ETicaretAPI.Application.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
