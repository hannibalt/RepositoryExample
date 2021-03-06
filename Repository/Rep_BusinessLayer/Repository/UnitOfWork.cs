﻿using Microsoft.EntityFrameworkCore;
using Rep_BusinessLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rep_BusinessLayer.Repository
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;
        private bool disposed = false;
        //private bool disposing;

        public EFUnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
                if (disposing)
                    _dbContext.Dispose();
            disposed = true;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new EFRepository<T>(_dbContext);
        }

        public int SaveChanges()
        {
            try
            {
                return _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
