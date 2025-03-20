﻿using Microsoft.AspNetCore.Mvc.RazorPages;
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
            // xtra logic space
        }
    }

    // Class to represent the content of the History page
    public class HistoryPageContent
    {
        public string Title { get; set; } // Title of the page
        public string Section1Title { get; set; } // Title of the first section
        public string Section1Content { get; set; } // Content of the first section
        public string Section1VideoUrl { get; set; } // Video URL for the first section
        public string Section2Title { get; set; } // Title of the second section
        public string Section2Content { get; set; } // Content of the second section
        public string Section2VideoUrl { get; set; } // Video URL for the second section
        public string Section3Title { get; set; } // Title of the third section
        public string Section3Content { get; set; } // Content of the third section
        public string Section3VideoUrl { get; set; } // Video URL for the third section
    }

    // Static class to provide content for the History page
    public static class HistoryContentService
    {
        public static HistoryPageContent GetHistoryPageContent()
        {
            return new HistoryPageContent
            {
                Title = "Gasolins Historie (1969–1978)",
                Section1Title = "Gasolins musikalske stil og tekster – eksempler og udvikling",
                Section1Content = "Gasolin’s musikalske stil var en unik blanding af rå rockenergi, melodisk sans og poetisk fortællelyst. De tog udgangspunkt i den klassiske rockmusik, men tilførte et dansk særpræg gennem sprog og kulturelle referencer. Anders Østergaard, instruktøren bag dokumentarfilmen Gasolin’ (2006), har beskrevet spændvidden således: “Franz kommer fra jazzscenen og går ind i rockmusikken inspireret af de lange syrede guitarsoloer – Kim Larsen vil synge sange ud fra en visetradition. Så vi har altså Jimi Hendrix kontra Osvald Helmuth”. Denne spænding mellem det psykedeliske og det folkelige gik igen i musikken. På den ene side leverede Beckerlee indimellem flammende guitarsoloer og eksperimenterende lydeffekter; på den anden side sørgede Larsen for, at sangene altid havde en kerne af enkelhed og imødekommenhed, som publikum kunne synge med på. \r\n\r\nTekster med hverdagsglimt og samfundsbid: Gasolin’s sangtekster – ofte skrevet i fællesskab af bandet med bidrag fra Mogens Mogensen – var kendt for at være uhøjtidelige, billedrige og rammende for deres tid. Larsen og co. kunne finde poesi i det dagligdags sprog; de brugte slang, humor og hverdagssituationer, så lytterne følte, at sangene talte direkte til dem. Samtidig rørte teksterne ved større temaer som social uretfærdighed, ungdomsoprør og frihedstrang. Et tidligt eksempel er “Langebro” fra debutalbummet (1971), hvor Gasolin’ maler et stemningsbillede af København en tidlig morgen. Sangen har en melankolsk, næsten blueset tone, der adskiller sig fra datidens gængse popsange, og den viser bandets evne til at skabe atmosfære og eftertanke. Et andet eksempel er “Snehvide” fra Gasolin’ 2 (1972), hvor bandet leger med eventyrfiguren Snehvide i en moderne kontekst – teksten kan tolkes som en kommentar til kvindens rolle og idealer i samfundet, pakket ind i Gasolins lune humor. På Gasolin’ 3 (1973) finder man “På banen (Derudaf)” og “Som et strejf af en dråbe”, som begge kombinerer fængende omkvæd med lyriske billeder, der kan læses på flere niveauer. Gasolin’ mestrede både det enkle og det dybe: “Kvinde min” er f.eks. en umiddelbart simpel kærlighedserklæring, men den fremføres med en inderlighed og et guitarhook, der har gjort den tidløs. \r\n\r\nRock and roll med dansk glimt i øjet: Musikalsk spænder Gasolins produktion fra hård rock over i blødere ballader. I den ene ende af spektret har vi numre som “Rabalderstræde” (1975) med sin hurtige boogie-rytme, drivende guitar og feststemning. Det er rock and roll for fuld udblæsning – en dansk pendant til Rolling Stones-agtig energi – men teksten foregår på et fiktivt dansk gadenavn og emmer af lokal tone. Publikum kunne danse og synge med på “Der er ballade på Rabalderstræde”, som blev et slogan for ubekymret natteliv. I den anden ende er der eftertænksomme sange som “Masser af succes” fra samme album, hvor Gasolin’ med et glimt i øjet filosoferer over berømmelsens væsen netop som de selv stod midt i den. Også “Denne her gang” og “Bella Donna” fra de senere albums viser Gasolin’s evne til at skrive flotte ballader og akustiske viser inden for rockformatet. Fælles for Gasolins musik er, at melodierne er stærke og sangbare, hvad enten tempoet er højt eller lavt. Dette gjorde, at sangene bed sig fast hos lytterne. Tekstmæssigt blandede de gadejargon med poetiske billeder – fra “GI’ gas” og “masser af succes” til linjer som “Det er en kold tid vi lever i” fra “Det er en kold tid” (skrevet til Christiania-pladen 1976). Sidstnævnte linje blev endda citeret af statsminister Anker Jørgensen i hans nytårstale i 1979 som kommentar til samfundets tilstand, hvilket understreger, hvor dybt Gasolins ord var trængt ind i dansk bevidsthed. Gasolin’s musikalske stil udviklede sig over årene: de tidlige 70’ere var præget af en vis psykedelia og eksperimenteren (f.eks. det drømmende nummer “Tremastet beton”), mens midten af 70’erne bød på strammere, rockede arrangementer og større produktion under Roy Thomas Baker. Mod slutningen forsøgte de sig med mere internationalt orienterede rockarrangementer på deres engelsksprogede sange, dog uden at miste det særlige “Gasolin-touch” – en blanding af humor, melodi og kant. \r\n\r\nBetydning for dansk ro",
                Section1VideoUrl = "https://www.youtube.com/embed/ROSYkEQY2sA",
                Section2Title = "Betydning for dansk rockmusik",
                Section2Content = "Gasolin’s indflydelse på dansk rock kan næppe overvurderes. I 1970’erne var de intet mindre end landets største rockband, ofte kaldt “70’ernes absolut mest populære danske rockorkester”. De bragte rockmusikken ind i danskernes hjerter på modersmålet og beviste, at man kunne have rock med dansk sjæl og stadig opnå massetække. Nogle har ligefrem sammenlignet Gasolin’ med The Beatles i dansk kontekst – hvert album var en begivenhed, og bandet opløstes på toppen af deres succes ligesom Beatles. Gasolin’ var med til at åbne døren for utallige andre danske rocknavne ved at vise, at det danske sprog ikke behøver at være en barriere, men tværtimod kan være en styrke. Bands som Shu-bi-dua, der opstod parallelt, og senere kunstnere som Gnags, TV-2 og Magtens Korridorer har alle nydt godt af den vej, Gasolin’ banede med dansksproget rock til folket. \r\n\r\nUd over deres musikalske eftermæle efterlod Gasolin’ også en mytologi. Fortællingen om det vilde band, de interne kampe mellem Larsen og Beckerlee, de store drømme og bratte opbrud – alt dette har gjort Gasolin’ til et særligt kapitel i dansk kulturhistorie. Der er skrevet biografier og lavet film om dem, og selv folk der ikke var født i 70’erne, kender navnene på deres hits. Gasolin’ blev folkeeje, som det ses af at sange som “Kvinde min” og “This Is My Life” (engelsk version af “Hvis du tør”) ofte spilles til fester, på barer og i radioen den dag i dag. I den danske kulturkanon har Gasolin’ også sat aftryk – livepladen Live Sådan (1976) er optaget i Kulturkanonen som et væsentligt værk. Bandet opnåede med årene nærmest en status af nationalklenodie, og deres historie fortælles igen og igen for nye generationer. \r\n\r\nEfter opløsningen fortsatte medlemmerne hver deres vej, men ikke uden at trække tråde til Gasolin’s arv. Kim Larsen startede en forrygende solokarriere og udsendte i 1983 albummet Midt om natten, der blev den bedst sælgende plade i Danmarks historie. Det album – og Larsens øvrige soloarbejde – bar tydelige spor af Gasolin’s folkelige rockstil, omend i en mere afdæmpet form. Wili Jønsson og Søren Berlev fortsatte som musikere i forskellige sammenhænge og som eftertragtede studiemusikere, mens Franz Beckerlee trådte et skridt tilbage fra rampelyset og helligede sig kunsten (dog med lejlighedsvise musikalske projekter, bl.a. Christianhavns Bluesband). Ingen af dem nåede dog op på siden af Gasolin’s kollektive gennemslagskraft hver for sig – Gasolin’s magi lå i sammenspillet. Trods mange tilbud sagde de nej til gendannelser, da de ønskede at bevare myten intakt. Dermed forblev Gasolin’ et frossent billede på 70’ernes storhedstid i dansk rock, upåvirket af comeback-forsøg eller nutidige tendenser. ",
                Section2VideoUrl = "https://www.youtube.com/embed/NSYf4mbaGUI",
                Section3Title = "Gasolins arv og musikken i dag",
                Section3Content = "Selvom Gasolin’ officielt ophørte i 1978, lever deres musik i bedste velgående. Bandet har gentagne gange oplevet fornyet interesse, og nye udgivelser med gammelt materiale har toppet hitlisterne længe efter deres tid. Et markant eksempel er opsamlingsboksen The Black Box, som blev udgivet i 2003 og indeholdt alle deres originale danske album på CD. The Black Box lå mere end 100 uger på den danske Top 40 og solgte omkring 150.000 eksemplarer  \r\n\r\n \r\n\r\n– et tal der vidner om, at Gasolin’s sange stadig finder vej til nye lyttere. I 2006 udsendtes dokumentarfilmen Gasolin’ (også kendt som Gasolin’ 4-ever) af Anders Østergaard, og den blev den mest sete dokumentarfilm i dansk filmhistorie. Filmen fascinerede både gamle fans og et ungt publikum, der her fik historien om “Gudernes danske børn” (som en bogtitel kalder dem) serveret med originale klip og ærlige interviews. Succesen understregede, at interessen for Gasolin’ langt fra var uddød. Også i udlandet har Gasolin’s musik sat spor, især i Skandinavien. I 2009 – 31 år efter deres opløsning – lå Gasolin’ pludselig nummer 1 på den svenske albumhitliste. Det skete med dobbeltalbummet Masser Af Succes – Greatest Hits & Greatest Live, som samlede deres bedste studie- og liveoptagelser. Albummet solgte 23.000 eksemplarer i Sverige og indbragte Gasolin’ en guldplade i nabolandet. At et dansk rockband fra 70’erne kan toppe hitlisterne i 2009, siger noget om den vedvarende styrke i deres musik. I Danmark udkom samme opsamling, og også her var modtagelsen varm – ligesom den havde været for tidligere kompilationsalbums som Rabalderstræde Forever (1991). Derudover lever Gasolins sange videre gennem utallige coverversioner og hyldestkoncerter. Hvert år spilles der Gasolin-tribute shows, teaterkoncerter har dedikeret hele forestillinger til deres musik, og unge bands lader sig inspirere af Gasolins ligefremme rockstil og danske lyrik. \r\n\r\nI dag er Gasolin’s musik en integreret del af dansk populærkultur. Man kan næppe tænde for en dansk radio uden før eller siden at høre en Gasolin’-klassiker som “Hvad gør vi nu, lille du?”, “Strengelegen” eller “Masser af succes”. Deres albums bliver ved med at genopstå i nye formater – remasterede udgaver, streaming-playlister, vinyl-genoptryk til samlere osv. – og hver generation finder deres egen vinkel på Gasolin’. Mange af Kim Larsens solo-koncerter gennem årene bød også på et par Gasolin-numre, til stor jubel for publikum, hvilket har været med til at holde sangene i live. Gasolin’s arv kan mærkes i sproget (udtryk fra deres tekster er blevet folkeeje), i musikken (den danske rocktradition de var med til at grundlægge) og i folks hjerter. Gasolin’s musik lever videre – på anlæg og scener, i gader og stræder – som soundtracket til en svunden tid, der stadig føles relevant. Som bandet selv synger i “Denne her gang”: “Lykken den kommer, lykken den går, men sangen den lever…” – og Gasolins sange lever i allerhøjeste grad videre den dag i dag. ",
                Section3VideoUrl = "https://www.youtube.com/embed/ANOTHER_VIDEO_ID"
            };
        }
    }
}