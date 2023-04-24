
using Application.ViewModel.Doctor;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class DoctorProfile:Profile
    {
        public DoctorProfile()
        {
            CreateMap<DoctorCreate, Doctor>();
            CreateMap<DoctorResponse, Doctor>();
            CreateMap<Doctor, DoctorResponse>();
        }
    }
}
