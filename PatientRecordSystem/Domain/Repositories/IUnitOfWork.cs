﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientRecordSystem.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}