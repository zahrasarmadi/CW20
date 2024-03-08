using CW20.Models;
using CW20.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW20_Divar.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}
        [BindProperty]
        public List<Ad> Ads{ get; set; }

        AdRepository adRepository=new AdRepository();
        public void OnGet()
        {
           Ads= adRepository.GetAdsList();
        }

    }
}
