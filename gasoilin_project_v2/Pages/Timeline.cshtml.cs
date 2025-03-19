using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace gasoilin_project_v2.Pages
{
    public class HistoryModel : PageModel
    {
        public class TimelineEvent
        {
            public string Year { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }

            public TimelineEvent(string year, string title, string description)
            {
                Year = year;
                Title = title;
                Description = description;
            }
        }

        public List<TimelineEvent> TimelineEvents { get; set; } = new List<TimelineEvent>();

        public void OnGet()
        {
            // Populate the timeline events
            TimelineEvents.Add(new TimelineEvent("1969", "Bandets oprindelse og medlemmernes baggrund",
                "Gasolin� blev dannet i 1969 i det k�benhavnske kvarter Christianshavn af Kim Larsen, Franz Beckerlee og Wili J�nsson..."));

            TimelineEvents.Add(new TimelineEvent("1970-1971", "Musikalsk udvikling og inspirationer",
                "Gasolin�s musikalske r�dder sp�ndte bredt fra international rock til danske vise-traditioner..."));

            TimelineEvents.Add(new TimelineEvent("1971-1973", "Debut og gennembrud (1971�1973)",
                "Gasolin� fik for alvor vind i sejlene, da de overgik til danske tekster..."));

            TimelineEvents.Add(new TimelineEvent("1974-1975", "Kulmination i Danmark (1974�1975)",
                "Bandet hvilede ikke p� laurb�rrene. Senere i 1974 udsendte de �Stakkels Jim�..."));

            TimelineEvents.Add(new TimelineEvent("1976-1977", "Dr�mmen om USA og udfordringer (1976�1977)",
                "Efter Gas 5 begyndte Gasolin� at dr�mme om et internationalt gennembrud..."));

            TimelineEvents.Add(new TimelineEvent("1978", "Opl�sning og sidste koncerter (1978)",
                "Kombinationen af USA-skuffelsen, udmattelse og interne sp�ndinger blev til sidst for meget for Gasolin�..."));
        }
    }
}
