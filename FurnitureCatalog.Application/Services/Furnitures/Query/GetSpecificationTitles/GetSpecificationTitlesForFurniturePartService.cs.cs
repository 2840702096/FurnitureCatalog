﻿using FurnitureCatalog.Application.Interfaces.Context;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetSpecificationTitles
{
    public class GetSpecificationTitlesForFurniturePartService : IGetSpecificationTitlesForFurniturePartService
    {
        private readonly IDataBaseContext _context;

        public GetSpecificationTitlesForFurniturePartService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<SelectListItem> Execute(int id)
        {
            int CategoryId = _context.Furnitures.Include(f => f.Categories).SingleOrDefault(f => f.Id == id).Categories.ParentId.Value;

            return _context.SpecificationTitles.Where(s=>s.CategoryId == CategoryId).Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.Name
            }).ToList();
        }
    }
}