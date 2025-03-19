using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace gasoilin_project_v2.Pages
{
    // The BiographyModel class represents the backend logic for the Biography page
    public class BiographyModel : PageModel
    {
        private readonly ILogger<BiographyModel> _logger; // Logger for debugging and tracking

        // Constructor to initialize the logger
        public BiographyModel(ILogger<BiographyModel> logger)
        {
            _logger = logger;
        }

        // Inner class to represent a person with name, description, and image path
        public class People
        {
            public string Name { get; set; } // Stores the person's name
            public string Description { get; set; } // Stores a short description
            public string ImagePath { get; set; } // Stores the image file path

            // Constructor to initialize People objects with provided values
            public People(string name, string description, string imagePath)
            {
                Name = name;
                Description = description;
                ImagePath = imagePath;
            }
        }

        // Array of People objects to store multiple biographies
        public People[] Peoples { get; set; } = new People[5];

        // Method that runs when the page is loaded (HTTP GET request)
        public void OnGet()
        {
            // Populating the Peoples array with predefined people and their details
            Peoples[0] = new People("Kim", "Verdens sødeste mand", "Kim.jpg");
            Peoples[1] = new People("Bjorn", "Sjoveste lille mand", "Bjørn.jpg");
            Peoples[2] = new People("Franz", "En rigtig bølle", "Franz.jpg");
            Peoples[3] = new People("Soren", "Han ser lidt underlig ud", "Søren.jpg");
            Peoples[4] = new People("Willi", "Han ser lidt underlig ud", "Willi.jpg");
        }
    }
}
