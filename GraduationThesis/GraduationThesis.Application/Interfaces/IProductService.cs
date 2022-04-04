using GraduationThesis.Data.Entities;
using GraduationThesis.Utilities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Application.Interfaces
{
    public interface IProductService
    {
        public List<ProductViewModel> GetAllProduct();

        ProductViewModel Add(ProductViewModel productViewModel);

        ProductViewModel GetProductById(int id);

        void Delete(int id);

        void Update(ProductViewModel productViewModel);

        void Save();
    }
}
