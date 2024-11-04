using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Application.Services.Categories.Command.AddCategory;
using FurnitureCatalog.Common.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureCatalog.Application.Services.Categories.Query.GetCategories
{
    public class GetCategoriesService : IGetCategoriesService
    {
        private readonly IDataBaseContext _context;

        public GetCategoriesService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<CategoryDto>> Execute(int pageId, int? parentId)
        {
            try
            {
                int Take = 2;
                int Skip = (pageId - 1) * Take;

                var Categories = _context.Categories
                    .Include(c => c.ParentCategory)
                    .Include(c => c.SubCategories)
                    .Where(c=>c.ParentId == parentId)
                    .OrderByDescending(c => c.InsertTime).Skip(Skip).Take(Take).Select(c => new CategoryDto
                    {
                        Id = c.Id,
                        Name = c.Name,
                        ParentCategory = c.ParentCategory != null ? new ParentCategoryDto
                        {
                            Id = c.ParentCategory.Id,
                            Name = c.ParentCategory.Name
                        }
                        : null,
                        HasChild = c.SubCategories.Count() > 0 ? true : false,
                    }).ToList();

                return new ResultDto<List<CategoryDto>>()
                {
                    IsSuccess = true,
                    Message = "اطلاعات با موفقیت کسب شد",
                    Title = "موفق",
                    Icon = "success",
                    Data = Categories
                };
            }
            catch (Exception)
            {
                return new ResultDto<List<CategoryDto>>()
                {
                    IsSuccess = false,
                    Message = "کسب اطلاعات با خطا مواجه شد",
                    Title = "ناموفق",
                    Icon = "error",
                    Data = null
                };
            }
        }
    }
}
