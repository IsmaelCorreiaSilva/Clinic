using Application.ViewModel.Doctor;

namespace Application.Interfaces
{
    public interface IDoctorService
    {
        Task<DoctorResponse> FindById(Guid id);
        Task<IEnumerable<DoctorResponse>> FindAll();
        Task<DoctorResponse> Insert(DoctorCreate doctor);
        Task<DoctorResponse> Update(DoctorResponse doctor);
        Task<bool> DeleteById(Guid id);
    }
}
