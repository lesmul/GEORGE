﻿namespace GEORGE.Shared.Models
{
    public class ZleceniaProdukcyjne
    {
        public long Id { get; set; }
        public string? RowId { get; set; } = Guid.NewGuid().ToString();
        public string? NumerZamowienia { get; set; }
        public string? NumerUmowy { get; set; }
        public DateTime DataProdukcji { get; set; } = DateTime.Now.AddDays(84);
        public DateTime DataWysylki { get; set; } = DateTime.Now.AddDays(88);
        public DateTime DataMontazu { get; set; } = DateTime.Now.AddDays(85);
        public string? Klient { get; set; }
        public string? Adres { get; set; }
        public string? Miejscowosc { get; set; }
        public string? Telefon { get; set; }
        public string? NazwaProduktu { get; set; }
        public string? NazwaProduktu2 { get; set; }
        public string? KodProduktu { get; set; }
        public int Ilosc { get; set; }
        public Single Wartosc { get; set; }
        public DateTime DataZapisu { get; set; } = DateTime.Now;
        public string? KtoZapisal { get; set; }
        public string? OstatniaZmiana { get; set; } = "Zmiana: " + DateTime.Now.ToLongDateString();
    }
}
