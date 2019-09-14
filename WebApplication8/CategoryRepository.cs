using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8
{
    public class CategoryRepository: Repository<Category>, ICategoryRepository
    {
        private readonly XContext _xContext;
        public CategoryRepository(XContext xContext):base(xContext)
        {
            _xContext = xContext;
        }
    }
}
