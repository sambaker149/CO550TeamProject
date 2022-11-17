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

namespace CO550TeamProject.Pages.CustomerAddresses
{
    public class EditModel : PageModel
    {
        private readonly CO550TeamProject.Data.ApplicationDbContext _context;

        public EditModel(CO550TeamProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CustomerAddress CustomerAddress { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CustomerAddress == null)
            {
                return NotFound();
            }

            var customeraddress =  await _context.CustomerAddress.FirstOrDefaultAsync(m => m.Id == id);
            if (customeraddress == null)
            {
                return NotFound();
            }
            CustomerAddress = customeraddress;
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

            _context.Attach(CustomerAddress).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerAddressExists(CustomerAddress.Id))
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

        private bool CustomerAddressExists(int id)
        {
          return _context.CustomerAddress.Any(e => e.Id == id);
        }
    }
}
