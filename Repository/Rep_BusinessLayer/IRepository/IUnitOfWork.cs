using System;
using System.Collections.Generic;
using System.Text;

namespace Rep_BusinessLayer.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        int SaveChanges();
    }
}
