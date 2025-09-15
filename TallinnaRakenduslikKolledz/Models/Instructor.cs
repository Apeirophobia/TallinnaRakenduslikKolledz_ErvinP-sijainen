using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikKolledz.Models
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Perekonnanimi")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Eesnimi")]
        public string FirstName { get; set; }
        /*  */
        [Display(Name = "Õpetaja nimi")]
        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }
        /*  */
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Tööleasumiskuupäev")]
        public DateTime HireDate { get; set; }

        public ICollection<CourseAssignment>? CourseAssignments { get; set; }
        public OfficeAssignment? OfficeAssignments { get; set; }
        /* Lisa kolm omadust õpetaja, ise nõtled välja*/
        [Display(Name = "Telefoni number")]
        public string? PhoneNumber { get; set; }
        [Display(Name = "Alkohoolik")]
        public int? Alcoholic { get; set; }
        [Display(Name = "Vangis olnud")]
        public int? BeenInJail { get; set; }
    }
}
