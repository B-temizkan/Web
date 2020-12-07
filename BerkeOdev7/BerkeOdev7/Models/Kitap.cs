using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BerkeOdev7.Models
{
    public class KitapVeri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public string YayinEvi { get; set; }
        public long Fiyat { get; set; }
        public short BasimYil { get; set; }


        public static List<KitapVeri> VeriListe = new List<KitapVeri>
        {
            new KitapVeri
            {
                Id=1,
                Ad="Son Ada",
                Yazar="Zülfü Livaneli",
                YayinEvi="Doğan Kitap",
                Fiyat=20,
                BasimYil=2019,

            },
            new KitapVeri
            {
                Id=2,
                Ad="Kayıp Sembol",
                Yazar="Dan Brown",
                YayinEvi="Altın Kitaplar",
                Fiyat=25,
                BasimYil=2006,

            },
             new KitapVeri
            {
                Id=3,
                Ad="Cehennem Kapıları",
                Yazar="Dan Brown",
                YayinEvi="Pegasus",
                Fiyat=15,
                BasimYil=2008,

            },
              new KitapVeri
            {
                Id=3,
                Ad="Cehennem",
                Yazar="Dan Brown",
                YayinEvi="Altın Kitaplar",
                Fiyat=35,
                BasimYil=2004,

            },
              new KitapVeri
            {
                Id=4,
                Ad="Karanlık Sular",
                Yazar="Paula Hawkıns",
                YayinEvi="İthaki",
                Fiyat=55,
                BasimYil=2016,

            },
              new KitapVeri
            {
                Id=5,
                Ad="Trendeki Kız",
                Yazar="Paula Hawkıns",
                YayinEvi="İthaki",
                Fiyat=45,
                BasimYil=2014,

            },
        };

    }
}