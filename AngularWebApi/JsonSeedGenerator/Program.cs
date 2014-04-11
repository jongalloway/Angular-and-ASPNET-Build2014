using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSeedGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string inPath = Path.Combine(projectPath, "all.json");
            string outPath = Path.Combine(projectPath, "output.txt");

            var o = JArray.Parse(File.ReadAllText(inPath));

            using (FileStream stream = new FileStream(outPath, FileMode.Create))
            using (TextWriter writer = new StreamWriter(stream))
            {
                var cards = o.SelectTokens("..cards[*]");

                foreach (var card in cards)
                {
                    var c = card.ToObject<Card>();
                    //try
                    //{
                        writer.WriteLine(FormatAdd(c));
                    //}
                    //catch
                    //{
                    //    writer.WriteLine("// Skipped due to formatting errors: " + c.nameEn);
                    //}
                }
            }
        }

        private static string FormatAdd(Card c)
        {
            string format = @"            context.Cards.Add(new Card {{ author = ""{0}"", cardMarketLink = ""{1}"", colorId = {2}, 
                                                convertedManaCost = {3}, defense = {4}, flavorEn = @""{5}"",
                                                flavorFr = @""{6}"", force = {7}, id = {8}, manaCost = ""{9}"", multiverseIdEn = {10}, 
                                                multiverseIdFr = {11}, nameEn = ""{12}"", nameFr = ""{13}"",
                                                number = {14}, picturePath = @""{15}"", power = ""{16}"", price = {17}F, rarityId = {18}, 
                                                    rulings = new Ruling[0], 
                                                    size = new Size {{ isPlane = false, isScheme = false }}, 
                                                tag = ""{19}"", textEn = @""{20}"", textFr = @""{21}"", typeEn = ""{22}"", typeFr = ""{23}"" }});";

            return string.Format(format, 
                c.author, 
                c.cardMarketLink,
                c.colorId,
                c.convertedManaCost,
                c.defense,
                c.flavorEn.Replace("\"", "\"\""),
                c.flavorFr.Replace("\"", "\"\""),
                c.force,
                c.id,
                c.manaCost,
                c.multiverseIdEn,
                c.multiverseIdFr,
                c.nameEn,
                c.nameFr,
                c.number,
                c.picturePath,
                c.power,
                c.price,
                c.rarityId,
                c.tag,
                c.textEn.Replace("\"", "\"\""),
                c.textFr.Replace("\"", "\"\""),
                c.typeEn,
                c.typeFr);
        }
    }
}
