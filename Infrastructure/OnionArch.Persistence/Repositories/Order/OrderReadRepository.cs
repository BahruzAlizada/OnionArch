using OnionArch.Application.Repositories;
using OnionArch.Domain.Entities;
using OnionArch.Persistence.Contexts;

namespace OnionArch.Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(Context context) : base(context)
        {
        }
    }
}
