using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly XContext _xContext;
        public UnitOfWork(XContext xContext)
        {
            _xContext = xContext;
            UserRepository = new UserRepository(xContext);
            CategoryRepository = new CategoryRepository(xContext);
            OrderRepository = new OrderRepository(xContext);
            PhoneRepository = new PhoneRepository(xContext);
        }
        public IUserRepository UserRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICategoryRepository CategoryRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IOrderRepository OrderRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPhone PhoneRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Complete()
        {
            return _xContext.SaveChanges();
        }

        public void Dispose()
        {
            _xContext.Dispose();
        }
    }
}
