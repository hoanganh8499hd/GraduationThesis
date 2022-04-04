using AutoMapper;
using GraduationThesis.Application.Interfaces;
using GraduationThesis.Data.Entities;
using GraduationThesis.Data.Infrastructure;
using GraduationThesis.Data.Repository.ProductRepo;
using GraduationThesis.Utilities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Application.Implementation
{
    public class ProductService : IProductService
    {

        private IProductRepository _productRepository;
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public ProductViewModel Add(ProductViewModel productViewModel)
        {
            var product = _mapper.Map<ProductViewModel, Product>(productViewModel);
            _productRepository.Add(product);
            return productViewModel;
        }

        public List<ProductViewModel> GetAllProduct()
        {
            return _mapper.ProjectTo<ProductViewModel>(_productRepository.GetAll().AsQueryable()).ToList();
        }

        public ProductViewModel GetProductById(int id)
        {
            var product = _mapper.Map<Product, ProductViewModel>(_productRepository.GetById(id));
            return product;
        }

        public void Delete(int id)
        {
            var product = _productRepository.GetById(id);
            if (product != null)
            {
                _productRepository.Remove(product);
            }
        }

        public void Update(ProductViewModel productViewModel)
        {
            var product = _mapper.Map<ProductViewModel, Product>(productViewModel);
            _productRepository.Update(product);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
