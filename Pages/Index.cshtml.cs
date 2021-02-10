using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetCore21Web.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            Task.Run(async () =>
            {
                var started = DateTime.UtcNow;
                await Task.Delay(TimeSpan.FromMinutes(10));

                Environment.FailFast($"{DateTime.UtcNow:s} Failfast intentionally since app started at {started:s}");
            });
        }
    }
}
