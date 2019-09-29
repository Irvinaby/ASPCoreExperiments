using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HekimogluWebPortal.Model.Family;
using HekimogluWebPortal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HekimogluWebPortal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public FamilyService FamilyService;
        public Family Family;

        public IndexModel(ILogger<IndexModel> logger, FamilyService familyService)
        {
            _logger = logger;
            FamilyService = familyService;
        }

        public void OnGet()
        {
            Family = FamilyService.GetFamily();
        }
    }
}
