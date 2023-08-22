using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PhotoMan.Data;
using PhotoMan.Models;

namespace PhotoMan.Pages.PhotoCollections
{
    public class ListModel : PageModel
    {
        private readonly PhotoMan.Data.ApplicationDbContext _context;

        public ListModel(PhotoMan.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<PhotoCollection> PhotoCollection { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.PhotoCollections != null)
            {
                PhotoCollection = await _context.PhotoCollections
                .Include(p => p.User).ToListAsync();
            }
        }
    }
}
