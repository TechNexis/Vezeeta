using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Doctor
    {
        [Required(ErrorMessage = "The Doctor Id is Required")]
        public int Id { get; set; }
        public string? name{ get; set; }
        public string? description { get; set; }
        public string? review { get; set; } 

        //public List<TimeSlots>? TimeSlots { get; set; }
        public string? title { get; set; }
        public string? address_id { get; set; }
        public string? gender { get; set; } 

        [ForeignKey("Specialization")]
        [Required(ErrorMessage = "The Specialization Id is Required")]
        public int SpecializationId { get; set; }
        public Specialization? Specialization { get; set; }

        [ForeignKey("Hospital")]
        [Required(ErrorMessage = "The Hospital Id is Required")]
        public int hospital_Id { get; set; }
        public Hospital? Hospital { get; set; }

        [ForeignKey("Appointment")]
        [Required(ErrorMessage = "The Appointment Id is Required")]
        public int appointment_Id { get; set; }
        public  Appointments? Appointment { get; set; }



    }
}
