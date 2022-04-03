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
               .ConstructUsing(c => new Category(c.cate_name, c.cate_slug, c.create_at, c.update_at, c.delete_at, c.isActive, c.isDelete, c.parent_id));
        }
    }
}
