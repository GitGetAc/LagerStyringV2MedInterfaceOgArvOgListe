namespace LagerStyringV2MedInterfaceOgArvOgListe
{
    internal class Program
    {
        static void Main()
        {
            //Lage Instanse av Lager classen og MenyUI
            Lager lager = new Lager();
            MenyUI menyUI = new MenyUI();

            //Lage instanser av de andre objektene //Initial lagerbeholdning
            Klær klær1 = new("T-shirt", 45.889, "M");
            Klær klær2 = new("Skirt", 8778.889, "XS");

            Matvare matvare1 = new("Ost", 100, "06.12.2025");
            Matvare matvare2 = new("Kjøtt", 150, "01.03.2024");

            Elektronikk elektronikk1 = new("Radio", 199, 12);
            Elektronikk elektronikk2 = new("CDSpiller", 399, 60);
            Elektronikk elektronikk3 = new("Fjern meg", 500, 24);

            //Legge til objektene inn på lageret gjennom lager metodene (som legger til objektene i en liste av lager objekter)
            lager.LeggeTilEtProdukt(klær1);
            lager.LeggeTilEtProdukt(klær2);
            lager.LeggeTilEtProdukt(matvare1);
            lager.LeggeTilEtProdukt(matvare2);
            lager.LeggeTilEtProdukt(elektronikk1);
            lager.LeggeTilEtProdukt(elektronikk2);
            lager.LeggeTilEtProdukt(elektronikk3);

            //Fjerne ett produkt fra lageret
            lager.FjernEtProdukt(elektronikk3);

            //ListeAlleProdukter inn i lageret med header og footer
            lager.ListeAlleProdukter();


            ////////////////////////////////Ez a kezdeti lagerbeholdning, de innentøl szetszdtuk modularisra a progit///////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            menyUI.HovedMeny();
            






            //Ott tartottam, hogy nem tudom rendesen szetszedni a usermenut Main() tøl, hogy a Lager() metodusait tudjam hasznalni a main() ben is es a MenyUi-ban is, szerintem az egeszet a Main() be kene rakni, ugy hogy a Program classban øsszegezzuk metodusokban a 2 class metodusait, holnap foltatjuk.


            //Folytatjuk a user input bekeressel, a menu elkeszitesevel, arv-olassal (kulønbøzø tipusu matvarek), tøbb property hozzaadasa, listazasok, filtreringek stb. 


        }
    }
}

/*Din oppgave er å utvikle et enkelt lagerstyringssystem ved hjelp av C# og grensesnitt. Lagerstyringssystemet skal håndtere forskjellige typer produkter og ha funksjonalitet for å legge til, fjerne og liste opp produkter.


Del 1: Interface


Lag et grensesnitt kalt IProdukt med følgende medlemmer:


public interface IProdukt
{
    string Navn { get; set; }
    double Pris { get; set; }

    void SkrivUtInfo();
}

Del 2: Klasser

Implementer tre klasser som implementerer IProdukt-grensesnittet:

    Elektronikk:
        Egenskap: Garantitid (i måneder).


    Matvare:
        Egenskap: Utløpsdato.


    Klær:
        Egenskap: Størrelse.


Del 3: Lagerstyringssystem


Lag en klasse Lager som inneholder en liste av IProdukt. Implementer følgende funksjonalitet:

    Metode for å legge til et produkt i lageret.
    Metode for å fjerne et produkt fra lageret.
    Metode for å liste opp alle produkter i lageret.


Del 4: Hovedprogram (Main)


I hovedprogrammet, gjør følgende:

    Opprett en instans av Lager.
    Opprett minst to instanser av hver produkttype (Elektronikk, Matvare, Klær) og legg dem til i lageret.
    Fjern et produkt fra lageret.
    List opp alle gjenværende produkter i lageret.*/
