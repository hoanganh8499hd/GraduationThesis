using GraduationThesis.Data.Entities;
using GraduationThesis.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Data.Repository.ProductRepo
{
    public interface IProductRepository : IRepository<Product>
    {
        public Product GetProductById(int id);
    }
}
