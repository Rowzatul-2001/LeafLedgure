using LeafLedgure.Data;
using LeafLedgure.Models.Domain;
using LeafLedgure.Repositories.Abstract;

namespace LeafLedgure.Repositories.Implementation
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext context;
        public ProductService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Add(Product model)
        {
            try
            {
                context.Products.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = this.FindById(id);
                if (data == null)
                    return false;
                context.Products.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Product FindById(int id)
        {
            return context.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            var data = (from product in context.Products
                        join author in context.Authors
                      on product.AuthorId equals author.Id
                        join publisher in context.Publishers on product.PublisherId equals publisher.Id
                        join genre in context.Genres on product.GenreId equals genre.Id
                        select new Product
                        {
                            Id = product.Id,
                            AuthorId = product.AuthorId,
                            GenreId = product.GenreId,
                            Isbn = product.Isbn,
                            PublisherId = product.PublisherId,
                            Title = product.Title,
                            TotalPages=product.TotalPages,
                            GenreName=genre.GenreName,
                            AuthorName=author.AuthorName,
                            PublisherName=publisher.PublisherName
                        }).ToList();
            return data;
        }

        public bool Update(Product model)
        {
            try
            {
                context.Products.Update(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
