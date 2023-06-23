
using Application.Interfaces;
using Application.ViewModel.Specialty;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class SpecialtyService:ISpecialtyService
    {
        private readonly ISpecialtyRepository specialtyRepository;
        private readonly IMapper mapper;

        public SpecialtyService(ISpecialtyRepository specialtyRepository,
            IMapper mapper)
        {
            this.specialtyRepository = specialtyRepository;
            this.mapper = mapper;
        }

        public async Task<bool> DeleteById(Guid id)
        {
            return await specialtyRepository.DeleteById(id);
        }

        public async Task<IEnumerable<SpecialtyResponse>> FindAll()
        {
          return mapper.Map<IEnumerable<SpecialtyResponse>>(await specialtyRepository.FindAll());   
        }

        public async Task<SpecialtyResponse> FindById(Guid id)
        {
            return mapper.Map<SpecialtyResponse>(await specialtyRepository.FindById(id));
        }

        public async Task<SpecialtyResponse> Insert(SpecialtyCreate newSpecialty)
        {
            var specialty = mapper.Map<Specialty>(newSpecialty);
            specialty = await specialtyRepository.Insert(specialty);
            return mapper.Map<SpecialtyResponse>(specialty);
        }

        public async Task<SpecialtyResponse> Update(SpecialtyResponse updateSpecialty)
        {
            var specialty = mapper.Map<Specialty>(updateSpecialty);
            specialty = await specialtyRepository.Update(specialty);
            return mapper.Map<SpecialtyResponse>(specialty);
        }
    }
}
