using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace gasoilin_project_v2.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    //det her er en tester for at e om jeg godt kan skrive

    //yes yes
    public void OnGet()
    {
        //fuck off
    }
}
