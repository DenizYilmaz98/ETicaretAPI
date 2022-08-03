﻿using ETicaretAPI.Application.Repositories.ProductRepo;
using ETicaretAPI.Domain.Entities.Common;
using ETicaretAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories.ProductRepo
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ETicaretAPIDbContext dbContext) : base(dbContext)
        {
        }
    }
}
