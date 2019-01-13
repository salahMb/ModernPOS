using System;
using DAL.Data;
using Core.Persistence.Repositories;
using System.Data.Common;
using System.Data;
using DAL.Core;

namespace BL
{
    public class POSHelper : IUnitOfWork // before it was UnitOfWork
    {
        //readonly
        private POSEntities _context = null;
        public ICustomerRepository CustomerRepository { get; private set; }
        public ICategoriesRepository CategoriesRepository { get; private set; }
        public IProductsRepository ProductsRepository { get; private set; }
        public POSHelper()
        {
            _context = new POSEntities();     
            CustomerRepository = new CustomerRepository(_context);
            CategoriesRepository = new CategoriesRepository(_context);
            ProductsRepository = new ProductsRepository(_context);
        }


        public  int Complete()
        {
            return _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (null != _context)
                    {
                        _context.Dispose();
                    }
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        //public void Dispose()
        //{
        //    if (null != _context)
        //    {
        //        _context.Dispose();
        //    }
        //}
    }
}