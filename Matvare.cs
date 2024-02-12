namespace LagerStyringV2MedInterfaceOgArvOgListe
{
    internal class Matvare : IProdukt
    {
        //Ha interface-t hasznalunk mindent ugyanugy kell deklaralni mint ha nem hasznalnak semmit nemugy mint az arv-nal
        public Matvare(string navn, double pris, string utløpsDato)
        {
            Navn = navn;
            Pris = pris;
            UtløpsDato = utløpsDato;
        }

        public string Navn { get; set; }
        public double Pris { get; set; }
        public string UtløpsDato {get; set;}

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Matvare:\tNavn: {Navn}\tPris: {Pris}\tUtløpsdato: {UtløpsDato}");
        }
    }
}
