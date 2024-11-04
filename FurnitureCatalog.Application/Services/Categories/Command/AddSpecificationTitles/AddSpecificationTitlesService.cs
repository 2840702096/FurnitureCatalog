using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Application.Services.Categories.Query.GetSpecificationTitles;
using FurnitureCatalog.Domain.Entities.Categories;
using System;

namespace FurnitureCatalog.Application.Services.Categories.Command.AddSpecificationTitles
{
    public class AddSpecificationTitlesService : IAddSpecificationTitlesService
    {
        private IDataBaseContext _context;

        public AddSpecificationTitlesService(IDataBaseContext context)
        {
            _context = context;
        }

        public void Execute(SpecificationTitlesDto input)
        {
            try
            {
                SpecificationTitles Title = new SpecificationTitles();
                Title.Name = input.Name;
                Title.CategoryId = input.CategoryId;
                Title.Categories = GetCategory(input.CategoryId);

                _context.SpecificationTitles.Add(Title);
                _context.SaveChanges();
            }
            catch(Exception)
            {

            }
        }

        Domain.Entities.Categories.Categories GetCategory(int id)
        {
            return _context.Categories.Find(id);
        }
    }
}
