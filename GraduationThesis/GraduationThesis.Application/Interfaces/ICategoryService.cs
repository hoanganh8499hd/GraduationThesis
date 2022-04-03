using GraduationThesis.Utilities.Dtos;
using GraduationThesis.Utilities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Application.Interfaces
{
    public interface ICategoryService
    {
        public List<CategoryViewModel> GetAllCategory();

        CategoryViewModel Add(CategoryViewModel categoryViewModel);

        CategoryViewModel GetCategoryById(int id);

        void Save();
    }
}
