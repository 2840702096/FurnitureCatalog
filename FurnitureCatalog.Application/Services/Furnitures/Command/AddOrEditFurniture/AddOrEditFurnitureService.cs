using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Common;
using FurnitureCatalog.Common.DTOs;
using Microsoft.AspNetCore.Hosting;
using System;

namespace FurnitureCatalog.Application.Services.Furnitures.Command.AddOrEditFurniture
{
    public class AddOrEditFurnitureService : IAddOrEditFurnitureService
    {
        private readonly IDataBaseContext _context;
        private readonly IWebHostEnvironment _en;

        public AddOrEditFurnitureService(IDataBaseContext context, IWebHostEnvironment en)
        {
            _context = context;
            _en = en;
        }

        public ResultDto Execute(AddOrEditFurnitureServiceInputDto input)
        {
            try
            {
                if (input.EditId == null)
                {
                    if(input.Image == null)
                    {
                        return new ResultDto()
                        {
                            IsSuccess = false,
                            Message = "لطفا عکس مورد نظر را انتخاب کنید",
                            Title = "هشدار",
                            Icon = "info"
                        };
                    }

                    Domain.Entities.Furniture.Furnitures Furniture = new Domain.Entities.Furniture.Furnitures();

                    Furniture.Name = input.Name;
                    Furniture.CategoryId = input.CategoryId;
                    Furniture.IsActive = false;

                    string ImagePath = "\\Admin\\images\\FurnitureImages\\";

                    string ThumbPath = "\\Admin\\images\\FurnitureThumbnail\\";

                    ImageHelper I = new ImageHelper(_en);

                    Furniture.Image = I.AddImage(input.Image, ImagePath, ThumbPath);

                    Furniture.Categories = ReturnCategory(input.CategoryId);

                    _context.Furnitures.Add(Furniture);
                    _context.SaveChanges();

                    return new ResultDto()
                    {
                        IsSuccess = true,
                        Message = "عملیات موفقیت آمیز بود",
                        Title = "موفق",
                        Icon = "success"
                    };

                }
                else
                {
                    var Furniture = _context.Furnitures.Find(input.EditId);
                    Furniture.ModifyTime = DateTime.Now;
                    Furniture.Name = input.Name;
                    Furniture.CategoryId = input.CategoryId;

                    string ImagePath = "\\Admin\\images\\FurnitureImages\\";

                    string ThumbPath = "\\Admin\\images\\FurnitureThumbnail\\";

                    ImageHelper I = new ImageHelper(_en);

                    Furniture.Image = I.EditImage(input.Image,Furniture.Image ,ImagePath, ThumbPath);

                    Furniture.Categories = ReturnCategory(input.CategoryId);

                    _context.Furnitures.Update(Furniture);
                    _context.SaveChanges();

                    return new ResultDto()
                    {
                        IsSuccess = true,
                        Message = "عملیات موفقیت آمیز بود",
                        Title = "موفق",
                        Icon = "success"
                    };
                }
            }
            catch (Exception)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "عملیات ناموفق بود",
                    Title = "ناموفق",
                    Icon = "error"
                };
            }
        }

        private Domain.Entities.Categories.Categories ReturnCategory(int id)
        {
            return _context.Categories.Find(id);
        }
    }
}
