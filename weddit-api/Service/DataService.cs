
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Data;
using shared.Model;
using System;

namespace weddit_api.Service
{
    public class DataService
    {
        private PostContext db { get; }

        public DataService(PostContext db)
        {
            this.db = db;
        }

        /// <summary>
        /// Seeder noget nyt data i databasen hvis det er nødvendigt.
        /// </summary>
        public void SeedData()
        {
            Random rnd = new Random();

            User user = db.Users.FirstOrDefault()!;
            if (user == null)
            {
                db.Users.Add(new User("Jacob"));
                db.Users.Add(new User("Anders"));

            }

            Post post = db.Posts.FirstOrDefault()!;
            if (post == null)
            {
                db.Posts.Add(new Post { Date = DateTime.Parse("10/08/2022 07:22:16"), Votes = rnd.Next(-500,3000), Title = "To læk på Nordstream 1", User = new User("Lars"), Text = "Der er sgu gået hul på noget, OBS: ik sejl over, I synker!!!", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("01/10/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Hvorfor er bajer godt for dig?", User = new User("Katrine"), Text = "Det er fordi, at de smager pisse godt, og så kan det godt være, at du får det dårligt i et stykke tid efter, men det er worth", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("01/02/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Det absolut billigste kollegieværelse på nyt kollegie i njalsgade, Amager er 7.500 kr/md for 28m² uden sollys.", User = new User("Thomas"), Text = "i.imgur.com/7zVxBCK.jpg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("12/02/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Poor Danish familie can't afford car and have have to bike to get around, 2022", User = new User("Morten"), Text = "i.imgur.com/eUjfcre.jpg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("09/02/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Svært valg", User = new User("Abinash"), Text = "i.imgur.com/B8eCaxm.jpg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("03/03/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Hvordan holder i frokosten på arbejdet ud?", User = new User("Denis"), Text = "Hej scootergalleri\nJeg har et problem (first world problem x10000) som jeg håber andre også har (haft) og dermed kan hjælpe mig til hvad hulan jeg gør.\nJeg hader frokostpausen på mit arbejde. Lige siden jeg indtrådte på arbejdsmarkedet efter endt uddannelse har jeg hadet frokostpausen. Hele seancen i minutterne op til middag hvor folk på skift råber \"nååå det er vel ved at være tid\" til at sidde og småsnakke med mine kollegaer om komplet ligegyldige ting mens jeg indtager den tvivlsomme omgang mad jeg har fået blandet på min tallerken i buffeten. Det er det samme i alle 3 virksomheder jeg nu har været i og jeg hader det.\nMisforstå mig ikke, jeg hader ikke mine kollegaer. De er flinke og jeg kan også sagtens deltage i snakken henover skrivebordet. Men i frokostpausen slapper jeg simpelthen ikke af i de 30 minutter der egentlig er tiltænkt til netop det. Hvis jeg kan finde den mindste undskyldning for lige at køre ud og \"ordne\" noget i frokostpausen så gør jeg det. De der 20-25 minutter i bilen for mig selv er himmelske.\nSå mit spørgsmål: Er der andre som har det på samme måde som mig? Og som har fundet en måde at håndtere det på? Jeg overvejer at gå til chefen med mine bekymringer men jeg er bange for at det bliver set som en utrolig negativ ting at jeg ikke vil bruge tid med mine kollegaer.", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("01/03/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Min roomie kommer ketchup på ALT", User = new User("Anna"), Text = "Altså jeg ved ikke, om det er noget, som I kan relatere til, men er det seriøst normalt at der skal ketchup på alt? Har prøvet at sige til dem, at det ikke er almindeligt, men de køber den ikke!!!", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("02/04/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Min yndlings pizza er hawaii", User = new User("Victor"), Text = "- sagde en psykopat engang, LOL", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("04/01/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "JONAS Fucking VINGEGAARD", User = new User("Tobias"), Text = "i.redd.it/r2o9rvs675e91.png", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("12/05/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "VM i herrefodbold", User = new User("Kasper"), Text = "Hvem tror I vinder??", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("06/05/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Inger efter 60 dage i kachotten", User = new User("Mette Kirstine"), Text = "i.redd.it/346ki0798b581.jpg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("07/06/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Jeg nægter at sætte vinterdæk på bilen. Det er min bil, mit valg, min frihed.", User = new User("Wiliam"), Text = "Effekten af ​​vinterdæk er ikke bevist, undtagen af ​​undersøgelser udført af producenterne selv.\nMin nabo kom ud for en ulykke efter at have sat sine vinterdæk på.\nNogle er allerede på deres tredje sæt dæk, hvilket beviser deres ineffektivitet.\nVi ved ikke, hvad de er lavet af.\nDækgiganterne skræmmer os om vinteren bare for at berige sig selv.\nFaktisk opfandt dækgiganterne sne og spreder den om natten, mens du sover.\nHvis jeg køber vinterdæk, kan regeringen spore mig i sneen.\nUddan dig selv, åbn dine øjne, stop med at være et får!\nI år siger jeg NEJ , til vinterdæk.", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("06/01/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Er jeg den eneste?", User = new User("Sebastian"), Text = "i.redd.it/n58qsy9sd5481.jpg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("09/07/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Hvad sagde blondinen, da hun gik ind i døren?", User = new User("Mikkel"), Text = "Av XD", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("10/07/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Hvordan laver man en surdej", User = new User("Allan"), Text = "Jeg har prøvet alt muligt, men den lugter bare af sur røv???", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("11/08/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Dannebrog i ukrainske farver", User = new User("Mathias"), Text = "https://external-preview.redd.it/YtqDvjsuXZH2BrexpuWJlQe9yCW3WwxsY-yquLTZBm4.jpg?auto=webp&s=523c7f3bd59d67f4d769ec864a1b773cb4831464", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("08/08/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Hør lige den nye VM sang!!", User = new User("Frederik"), Text = "www.youtube.com/watch?v=ryvOkYkasZo", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("09/02/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "As an immigrant, I'll never complain about Danish taxes", User = new User("Jakob"), Text = "I'm an American recently moved to Denmark with my Danish wife. Before we moved, I audibly exhaled looking at our prospective taxes online.\nBut the very day I got my CPR number, I had unexplainable chest pain and shortness of breath. I tried to ignore it because you only call for help in the US when you want to voluntarily bankrupt yourself. The ambulance alone would have cost me $1000 or more. But after 8 hours, I finally had my wife call. (Do not wait this long, you could easily die!) My last words before going were, \"It's free, right?\"\nEven when I got there, I was ready for them to dismiss me, as a relatively young 30 year old with heart trouble. When they asked for my medical history, I had to explain I couldn't afford one. My side of the family has a million stories about conditions missed, misdiagnosed, or dismissed out of hand. But I'm here on my third day now, being given every test under the sun, just to be on the safe side. It makes me feel so much better to be validated and truly cared for by professionals.\nEven the little things, like visiting hours, are all day! I can't tell you all how thankful I am that Denmark supported me before I could even chip in my part, but I can share it with you nice people. Thank you!", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("02/09/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Sådan husker jeg folkeskolen i 90erne", User = new User("Tina"), Text = "i.redd.it/9bwd4ujarrn81.jpg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("03/10/2021 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Hvordan får man en fisk til at grine???", User = new User("Gunner"), Text = "Man propper den i KILDEvand heh", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("10/10/2021 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Bernie Sanders bruger Danmark som eksemple :)", User = new User("Lucca"), Text = "i.redd.it/8blg9g8xcwx41.png", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("11/05/2021 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Sweden. swedish flag. DANSKERE UNITE! like dettte flag så at det vil komme op når at folk søger på sweden.", User = new User("Bent"), Text = "Tror ik det virker, men prøv at gøre det alligevel", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("11/04/2021 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Det er Valdemarsdag, mine lyndanisser!", User = new User("Bo"), Text = "i.redd.it/sf19zmool3411.png", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Now, Title = "Diskussion: er der flere hjul end døre i verden?", User = new User("Børge"), Text = "Jeg tror hjul", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("04/12/2021 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Sådan retfærdige gøre jeg at være broke", User = new User("Pernille"), Text = "i.imgur.com/lUPoR0E.jpeg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("05/12/2021 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Hvordan laver man et avocado træ??", User = new User("Maria"), Text = "Kan ik finde ud af det, skal man spise den først eller hva??", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("06/01/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Kender I det haha", User = new User("Mohammed"), Text = "i.imgur.com/hXL16Il.jpeg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("07/01/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Hvad er forskellen på en string og en integer", User = new User("Burat"), Text = "Er dum til programering, send help pls", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("08/02/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Grunden til jeg sov for længe i morges..", User = new User("Mahmoud"), Text = "i.imgur.com/borfbNN.jpeg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("03/04/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Hvad kalder man en hund der kan trylle?", User = new User("Ella"), Text = "En labracadabrador!!", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("04/11/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Relateable efter en bytur", User = new User("Ali"), Text = "i.imgur.com/EgWoO0g.jpeg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("09/05/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Min opvasker er stoppet...", User = new User("Tony"), Text = "Viceværten siger, at vi selv skal betale, men vi bor til leje - kan det så virkeli passe?", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("10/06/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Nyd friheden venner", User = new User("Christian"), Text = "i.imgur.com/pKfiVLa.jpeg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("11/07/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Må hunde godt skide ude foran lejligheder, hvis man samler op?", User = new User("Ane"), Text = "Der var en mand, som råbte efter mig i dag, da min hund Lucca sked tæt på en dør. Men vi samlede det op, og man kan jo ligesom ikke sige til en hund, at den skal stoppe med at skide, når den gerne vil", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("08/01/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Når man laver projekt på ITA", User = new User("Cecilie"), Text = "i.imgur.com/1OF9ihQ.jpeg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("09/09/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Mcd's cheeseburger stiger med to kr.", User = new User("Lisbeth"), Text = "DET ER GODT NOK NOGET GRIS", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("12/10/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "RIP os på SU", User = new User("Hans"), Text = "i.imgur.com/8OvZxoF.jpeg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("01/11/2021 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Flere og flere unge bliver afhængige af alkohol", User = new User("Amanda"), Text = "I det mindste er det ikke stoffer ROFL", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("02/12/2021 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Kender I den kollega...???", User = new User("Sisse"), Text = "i.imgur.com/v2eFOhH.jpeg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("03/01/2021 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Erhvervsakademiet åbner ny prof. bachelor", User = new User("Magnus"), Text = "Den hedder ITA og den er faktisk ok nice", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("02/12/2021 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Livet som voksen", User = new User("Jonas"), Text = "i.imgur.com/JGuwNC3.jpeg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("03/01/2021 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Ung fyr på 23 år anholdt i Italien for tyveri", User = new User("Patrick"), Text = "Han havde stjålet en sneryder, et skilt, en dørmåtte og en aflang påtteplante. Men så fik politiet fat i ham, og fik ham til at aflevere det hele tilbage.... A for effort tho", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("04/04/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "SÅDAN skal toiletpapirsrullen stå", User = new User("Sofie"), Text = "i.imgur.com/6uA71cA.jpeg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("05/05/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Hvordan brygger man en god kop kaffe?", User = new User("Olivia"), Text = "Jeg har lige købt en ny espressomaskine, men ærligt, latte-art er SVÆRT", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("06/06/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Efter en lang dag bag kassen på arbejde", User = new User("Stine"), Text = "i.imgur.com/URO9cwc.jpeg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("07/07/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Kan man godt reklamere over sko der er beskidte", User = new User("Mikki"), Text = "Havde dem godt nok med på floor, men altså, de bliver FANDME ikke rene igen og det er for dårligt og slet ikke min skyld. MENINGER?", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("09/08/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Er det kun mig der dumper de her hver gang??", User = new User("John"), Text = "i.imgur.com/EV4WvO0.jpeg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("09/07/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Er jeg woke", User = new User("Rasmus"), Text = "Jeg ser nemlig ikke køn eller hudfarve kun personer. Tror jeg er woke", TextIsLink = false });
                db.Posts.Add(new Post { Date = DateTime.Parse("10/08/2022 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Det ligner Doctor Strange det her", User = new User("Alberte"), Text = "i.imgur.com/smf67wT.jpeg", TextIsLink = true });
                db.Posts.Add(new Post { Date = DateTime.Parse("11/09/2021 01:01:01"), Votes = rnd.Next(-500, 3000), Title = "Vinterbadning er for nedern", User = new User("Klara"), Text = "Det er jo mega koldt, hvorfor gider folk det overhovedet??", TextIsLink = false });
            }

            db.SaveChanges();

            Comment comment = db.Comments.FirstOrDefault()!;
            if (comment == null)
            {
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Jacob"), Text = "Det lugter russisk", PostId = 1, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Anders"), Text = "Stakkels fisk", PostId = 1, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Lars"), Text = "Jeg har tømmermænd nu. hader bajer", PostId = 2, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Katrine"), Text = "Øllllll", PostId = 2, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Thomas"), Text = "Hvis bare man var studerende, hva", PostId = 3, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Morten"), Text = "Life pro tips: bo udenfor det er gratis", PostId = 3, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Abi"), Text = "Hahaha", PostId = 4, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Dennis"), Text = "ROFL", PostId = 4, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Anna"), Text = "Totalt", PostId = 5, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Victor"), Text = "Jeg ville ikke kunne vælge", PostId = 5, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Tobias"), Text = "Jeg har bare ik et arbejde", PostId = 6, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Kasper"), Text = "Spis hjemmefra??", PostId = 6, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Mette Kirstine"), Text = "I det mindste er det ikke remo", PostId = 7, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Willy"), Text = "Så længe det er Heinz", PostId = 7, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Seb"), Text = "Jeg propper altid majs på", PostId = 8, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Kim"), Text = "Det er sgu da fucker godt", PostId = 8, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Mikkel"), Text = "Fire fire fire fire nuuuuul", PostId = 9, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Frederik"), Text = "Er han var håndbold", PostId = 9, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Tobias"), Text = "Hepper på Tunesien", PostId = 10, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Asta"), Text = "Dunno", PostId = 10, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Pernille"), Text = "Hun ser altså ret bekendt ud", PostId = 11, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Jacob"), Text = "Er ik gammel nok til at stemme", PostId = 11, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Tina"), Text = "De er også røvdyre", PostId = 12, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Gunner"), Text = "Så glider du da rundt??", PostId = 12, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Lucca"), Text = "Nej også mig", PostId = 13, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Mogens"), Text = "Kan ik relatere", PostId = 13, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Vivi"), Text = "LOL", PostId = 14, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Birhte"), Text = "Godt man er brunette hehe", PostId = 14, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Bent"), Text = "Step 1: Lad være", PostId = 15, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Bo"), Text = "Du skal huske at give den mad", PostId = 15, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Børge"), Text = "RIP Ukraine", PostId = 16, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Bibbi"), Text = "Jeg købte et støt ukraine armbånd, så har gjort min del", PostId = 16, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Pernille"), Text = "Okay, en banger", PostId = 17, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Maria"), Text = "Dårlig sang", PostId = 17, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Muhammad"), Text = "Jeg forstår ik engelsk, kan nogen oversætte", PostId = 18, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Burrat"), Text = "Godt for dig", PostId = 18, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Mahmoud"), Text = "Jeg blev født i 2000", PostId = 19, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Ella"), Text = "Gamle nisser", PostId = 19, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Ali"), Text = "Så flyder den da op??", PostId = 20, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Christian"), Text = "xD", PostId = 20, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Tony"), Text = "Legenden", PostId = 21, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Kristian"), Text = "Bernie 4 prez", PostId = 21, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Ane"), Text = "GO DANMARK", PostId = 22, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Hanne"), Text = "LÅLÅLÅ", PostId = 22, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Hans"), Text = "Juhuuu", PostId = 23, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Simba"), Text = "Forstår ik", PostId = 23, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Frost"), Text = "Jeg tror døre", PostId = 24, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Jesus"), Text = "Jeg tror der er lige mange af hver", PostId = 24, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Cecilie"), Text = "SU LIFE", PostId = 25, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Lisbeth"), Text = "Tag da et kvicklån", PostId = 25, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Hans"), Text = "Den skal vist i vand", PostId = 26, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Amanda"), Text = "Prøv at lægge den ned i et hul med jord", PostId = 26, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Sisse"), Text = "Nej", PostId = 27, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Maria"), Text = "Jeg kender, hahaha", PostId = 27, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Magnus"), Text = "Noget med tal", PostId = 28, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Jonas"), Text = "Noget med bogstaver", PostId = 28, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Patrick"), Text = "Køb en ægte alarm, jezzz", PostId = 29, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Sofie"), Text = "Jeg vågner altid bare til solen, det sutter om vinteren tho", PostId = 29, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Sofia"), Text = "Magisk vuffer", PostId = 30, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Jannick"), Text = "Hahahahah", PostId = 30, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Astrid"), Text = "Elsker byen", PostId = 31, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Kia"), Text = "Har I været i gaden før???", PostId = 31, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Olivia"), Text = "Fuck viceværter", PostId = 32, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Stine"), Text = "Så må du jo vaske op i hånden...", PostId = 32, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Mikki"), Text = "Tak", PostId = 33, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Johm"), Text = "Forstår ik", PostId = 33, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Sasha"), Text = "Det må de da godt", PostId = 34, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Kirstine"), Text = "SAMMEL NU OP", PostId = 34, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Krestine"), Text = "Hvad er ITA", PostId = 35, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Nanna"), Text = "Har IT arkitektur noget med bygninger at gøre egentlig", PostId = 35, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Clara Maria"), Text = "Ja boycut lortet", PostId = 36, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Kald mig Bo"), Text = "Elsker ost hahaha", PostId = 36, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Rasmus"), Text = "Hvad står SU for", PostId = 37, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Klara"), Text = "Glæder mig til at blive gammel nok til at få su", PostId = 37, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Alberte"), Text = "ja ahahaha", PostId = 38, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Morten"), Text = "Min mor siger coke er skidt", PostId = 38, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Gustav"), Text = "Ja ahha", PostId = 39, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Celine"), Text = "Det er Bo fra mit job", PostId = 39, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Silje"), Text = "Jeg er fan", PostId = 40, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Mark"), Text = "Synes ham Kristian er en mega nice lærer", PostId = 40, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Susan"), Text = "Tough life", PostId = 41, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Mie"), Text = "Hahhahahaahhaahaha", PostId = 41, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Kris"), Text = "Den bandit", PostId = 42, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Kapper"), Text = "Han er sikkert lækker IRL", PostId = 42, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Torben"), Text = "Det er løgn", PostId = 43, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Tina"), Text = "Død over dig din troll", PostId = 43, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Bjørn"), Text = "Prøv instant coffee det er mums", PostId = 44, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Lissie"), Text = "Jeg har en med kapsler", PostId = 44, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Dagmar"), Text = "Tak for din service", PostId = 45, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Henning"), Text = "Jeg bor tæt på to rema1000", PostId = 45, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Marianne"), Text = "Nej du kan da ej", PostId = 46, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Delan"), Text = "Jo du kan da så gogogoog", PostId = 46, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Amani"), Text = "Ja", PostId = 47, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Sofie"), Text = "ogs mig AHAH", PostId = 47, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Nafisa"), Text = "Ja sygt woke bro", PostId = 48, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Iman"), Text = "Hvad er woke", PostId = 48, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Kristian"), Text = "Ja han er god til at trylle", PostId = 49, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Thorkild"), Text = "Mums hapshaps", PostId = 49, Votes = rnd.Next(-5, 100) });

                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Dennis"), Text = "Det er kun folk der mangler kant der gør sådan noget", PostId = 50, Votes = rnd.Next(-5, 100) });
                db.Comments.Add(new Comment { Date = DateTime.Now, User = new User("Kristoffer"), Text = "Tror de prøver at fange fisk", PostId = 50, Votes = rnd.Next(-5, 100) });

            }

            db.SaveChanges();
        }

        // Hent alle posts til forsiden
        public List<Post> GetPosts()
        {
            return db.Posts.Include(x => x.User).Include(x => x.Comments).ToList();
        }

        // Hent en specifik post
        public Post GetPost(int postId)
        {
            Post post = db.Posts.Include(x => x.User).Include(x => x.Comments).Where(x => x.PostId == postId).First();

            List<Comment> kommentarer = db.Comments.Include(x => x.User).Where(x => x.PostId == postId).ToList();

            post.Comments = kommentarer;

            return post;
        }

        // Tilføjer en kommentar
        public string AddComment(Comment newComment)
        {
            db.Comments.Add(new Comment { Date = DateTime.Now, User = newComment.User, Text = newComment.Text, PostId = newComment.PostId });

            db.SaveChanges();

            return "New comment added";
        }

        // Tilføjer en post
        public string AddPost(Post newPost)
        {
            db.Posts.Add(new Post { Date = DateTime.Now, Title = newPost.Title, Text = newPost.Text, User = newPost.User, TextIsLink = newPost.TextIsLink });

            db.SaveChanges();

            return "New post added";
        }

        // Tilføjer en stemme til en post
        public string AddVotePost(int postId, bool vote)
        {
            if (vote == true)
            {
                Post post = db.Posts.Where(x => x.PostId == postId).First();

                post.Votes++;
            }
            else if (vote == false)
            {
                Post post = db.Posts.Where(x => x.PostId == postId).First();

                post.Votes--;
            }

            db.SaveChanges();

            return "Vote added";
        }

        // Tilføjer en stemme til en kommentar
        public string AddVoteComment(int commentId, bool vote)
        {
            if (vote == true)
            {
                Comment comment = db.Comments.Where(x => x.CommentId == commentId).First();

                comment.Votes++;
            }
            else if (vote == false)
            {
                Comment comment = db.Comments.Where(x => x.CommentId == commentId).First();

                comment.Votes--;
            }

            db.SaveChanges();

            return "Vote added";
        }


    }

}


