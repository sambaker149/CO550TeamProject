using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CO550TeamProject.Data;
using CO550TeamProject.Models;

namespace CO550TeamProject.Pages.CustomerPayments
{
    public class DetailsModel : PageModel
    {
        private readonly CO550TeamProject.Data.ApplicationDbContext _context;

        public DetailsModel(CO550TeamProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public CustomerPayment CustomerPayment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CustomerPayment == null)
            {
                return NotFound();
            }

            var customerpayment = await _context.CustomerPayment.FirstOrDefaultAsync(m => m.Id == id);
            if (customerpayment == null)
            {
                return NotFound();
            }
            else 
            {
                CustomerPayment = customerpayment;
            }
            return Page();
        }
    }
}
