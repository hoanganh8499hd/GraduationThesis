using GraduationThesis.Data.EF;
using GraduationThesis.Data.Entities;
using GraduationThesis.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Data.Repository.CategoryRepo
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(GraduationThesisDbContext context) : base(context)
        {
        }
    }
}
