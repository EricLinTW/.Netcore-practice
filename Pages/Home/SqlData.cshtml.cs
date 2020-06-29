using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using _Netcore_practice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace _Netcore_practice.Pages {
    [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class SqlDataModel : PageModel {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty (RequestId);

        private readonly ILogger<SqlDataModel> _logger;

        public SqlDataModel (ILogger<SqlDataModel> logger) {
            _logger = logger;
        }

        public void OnGet () {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }
}