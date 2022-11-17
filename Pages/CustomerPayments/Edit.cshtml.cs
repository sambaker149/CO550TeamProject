using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CO550TeamProject.Data;
using CO550TeamProject.Models;

namespace CO550TeamProject.Pages.CustomerPayments
{
    public class EditModel : PageModel
    {
        private readonly CO550TeamProject.Data.ApplicationDbContext _context;

        public EditModel(CO550TeamProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CustomerPayment CustomerPayment { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CustomerPayment == null)
            {
                return NotFound();
            }

            var customerpayment =  await _context.CustomerPayment.FirstOrDefaultAsync(m => m.Id == id);
            if (customerpayment == null)
            {
                return NotFound();
            }
            CustomerPayment = customerpayment;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CustomerPayment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerPaymentExists(CustomerPayment.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CustomerPaymentExists(int id)
        {
          return _context.CustomerPayment.Any(e => e.Id == id);
        }
    }
}
