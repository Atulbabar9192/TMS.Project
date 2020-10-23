using System;
using System.Collections.Generic;
using System.Text;
using TMS.Project.Data;

namespace TMS.Persistance
{
     public interface IUnitOfWork : IDisposable
    {
        Repository<User> UserRepository { get; }
        int Save();

    }
}
