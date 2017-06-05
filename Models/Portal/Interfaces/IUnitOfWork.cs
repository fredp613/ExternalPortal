﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalPortal.Models.Portal.Interfaces
{
    public interface IUnitOfWork
    {
        IProjectRepository Projects { get;  }
        int SaveChanges();
        Task<int> SaveChangesAsync();

    }
}
