using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8
{
    public interface IUserRepository: IRepository<User>
    {
        IEnumerable<User> GetBirthdayPeople();
    }
}
