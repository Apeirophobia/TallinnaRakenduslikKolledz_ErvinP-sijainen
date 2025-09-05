namespace TallinnaRakenduslikKolledz.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

        /* Lisa kolm omadust */

        public int? Smart { get; set; }
        public int? Sleepy { get; set; }
        public ICollection<Track>? Tracks { get; set; }
    }
}
