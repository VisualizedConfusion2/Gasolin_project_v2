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
            Peoples[0] = new People("Kim Larsen", "Kim Larsen var Gasolins ikoniske forsanger, sangskriver og frontmand. Han blev født den 23. oktober 1945 i København og voksede op på Christianshavn. Hans karakteristiske stemme og evne til at skrive folkelige tekster gjorde ham til en af Danmarks mest elskede musikere. Larsen var stærkt inspireret af både amerikansk rock’n’roll og danske folkeviser, hvilket gav Gasolins musik en unik blanding af energi og poesi. \r\n\r\nEfter Gasolins opløsning i 1978 fortsatte han en succesrig solokarriere med album som Værsgo (1973) og Midt om natten (1983), hvor sidstnævnte blev et af de bedst sælgende danske album nogensinde. Han var en folkelig troubadour, som forblev populær indtil sin død i 2018. ", "Kim.jpg");
            Peoples[1] = new People("Bjorn", "Franz Beckerlee var Gasolins leadguitarist og medstifter af bandet. Han blev født den 15. august 1942 i København og var oprindeligt jazzmusiker, før han kastede sig over rockmusikken. Hans eksperimenterende og kraftfulde guitarlyd var med til at give Gasolin deres karakteristiske rå og psykedeliske kant. \r\n\r\nBeckerlee var kendt for sin intense og bluesinspirerede spillestil, der var præget af fuzz-effekter og improvisation. Efter Gasolins opløsning fortsatte han i en mere kunstnerisk retning og fokuserede på malerkunst og jazzmusik. Hans bidrag til dansk rockmusik er uomtvistelige, og han er stadig et ikon inden for dansk guitarmusik. ", "Bjørn.jpg");
            Peoples[2] = new People("Franz", "Wili Jønsson var Gasolins bassist og en af bandets primære harmonisanger. Han blev født den 27. marts 1942 og havde en stærk musikalsk baggrund, der gjorde ham til en af de mest alsidige musikere i dansk rock. Hans basgange var dynamiske og melodiske, hvilket gav Gasolins sange et solidt fundament. \r\n\r\nJønsson var også en vigtig sangskriver og kom med kreative input til bandets arrangementer. Efter Gasolins opløsning spillede han med flere andre danske kunstnere, herunder Lars Muhl og Lis Sørensen. Han forblev aktiv i musikbranchen og er anerkendt som en af de bedste danske bassister nogensinde. ", "Franz.jpg");
            Peoples[3] = new People("Soren", "Søren Berlev var Gasolins trommeslager og tiltrådte bandet i 1971, hvor han erstattede Bjørn Uglebjerg. Født den 14. maj 1950, blev han kendt for sin kraftfulde og præcise trommestil, der drev Gasolins rockede udtryk fremad. \r\n\r\nBerlevs spil var inspireret af både blues, rock og jazz, hvilket gav Gasolins musik en dynamisk rytmisk bund. Efter Gasolins opløsning fortsatte han som musiker i forskellige projekter og dannede senere Berlev’s Rock’n’Roll Hotel. Hans bidrag til dansk rock er stadig anerkendt, og han har bevaret en passion for musikken gennem hele sit liv. ", "Søren.jpg");
            Peoples[4] = new People("Willi", "Bjørn Uglebjerg var Gasolins oprindelige trommeslager og var en del af bandets tidlige år. Han blev født den 10. december 1945 og havde en baggrund som jazz- og bluesmusiker, før han blev en del af den danske rockscene. \r\n\r\nUglebjerg spillede trommer på Gasolins første studieindspilninger og var med til at forme bandets lyd i de tidlige år. Hans spillestil var mere tilbagelænet og blødere i udtrykket sammenlignet med den mere hårdtslående stil, som senere blev kendetegnende for Gasolin efter Søren Berlev overtog trommerne i 1971. \r\n\r\nEfter sin tid i Gasolin fortsatte Uglebjerg med at spille musik i forskellige sammenhænge, men han trak sig i høj grad tilbage fra rampelyset. Han døde i 2015, men hans bidrag til Gasolins grundlæggende lyd vil altid være en del af bandets historie. \r\n\r\nSelvom han kun var en del af Gasolin i den tidlige fase, var hans rolle vigtig i opbygningen af bandet, og han lagde rytme til deres første skridt mod stjernestatus i dansk rock. ", "Willi.jpg");
        }
    }
}
