
using Application.ViewModel.Specialty;
using Domain.Entities;

namespace Application.Mappings
{
    public class SpecialtyProfile:DoctorProfile
    {
        public SpecialtyProfile()
        {
            CreateMap<SpecialtyCreate, Specialty>();
            CreateMap<SpecialtyResponse, Specialty>();
            CreateMap<Specialty, SpecialtyResponse>();
        }
    }
}
