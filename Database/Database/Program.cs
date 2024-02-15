
using System;

//using Menuutje;

Console.WriteLine("1 - Gebruiker toevoegen");
Console.WriteLine("2 - Gebruiker verwijderen");
Console.WriteLine("3 - Gebruiker bewerken");
Console.WriteLine("4 - EXIT");
Console.WriteLine("Wat is uw keuze?");

//een boolean die bijhoudt of het programma moet afsluiten
bool quit = false;

//een integer om de string van de input omgezet naar een int in op te slaan
int inputInt = 0;

//instantieren van nieuwe classes
Person mijnPerson = new Person();
mijnPerson.name = "Jesse";
mijnPerson.lastName = "Wissink";
mijnPerson.address = "Hellkichen";
mijnPerson.age = 30;

//list of peepel
List<Person> peopel = new List<Person>();
peopel.Add(mijnPerson);

//terwijl quit NIET waar is
while (!quit)
{
    //lees de input en sla die op in input
    string input = Console.ReadLine();

    //probeer van de string een int te maken
    int.TryParse(input, out inputInt);

    //output wat de gebruiker heeft gekozen
    Console.WriteLine("Choice: " + inputInt);

    //afhankelijk van die int
    switch (inputInt)
    {
        case 0:
            //doen we niks
            foreach (Person person in peopel)
            {
                Console.WriteLine(person.name);
            }


            break;
        case 1:
            //gebruiker toevoegen
            Person nieuwPersoon = new Person();
            Console.WriteLine("Wat is de voornaam?");
            string nieuweInput = Console.ReadLine();
            Console.WriteLine("De gebruiker heeft ingevoerd " + nieuweInput);
            nieuwPersoon.name = nieuweInput;

            // gebruikers achternaam vragen
            //Person nieuwPersoon = new Person();
            Console.WriteLine("Wat is de aghter naam?");
            nieuweInput = Console.ReadLine();
            Console.WriteLine("De gebruiker heeft ingevoerd " + nieuweInput);
            nieuwPersoon.lastName = nieuweInput;


            // gebruikers adres vragen
            //Person nieuwPersoon3 = new Person();
            Console.WriteLine("Wat is de address ?");
            nieuweInput = Console.ReadLine();
            Console.WriteLine("De gebruiker heeft ingevoerd " + nieuweInput);
            nieuwPersoon.address = nieuweInput;


            //gebruikers leeftijd vragen
            Console.WriteLine("Wat is de leeftijd");
            if (int.TryParse(Console.ReadLine(), out int leeftijd))
            {
                Console.WriteLine("De gebruiker heeft ingevoerd " + leeftijd);
                nieuwPersoon.age = leeftijd;
            }
            else
            {
                Console.WriteLine("Dit is geen geldige leeftijd. Leeftijd wordt ingesteld op 0.");
                nieuwPersoon.age = 0;
                
            }
            peopel.Add(nieuwPersoon);
            break;
        case 2:
            //gebruiker verwijderen
            for (int i = 0; i < peopel.Count; i++)
            {
                Console.WriteLine($"{i} - {peopel[i].name}");
            }
            Console.WriteLine("Geef aan welke je wilt verwinderen");

            string verwijderInput = Console.ReadLine();
            int verwijderInputInt;

            int.TryParse(verwijderInput, out verwijderInputInt);
            if (verwijderInputInt < peopel.Count)
            {
                peopel.RemoveAt(verwijderInputInt);
            }
            break;
        case 3:
            //Gebruiker bewerken

            //eerst alle gebruikers tonen met een getal ervoor (die overeenkomt met de plek in de array)
            for (int i = 0; i < peopel.Count; i++)
            {
                Console.WriteLine($"{i} - {peopel[i].name}");
            }
            //vragen welke de gebruiker wilt bewerken
            Console.WriteLine("Welke wilt u bewerken?");
            string bewerkInput = Console.ReadLine();

            //weer de tekst omzetten naar een getal
            int bewerkInputInt;
            int.TryParse(bewerkInput, out bewerkInputInt);

            //een variabele klaarzetten van het persoon wat we willen bewerken
            Person personToEdit = peopel[bewerkInputInt];

            Console.WriteLine("Wat wilt u aanpassen?");
            Console.WriteLine("0 - Naam");
            Console.WriteLine("1 - achternaam");
            Console.WriteLine("2 - leeftijd");
            Console.WriteLine("3 - email");
            Console.WriteLine("4 - terug naar hoofdmenu");

            bewerkInput = Console.ReadLine();
            int.TryParse(bewerkInput, out bewerkInputInt);

            switch (bewerkInputInt)
            {
                case 0:
                    //naam bewerken
                    Console.WriteLine("Geef de nieuwe voornaam op");
                    personToEdit.name = Console.ReadLine();
                    break;
                case 1:
                    //achternaam bewerken
                    Console.WriteLine("Geef de nieuwe achternaam op");
                    personToEdit.lastName = Console.ReadLine();
                    break;
                case 2:
                    //leeftijd bewerken
                    Console.WriteLine("Geef de nieuwe leeftijd op");
                    int.TryParse(Console.ReadLine(), out personToEdit.age);
                    break;
                case 3:
                    //email bewerken
                    Console.WriteLine("Geef het nieuwe email op");
                    personToEdit.address = Console.ReadLine();
                    break;
                case 4:
                    //terug naar hoofdmenu
                    break;
            }
            break;

            break;
        case 4:
            //exit application
            quit = true;
            break;
        default:
            Console.WriteLine("Ongeldige input");
            //hier komt alle andere input die we niet hebben afgevangen in de cases
            break;
    }
}
// this void save was made by aiden wedema