using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Catalin_Teburzuca_lab2.Data;
using Catalin_Teburzuca_lab2.Models;

namespace Catalin_Teburzuca_lab2.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Catalin_Teburzuca_lab2.Data.Catalin_Teburzuca_lab2Context _context;

        public CreateModel(Catalin_Teburzuca_lab2.Data.Catalin_Teburzuca_lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Publisher == null || Publisher == null)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
