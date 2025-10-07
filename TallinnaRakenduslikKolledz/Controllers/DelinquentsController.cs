using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TallinnaRakenduslikKolledz.Data;
using TallinnaRakenduslikKolledz.Models;

namespace TallinnaRakenduslikKolledz.Controllers
{
    public class DelinquentsController : Controller
    {
        private readonly SchoolContext _context;

        public DelinquentsController(SchoolContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var deliquents = await _context.Delinquents.ToListAsync();
            return View(deliquents);
        }

        public async Task<IActionResult> Create()
        {
            PopulateViolationDropDownList();
            return View();
        }

        private void PopulateViolationDropDownList()
        {
            Array enumList = Enum.GetValues(typeof(Violation));
            List<Violation> newSelectList = new List<Violation>();
            foreach (Violation getViolation in enumList)
            {
                newSelectList.Add(getViolation);
            }

            enumList = Enum.GetValues(typeof(DelinquentType));
            List<DelinquentType> delinquentTypes = new List<DelinquentType>();

            foreach (DelinquentType getDelinquentType in enumList)
            {
                delinquentTypes.Add(getDelinquentType);
            }

            ViewBag.ViolationList = new SelectList(newSelectList);
            ViewBag.DelinquentTypes = new SelectList(delinquentTypes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Delinquent delinquent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(delinquent);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

    }
}
