using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace dotnet_helloworld.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    // requires using Microsoft.Extensions.Configuration;
    private readonly IConfiguration Configuration;

    public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
    {
        _logger = logger;
        Configuration = configuration;
    }

    public void OnGet()
    {

    }

    //public ContentResult OnGet()
    //{
    //    // If it has to be accessed in the code here
    //    var title = Configuration["Position:Title"];

    //    return Content($"Title from App Settings: {title} \n");
    //}
}
