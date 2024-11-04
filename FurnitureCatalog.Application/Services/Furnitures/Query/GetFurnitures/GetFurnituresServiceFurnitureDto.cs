using System;

public class GetFurnituresServiceFurnitureDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public bool IsActive { get; set; }
    public DateTime InsertTime { get; set; }
    public GetFurnituresServiceCategoryDto Category { get; set; }
}
