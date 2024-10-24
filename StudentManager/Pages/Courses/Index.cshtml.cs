using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentManager.Data;
using StudentManager.Models;

namespace StudentManager.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly StudentManager.Data.StudentManagerContext _context;

        public IndexModel(StudentManager.Data.StudentManagerContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }
    }
}