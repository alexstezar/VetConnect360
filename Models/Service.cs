using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetConnect360.Models
{
    public class Service
    {
        public int ID { get; set; }

        [Display(Name = "Medical Procedure")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        public ICollection<Appointment>? Appointments { get; set; }

    }
}
