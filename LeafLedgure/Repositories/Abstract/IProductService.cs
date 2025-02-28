using LeafLedgure.Models.Domain;

namespace LeafLedgure.Repositories.Abstract
{
    public interface IProductService
    {
        bool Add(Product model);
        bool Update(Product model);
        bool Delete(int id);
        Product FindById(int id);
        IEnumerable<Product> GetAll();
    }
}
