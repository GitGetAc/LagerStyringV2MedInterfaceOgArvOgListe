namespace LagerStyringV2MedInterfaceOgArvOgListe
{
    internal class Lager
    {
        //Ez kurva fontos es ebbøl generalunk egy konstruktort
        public List<IProdukt> Produkter { get; set; }

        //Ez a konstruktør
        public Lager()
        {
            Produkter = new List<IProdukt>();
        }

        public void LeggeTilEtProdukt(IProdukt produkt)
        {
            Produkter.Add(produkt);
        }

        public void FjernEtProdukt(IProdukt produkt)
        {
            Produkter.Remove(produkt);
        }

        //Ez egy erdekes dolog: Itt gyakorlatilag az interface-ben definialt es a kuløn klassekban implementalt SkrivUtInfo() metode-t hasznaljuk a kilistazasra a fø programban
        public void ListeAlleProdukter()
        {
            Console.WriteLine("-----------------------------Lagerbeholdning--------------------------\n");

            foreach (var produkt in Produkter)
            {
                produkt.SkrivUtInfo();
            }

            Console.WriteLine("\n----------------------------------------------------------------------\n");
        }
    }
}
