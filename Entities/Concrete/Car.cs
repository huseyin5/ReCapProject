﻿using Entities.Abstract;

namespace Entities.Concrete;

public class Car : IEntity
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public int ColorId { get; set; }
    public short ModelYear { get; set; }
    public short DailyPrice { get; set; }
    public string Description { get; set; }
}