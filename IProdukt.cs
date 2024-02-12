namespace LagerStyringV2MedInterfaceOgArvOgListe
{
    interface IProdukt
    {
        string Navn { get; set; }
        double Pris { get; set; }

        void SkrivUtInfo();
    }
}
