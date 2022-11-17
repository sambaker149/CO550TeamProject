using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CO550TeamProject.Data;
using CO550TeamProject.Models;

namespace CO550TeamProject.Pages.CustomerAddresses
{
    public class DetailsModel : PageModel
    {
        private readonly CO550TeamProject.Data.ApplicationDbContext _context;

        public DetailsModel(CO550TeamProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public CustomerAddress CustomerAddress { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CustomerAddress == null)
            {
                return NotFound();
            }

            var customeraddress = await _context.CustomerAddress.FirstOrDefaultAsync(m => m.Id == id);
            if (customeraddress == null)
            {
                return NotFound();
            }
            else 
            {
                CustomerAddress = customeraddress;
            }
            return Page();
        }
    }
}
