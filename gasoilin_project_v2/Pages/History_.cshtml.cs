using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace gasoilin_project_v2.Pages
{
    // The PrivacyModel class represents the backend logic for the History page
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger; // Logger for debugging and tracking

        // Property to hold the content of the page
        public HistoryPageContent Content { get; set; }

        // Constructor to initialize the logger and fetch page content
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
            Content = HistoryContentService.GetHistoryPageContent(); // Fetching page content from the HistoryContentService
        }

        // Method that runs when the page is loaded (HTTP GET request)
        public void OnGet()
        {
            // Additional logic can be added here if needed
        }
    }

    // Static class to provide content for the History page
    public static class HistoryContentService
    {
        // Method to get the page content
        public static HistoryPageContent GetHistoryPageContent()
        {
            return new HistoryPageContent
            {
                Title = "Gasolins Historie (1969–1978)",
                Section1Title = "Gasolins musikalske stil og tekster – eksempler og udvikling",
                Section1Content = "Gasolin’s musikalske stil var en unik blanding af rå rockenergi, melodisk sans og poetisk fortællelyst...",
                Section2Title = "Betydning for dansk rockmusik",
                Section2Content = "Gasolin’s indflydelse på dansk rock kan næppe overvurderes...",
                Section3Title = "Gasolins arv og musikken i dag",
                Section3Content = "Selvom Gasolin’ officielt ophørte i 1978, lever deres musik i bedste velgående..."
            };
        }
    }

    // Class to represent the content of the History page
    public class HistoryPageContent
    {
        public string Title { get; set; } // Title of the page
        public string Section1Title { get; set; } // Title of the first section
        public string Section1Content { get; set; } // Content of the first section
        public string Section2Title { get; set; } // Title of the second section
        public string Section2Content { get; set; } // Content of the second section
        public string Section3Title { get; set; } // Title of the third section
        public string Section3Content { get; set; } // Content of the third section
    }
}