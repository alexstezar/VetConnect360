using System.ComponentModel.DataAnnotations;

namespace VetConnect360.Models
{
    public class Owner
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        [Display(Name = "Full Name")]
        public string OwnerFullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Pet>? Pets { get; set; }
    }
}
