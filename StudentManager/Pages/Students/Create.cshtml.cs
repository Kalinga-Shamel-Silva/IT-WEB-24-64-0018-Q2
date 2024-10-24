using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentManager.Data;
using StudentManager.Models;

namespace StudentManager.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly StudentManager.Data.StudentManagerContext _context;

        public CreateModel(StudentManagerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student { get; set; } = default!;

        public IList<Course> Course { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }


}
