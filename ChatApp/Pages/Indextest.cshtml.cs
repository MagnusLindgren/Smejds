
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Pages
{
    public class IndextestModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndextestModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
    }
}
