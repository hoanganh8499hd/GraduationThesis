using AutoMapper;
using GraduationThesis.Application.Interfaces;
using GraduationThesis.Data.Entities;
using GraduationThesis.Data.Infrastructure;
using GraduationThesis.Data.Repository.CategoryRepo;
using GraduationThesis.Utilities.Dtos;
using GraduationThesis.Utilities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Application.Implementation
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public CategoryViewModel Add(CategoryViewModel categoryViewModel)
        {
            var category = _mapper.Map<CategoryViewModel,Category>(categoryViewModel);
            _categoryRepository.Add(category);
            return categoryViewModel;
        }

        public List<CategoryViewModel> GetAllCategory()
        {
             return _mapper.ProjectTo<CategoryViewModel>(_categoryRepository.GetAll().AsQueryable()).ToList();
        }

        public CategoryViewModel GetCategoryById(int id)
        {
            var category = _mapper.Map<Category, CategoryViewModel>(_categoryRepository.GetById(id));
            return category;
        }

        public void Save()
        {
           _unitOfWork.Commit();
        }
    }
}
