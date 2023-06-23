using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class SpecialtyRepository : ISpecialtyRepository
    {
        private readonly ApplicationDbContext context;

        public SpecialtyRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<bool> DeleteById(Guid id)
        {
            var specialtySearch = await context.Specialties.FindAsync(id);

            if (specialtySearch != null)
            {
                context.Specialties.Remove(specialtySearch);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Specialty>> FindAll()
        {
            return await context.Specialties.AsNoTracking().ToListAsync();
        }

        public async Task<Specialty> FindById(Guid id)
        {
            return await context.Specialties.FindAsync(id);
        }

        public async Task<Specialty> Insert(Specialty specialty)
        {
            await context.Specialties.AddAsync(specialty);
            await context.SaveChangesAsync();
            return specialty;
        }

        public async Task<Specialty> Update(Specialty specialty)
        {
           var specialtySearch = await context.Specialties.FindAsync(specialty.Id);

            if (specialtySearch == null)
                return null;

            context.Entry(specialtySearch).CurrentValues.SetValues(specialty);
            await context.SaveChangesAsync();

            return specialty;
        }
    }
}
