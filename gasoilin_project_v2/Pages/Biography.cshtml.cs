using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tinderforpets_v1;

namespace gasoilin_project_v2.Pages
{
    public class BiographyModel : PageModel
    {

        //public People peoples { set; get; }

        private People[] peoples = new People[5];



        private readonly ILogger<IndexModel> _logger;

        public People[] Peoples { get => peoples; set => peoples = value; }

        public BiographyModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        //People = new persons("kim", "Verdens s�deste kat", "https://media.tenor.com/2W3J9A-BQBgAAAAm/moves-dance.webp");

        Peoples[0] = new People("Kim", "Verdens s�deste mand", "Kim.jpg");

        Peoples[1] = new People("Bj�rn", "Sjoveste lille mand", "Bj�rn.jpg");

        Peoples[2] = new People("Franz", "En rigtig b�lle", "Franz.jpg");

        Peoples[3] = new People("S�ren", "Han ser lidt underlig ud", "S�ren.jpg");

        Peoples[4] = new People("Wili", "Han ser lidt underlig ud", "Willi.jpg");
        }
    }
}
