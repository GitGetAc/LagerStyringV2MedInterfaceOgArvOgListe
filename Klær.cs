namespace LagerStyringV2MedInterfaceOgArvOgListe
{
    internal  class Klær : IProdukt
    {
        //Ha interface-t hasznalunk mindent ugyanugy kell deklaralni mint ha nem hasznalnak semmit nemugy mint az arv-nal
        public Klær(string navn, double pris, string størrelse)
        {
            Navn = navn;
            Pris = pris;
            Størrelse = størrelse;
        }

        public string Navn { get; set; }
        public double Pris { get; set; }
        public string Størrelse {  get; set; }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Klær:\t\tNavn: {Navn}\tPris: {Pris}\tStørrelse: {Størrelse}");
        }
    }
}
