using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Application.Services.Categories.Query.GetSpecificationTitles;
using FurnitureCatalog.Domain.Entities.Categories;
using System;

namespace FurnitureCatalog.Application.Services.Categories.Command.AddDescriptionTitle
{
    public class AddDescriptionTitleService : IAddDescriptionTitleService
    {
        private IDataBaseContext _context;

        public AddDescriptionTitleService(IDataBaseContext context)
        {
            _context = context;
        }

        public void Execute(SpecificationTitlesDto input)
        {
            try
            {
                DescriptionTitle Title = new DescriptionTitle();
                Title.Name = input.Name;
                Title.CategoryId = input.CategoryId;
                Title.Category = GetCategory(input.CategoryId);

                _context.DescriptionTitles.Add(Title);
                _context.SaveChanges();
            }
            catch (Exception)
            {

            }
        }

        Domain.Entities.Categories.Categories GetCategory(int id)
        {
            return _context.Categories.Find(id);
        }
    }
}
