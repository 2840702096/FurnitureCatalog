using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Common.DTOs;
using System;

namespace FurnitureCatalog.Application.Services.Furnitures.Command.FurnitureActivation
{
    public class FurnitureActivationService : IFurnitureActivationService
    {
        private readonly IDataBaseContext _context;

        public FurnitureActivationService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(int id)
        {
            try
            {
                var Furniture = _context.Furnitures.Find(id);
                Furniture.IsActive = !Furniture.IsActive;

                string Message = (Furniture.IsActive) ? "فعال" : "غیرفعال";

                _context.Furnitures.Update(Furniture);
                _context.SaveChanges();

                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = $"{Message} سازی موفقیت آمیز بود",
                    Title = "موفق",
                    Icon = "success"
                };
            }
            catch (Exception)
            {
                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "فعال سازی ناموفق بود",
                    Title = "ناموفق",
                    Icon = "error"
                };
            }
        }
    }
}
