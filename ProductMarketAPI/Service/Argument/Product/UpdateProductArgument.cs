﻿namespace ProductMarketAPI.Service.Argument.Product;

public class UpdateProductArgument
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public string Description { get; set; }
}