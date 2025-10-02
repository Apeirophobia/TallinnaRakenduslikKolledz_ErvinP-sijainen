using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikKolledz.Models
{
    public enum DepartmentStatus
    {
        Suletud,
        Avatud,
        Pausil,
        Deprecated,
    }
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        
        public int? InstructorID { get; set; }
        public Instructor? Administrator { get; set; }
        public ICollection<Course>? Courses { get; set; }
        public byte? RawVersion { get; set; }
        /* 3 isiklikult unikaalset andmevälja kursusele juurde */

        public DepartmentStatus? CurrentStatus { get; set; }
        public int? StudentsDroppedOut { get; set; }
        public int? TotalGraduates { get; set; }


    }
}
