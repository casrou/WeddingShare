using Microsoft.AspNetCore.Mvc.RazorPages;
using WeddingShare.Models.Database;

namespace WeddingShare.Views.Admin.Settings
{
    public class BasicModel : PageModel
    {
        public BasicModel()
        {
        }

        public IDictionary<string, string>? Settings { get; set; }

        public IEnumerable<CustomResourceModel>? CustomResources { get; set; }

        public void OnGet()
        {
        }
    }
}