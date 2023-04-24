
using Application.Interfaces;
using Application.ViewModel.Doctor;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository doctorRepository;
        private readonly IMapper mapper;

        public DoctorService(IDoctorRepository doctorRepository, IMapper mapper)
        {
            this.doctorRepository = doctorRepository;
            this.mapper = mapper;
        }

        public async Task<bool> DeleteById(Guid id)
        {
            return await doctorRepository.DeleteById(id);
        }

        public async Task<IEnumerable<DoctorResponse>> FindAll()
        {
            var result = await doctorRepository.FindAll();
            return mapper.Map<IEnumerable<DoctorResponse>>(result);
        }

        public async Task<DoctorResponse> FindById(Guid id)
        {
            var resul = await doctorRepository.FindById(id);
            return mapper.Map<DoctorResponse>(resul);
        }

        public async Task<DoctorResponse> Insert(DoctorCreate newDoctor)
        {
            var doctor = mapper.Map<Doctor>(newDoctor);
            var doctorResult = await doctorRepository.Insert(doctor);
            return mapper.Map<DoctorResponse>(doctorResult);
        }

        public async Task<DoctorResponse> Update(DoctorResponse editDoctor)
        {
            var doctor = mapper.Map<Doctor>(editDoctor);
            var doctorResult = await doctorRepository.Update(doctor);
            return mapper.Map<DoctorResponse>(doctorResult);
        }
    }
}
