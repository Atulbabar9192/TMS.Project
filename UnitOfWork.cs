using System;
using System.Collections.Generic;
using System.Text;
using TMS.Project.Data;

namespace TMS.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TMSDataContext _context;
        public Repository<User> UserRepository { get; }
        public UnitOfWork(TMSDataContext context)
        {
            this._context = context;
            this.UserRepository = new Repository<User>(this._context);
        }
        public int Save()
        {
            return this._context.SaveChanges();
        }
        public void Dispose()
        {
            this._context.Dispose();
        }

    }
}
