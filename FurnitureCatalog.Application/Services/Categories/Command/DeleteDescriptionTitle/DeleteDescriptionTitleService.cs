using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Common.DTOs;
using System;
using System.Linq;

namespace FurnitureCatalog.Application.Services.Categories.Command.DeleteDescriptionTitle
{
    public class DeleteDescriptionTitleService : IDeleteDescriptionTitleService
    {
        private IDataBaseContext _context;

        public DeleteDescriptionTitleService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(int id)
        {
            try
            {
                if (_context.FurnitureDescriptions.Any(s => s.TitleId == id))
                {
                    return new ResultDto()
                    {
                        IsSuccess = false,
                        Message = "به دلیل مقداردهی شدن این عنوان در قسمت توضیحات مبلمان، عملیات حذف امکانپذیر نمی باشد",
                        Title = "ناموفق",
                        Icon = "error"
                    };
                }

                var Title = _context.DescriptionTitles.Find(id);

                Title.IsDeleted = true;
                Title.DeleteTime = DateTime.Now;

                _context.DescriptionTitles.Update(Title);
                _context.SaveChanges();

                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "عنوان با موفقیت حذف شد",
                    Title = "موفق",
                    Icon = "success"
                };
            }
            catch (Exception)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "حذف عنوان با خطا مواجه شد",
                    Title = "ناموفق",
                    Icon = "error"
                };
            }
        }
    }
}
