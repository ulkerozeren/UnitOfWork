using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly XContext _xContext;
        public UserRepository(XContext xContext) :base(xContext)
        {
            _xContext = xContext;
        }

        public IEnumerable<User> GetBirthdayPeople()
        {
           return _xContext.Users.Where(x=>x.Id==3);
        }
    }
}
