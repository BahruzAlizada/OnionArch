using OnionArch.Application.Repositories;
using OnionArch.Domain.Entities;
using OnionArch.Persistence.Contexts;

namespace OnionArch.Persistence.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(Context context) : base(context)
        {
        }
    }
}
