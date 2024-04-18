﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Dtos.SaleAppDtos.ProductAppDtos
{
    public class DeleteProductAppDto
    {
        public Guid Id { get; set; }
        public string ProductCategoryId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public decimal UnitPrice { get; set; } 
    }
}
