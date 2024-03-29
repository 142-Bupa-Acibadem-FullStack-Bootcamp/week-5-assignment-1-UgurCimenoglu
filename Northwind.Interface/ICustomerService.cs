﻿using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Interface
{
    public interface ICustomerService : IGenericService<Customer,DtoCustomer>   
    {
        IQueryable CustomerReport();
        IResponse<DtoCustomer> GetCustomerByStringId(string id);
    }
}
