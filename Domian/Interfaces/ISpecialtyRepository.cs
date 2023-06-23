using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ISpecialtyRepository
    {
        Task<Specialty> FindById(Guid id);
        Task<IEnumerable<Specialty>> FindAll();
        Task<Specialty> Insert(Specialty specialty);
        Task<Specialty> Update(Specialty specialty);
        Task<bool> DeleteById(Guid id);
    }
}
