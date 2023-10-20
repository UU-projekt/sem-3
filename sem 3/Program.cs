// hjälp-funktion som skriver ut alla element i en array
void prettyPrint<T>(T[] arr)
{
    foreach (var item in arr) Console.Write(item + ", ");
    Console.WriteLine();
}
void BelowZero(string[] arr)
{
    // denna variabel håller koll på hur många (godkända) nummer under 0 som hittats
    int numberBelowZero = 0;
    // Gå igenom alla strängar i arrayen...
    foreach (var item in arr)
    {
        // försök tyda strängen från arrayen och spara resultatet (dvs om strängen kunde tydas som nr i "couldParse")
        bool couldParse = int.TryParse(item, out int temp);

        // om strängen kunde tydas OCH temperaturen är under 0:
        if (couldParse && temp < 0)
        {
            // öka variabeln som håller koll på antalet nummer under 0 med 1
            numberBelowZero++;

            // Skriv ut nummret i konsolen! Vi använder Console.Write ist för Console.WriteLine eftersom
            // vi vill ha alla nummer på samma rad
            Console.Write(temp + " ");
        }
    }

    // Skriv ut antalet godkända nummer vi hittade
    Console.WriteLine("Antal: " + numberBelowZero);
}

BelowZero(new string[] { " 21 ", " 16 ", " 0 " });
BelowZero(new string[]{ " 14 " , " 11 " , " -2 " , " -5 " , " minus fyra " });

int[] IndexesOfChar(string s, char c)
{
    // skapar en temporär array som är lika lång som själva strängen
    // eftersom vi inte på förhand kan veta hur många av den valda bokstaven som förekommer
    // så instansierar vi en array som är så lång som den maximalt behöver vara
    int[] temp = new int[s.Length];

    // skapa en nummervariabel som håller koll på hur många gånger vi stöter på den valda bokstaven
    int nrEncountered = 0;

    // Gå igenom alla tecken i strängen (en sträng är i grund och botten en array av bokstäver)
    for(int i = 0; i < s.Length; i++)
    {
        // om bokstaven är det vi letar efter:
        if (s[i] == c)
        {
            // putta in den i arrayen! Vi använder i - 1 eftersom vi vill ha indexpositionen
            temp[nrEncountered] = i - 1;
            // Öka numret av bokstäver som vi hittat med 1
            nrEncountered++;
        }
    }

    // skapa en ny array som har samma längd som antalet bokstäver som vi hittade
    int[] resizedArray = new int[nrEncountered];
    // putta över elementen från den temporära arrayen till den nya
    for(int i = 0; i < nrEncountered; i++) resizedArray[i] = temp[i];

    // Vi får inte använda denna funktion men om vi fick skulle det vara smidigt att använda:
    // Array.Resize(ref temp, nrEncountered);

    // skicka tillbaka den nya arrayen till användaren
    return resizedArray;
}

int[] arr = IndexesOfChar(" Hello world . ", 'o');
int[] arr2 = IndexesOfChar(" Good afternoon , sir . ", 'o');
prettyPrint(arr);
prettyPrint(arr2);

// Ska inte ljuga vettafan hur man skulle lösa denna. Suger på matte
void EachNumberInInt(int nr)
{
    // Om numret är negativt kan vi strunta i att hantera det
    if(nr < 0) return;

    // gå från 1 -> 999999999 i steg av 10
    for (int i = 1; i < 999999999; i *= 10)
    {
        int res = nr / i;
        if (res == 0) break;
        Console.WriteLine(res % 10);
    }
}

EachNumberInInt(123456);
EachNumberInInt(8910);

// GLAD GUBBE :)