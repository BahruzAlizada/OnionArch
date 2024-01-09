using OnionArch.Application.Repositories;
using OnionArch.Domain.Entities;
using OnionArch.Persistence.Contexts;

namespace OnionArch.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(Context context) : base(context)
        {
        }
    }
}
