using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class DetailRepository : IDataRepository<Detail>
    {
        private readonly IContext _context;
        public DetailRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Detail> AddAsync(Detail entity)
        {
            EntityEntry<Detail> newOne = _context.Details.Add(entity);

            await _context.SaveChangesAsync();
            return newOne.Entity;
        }

        public async Task DeleteAsync(string id)
        {

            _context.Details.Remove(_context.Details.FirstOrDefault(p => p.Idenentity == id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Detail>> GetAllAsync()
        {
            return await _context.Details.ToListAsync();
        }

        public async Task<Detail> GetByIdAsync(string id)
        {
            return await _context.Details.FindAsync(id);
        }

        public async Task<Detail> UpdateAsync(Detail entity)
        {
            //var newEntity = _context.Details.Update(entity);
            //await _context.SaveChangesAsync();
            //return newEntity.Entity;

            var upd = await GetByIdAsync(entity.Idenentity);
            upd.BornDate=entity.BornDate;
            upd.Gender = entity.Gender;
            upd.FirstName= entity.FirstName;
            upd.LastName= entity.LastName;
            upd.Hmo=entity.Hmo;
            
            var newEntity = _context.Details.Update(upd);
            await _context.SaveChangesAsync();
            return newEntity.Entity;
        }
    }
}
