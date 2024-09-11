using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository { get; }
        IRefreshTokenRepository RefreshTokenRepository { get; }

        //IManufacturerRepository ManufacturerRepository { get; }       //Manufacturer inherit from IdentityUser and it by default use UnitOfWork

        Task<int> SaveChangesAsync();
    }
}
