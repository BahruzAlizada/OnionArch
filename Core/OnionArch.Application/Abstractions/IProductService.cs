using OnionArch.Domain.Entities;
using System;


namespace OnionArch.Application.Abstractions
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
