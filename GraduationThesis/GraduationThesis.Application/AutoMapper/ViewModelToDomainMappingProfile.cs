using AutoMapper;
using GraduationThesis.Data.Entities;
using GraduationThesis.Utilities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CategoryViewModel, Category>()
               .ConstructUsing(c => new Category(c.id, c.cate_name, c.cate_slug, c.create_at, c.update_at, c.delete_at, c.isActive, c.isDelete, c.parent_id));

            CreateMap<ProductViewModel, Product>()
               .ConstructUsing(
                c => new Product(c.id, c.name, c.code, c.slug, c.brand_id, c.image, c.more_images, c.unit_price, c.promotion_price, c.warranty, c.instock, c.view_count, c.specifications, c.short_desc, c.descriptions, c.featured, c.best_seller, c.isActive, c.isDelete, c.meta_tittle, c.meta_keywords, c.meta_descriptions, c.create_at, c.update_at, c.delete_at)
                );
        }
    }
}
