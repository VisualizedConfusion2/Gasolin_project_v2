using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tinderforpets_v1;

namespace gasoilin_project_v2.Pages
{
    public class BiographyModel : PageModel
    {

        //public People peoples { set; get; }

        private People[] peoples = new People[4];



        private readonly ILogger<IndexModel> _logger;

        public People[] Peoples { get => peoples; set => peoples = value; }

        public BiographyModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        //People = new persons("kim", "Verdens sødeste kat", "https://media.tenor.com/2W3J9A-BQBgAAAAm/moves-dance.webp");

        Peoples[0] = new People("Kim", "Verdens sødeste mand", "bobdance.gif");

        Peoples[1] = new People("Kim", "Sjoveste lille mand", "waltor.jpg");

        Peoples[2] = new People("Kim", "En rigtig bølle", "download.jpg");

        Peoples[3] = new People("Kim", "Han ser lidt underlig ud", "frogultra.png");
        }
    }
}
