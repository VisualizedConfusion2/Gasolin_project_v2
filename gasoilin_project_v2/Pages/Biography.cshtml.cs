using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace gasoilin_project_v2.Pages
{
    public class BiographyModel : PageModel
    {
        private readonly ILogger<BiographyModel> _logger;

        public BiographyModel(ILogger<BiographyModel> logger)
        {
            _logger = logger;
        }

        public class People
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImagePath { get; set; }

            public People(string name, string description, string imagePath)
            {
                Name = name;
                Description = description;
                ImagePath = imagePath;
            }
        }

        public People[] Peoples { get; set; } = new People[5];

        
        public void OnGet()
        {
            Peoples[0] = new People("Kim", "Verdens sødeste mand", "Kim.jpg");
            Peoples[1] = new People("Bjorn", "Sjoveste lille mand", "Bjørn.jpg");
            Peoples[2] = new People("Franz", "En rigtig bølle", "Franz.jpg");
            Peoples[3] = new People("Soren", "Han ser lidt underlig ud", "Søren.jpg");
            Peoples[4] = new People("Willi", "Han ser lidt underlig ud", "Willi.jpg");
        }
    }
}
