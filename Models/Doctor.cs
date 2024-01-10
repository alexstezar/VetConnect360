using System.ComponentModel.DataAnnotations;

namespace VetConnect360.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        [Display(Name = "Full Name")]
        public string DoctorFullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public int Experience { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ICollection<Appointment>? Appointments { get; set; }

    }
}
