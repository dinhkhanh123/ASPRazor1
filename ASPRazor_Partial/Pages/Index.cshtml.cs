using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ASPRazor_Partial.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public IActionResult OnPost()
        {
            var username = this.Request.Form["username"];
            var message = new MessagePage.Message();
            message.title = "Thong bao";
            message.htmlcontent = $"Cam on {username}, da gui thong tin";
            message.secondwait = 5;
            message.urlredirect = Url.Page("/Privacy");
            return ViewComponent("MessagePage", message);
        }
        // public IActionResult OnGet()
        // {
        //     //PageModel : partial-> ViewComponent
        //     //Controller : PartialView->ViewComponent
        //     return ViewComponent("ProductBox", false);
        // }
    }
}
