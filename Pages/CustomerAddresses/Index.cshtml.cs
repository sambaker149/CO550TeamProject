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
    public class IndexModel : PageModel
    {
        private readonly CO550TeamProject.Data.ApplicationDbContext _context;

        public IndexModel(CO550TeamProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CustomerAddress> CustomerAddress { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CustomerAddress != null)
            {
                CustomerAddress = await _context.CustomerAddress.ToListAsync();
            }
        }
    }
}
