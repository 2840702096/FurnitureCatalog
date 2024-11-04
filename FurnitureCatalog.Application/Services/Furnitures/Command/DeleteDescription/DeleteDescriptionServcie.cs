using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Common.DTOs;
using System;

namespace FurnitureCatalog.Application.Services.Furnitures.Command.DeleteDescription
{
    public class DeleteDescriptionServcie : IDeleteDescriptionServcie
    {
        private readonly IDataBaseContext _context;

        public DeleteDescriptionServcie(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(int id)
        {
            try
            {
                var Description = _context.FurnitureDescriptions.Find(id);
                Description.IsDeleted = true;
                Description.DeleteTime = DateTime.Now;

                _context.FurnitureDescriptions.Update(Description);
                _context.SaveChanges();

                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "حذف موفقیت آمیز شد",
                    Title = "موفق",
                    Icon = "success"
                };
            }
            catch (Exception)
            {
                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "حذف با خطا مواجه شد",
                    Title = "ناموفق",
                    Icon = "error"
                };
            }

        }
    }
}
