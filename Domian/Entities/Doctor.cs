

namespace Domain.Entities
{
    public class Doctor
    {
        public Doctor() { }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Crm { get; set; }
        public DateTime DataBirth { get; set; }

    }
}
