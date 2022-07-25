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
        public void OnGet()
        {

        }
        [BindProperty]
        public Task NewTask { get; set; }
        public void OnPost(IActionResult actionResult) {
            RedirectToPage("Index");
        }

    }
}
