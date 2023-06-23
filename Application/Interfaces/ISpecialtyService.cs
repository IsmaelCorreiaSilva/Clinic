

using Application.ViewModel.Specialty;

namespace Application.Interfaces
{
    public interface ISpecialtyService
    {
        Task<SpecialtyResponse> FindById(Guid id);
        Task<IEnumerable<SpecialtyResponse>> FindAll();
        Task<SpecialtyResponse> Insert(SpecialtyCreate specialty);
        Task<SpecialtyResponse> Update(SpecialtyResponse specialty);
        Task<bool> DeleteById(Guid id);

    }
}
