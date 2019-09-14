using System;

namespace WebApplication8
{
    public interface IUnitOfWork: IDisposable
    {
        IUserRepository UserRepository { get; set; }
        ICategoryRepository CategoryRepository { get; set; }
        IOrderRepository OrderRepository { get; set; }
        IPhone PhoneRepository { get; set; }
        int Complete();
    }
}
