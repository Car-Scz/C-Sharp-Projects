using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeDisplay.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string Time { get; set; }

        public void OnGet()
        {
            Time = DateTime.Now.ToShortTimeString();
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
    }
}
