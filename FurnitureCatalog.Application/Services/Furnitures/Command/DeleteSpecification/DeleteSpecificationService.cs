using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Common.DTOs;
using System;

namespace FurnitureCatalog.Application.Services.Furnitures.Command.DeleteSpecification
{
    public class DeleteSpecificationService : IDeleteSpecificationService
    {
        private readonly IDataBaseContext _context;

        public DeleteSpecificationService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(int id)
        {
            try
            {
                var Specification = _context.Specifications.Find(id);
                Specification.IsDeleted = true;
                Specification.DeleteTime = DateTime.Now;

                _context.Specifications.Update(Specification);
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
