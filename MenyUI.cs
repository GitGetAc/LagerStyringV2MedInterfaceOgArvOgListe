namespace LagerStyringV2MedInterfaceOgArvOgListe
{
    internal class MenyUI
    {
      Lager lager = new Lager();

        public void HovedMeny()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Hva vil du gjøre?");
            Console.WriteLine("1. Legge til et produkt");
            Console.WriteLine("2. Fjern et produkt");
            Console.WriteLine("3. Liste alle produkter");
            Console.WriteLine("4. Avslutte programmet");
            Console.WriteLine("--------------------------------\n");

            string menyvalg = MenyValg();

            switch (menyvalg)
            {
                case "1":
                    LeggeTilMeny();
                    break;
                case "2":
                    FjernMeny();
                    break;
                case "3":
                    lager.ListeAlleProdukter(); HovedMeny();
                    break;
                case "4":
                    Avslutt();
                    break;
                default:
                    Console.WriteLine("Ugylidig input!"); HovedMeny();
                    break;
            }
        }

        public void LeggeTilMeny()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Hva slags vare vil du legge til?");
            Console.WriteLine("1. Klær");
            Console.WriteLine("2. Mat"); 
            Console.WriteLine("3. Elektronikk");
            Console.WriteLine("--------------------------------\n");
        }

        public void FjernMeny()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Hva slags vare vil du fjerne?");
            Console.WriteLine("1. Klær");
            Console.WriteLine("2. Mat");
            Console.WriteLine("3. Elektronikk");
            Console.WriteLine("--------------------------------\n");
        }

        public string MenyValg()
        {
            return Console.ReadLine()!;
        }

        public void Avslutt()
        {
            Console.Write("Du valgte til å avslutte programmet! --- Trykk på en knapp...");
            Console.ReadKey();
            Environment.Exit(0);
        }

    }
}
