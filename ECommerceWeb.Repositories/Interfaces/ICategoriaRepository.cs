﻿using ECommerceWeb.Entities;

namespace ECommerceWeb.Repositories.Interfaces
{
    public interface ICategoriaRepository : IRepositoryBase<Categoria>
    {
        Task<ICollection<Categoria>> ListMinimalAsync();
    }
}
