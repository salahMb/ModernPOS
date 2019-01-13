﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Core
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}
