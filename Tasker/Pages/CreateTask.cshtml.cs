using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker.Pages
{
    public class CreateTaskModel : PageModel
    {
        [BindProperty] 
        public Task NewTask { get; set; }

        private ApplicationDBContext _context;

        public CreateTaskModel(ApplicationDBContext context)
        {
            context = _context;
        }

        public void OnGet()
        {

        }
    
        public IActionResult OnPost()
        {
             if (ModelState.IsValid)
            {
                _context.Tasks.Add(NewTask);
                _context.SaveChanges();

                return new RedirectToPageResult("Index");
            }
            return new RedirectToPageResult("Index");
           
            //RedirectToPage("Index");
        }

        
    }
}
