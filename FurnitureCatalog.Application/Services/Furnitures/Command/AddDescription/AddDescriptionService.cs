using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Application.Services.Furnitures.Command.AddSpecification;
using FurnitureCatalog.Domain.Entities.Categories;
using FurnitureCatalog.Domain.Entities.Furniture;
using System;

namespace FurnitureCatalog.Application.Services.Furnitures.Command.AddDescription
{
    public class AddDescriptionService : IAddDescriptionService
    {
        private readonly IDataBaseContext _context;

        public AddDescriptionService(IDataBaseContext context)
        {
            _context = context;
        }

        public void Execute(AddSpecificationServiceInputDto input)
        {
            try
            {
                FurnitureDescription NewDescription = new FurnitureDescription();

                NewDescription.Value = input.Value;
                NewDescription.TitleId = input.STitleId;
                NewDescription.FurnitureId = input.FurnitureId;
                NewDescription.Furniture = GetFurniture(input.FurnitureId);
                NewDescription.Title = GeDescriptionTitle(input.STitleId);

                _context.FurnitureDescriptions.Add(NewDescription);
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

        private DescriptionTitle GeDescriptionTitle(int id)
        {
            return _context.DescriptionTitles.Find(id);
        }
    }
}
