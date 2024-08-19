using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Patient
    {

        public int Id { get; set; }
        public string gender { get; set; }
        public int age{ get; set; }
        public int image{ get; set; }

        public string? assomptions { get; set; }




    }
}
