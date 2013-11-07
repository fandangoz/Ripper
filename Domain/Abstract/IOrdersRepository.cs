﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
namespace Domain.Abstract
{
    public interface IOrdersRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
        void EditOrder(Order order);
    }
}
