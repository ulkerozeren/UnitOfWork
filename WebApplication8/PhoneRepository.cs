using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8
{
    public class PhoneRepository: Repository<Phone>, IPhone
    {
        private readonly XContext _xContext;
        public PhoneRepository(XContext xContext) : base(xContext)
        {
            _xContext = xContext;
        }
    }
}
