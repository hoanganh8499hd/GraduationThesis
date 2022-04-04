using GraduationThesis.Data.EF;
using GraduationThesis.Data.Entities;
using GraduationThesis.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Data.Repository.ProductRepo
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(GraduationThesisDbContext context) : base(context)
        {
        }
    }
}
