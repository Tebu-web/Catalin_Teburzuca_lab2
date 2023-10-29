using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Catalin_Teburzuca_lab2.Data;
using Catalin_Teburzuca_lab2.Models;

namespace Catalin_Teburzuca_lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Catalin_Teburzuca_lab2.Data.Catalin_Teburzuca_lab2Context _context;

        public IndexModel(Catalin_Teburzuca_lab2.Data.Catalin_Teburzuca_lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                .Include(b=>b.Publisher)
                .ToListAsync();
            }
        }
    }
}
