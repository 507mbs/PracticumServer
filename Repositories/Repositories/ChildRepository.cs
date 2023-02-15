using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repositories;
using Repositories.Entities;
using Repositories.Interface;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class ChildRepository : IDataRepository<Child>
    {
        private readonly IContext _context;
        public ChildRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Child> AddAsync(Child entity)
        {
            EntityEntry<Child> newOne = _context.Children.Add(entity);

            await _context.SaveChangesAsync();
            return newOne.Entity;
        }

        public async Task DeleteAsync(string id)
        {

            _context.Children.Remove(_context.Children.FirstOrDefault(p => p.Identity == id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.ToListAsync();
        }

        public async Task<Child> GetByIdAsync(string id)
        {
            return await _context.Children.FindAsync(id);
        }

        public async Task<Child> UpdateAsync(Child entity)
        {
            //var newEntity = _context.Children.Update(entity);
            //await _context.SaveChangesAsync();
            //return newEntity.Entity;

            var upd = await GetByIdAsync(entity.Identity);           
            upd.BornDate= entity.BornDate;
            upd.ParentId = entity.ParentId;
            upd.Name = entity.Name;
            upd.Parent= entity.Parent;
            var newEntity = _context.Children.Update(upd);
            await _context.SaveChangesAsync();
            return newEntity.Entity;
        }
    }
}
