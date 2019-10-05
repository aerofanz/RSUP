﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Repository_api
{
    public interface IUnitOfWork
    {
        IAuthRepository AuthRepository { get;  }
        IRoleRepository RoleRepository { get;  }
        ICustomerRepository CustomerRepository { get; }
        void Commit();
        void Rollback();
    }
}
