using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace gasoilin_project_v2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public PageContent Content { get; private set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Content = ContentService.GetPageContent();
        }

        public void OnGet()
        {
            // Additional logic if needed
        }
    }

    public static class ContentService
    {
        public static PageContent GetPageContent()
        {
            return new PageContent
            {
                ImageUrl = "banner.png",
                AltText = "Banner af Gasolin",
                Title = "", //write titel text here
                Description = "", //write text here about
            };
        }
    }

    public class PageContent
    {
        public string ImageUrl { get; set; }
        public string AltText { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
