Labben har gjorts av Peter Palosaari.

# Labb 2 Ändringar
## Ändringar jag har gjort i de olika klasserna:

- OrderService.cs
   - Klassen har nu ett interface istället som förhåller sig till "Interface Segregation Principle".
   - Klassen ändrad till "Dependency Injection" så att klassen är beroende av IOrder.cs interfacet. Nu blir klassen beroende av en abstraktion IOrder.cs istället för en konkret implementation av Order.cs.
   - Metoderna SendNotifictionEmail() och LogMessage(string message) är borttagna så att klassen håller sig till "Single Responsibility Principle" och "KISS".
   - Metoden ProcessOrder() namn har förenklats till Start().
   - Metoden Start() har ingen indataparameter längre utan den sätts in konstruktorn istället med "Dependency Injection".
   - Metoden Start() är förenklad genom att If/Else-satserna har kortats ner med bibehållen funktionalitet "DRY".
   - Metoderna ProcessOrderNormally(), ProcessOrderQuickly() och ProcessOrderInLigtningSpeed() har ersatts av en metod Process() istället "DRY" och "KISS".
   - Process() metoden har samma funktionalitet som metoderna den ersatte.
- Order.cs
   -  Klassen har nu ett interface istället.
   -  Enum Status har flyttats in i klassen istället för att ligga direkt under namespacet. Detta för att enum:ets värde blir automatiskt tillgängligt när man använder sig av Order.cs klassen i exempelvis OrderService.cs klassen.
- Email.cs
   - Ny klass som ersätter metoden OrderService.SendNotifictionEmail()
- ConsoleWriteLoggingStrategy.cs
   - Ny klass som ersätter metoden OrderService.LogMessage(string message) med bibehållen funktionalitet genom att skriva till konsollen.
- StatusLogger.cs
   - Ny klass för att kunna använda sig av "Open Closed Principle" när man önskar att logga status och för att kunna använda sig av olika loggningssätt, i detta fall genom att skriva till konsollen med ConsoleWriteLoggingStrategy.cs. Klassen används av OrderService.cs och Email.cs bl. a. genom: 
      - StatusLogger _log = new(new ConsoleWriteLoggingStrategy());
      - _log.Status("Attempting to process order with ID " + _iOrder.ID);

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
