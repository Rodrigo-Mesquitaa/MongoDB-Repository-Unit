using GenericRepository.Interfaces;
using GenericRepository.Model;

namespace GenericRepository.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IMongoContext context) : base(context)
        {
        }
    }
}

