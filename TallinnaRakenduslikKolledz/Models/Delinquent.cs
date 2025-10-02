using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikKolledz.Models
{
    public enum Violation
    {
        DrugRecreation,
        DrugTrafficking,
        Assault,
        SexualAssault,
        HateCrimeInstigation,
        Arson,
        ThrowingFood,
        Misdismeanor,
        Vandalism
    }

    public enum DelinquentType
    {
        Student,
        Instructor
    }

    public class Delinquent
    {
        [Key]
        public int DeliquentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Violation Violation { get; set; }
        public DelinquentType DelinquentType { get; set; }
        public string Description { get; set; }

    }
}
