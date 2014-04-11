using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Step6A.Models
{
    public class Card
    {
        public string author { get; set; }
        public string cardMarketLink { get; set; }
        public int colorId { get; set; }
        public int convertedManaCost { get; set; }
        public int defense { get; set; }
        public string flavorEn { get; set; }
        public string flavorFr { get; set; }
        public int force { get; set; }
        public int id { get; set; }
        public string manaCost { get; set; }
        public int multiverseIdEn { get; set; }
        public int multiverseIdFr { get; set; }
        public string nameEn { get; set; }
        public string nameFr { get; set; }
        public int number { get; set; }
        public string picturePath { get; set; }
        public string power { get; set; }
        public float price { get; set; }
        public int rarityId { get; set; }
        public Ruling[] rulings { get; set; }
        public Size size { get; set; }
        public object tag { get; set; }
        public string textEn { get; set; }
        public string textFr { get; set; }
        public string typeEn { get; set; }
        public string typeFr { get; set; }
    }

    public class Size
    {
        public bool isPlane { get; set; }
        public bool isScheme { get; set; }
    }

    public class Ruling
    {
        public string text { get; set; }
    }
}