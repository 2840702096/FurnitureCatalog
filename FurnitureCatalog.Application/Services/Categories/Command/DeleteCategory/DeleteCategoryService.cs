using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Common.DTOs;
using System;

namespace FurnitureCatalog.Application.Services.Categories.Command.DeleteCategory
{
    public class DeleteCategoryService : IDeleteCategoryService
    {
        private IDataBaseContext _context;

        public DeleteCategoryService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<int> Execute(int id)
        {
            try
            {
                var Category = _context.Categories.Find(id);

                Category.IsDeleted = true;
                Category.DeleteTime = DateTime.Now;

                _context.Categories.Update(Category);
                _context.SaveChanges();

                if (Category.ParentId == null)
                {
                    return new ResultDto<int>()
                    {
                        IsSuccess = true,
                        Message = "گروه با موفقیت حذف شد",
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
                        Message = "گروه با موفقیت حذف شد",
                        Title = "موفق",
                        Icon = "success",
                        IsEdit = true,
                        Data = Category.ParentId.Value
                    };
                }
            }
            catch (Exception)
            {
                return new ResultDto<int>()
                {
                    IsSuccess = false,
                    Message = "حذف گروه با خطا مواجه شد",
                    Title = "ناموفق",
                    Icon = "error",
                    Data = 0
                };
            }
        }
    }
}
