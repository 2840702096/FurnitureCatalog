using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Application.Services.Categories.Query.GetCategories;
using FurnitureCatalog.Common.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FurnitureCatalog.Application.Services.Categories.Command.AddCategory
{
    public class AddCategoryService : IAddCategoryService
    {
        private IDataBaseContext _context;

        public AddCategoryService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<int> Execute(AddCategoryServiceInputDto input)
        {
            //try
            //{
            if (input.CategoryIdForEdit == null)
            {
                Domain.Entities.Categories.Categories Category = new Domain.Entities.Categories.Categories();

                Category.Name = input.Name;
                Category.ParentId = input.ParentId;

                var Parent = _context.Categories.Find(input.ParentId);

                if (input.ParentId != null)
                {
                    Category.ParentCategory = Parent;
                }

                _context.Categories.Add(Category);

                if (input.ParentId != null)
                {
                    Parent.SubCategories.Add(Category);
                    _context.Categories.Update(Parent);
                }

                _context.SaveChanges();

                return new ResultDto<int>()
                {
                    IsSuccess = true,
                    Message = "افزودن گروه موفقیت آمیز بود",
                    Title = "موفق",
                    Icon = "success",
                    IsEdit = false,
                    Data = 0
                };
            }
            else
            {
                var Parent = _context.Categories.Include(c => c.ParentCategory).SingleOrDefault(c => c.Id == input.CategoryIdForEdit).ParentCategory;
                Domain.Entities.Categories.Categories Category = _context.Categories.Find(input.CategoryIdForEdit);

                Category.Name = input.Name;
                Category.ModifyTime = DateTime.Now;

                _context.Categories.Update(Category);
                _context.SaveChanges();

                if (Parent == null)
                {
                    return new ResultDto<int>()
                    {
                        IsSuccess = true,
                        Message = "ویرایش گروه موفقیت آمیز بود",
                        Title = "موفق",
                        Icon = "success",
                        IsEdit = false,
                        Data = 0
                    };
                }
                else
                {
                    return new ResultDto<int>()
                    {
                        IsSuccess = true,
                        Message = "ویرایش گروه موفقیت آمیز بود",
                        Title = "موفق",
                        Icon = "success",
                        IsEdit = true,
                        Data = Parent.Id
                    };
                }
            }
            //}
            //catch (Exception)
            //{
            //    var Parent = _context.Categories.Include(c => c.ParentCategory).SingleOrDefault(c => c.Id == input.CategoryIdForEdit).ParentCategory;
            //    if (input.CategoryIdForEdit == null)
            //    {
            //        return new ResultDto<int>()
            //        {
            //            IsSuccess = false,
            //            Message = "افزودن گروه با خطا مواجه شد",
            //            Title = "ناموفق",
            //            Icon = "error",
            //            Data = Parent.Id
            //        };
            //    }
            //    else
            //    {
            //        return new ResultDto<int>()
            //        {
            //            IsSuccess = false,
            //            Message = "ویرایش گروه با خطا مواجه شد",
            //            Title = "ناموفق",
            //            Icon = "error",
            //            Data = Parent.Id
            //        };
            //    }
            //}
        }
    }
}
