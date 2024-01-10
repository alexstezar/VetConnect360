namespace VetConnect360.Models
{
    public class Appointment
    {
        public int ID { get; set; }

        public int? PetID { get; set; }
        public Pet? Pet { get; set; }

        public DateTime Date { get; set; }

        public int? DoctorID { get; set; }
        public Doctor? Doctor { get; set; }

        public int? ServiceID { get; set; }
        public Service? Service { get; set; }

    }
}
