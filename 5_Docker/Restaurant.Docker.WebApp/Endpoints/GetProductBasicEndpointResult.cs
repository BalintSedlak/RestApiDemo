﻿namespace Restaurant.Docker.WebApp.Endpoints;

public class GetProductBasicEndpointResult
{
    public string ProductName { get; set; }

    public decimal? UnitPrice { get; set; }

    public short? UnitsInStock { get; set; }
}