
using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ApplicationDbContext context;

        public DoctorRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<bool> DeleteById(Guid id)
        {
           var doctorSearch = await context.Doctors.FindAsync(id);
            
            if (doctorSearch != null)
            {
                context.Doctors.Remove(doctorSearch);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        
        }

        public async Task<IEnumerable<Doctor>> FindAll()
        {
            return await context.Doctors.AsNoTracking().ToListAsync();
        }

        public async Task<Doctor> FindById(Guid id)
        {
            return await context.Doctors.FindAsync(id);
        }

        public async Task<Doctor> Insert(Doctor doctor)
        {
            await context.Doctors.AddAsync(doctor);
            await context.SaveChangesAsync();
            return doctor;
        }

        public async Task<Doctor> Update(Doctor doctor)
        {
            var doctorSearch = await context.Doctors.FindAsync(doctor.Id);

            if (doctorSearch == null)
                return null;

            context.Entry(doctorSearch).CurrentValues.SetValues(doctor);
            await context.SaveChangesAsync();

            return doctor;
        }
    }
}
