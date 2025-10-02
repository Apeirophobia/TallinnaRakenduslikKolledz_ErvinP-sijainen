using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikKolledz.Models
{
    public class CafeteriaMenu
    {
        [Key]
        public int CafeteriaMenuID { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public string Meal { get; set; }
        public decimal Price { get; set; }
    }
}
