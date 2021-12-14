# Labb 2 Ändringar
## Ändringar jag har gjort i de olika klasserna:

- OrderService.cs
   - Klassen ändrad till Dependency Injection så att klassen är beroende av IOrder.cs interfacet. Nu blir klassen är beroende av en abstraktion IOrder.cs istället för en konkret implementation av Order.cs
   - Metoden ProcessOrder() är förenklad genom att If/Else-satserna har kortats ner med bibehållen funktionalitet (DRY).





# Labb 2

I denna laboration skall vi pröva att refaktorera lite kod efter de regler vi lärt oss hittils. 

Det är helt ok att ni jobbar i par.

## Vad är målet med laborationen?

Vi ska använda oss av hela batteriet för att refaktorera koden till lättförståelig och förvaltningsbar kod enligt
SOLID, DRY och KISS. Övriga knep för att förtydliga är också önskvärt.

## Vad är kraven för laborationen?

1. Koden ska vara lättförståelig, eller så lättförståelig som möjligt.
2. Ni ska använda minst två av de fem principerna i SOLID.
3. DRY ska användas där det passar.

## Redovisning

Skriv ihop en README.md eller README.txt och förklara kortfattat hur och varför ni har gjort eller inte gjort vad. 
Lägg även till namnen på de som gjorde i labben i denna fil.

Redovisning senast 2021-12-10

### Klassrummet
Vid tillfälle på plats. Föredras.

### Teams
Skriv till Dan så kan vi komma överrens om en tid.

### GitHub
Skicka github-länken till Dan
