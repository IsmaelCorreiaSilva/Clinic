

using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IDoctorRepository
    {
        Task<Doctor> FindById(Guid id);
        Task<IEnumerable<Doctor>> FindAll();
        Task<Doctor> Insert(Doctor doctor);
        Task<Doctor> Update(Doctor doctor);
        Task<bool> DeleteById(Guid id);
    }
}
