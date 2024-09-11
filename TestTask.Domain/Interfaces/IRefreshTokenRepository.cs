using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Domain.Entities;

namespace TestTask.Domain.Interfaces
{
    public interface IRefreshTokenRepository
    {
        Task<string> AddOrUpdateRefreshTokenAsync(RefreshToken refreshToken);
        Task<RefreshToken> GetRefreshTokenAsync(string refreshTokenValue);
    }
}
