using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Common.DTOs;
using FurnitureCatalog.Domain.Entities.Categories;
using FurnitureCatalog.Domain.Entities.Furniture;
using System;

namespace FurnitureCatalog.Application.Services.Furnitures.Command.AddSpecification
{
    public class AddSpecificationService : IAddSpecificationService
    {
        private readonly IDataBaseContext _context;

        public AddSpecificationService(IDataBaseContext context)
        {
            _context = context;
        }

        public void Execute(AddSpecificationServiceInputDto input)
        {
            try
            {
                Specifications NewSpecification = new Specifications();

                NewSpecification.Value = input.Value;
                NewSpecification.STitleId = input.STitleId;
                NewSpecification.FurnitureId = input.FurnitureId;
                NewSpecification.Furnitures = GetFurniture(input.FurnitureId);
                NewSpecification.SpecificationTitles = GetSpecificationTitle(input.STitleId);

                _context.Specifications.Add(NewSpecification);
                _context.SaveChanges();
            }
            catch (Exception)
            {
            }
        }
        private Domain.Entities.Furniture.Furnitures GetFurniture(int id)
        {
            return _context.Furnitures.Find(id);
        }

        private SpecificationTitles GetSpecificationTitle(int id)
        {
            return _context.SpecificationTitles.Find(id);
        }
    }
}
