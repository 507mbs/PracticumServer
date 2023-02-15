using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IContext
    {
        DbSet<Child> Children { get; set; }
        
        DbSet<Detail> Details { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
