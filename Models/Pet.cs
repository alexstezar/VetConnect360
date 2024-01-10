using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace VetConnect360.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Photo {  get; set; }

        public int? OwnerID { get; set; }
        public Owner? Owner { get; set; }


        public ICollection<Appointment>? Appointments { get; set; }

    }
}
