using GraduationThesis.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Application.Interfaces
{
    public interface IProductService
    {
        public List<Product> GetAll();

        Product Add(Product product);

        Product GetById(int id);

        void Save();
    }
}
