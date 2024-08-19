using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Specialization
    {
        public int Id { get; set; }

        [MinLength(3)]

        [MaxLength(20)]

        [Required(ErrorMessage = " Name Is Required")]

        public string Name { get; set; }
        public List<Doctor>? Doctors { get; set; }


    }
}
