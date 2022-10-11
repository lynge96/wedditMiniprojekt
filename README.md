## Softwarearkitektur - Miniprojekt i Web API + EF. :penguin:
>Udarbejdet af Anders Ravnsbæk og Jacob Kaae
  
  
**Projektmål**

Formålet med dette projekt er at implementere en simpel kopi af Reddit.
Brugere er i stand til at oprette nye tråde, som enten er en URL (et link) eller et stykke tekst, og andre brugere kan efterfølgende kommenterer på disse tråde.
Både til trådene og kommentarerne kan brugere tilføje deres stemmer (upvote eller downvote), således at hvert spørgsmål eller svar har et antal positive eller negative stemmer.

**Funktionelle Krav**

**Forsiden**: Her vises en liste af de 50 nyeste tråde, sorteret efter dato. Herfra kan man klikke på de enkelte tråde og bliver ført over på en tråd-specifik side (beskrevet nedenfor).

**Tråd-siden**: Denne side viser en bestemt tråd. Hvis tråden er oprettet som tekst, vises teksten, ellers vises URL’en som tråden er oprettet med.

Derudover vises der metadata, så som:

    - Dato for oprettelse af tråden
    - Navn på forfatter (bruger)
    - Hvor mange stemmer tråden har.
    - Knapper til at stemme (upvote / downvote)
    
Under metadata vises alle kommentarerne. Hver kommentar består af:
  
    - Tekst
    - Navn på forfatter (bruger)
    - Dato for kommentaren
    - Hvor mange stemmer den har fået
    - Knapper til at stemme (upvote / downvote)
    
Nederst på samme side er der en form, hvor det er muligt at skrive en ny kommentar på tråden.

**Ny tråd-siden**: På denne side kan man oprette en ny tråd. En tråd oprettes med en overskrift, og enten noget tekst eller en URL. Forfatternavnet skal også angives.

**Generelt**: Alle sider bør have et link tilbage til forsiden, så brugeren nemt kan navigere rundt i app’en.
  
  
  
Projektet skal kunne bygges og køres med følgende kommandoer:
  
    $ dotnet build
    $ dotnet ef database update
    $ dotnet run




