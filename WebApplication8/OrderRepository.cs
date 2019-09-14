using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8
{
    public class OrderRepository: Repository<Order>, IOrderRepository
    {
        private readonly XContext _xContext;
        public OrderRepository(XContext xContext):base(xContext)
        {
            _xContext = xContext;
        }
    }
}
