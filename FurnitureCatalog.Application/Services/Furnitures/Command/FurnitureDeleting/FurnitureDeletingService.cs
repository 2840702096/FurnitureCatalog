using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Common.DTOs;
using System;

namespace FurnitureCatalog.Application.Services.Furnitures.Command.FurnitureDeleting
{
    public class FurnitureDeletingService : IFurnitureDeletingService
    {
        private readonly IDataBaseContext _context;

        public FurnitureDeletingService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(int id)
        {
            try
            {
                var Furniture = _context.Furnitures.Find(id);
                Furniture.DeleteTime = DateTime.Now;
                Furniture.IsDeleted = true;

                _context.Furnitures.Update(Furniture);
                _context.SaveChanges();

                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "حذف موفقیت آمیز بود",
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
