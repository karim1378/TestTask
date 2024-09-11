using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Domain.Entities
{
    public class Manufacturer : IdentityUser
    {
        public string FullName { get; set; }

        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        public RefreshToken RefreshToken { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
