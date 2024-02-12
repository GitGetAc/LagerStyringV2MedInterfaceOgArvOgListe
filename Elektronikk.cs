namespace LagerStyringV2MedInterfaceOgArvOgListe
{
    internal class Elektronikk : IProdukt
    {
        public Elektronikk(string navn, double pris, int garantitid)
        {
            //Ha interface-t hasznalunk mindent ugyanugy kell deklaralni mint ha nem hasznalnak semmit nemugy mint az arv-nal
            Navn = navn;
            Pris = pris;
            GarantiTid = garantitid;
        }

        public string Navn { get; set; }
        public double Pris { get; set; }
        public int GarantiTid { get; set; }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Elektronikk:\tNavn: {Navn}\tPris: {Pris}\tGarantitid: {GarantiTid}");
        }
    }
}
