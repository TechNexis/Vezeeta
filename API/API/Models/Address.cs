namespace API.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int patiant_id { get; set; }
         
        public string line1 { get; set; }
        public string line2 { get; set; }

        public int region_id { get; set; }
        public int postal_code { get; set; }




    }
}
