using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BoostrapV2.Pages
{
    public class IndexModel : PageModel
    {
        public string? FirstName  { get; set; }
        public IndexModel()
        {
        }
        public void OnGet()
        {
        }
    }
}