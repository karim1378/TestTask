using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Domain.Entities;

namespace TestTask.Domain.Interfaces
{
    public interface IManufacturerRepository
    {
        Task<IdentityResult> CreateAsync(Manufacturer manufacturer, string password);
        Task<Manufacturer> GetByIdAsync(string id);
        Task<Manufacturer> GetByUserNameAsync(string userName);
        Task<Manufacturer> GetByEmailAsync(string email);
        Task<IdentityResult> UpdateAsync(Manufacturer user);
        Task<IdentityResult> ResetPasswordAsync(Manufacturer user, string token, string newPassword);
        Task<string> GeneratePasswordResetTokenAsync(Manufacturer manufacturer);
        Task<SignInResult> SignInAsync(string userName, string password);
        Task<IEnumerable<Manufacturer>> GetAllManufacturerAsync();
        Task<IdentityResult> DeleteAsync(Manufacturer manufacturer);
    }
}
