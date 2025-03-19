using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace gasoilin_project_v2.Pages
{
    // The IndexModel class represents the backend logic for the Index page
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger; // Logger for debugging and tracking

        // Property to hold the content of the page
        public PageContent Content { get; set; }

        // Constructor to initialize the logger and fetch page content
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Content = ContentService.GetPageContent(); // Fetching page content from the ContentService
        }

        // Method that runs when the page is loaded (HTTP GET request)
        public void OnGet()
        {
            // Additional logic can be added here if needed
        }
    }

    // Static class to provide content for the page
    public static class ContentService
    {
        // Method to get the page content
        public static PageContent GetPageContent()
        {
            return new PageContent
            {
                ImageUrl = "image/banner.png", // URL of the banner image
                AltText = "Banner af Gasolin", // Alternative text for the image if it doesn't load
                Title = "", // Title text for the page
                Description = "", // Description text for the page
            };
        }
    }

    // Class to represent the content of the page
    public class PageContent
    {
        public string ImageUrl { get; set; } // URL of the image
        public string AltText { get; set; } // Alternative text for the image
        public string Title { get; set; } // Title of the page
        public string Description { get; set; } // Description of the page
    }
}