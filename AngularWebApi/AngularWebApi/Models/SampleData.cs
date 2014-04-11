using Step6A.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngularWebApi.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<CardContext>
    {
        Random random = new Random();
        protected override void Seed(CardContext context)
        {
            AddCards(context);
            context.SaveChanges();
        }

        // Note: Generated using JsonSeedGenerator console application
        private void AddCards(CardContext context)
        {
            context.Cards.Add(new Card
            {
                author = "Jeremy Jarvis",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=13995&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 6,
                defense = 5,
                flavorEn = @"She doesn't escort the dead to the afterlife, but instead raises them to fight and die again.
",
                flavorFr = @"Elle n'escorte pas les morts dans l'après-vie ; elle les ressuscite pour combattre et mourir à nouveau.
",
                force = 4,
                id = 14148,
                manaCost = "(4)(W)(W)",
                multiverseIdEn = 121196,
                multiverseIdFr = 127066,
                nameEn = "Adarkar Valkyrie",
                nameFr = "Valkyrie d’Adarkar",
                number = 1,
                picturePath = @"Coldsnap\Adarkar Valkyrie.jpg",
                power = "4 / 5",
                price = 6.755545F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying, vigilance
(T): When target creature other than Adarkar Valkyrie dies this turn, return that card to the battlefield under your control.
",
                textFr = @"Vol, vigilance
(T)&nbsp;: Quand une créature ciblée autre que la Valkyrie d'Adarkar est mise dans un cimetière ce tour-ci, renvoyez en jeu cette carte sous votre contrôle.
",
                typeEn = "Snow Creature — Angel",
                typeFr = "Créature neigeuse  - ange"
            });
            context.Cards.Add(new Card
            {
                author = "Randy Gallegos",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=13996&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 5,
                defense = 3,
                flavorEn = @"Terisiare has only two kinds of weather: cold and weird.
",
                flavorFr = @"Terisiare n'a que deux types de climats : froid et étrange.
",
                force = 3,
                id = 14149,
                manaCost = "(4)(U)",
                multiverseIdEn = 121268,
                multiverseIdFr = 127067,
                nameEn = "Adarkar Windform",
                nameFr = "Venteforme d’Adarkar",
                number = 26,
                picturePath = @"Coldsnap\Adarkar Windform.jpg",
                power = "3 / 3",
                price = 0.158865F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying
(1): Target creature loses flying until end of turn. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"Vol
(1)&nbsp;: La créature ciblée perd le vol jusqu'à la fin du tour. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Creature — Illusion",
                typeFr = "Créature neigeuse  - illusion"
            });
            context.Cards.Add(new Card
            {
                author = "Daren Bader",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=13997&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 7,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14150,
                manaCost = "(5)(G)(G)",
                multiverseIdEn = 121157,
                multiverseIdFr = 127068,
                nameEn = "Allosaurus Rider",
                nameFr = "Chevaucheur d’allosaure",
                number = 101,
                picturePath = @"Coldsnap\Allosaurus Rider.jpg",
                power = "1+* / 1+*",
                price = 0.521985F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"You may exile two green cards from your hand rather than pay Allosaurus Rider's mana cost.
Allosaurus Rider's power and toughness are each equal to 1 plus the number of lands you control.
",
                textFr = @"Vous pouvez retirer de la partie deux cartes vertes de votre main à la place de payer le coût de mana du Chevaucheur d'allosaure.
La force et l'endurance du Chevaucheur d'allosaure sont chacune égale à 1 plus le nombre de terrains que vous contrôlez.
",
                typeEn = "Creature — Elf Warrior",
                typeFr = "Créature  - elfe et guerrier"
            });
            context.Cards.Add(new Card
            {
                author = "John Avon",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=13998&amp;partner=URZGTHR",
                colorId = 7,
                convertedManaCost = 0,
                defense = 0,
                flavorEn = @"""A realm once green now ruled by Frost,
Where flesh and field both pay its cost.
Those dearly loved, forever lost . . .""
—The Dynasty of Winter Kings
",
                flavorFr = @"« Un royaume verdoyant dominé par le Gel,
Auquel chair et cultures paient une terrible gabelle.
Êtres aimés, disparus éternels . . . »
—La dynastie des Rois de l'hiver
",
                force = 0,
                id = 14151,
                manaCost = "",
                multiverseIdEn = 121158,
                multiverseIdFr = 127069,
                nameEn = "Arctic Flats",
                nameFr = "Plaine arctique",
                number = 143,
                picturePath = @"Coldsnap\Arctic Flats.jpg",
                power = "",
                price = 0.673285F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Arctic Flats enters the battlefield tapped.
(T): Add (G) or (W) to your mana pool.
",
                textFr = @"La Plaine arctique arrive en jeu engagée.
(T)&nbsp;: Ajoutez (G) ou (W) à votre réserve.
",
                typeEn = "Snow Land",
                typeFr = "Terrain neigeux"
            });
            context.Cards.Add(new Card
            {
                author = "Dave Kendall",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=13999&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 6,
                defense = 6,
                flavorEn = @"",
                flavorFr = @"",
                force = 6,
                id = 14152,
                manaCost = "(5)(G)",
                multiverseIdEn = 121229,
                multiverseIdFr = 127070,
                nameEn = "Arctic Nishoba",
                nameFr = "Nishoba arctique",
                number = 102,
                picturePath = @"Coldsnap\Arctic Nishoba.jpg",
                power = "6 / 6",
                price = 0.158865F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Trample
Cumulative upkeep (G) or (W) (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
When Arctic Nishoba dies, you gain 2 life for each age counter on it.
",
                textFr = @"Piétinement
Entretien cumulatif (G) ou (W) (Au début de votre entretien, mettez un marqueur «&nbsp;âge&nbsp;» sur ce permanent, puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur «&nbsp;âge&nbsp;» sur lui.)
Quand le Nishoba arctique est mis dans un cimetière depuis le jeu, vous gagnez 2 points de vie pour chaque marqueur « âge » sur lui.
",
                typeEn = "Creature — Cat Warrior",
                typeFr = "Créature  - chat et guerrier"
            });
            context.Cards.Add(new Card
            {
                author = "Pete Venters",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14000&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 4,
                defense = 2,
                flavorEn = @"""Artifice sundered the world. It shall not again wreak such sorrow.""
",
                flavorFr = @"« L'artifice a déchiré le monde. Plus jamais il ne sera responsable de tant de tristesse. »
",
                force = 2,
                id = 14153,
                manaCost = "(3)(U)",
                multiverseIdEn = 122124,
                multiverseIdFr = 127071,
                nameEn = "Arcum Dagsson",
                nameFr = "Arcum Dagsson",
                number = 27,
                picturePath = @"Coldsnap\Arcum Dagsson.jpg",
                power = "2 / 2",
                price = 1.520565F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(T): Target artifact creature's controller sacrifices it. That player may search his or her library for a noncreature artifact card, put it onto the battlefield, then shuffle his or her library.
",
                textFr = @"(T)&nbsp;: Le contrôleur de la créature-artefact ciblée la sacrifie. Ce joueur peut chercher dans sa bibliothèque une carte d'artefact non-créature, la mettre en jeu, puis mélanger sa bibliothèque.
",
                typeEn = "Legendary Creature — Human Artificer",
                typeFr = "Créature légendaire  - humain et artificier"
            });
            context.Cards.Add(new Card
            {
                author = "Darrell Riche",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14001&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 6,
                defense = 4,
                flavorEn = @"",
                flavorFr = @"",
                force = 4,
                id = 14154,
                manaCost = "(5)(G)",
                multiverseIdEn = 121260,
                multiverseIdFr = 127072,
                nameEn = "Aurochs Herd",
                nameFr = "Troupeau d’aurochs",
                number = 103,
                picturePath = @"Coldsnap\Aurochs Herd.jpg",
                power = "4 / 4",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Trample
When Aurochs Herd enters the battlefield, you may search your library for an Aurochs card, reveal it, and put it into your hand. If you do, shuffle your library.
Whenever Aurochs Herd attacks, it gets +1/+0 until end of turn for each other attacking Aurochs.
",
                textFr = @"Piétinement
Quand le Troupeau d'aurochs arrive en jeu, vous pouvez chercher dans votre bibliothèque une carte d'aurochs, la révéler et la mettre dans votre main. Si vous faites ainsi, mélangez votre bibliothèque.
À chaque fois que le Troupeau d'aurochs attaque, il gagne +1/+0 jusqu'à la fin du tour pour chaque autre aurochs attaquant.
",
                typeEn = "Creature — Aurochs",
                typeFr = "Créature  - aurochs"
            });
            context.Cards.Add(new Card
            {
                author = "Dave Kendall",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14002&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 4,
                defense = 5,
                flavorEn = @"",
                flavorFr = @"",
                force = 3,
                id = 14155,
                manaCost = "(3)(B)",
                multiverseIdEn = 121272,
                multiverseIdFr = 127073,
                nameEn = "Balduvian Fallen",
                nameFr = "Balduvian déchu",
                number = 51,
                picturePath = @"Coldsnap\Balduvian Fallen.jpg",
                power = "3 / 5",
                price = 0.158865F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Cumulative upkeep (1) (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
Whenever Balduvian Fallen's cumulative upkeep is paid, it gets +1/+0 until end of turn for each (B) or (R) spent this way.
",
                textFr = @"Entretien cumulatif (1) (Au début de votre entretien, mettez un marqueur «&nbsp;âge&nbsp;» sur ce permanent, puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur «&nbsp;âge&nbsp;» sur lui.)
À chaque fois que l'entretien cumulatif du Balduvian déchu est payé, il gagne +1/+0 jusqu'à la fin du tour pour chaque (B) ou (R) dépensé de cette manière.
",
                typeEn = "Creature — Zombie",
                typeFr = "Créature  - zombie"
            });
            context.Cards.Add(new Card
            {
                author = "Stephen Tappin",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14003&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 3,
                defense = 1,
                flavorEn = @"""Whether frozen or fertile, the land is our ally. It awaits the call to battle.""
",
                flavorFr = @"« Gelée ou fertile, la terre est notre alliée. Elle attend l'appel au combat. »
",
                force = 1,
                id = 14156,
                manaCost = "(2)(U)",
                multiverseIdEn = 121175,
                multiverseIdFr = 127074,
                nameEn = "Balduvian Frostwaker",
                nameFr = "Gelveilleur balduvian",
                number = 28,
                picturePath = @"Coldsnap\Balduvian Frostwaker.jpg",
                power = "1 / 1",
                price = 0.158865F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(U), (T): Target snow land becomes a 2/2 blue Elemental creature with flying. It's still a land.
",
                textFr = @"(U), (T)&nbsp;: Le terrain neigeux ciblé devient une créature 2/2 bleue Élémental avec le vol. C'est toujours un terrain.
",
                typeEn = "Creature — Human Wizard",
                typeFr = "Créature  - humain et sorcier"
            });
            context.Cards.Add(new Card
            {
                author = "John Matson",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14004&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 1,
                defense = 0,
                flavorEn = @"""Let your heartbeat be the thunder in the valley. Let your swords be the lightning on the peaks.""
—Lothar Lovisason, Balduvian chieftain
",
                flavorFr = @"« Que vos battements de cœur remplacent le tonnerre dans la vallée. Que vos épées remplacent les éclairs sur les cimes. »
—Lothar Lovisason, chef balduvian
",
                force = 0,
                id = 14157,
                manaCost = "(X)(R)",
                multiverseIdEn = 121248,
                multiverseIdFr = 127075,
                nameEn = "Balduvian Rage",
                nameFr = "Rage balduviane",
                number = 76,
                picturePath = @"Coldsnap\Balduvian Rage.jpg",
                power = "",
                price = 0.16643F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Target attacking creature gets +X/+0 until end of turn.
Draw a card at the beginning of the next turn's upkeep.
",
                textFr = @"La créature attaquante ciblée gagne +X/+0 jusqu'à la fin du tour.
Piochez une carte au début de l'entretien du prochain tour.
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Zoltan Boros & Gabor Szikszai",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14021&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 3,
                defense = 0,
                flavorEn = @"The people of Terisiare had come to live on frozen fields as though on solid ground. Nothing reminded them of the difference more clearly than the rifts brought on by the Thaw.
",
                flavorFr = @"La population de Terisiare vivait sur la glace, convaincue de sa solidité. Sa rupture, due au Dégel, lui fit reprendre conscience de la dure réalité.
",
                force = 0,
                id = 14174,
                manaCost = "(2)(R)",
                multiverseIdEn = 121169,
                multiverseIdFr = 127092,
                nameEn = "Cryoclasm",
                nameFr = "Cryoclasme",
                number = 79,
                picturePath = @"Coldsnap\Cryoclasm.jpg",
                power = "",
                price = 0.219385F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Destroy target Plains or Island. Cryoclasm deals 3 damage to that land's controller.
",
                textFr = @"Détruisez la plaine ciblée ou l'île ciblée. Le Cryoclasme inflige 3 blessures au contrôleur de ce terrain.
",
                typeEn = "Sorcery",
                typeFr = "Rituel"
            });
            context.Cards.Add(new Card
            {
                author = "Michael Phillippi",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14022&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 6,
                defense = 3,
                flavorEn = @"""With his dream of unification fulfilled, Darien became the last king of Kjeldor. Those who followed were known as the kings of New Argive.""
—Kjeldor: Ice Civilization
",
                flavorFr = @"« Ayant concrétisé son rêve de réunification, Darien devint le dernier roi du Kjeldor. Ses successeurs furent les rois de la Nouvelle Argive. »
—Kjeldor : Civilisation glaciaire
",
                force = 3,
                id = 14175,
                manaCost = "(4)(W)(W)",
                multiverseIdEn = 122049,
                multiverseIdFr = 127093,
                nameEn = "Darien, King of Kjeldor",
                nameFr = "Darien, roi du Kjeldor",
                number = 4,
                picturePath = @"Coldsnap\Darien, King of Kjeldor.jpg",
                power = "3 / 3",
                price = 3.19243F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Whenever you're dealt damage, you may put that many 1/1 white Soldier creature tokens onto the battlefield.
",
                textFr = @"À chaque fois que vous subissez des blessures, vous pouvez mettre en jeu autant de jetons de créature 1/1 blanche Soldat.
",
                typeEn = "Legendary Creature — Human Soldier",
                typeFr = "Créature légendaire  - humain et seigneur"
            });
            context.Cards.Add(new Card
            {
                author = "Stephan Martiniere",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14023&amp;partner=URZGTHR",
                colorId = 7,
                convertedManaCost = 0,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14176,
                manaCost = "",
                multiverseIdEn = 121155,
                multiverseIdFr = 127094,
                nameEn = "Dark Depths",
                nameFr = "Profondeurs obscures",
                number = 145,
                picturePath = @"Coldsnap\Dark Depths.jpg",
                power = "",
                price = 23.26237F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Dark Depths enters the battlefield with ten ice counters on it.
(3): Remove an ice counter from Dark Depths.
When Dark Depths has no ice counters on it, sacrifice it. If you do, put a legendary 20/20 black Avatar creature token with flying and ""This creature is indestructible"" named Marit Lage onto the battlefield.
",
                textFr = @"Les Profondeurs obscures arrivent en jeu avec, sur elles, dix marqueurs « glace ».
(3)&nbsp;: Retirez un marqueur «&nbsp;glace&nbsp;» des Profondeurs obscures.
Quand les Profondeurs obscures n'ont plus de marqueur « glace » sur elles, sacrifiez-les. Si vous faites ainsi, mettez en jeu un jeton de créature légendaire indestructible 20/20 noire Avatar avec le vol appelée Marit Lage.
",
                typeEn = "Legendary Snow Land",
                typeFr = "Terrain neigeux légendaire"
            });
            context.Cards.Add(new Card
            {
                author = "Jeremy Jarvis",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14024&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 1,
                defense = 0,
                flavorEn = @"""I hope it's true that every snowflake is unique, because I never want to see one like this again. Now clean up that body.""
—Thangbrand Gyrdsson, Kjeldoran patrol
",
                flavorFr = @"« J'espère qu'il est vrai que chaque flocon de neige est unique, parce que je ne veux plus jamais en voir un pareil. Nettoyez-moi ce cadavre. »
—Thangbrand Gyrdsson, patrouilleur kjeldorien
",
                force = 0,
                id = 14177,
                manaCost = "(B)",
                multiverseIdEn = 121119,
                multiverseIdFr = 127095,
                nameEn = "Deathmark",
                nameFr = "Mortemarque",
                number = 54,
                picturePath = @"Coldsnap\Deathmark.jpg",
                power = "",
                price = 0.27234F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Destroy target green or white creature.
",
                textFr = @"Détruisez la créature verte ou blanche ciblée.
",
                typeEn = "Sorcery",
                typeFr = "Rituel"
            });
            context.Cards.Add(new Card
            {
                author = "Joel Thomas",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14025&amp;partner=URZGTHR",
                colorId = 8,
                convertedManaCost = 6,
                defense = 4,
                flavorEn = @"""There are deep, deep places in this world that have long burned hot with little regard for the whitening of the earth's thin skin.""
—Sek'Kuar, Deathkeeper
",
                flavorFr = @"« Il existe des lieux profonds dans ce monde qui brûlent et chauffent sans se soucier du blanchiment de la fine peau de la terre. »
—Sek'Kuar, gardemort
",
                force = 4,
                id = 14178,
                manaCost = "(4)(B)(R)",
                multiverseIdEn = 122057,
                multiverseIdFr = 127096,
                nameEn = "Deepfire Elemental",
                nameFr = "Élémental du feu souterrain",
                number = 127,
                picturePath = @"Coldsnap\Deepfire Elemental.jpg",
                power = "4 / 4",
                price = 0.19669F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(X)(X)(1): Destroy target artifact or creature with converted mana cost X.
",
                textFr = @"(X)(X)(1)&nbsp;: Détruisez l'artefact ciblé ou la créature ciblée dont le coût converti de mana est X.
",
                typeEn = "Creature — Elemental",
                typeFr = "Créature  - élémental"
            });
            context.Cards.Add(new Card
            {
                author = "Heather Hudson",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14026&amp;partner=URZGTHR",
                colorId = 8,
                convertedManaCost = 5,
                defense = 3,
                flavorEn = @"""That such delicate creatures could become so powerful in the embrace of winter is yet more proof that I am right.""
—Heidar, Rimewind master
",
                flavorFr = @"« Que des créatures si délicates deviennent si puissantes sous l'emprise de l'hiver ne fait que prouver que j'ai raison. »
—Heidar, maître de Soufflegivre
",
                force = 3,
                id = 14179,
                manaCost = "(2)(G)(W)(U)",
                multiverseIdEn = 121138,
                multiverseIdFr = 127097,
                nameEn = "Diamond Faerie",
                nameFr = "Fée de diamant",
                number = 128,
                picturePath = @"Coldsnap\Diamond Faerie.jpg",
                power = "3 / 3",
                price = 0.28747F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying
(1): Snow creatures you control get +1/+1 until end of turn. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"Vol
(1)&nbsp;: Les créatures neigeuses que vous contrôlez gagnent +1/+1 jusqu'à la fin du tour. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Creature — Faerie",
                typeFr = "Créature neigeuse  - peuple fée"
            });
            context.Cards.Add(new Card
            {
                author = "Pete Venters",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14027&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 4,
                defense = 1,
                flavorEn = @"""You pray to Freyalise, but she cannot hear your pleas. It is Tevesh Szat who will claim your soul.""
",
                flavorFr = @"« Vous priez Freyalise, mais elle n'entend pas vos supplications. C'est Tevesh Szat qui s'emparera de votre âme. »
",
                force = 3,
                id = 14180,
                manaCost = "(2)(B)(B)",
                multiverseIdEn = 121222,
                multiverseIdFr = 127098,
                nameEn = "Disciple of Tevesh Szat",
                nameFr = "Disciple de Tevesh Szat",
                number = 55,
                picturePath = @"Coldsnap\Disciple of Tevesh Szat.jpg",
                power = "3 / 1",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(T): Target creature gets -1/-1 until end of turn.
(4)(B)(B), (T), Sacrifice Disciple of Tevesh Szat: Target creature gets -6/-6 until end of turn.
",
                textFr = @"(T)&nbsp;: La créature ciblée gagne -1/-1 jusqu'à la fin du tour.
(4)(B)(B), (T), sacrifiez le Disciple de Tevesh Szat&nbsp;: La créature ciblée gagne -6/-6 jusqu'à la fin du tour.
",
                typeEn = "Creature — Human Cleric",
                typeFr = "Créature  - humain et clerc"
            });
            context.Cards.Add(new Card
            {
                author = "Zoltan Boros & Gabor Szikszai",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14028&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 5,
                defense = 3,
                flavorEn = @"Adarkar's blank wastes make the mind wander—and stray thoughts are quickly caught and devoured.
",
                flavorFr = @"Les étendues blanches d'Adarkar provoquent l'errance de l'âme — et ces pensées perdues sont rapidement capturées et dévorées.
",
                force = 3,
                id = 14181,
                manaCost = "(4)(U)",
                multiverseIdEn = 121174,
                multiverseIdFr = 127099,
                nameEn = "Drelnoch",
                nameFr = "Drelnoch",
                number = 32,
                picturePath = @"Coldsnap\Drelnoch.jpg",
                power = "3 / 3",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Whenever Drelnoch becomes blocked, you may draw two cards.
",
                textFr = @"À chaque fois que le Drelnoch devient bloqué, vous pouvez piocher deux cartes.
",
                typeEn = "Creature — Yeti Mutant",
                typeFr = "Créature  - yeti et mutant"
            });
            context.Cards.Add(new Card
            {
                author = "Nick Percival",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14029&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 3,
                defense = 2,
                flavorEn = @"",
                flavorFr = @"",
                force = 2,
                id = 14182,
                manaCost = "(2)(R)",
                multiverseIdEn = 121254,
                multiverseIdFr = 127100,
                nameEn = "Earthen Goo",
                nameFr = "Empois de terre",
                number = 80,
                picturePath = @"Coldsnap\Earthen Goo.jpg",
                power = "2 / 2",
                price = 0.1513F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Trample
Cumulative upkeep (R) or (G) (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
Earthen Goo gets +1/+1 for each age counter on it.
",
                textFr = @"Piétinement
Entretien cumulatif (R) ou (G) (Au début de votre entretien, mettez un marqueur «&nbsp;âge&nbsp;» sur ce permanent, puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur «&nbsp;âge&nbsp;» sur lui.)
L'Empois de terre gagne +1/+1 pour chaque marqueur « âge » sur lui.
",
                typeEn = "Creature — Ooze",
                typeFr = "Créature  - limon"
            });
            context.Cards.Add(new Card
            {
                author = "Volkan Baga",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14030&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 1,
                defense = 0,
                flavorEn = @"""Starving an army that feeds on its enemies is a sound strategy.""
—Garza Zol, plague queen
",
                flavorFr = @"« Affamer une armée qui se nourrit de ses ennemis est une excellente stratégie. »
—Garza Zol, reine de la peste
",
                force = 0,
                id = 14183,
                manaCost = "(B)",
                multiverseIdEn = 121137,
                multiverseIdFr = 127101,
                nameEn = "Feast of Flesh",
                nameFr = "Festin de chair",
                number = 56,
                picturePath = @"Coldsnap\Feast of Flesh.jpg",
                power = "",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Feast of Flesh deals X damage to target creature and you gain X life, where X is 1 plus the number of cards named Feast of Flesh in all graveyards.
",
                textFr = @"Le Festin de chair inflige X blessures à la créature ciblée et vous gagnez X points de vie, X étant égal à 1 plus le nombre de cartes appelées Festin de chair dans tous les cimetières.
",
                typeEn = "Sorcery",
                typeFr = "Rituel"
            });
            context.Cards.Add(new Card
            {
                author = "Parente",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14005&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 4,
                defense = 2,
                flavorEn = @"",
                flavorFr = @"",
                force = 3,
                id = 14158,
                manaCost = "(3)(R)",
                multiverseIdEn = 122056,
                multiverseIdFr = 127076,
                nameEn = "Balduvian Warlord",
                nameFr = "Seigneur de guerre balduvian",
                number = 77,
                picturePath = @"Coldsnap\Balduvian Warlord.jpg",
                power = "3 / 2",
                price = 0.158865F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(T): Remove target blocking creature from combat. Creatures it was blocking that hadn't become blocked by another creature this combat become unblocked, then it blocks an attacking creature of your choice. Activate this ability only during the declare blockers step.
",
                textFr = @"(T)&nbsp;: Retirez la créature bloqueuse ciblée du combat. Les créatures qu'elle bloquait et qu'aucune autre créature ne bloquait pendant ce combat deviennent non-bloquées. Cette créature bloque ensuite une créature attaquante de votre choix. Ne jouez cette capacité que pendant l'étape de déclaration des bloqueurs.
",
                typeEn = "Creature — Human Barbarian",
                typeFr = "Créature  - humain et barbare"
            });
            context.Cards.Add(new Card
            {
                author = "Hideaki Takamura",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14006&amp;partner=URZGTHR",
                colorId = 8,
                convertedManaCost = 4,
                defense = 3,
                flavorEn = @"",
                flavorFr = @"",
                force = 2,
                id = 14159,
                manaCost = "(2)(U)(B)",
                multiverseIdEn = 121151,
                multiverseIdFr = 127077,
                nameEn = "Blizzard Specter",
                nameFr = "Spectre du blizzard",
                number = 126,
                picturePath = @"Coldsnap\Blizzard Specter.jpg",
                power = "2 / 3",
                price = 0.779195F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying
Whenever Blizzard Specter deals combat damage to a player, choose one — That player returns a permanent he or she controls to its owner's hand; or that player discards a card.
",
                textFr = @"Vol
À chaque fois que le Spectre du blizzard inflige des blessures de combat à un joueur, choisissez l'un — Ce joueur renvoie un permanent qu'il contrôle dans la main de son propriétaire ; ou ce joueur se défausse d'une carte.
",
                typeEn = "Snow Creature — Specter",
                typeFr = "Créature neigeuse  - spectre"
            });
            context.Cards.Add(new Card
            {
                author = "Marcelo Vignali",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14007&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 2,
                defense = 2,
                flavorEn = @"Those who used reindeer as beasts of burden knew to avoid the centaurs, who raged at the enslavement of their spirit-kin.
",
                flavorFr = @"Ceux qui utilisaient les rennes comme bêtes de somme évitaient les centaures, furieux de voir leurs cousins ainsi réduits à l'esclavage.
",
                force = 2,
                id = 14160,
                manaCost = "(1)(G)",
                multiverseIdEn = 121200,
                multiverseIdFr = 127078,
                nameEn = "Boreal Centaur",
                nameFr = "Centaure de Boréal",
                number = 104,
                picturePath = @"Coldsnap\Boreal Centaur.jpg",
                power = "2 / 2",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @": Boreal Centaur gets +1/+1 until end of turn. Activate this ability only once each turn. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"&nbsp;: Le Centaure de Boréal gagne +1/+1 jusqu'à la fin du tour. Ne jouez cette capacité qu'une seule fois par tour. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Creature — Centaur Warrior",
                typeFr = "Créature neigeuse  - centaure et guerrier"
            });
            context.Cards.Add(new Card
            {
                author = "Dan Dos Santos",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14008&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 1,
                defense = 1,
                flavorEn = @"Some creatures are bound to the cold by Rimewind magic. Others seek it out, adapted by two thousand years of the Ice. The Boreal, where Heidar's frigid sway is strongest, is home to both.
",
                flavorFr = @"Certaines créatures sont liées au froid par la magie de Soufflegivre. D'autres en ont besoin pour survivre, après s'être adaptées aux glaces pendant deux mille ans. Boréal, où le pouvoir glacé d'Heidar est le plus puissant, les abrite toutes.
",
                force = 1,
                id = 14161,
                manaCost = "(G)",
                multiverseIdEn = 121193,
                multiverseIdFr = 127079,
                nameEn = "Boreal Druid",
                nameFr = "Druide de Boréal",
                number = 105,
                picturePath = @"Coldsnap\Boreal Druid.jpg",
                power = "1 / 1",
                price = 0.1513F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(T): Add (1) to your mana pool.
",
                textFr = @"(T)&nbsp;: Ajoutez (1) à votre réserve.
",
                typeEn = "Snow Creature — Elf Druid",
                typeFr = "Créature neigeuse  - elfe et druide"
            });
            context.Cards.Add(new Card
            {
                author = "Cyril Van Der Haegen",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14009&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 5,
                defense = 2,
                flavorEn = @"""More than snow falls from the Boreal skies.""
—Arkin Egilsson, skycaptain
",
                flavorFr = @"« Il n'y a pas que la neige qui tombe du ciel de Boréal. »
—Arkin Egilsson, capitaine céleste
",
                force = 3,
                id = 14162,
                manaCost = "(3)(W)(W)",
                multiverseIdEn = 121244,
                multiverseIdFr = 127080,
                nameEn = "Boreal Griffin",
                nameFr = "Griffon de Boréal",
                number = 2,
                picturePath = @"Coldsnap\Boreal Griffin.jpg",
                power = "3 / 2",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying
: Boreal Griffin gains first strike until end of turn. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"Vol
&nbsp;: Le Griffon de Boréal acquiert l'initiative jusqu'à la fin du tour. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Creature — Griffin",
                typeFr = "Créature neigeuse  - griffon"
            });
            context.Cards.Add(new Card
            {
                author = "Heather Hudson",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14010&amp;partner=URZGTHR",
                colorId = 7,
                convertedManaCost = 0,
                defense = 0,
                flavorEn = @"""Who will stay the Tyrant's hand,
As ice and woe both grip our land?
The helpless feel his frozen brand.""
—The Dynasty of Winter Kings
",
                flavorFr = @"« Qui du Tyran va nous protéger,
tandis que glace et malheur meurtrissent la contrée ?
Les faibles subissent la brûlure de son tison glacé. »
—La dynastie des Rois de l'hiver
",
                force = 0,
                id = 14163,
                manaCost = "",
                multiverseIdEn = 121189,
                multiverseIdFr = 127081,
                nameEn = "Boreal Shelf",
                nameFr = "Saillie de Boréal",
                number = 144,
                picturePath = @"Coldsnap\Boreal Shelf.jpg",
                power = "",
                price = 0.597635F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Boreal Shelf enters the battlefield tapped.
(T): Add (W) or (U) to your mana pool.
",
                textFr = @"La Saillie de Boréal arrive en jeu engagée.
(T)&nbsp;: Ajoutez (W) ou (U) à votre réserve.
",
                typeEn = "Snow Land",
                typeFr = "Terrain neigeux"
            });
            context.Cards.Add(new Card
            {
                author = "Cyril Van Der Haegen",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14011&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"""To a trained mind, the cold is but a momentary distraction.""
",
                flavorFr = @"« Pour l'esprit entraîné, le froid n'est qu'une distraction momentanée. »
",
                force = 0,
                id = 14164,
                manaCost = "(1)(R)",
                multiverseIdEn = 122123,
                multiverseIdFr = 127082,
                nameEn = "Braid of Fire",
                nameFr = "Tresse de feu",
                number = 78,
                picturePath = @"Coldsnap\Braid of Fire.jpg",
                power = "",
                price = 5.34089F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Cumulative upkeep—Add (R) to your mana pool. (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
",
                textFr = @"Entretien cumulatif&nbsp;—&nbsp;Ajoutez (R) à votre réserve. (Au début de votre entretien, mettez un marqueur «&nbsp;âge&nbsp;» sur ce permanent puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur «&nbsp;âge&nbsp;» sur lui.)
",
                typeEn = "Enchantment",
                typeFr = "Enchantement"
            });
            context.Cards.Add(new Card
            {
                author = "rk post",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14012&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 4,
                defense = 4,
                flavorEn = @"""I have been trapped in the lizard's lair for days. It seems to regard me as its child and will not let me leave.""
—Aevar Borg, northern guide, journal entry
",
                flavorFr = @"« Je suis coincé dans le repaire du lézard depuis des jours. Il semble me considérer comme sa progéniture et refuse de me laisser partir. »
—Ævar Borg, guide du Nord, extrait de journal
",
                force = 4,
                id = 14165,
                manaCost = "(2)(G)(G)",
                multiverseIdEn = 122055,
                multiverseIdFr = 127083,
                nameEn = "Brooding Saurian",
                nameFr = "Saurien couveur",
                number = 106,
                picturePath = @"Coldsnap\Brooding Saurian.jpg",
                power = "4 / 4",
                price = 0.39338F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"At the beginning of each end step, each player gains control of all nontoken permanents he or she owns.
",
                textFr = @"À la fin de chaque tour, chaque joueur acquiert le contrôle de tous les permanents non-jeton qu'il possède.
",
                typeEn = "Creature — Lizard",
                typeFr = "Créature  - lézard"
            });
            context.Cards.Add(new Card
            {
                author = "Kev Walker",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14013&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 2,
                defense = 1,
                flavorEn = @"The aurochs herd is content to graze—until the bull provides the dissenting urge to charge.
",
                flavorFr = @"Le troupeau d'aurochs se contente de paître — jusqu'à ce que le mâle déclenche la charge.
",
                force = 2,
                id = 14166,
                manaCost = "(1)(G)",
                multiverseIdEn = 121152,
                multiverseIdFr = 127084,
                nameEn = "Bull Aurochs",
                nameFr = "Aurochs mâle",
                number = 107,
                picturePath = @"Coldsnap\Bull Aurochs.jpg",
                power = "2 / 1",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Trample
Whenever Bull Aurochs attacks, it gets +1/+0 until end of turn for each other attacking Aurochs.
",
                textFr = @"Piétinement
À chaque fois que l'Aurochs mâle attaque, il gagne +1/+0 jusqu'à la fin du tour pour chaque autre aurochs attaquant.
",
                typeEn = "Creature — Aurochs",
                typeFr = "Créature  - aurochs"
            });
            context.Cards.Add(new Card
            {
                author = "Jim Murray",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14014&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 4,
                defense = 0,
                flavorEn = @"""Thick hides and layered armor won't help when I freeze you from the inside out.""
—Heidar, Rimewind master
",
                flavorFr = @"« Peaux de cuir et armures rembourrées ne vous seront d'aucun secours si je vous congèle de l'intérieur. »
—Heidar, maître de Soufflegivre
",
                force = 0,
                id = 14167,
                manaCost = "(3)(B)",
                multiverseIdEn = 121190,
                multiverseIdFr = 127085,
                nameEn = "Chill to the Bone",
                nameFr = "Transi jusqu’aux os",
                number = 52,
                picturePath = @"Coldsnap\Chill to the Bone.jpg",
                power = "",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Destroy target nonsnow creature.
",
                textFr = @"Détruisez la créature non-neigeuse ciblée.
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Jeff Nentrup",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14015&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 3,
                defense = 1,
                flavorEn = @"Rimewind necromancers caught travelers in mystical blizzards then trapped their spirits in the mist of their final frozen breaths.
",
                flavorFr = @"Les nécromanciens de Soufflegivre capturaient les voyageurs dans des blizzards mystiques et emprisonnaient leur esprit dans la vapeur glacée de leur dernier souffle.
",
                force = 1,
                id = 14168,
                manaCost = "(2)(B)",
                multiverseIdEn = 121258,
                multiverseIdFr = 127086,
                nameEn = "Chilling Shade",
                nameFr = "Ombre glaçante",
                number = 53,
                picturePath = @"Coldsnap\Chilling Shade.jpg",
                power = "1 / 1",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying
: Chilling Shade gets +1/+1 until end of turn. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"Vol
&nbsp;: L'Ombre glaçante gagne +1/+1 jusqu'à la fin du tour. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Creature — Shade",
                typeFr = "Créature neigeuse  - ombre"
            });
            context.Cards.Add(new Card
            {
                author = "Mark Romanoski",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14016&amp;partner=URZGTHR",
                colorId = 6,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"The Phyrexian death machine awoke, its coldsteel heart imbuing it with sinister new power.
",
                flavorFr = @"La machine à tuer phyrexiane s'éveilla, sa puissance augmentée par son sinistre cœur de froidacier.
",
                force = 0,
                id = 14169,
                manaCost = "(2)",
                multiverseIdEn = 121123,
                multiverseIdFr = 127087,
                nameEn = "Coldsteel Heart",
                nameFr = "Cœur de froidacier",
                number = 136,
                picturePath = @"Coldsnap\Coldsteel Heart.jpg",
                power = "",
                price = 0.7565F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Coldsteel Heart enters the battlefield tapped.
As Coldsteel Heart enters the battlefield, choose a color.
(T): Add one mana of the chosen color to your mana pool.
",
                textFr = @"Le Cœur de froidacier arrive en jeu engagé.
Au moment où le Cœur de froidacier arrive en jeu, choisissez une couleur.
(T)&nbsp;: Ajoutez un mana de la couleur choisie à votre réserve.
",
                typeEn = "Snow Artifact",
                typeFr = "Artefact neigeux"
            });
            context.Cards.Add(new Card
            {
                author = "John Matson",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14017&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 7,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14170,
                manaCost = "(5)(U)(U)",
                multiverseIdEn = 121243,
                multiverseIdFr = 127088,
                nameEn = "Commandeer",
                nameFr = "Réquisition",
                number = 29,
                picturePath = @"Coldsnap\Commandeer.jpg",
                power = "",
                price = 1.39196F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"You may exile two blue cards from your hand rather than pay Commandeer's mana cost.
Gain control of target noncreature spell. You may choose new targets for it. (If that spell is an artifact, enchantment, or planeswalker, the permanent enters the battlefield under your control.)
",
                textFr = @"Vous pouvez retirer de la partie deux cartes bleues de votre main à la place de payer le coût de mana de la Réquisition.
Acquérez le contrôle du sort non-créature ciblé. Vous pouvez lui choisir de nouvelles cibles. (Si ce sort est un artefact ou un enchantement, le permanent arrive en jeu sous votre contrôle.)
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Joel Thomas",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14018&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 4,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14171,
                manaCost = "(2)(U)(U)",
                multiverseIdEn = 122121,
                multiverseIdFr = 127089,
                nameEn = "Controvert",
                nameFr = "Controverse",
                number = 30,
                picturePath = @"Coldsnap\Controvert.jpg",
                power = "",
                price = 0.18156F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Counter target spell.
Recover (2)(U)(U) (When a creature is put into your graveyard from the battlefield, you may pay (2)(U)(U). If you do, return this card from your graveyard to your hand. Otherwise, exile this card.)
",
                textFr = @"Contrecarrez le sort ciblé.
Recouvrement (2)(U)(U) (Quand une créature est mise dans votre cimetière depuis le jeu, vous pouvez payer (2)(U)(U). Si vous faites ainsi, renvoyez cette carte dans votre main depuis votre cimetière. Sinon, retirez cette carte de la partie.)
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "John Zeleznik",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14019&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14172,
                manaCost = "(U)(U)",
                multiverseIdEn = 121159,
                multiverseIdFr = 127090,
                nameEn = "Counterbalance",
                nameFr = "Contrepoids",
                number = 31,
                picturePath = @"Coldsnap\Counterbalance.jpg",
                power = "",
                price = 4.970205F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Whenever an opponent casts a spell, you may reveal the top card of your library. If you do, counter that spell if it has the same converted mana cost as the revealed card.
",
                textFr = @"À chaque fois qu'un adversaire joue un sort, vous pouvez révéler la carte du dessus de votre bibliothèque. Si vous faites ainsi, contrecarrez ce sort s'il a le même coût converti de mana que la carte révélée.
",
                typeEn = "Enchantment",
                typeFr = "Enchantement"
            });
            context.Cards.Add(new Card
            {
                author = "Wayne Reynolds",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14020&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 3,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14173,
                manaCost = "(2)(W)",
                multiverseIdEn = 121140,
                multiverseIdFr = 127091,
                nameEn = "Cover of Winter",
                nameFr = "Couverture hivernale",
                number = 3,
                picturePath = @"Coldsnap\Cover of Winter.jpg",
                power = "",
                price = 0.264775F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Cumulative upkeep  (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.  can be paid with one mana from a snow permanent.)
If a creature would deal combat damage to you and/or one or more creatures you control, prevent X of that damage, where X is the number of age counters on Cover of Winter.
: Put an age counter on Cover of Winter.
",
                textFr = @"Entretien cumulatif  ( peut être payé avec un mana d'un permanent neigeux.)
Si une créature devait infliger des blessures de combat, à vous et/ou à une ou plusieurs créatures que vous contrôlez, prévenez X de ces blessures, X étant le nombre de marqueurs « âge » sur la Couverture hivernale.
&nbsp;: Mettez un marqueur «&nbsp;âge&nbsp;» sur la Couverture hivernale.
",
                typeEn = "Snow Enchantment",
                typeFr = "Enchantement neigeux"
            });
            context.Cards.Add(new Card
            {
                author = "Stephen Tappin",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14031&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 3,
                defense = 2,
                flavorEn = @"He is the only one who sees the patterns in the overlapping maps and conflicting reports.
",
                flavorFr = @"Les Chevaliers de Stromgald frappèrent le Perchoir de Darien sur deux flancs. Ils auraient pris le Kjeldor dans un étau sans les tacticiens de Darien.
",
                force = 2,
                id = 14184,
                manaCost = "(1)(W)(W)",
                multiverseIdEn = 121265,
                multiverseIdFr = 127102,
                nameEn = "Field Marshal",
                nameFr = "Général de campagne",
                number = 5,
                picturePath = @"Coldsnap\Field Marshal.jpg",
                power = "2 / 2",
                price = 3.52529F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Other Soldier creatures get +1/+1 and have first strike. (They deal combat damage before creatures without first strike.)
",
                textFr = @"Les autres soldats gagnent +1/+1 et ont l'initiative.
",
                typeEn = "Creature — Human Soldier",
                typeFr = "Créature  - humain et soldat"
            });
            context.Cards.Add(new Card
            {
                author = "Brian Despain",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14032&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"""Your downfall was not your ignorance, your weakness, or your hubris, but your warm blood.""
—Heidar, Rimewind master
",
                flavorFr = @"« La nature ? Le feu ? Pff  Tous deux sont chaotiques et difficiles à contrôler. La glace est structurée, ordonnée, légère comme une plume et aussi puissante qu'un glacier. C'est dans la glace qu'est le pouvoir  »
—Heidar, maître de Soufflegivre
",
                force = 0,
                id = 14185,
                manaCost = "(1)(U)",
                multiverseIdEn = 121218,
                multiverseIdFr = 127103,
                nameEn = "Flashfreeze",
                nameFr = "Gel immédiat",
                number = 33,
                picturePath = @"Coldsnap\Flashfreeze.jpg",
                power = "",
                price = 0.28747F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Counter target red or green spell.
",
                textFr = @"Contrecarrez le sort rouge ou vert ciblé.
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Thomas M. Baxa",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14033&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14186,
                manaCost = "(1)(G)",
                multiverseIdEn = 122059,
                multiverseIdFr = 127104,
                nameEn = "Freyalise’s Radiance",
                nameFr = "Irradiance selon Freyalise",
                number = 108,
                picturePath = @"Coldsnap\Freyalise's Radiance.jpg",
                power = "",
                price = 0.158865F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Cumulative upkeep (2) (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
Snow permanents don't untap during their controllers' untap steps.
",
                textFr = @"Entretien cumulatif (2) ((Au début de votre entretien, mettez un marqueur «&nbsp;âge&nbsp;» sur ce permanent, puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur «&nbsp;âge&nbsp;» sur lui.)
Les permanents neigeux ne se dégagent pas pendant les étapes de dégagement de leurs contrôleurs.
",
                typeEn = "Enchantment",
                typeFr = "Enchantement"
            });
            context.Cards.Add(new Card
            {
                author = "Jim Pavelec",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14034&amp;partner=URZGTHR",
                colorId = 7,
                convertedManaCost = 0,
                defense = 0,
                flavorEn = @"""Now caged in Winter's bitter chill,
Our people cry, their voices shrill—
Eternal cold breaks down their will.""
—The Dynasty of Winter Kings
",
                flavorFr = @"« Prisonnier du froid mordant de l'hiver,
Notre peuple se lamente et se désespère —
Le froid éternel ronge leur caractère. »
—La dynastie des Rois de l'hiver
",
                force = 0,
                id = 14187,
                manaCost = "",
                multiverseIdEn = 121212,
                multiverseIdFr = 127105,
                nameEn = "Frost Marsh",
                nameFr = "Marécage gelé",
                number = 146,
                picturePath = @"Coldsnap\Frost Marsh.jpg",
                power = "",
                price = 0.72624F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Frost Marsh enters the battlefield tapped.
(T): Add (U) or (B) to your mana pool.
",
                textFr = @"Le Marécage gelé arrive en jeu engagé.
(T)&nbsp;: Ajoutez (U) ou (B) à votre réserve.
",
                typeEn = "Snow Land",
                typeFr = "Terrain neigeux"
            });
            context.Cards.Add(new Card
            {
                author = "Lars Grant-West",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14035&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 3,
                defense = 2,
                flavorEn = @"The Rimewind wizards strove to perpetuate a magical winter. Their unnatural snows birthed unnatural beasts.
",
                flavorFr = @"Les sorciers de Soufflegivre visaient à perpétuer un hiver magique. Leur neige surnaturelle donna naissance à des bêtes contre-nature.
",
                force = 2,
                id = 14188,
                manaCost = "(2)(U)",
                multiverseIdEn = 121132,
                multiverseIdFr = 127106,
                nameEn = "Frost Raptor",
                nameFr = "Rapace de givre",
                number = 34,
                picturePath = @"Coldsnap\Frost Raptor.jpg",
                power = "2 / 2",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying
: Frost Raptor gains shroud until end of turn. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"Vol
&nbsp;: Le Rapace de givre ne peut pas être la cible de sorts ou de capacités ce tour-ci. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Creature — Bird",
                typeFr = "Créature neigeuse  - oiseau"
            });
            context.Cards.Add(new Card
            {
                author = "Greg Hildebrandt",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14036&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 3,
                defense = 3,
                flavorEn = @"Its white webs glitter, mimicking the frost on the tree's branches.
",
                flavorFr = @"Ses toiles blanches scintillent, imitant le givre sur les branches des arbres.
",
                force = 1,
                id = 14189,
                manaCost = "(2)(G)",
                multiverseIdEn = 121197,
                multiverseIdFr = 127107,
                nameEn = "Frostweb Spider",
                nameFr = "Araignée toilegivre",
                number = 109,
                picturePath = @"Coldsnap\Frostweb Spider.jpg",
                power = "1 / 3",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Reach (This creature can block creatures with flying.)
Whenever Frostweb Spider blocks a creature with flying, put a +1/+1 counter on Frostweb Spider at end of combat.
",
                textFr = @"L'Araignée toilegivre peut bloquer comme si elle avait le vol.
À chaque fois que l'Araignée toilegivre bloque une créature avec le vol, mettez un marqueur +1/+1 sur l'Araignée toilegivre à la fin du combat.
",
                typeEn = "Snow Creature — Spider",
                typeFr = "Créature neigeuse  - araignée"
            });
            context.Cards.Add(new Card
            {
                author = "Ralph Horsley",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14037&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 3,
                defense = 0,
                flavorEn = @"""Guard, fetch me a mallet.""
—Heidar, Rimewind master
",
                flavorFr = @"« Garde, va me chercher un marteau. »
—Heidar, maître de Soufflegivre
",
                force = 0,
                id = 14190,
                manaCost = "(1)(U)(U)",
                multiverseIdEn = 121228,
                multiverseIdFr = 127108,
                nameEn = "Frozen Solid",
                nameFr = "Gelé",
                number = 35,
                picturePath = @"Coldsnap\Frozen Solid.jpg",
                power = "",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Enchant creature 
Enchanted creature doesn't untap during its controller's untap step. 
When enchanted creature is dealt damage, destroy it.
",
                textFr = @"Enchanter : créature
La créature enchantée ne se dégage pas pendant l'étape de dégagement de son contrôleur.
Quand des blessures sont infligées à la créature enchantée, détruisez-la.
",
                typeEn = "Enchantment — Aura",
                typeFr = "Enchantement  - aura"
            });
            context.Cards.Add(new Card
            {
                author = "Stephen Tappin",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14038&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 7,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14191,
                manaCost = "(5)(R)(R)",
                multiverseIdEn = 121181,
                multiverseIdFr = 127109,
                nameEn = "Fury of the Horde",
                nameFr = "Fureur de la horde",
                number = 81,
                picturePath = @"Coldsnap\Fury of the Horde.jpg",
                power = "",
                price = 2.01229F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"You may exile two red cards from your hand rather than pay Fury of the Horde's mana cost.
Untap all creatures that attacked this turn. After this main phase, there is an additional combat phase followed by an additional main phase.
",
                textFr = @"Vous pouvez retirer de la partie deux cartes rouges de votre main à la place de payer le coût de mana de la Fureur de la horde.
Dégagez toutes les créatures qui ont attaqué ce tour-ci. Cette phase principale est suivie d'une phase de combat supplémentaire, puis d'une phase principale supplémentaire.
",
                typeEn = "Sorcery",
                typeFr = "Rituel"
            });
            context.Cards.Add(new Card
            {
                author = "Darrell Riche",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14039&amp;partner=URZGTHR",
                colorId = 8,
                convertedManaCost = 7,
                defense = 5,
                flavorEn = @"",
                flavorFr = @"",
                force = 5,
                id = 14192,
                manaCost = "(4)(U)(B)(R)",
                multiverseIdEn = 121126,
                multiverseIdFr = 127110,
                nameEn = "Garza Zol, Plague Queen",
                nameFr = "Garza Zol, reine de la peste",
                number = 129,
                picturePath = @"Coldsnap\Garza Zol, Plague Queen.jpg",
                power = "5 / 5",
                price = 0.62033F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying, haste
Whenever a creature dealt damage by Garza Zol, Plague Queen this turn dies, put a +1/+1 counter on Garza Zol.
Whenever Garza Zol deals combat damage to a player, you may draw a card.
",
                textFr = @"Vol, célérité
À chaque fois qu'une créature blessée par Garza Zol, reine de la peste ce tour-ci est mise dans un cimetière, mettez un marqueur +1/+1 sur Garza Zol.
À chaque fois que Garza Zol inflige des blessures de combat à un joueur, vous pouvez piocher une carte.
",
                typeEn = "Legendary Creature — Vampire",
                typeFr = "Créature légendaire  - vampire"
            });
            context.Cards.Add(new Card
            {
                author = "Parente",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14040&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 3,
                defense = 2,
                flavorEn = @"",
                flavorFr = @"",
                force = 2,
                id = 14193,
                manaCost = "(B)(B)(B)",
                multiverseIdEn = 122051,
                multiverseIdFr = 127111,
                nameEn = "Garza’s Assassin",
                nameFr = "Assassin de Garza",
                number = 57,
                picturePath = @"Coldsnap\Garza's Assassin.jpg",
                power = "2 / 2",
                price = 0.28747F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Sacrifice Garza's Assassin: Destroy target nonblack creature.
Recover—Pay half your life, rounded up. (When another creature is put into your graveyard from the battlefield, you may pay half your life, rounded up. If you do, return this card from your graveyard to your hand. Otherwise, exile this card.)
",
                textFr = @"Sacrifiez l'Assassin de Garza : Détruisez la créature non-noire ciblée.
Recouvrement — Payez la moitié de vos points de vie, arrondie à l'unité supérieure. (Quand une autre créature est mise dans votre cimetière depuis le jeu, vous pouvez payer la moitié de vos points de vie, arrondie à l'unité supérieure. Si vous faites ainsi, renvoyez cette carte dans votre main depuis votre cimetière. Sinon, retirez cette carte de la partie.)
",
                typeEn = "Creature — Human Assassin",
                typeFr = "Créature  - humain et assassin"
            });
            context.Cards.Add(new Card
            {
                author = "Alex Horley-Orlandelli",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14041&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 1,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14194,
                manaCost = "(W)",
                multiverseIdEn = 121213,
                multiverseIdFr = 127112,
                nameEn = "Gelid Shackles",
                nameFr = "Fers algides",
                number = 6,
                picturePath = @"Coldsnap\Gelid Shackles.jpg",
                power = "",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Enchant creature
Enchanted creature can't block, and its activated abilities can't be activated.
: Enchanted creature gains defender until end of turn. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"Enchanter : créature
La créature enchantée ne peut pas bloquer et ses capacités activées ne peuvent pas être jouées.
&nbsp;: La créature enchantée acquiert défenseur jusqu'à la fin du tour. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Enchantment — Aura",
                typeFr = "Enchantement neigeux  - aura"
            });
            context.Cards.Add(new Card
            {
                author = "Brian Despain",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14042&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 4,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14195,
                manaCost = "(2)(W)(W)",
                multiverseIdEn = 121211,
                multiverseIdFr = 127113,
                nameEn = "Glacial Plating",
                nameFr = "Blindage glacial",
                number = 7,
                picturePath = @"Coldsnap\Glacial Plating.jpg",
                power = "",
                price = 0.158865F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Enchant creature
Cumulative upkeep  (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.  can be paid with one mana from a snow permanent.)
Enchanted creature gets +3/+3 for each age counter on Glacial Plating.
",
                textFr = @"Enchanter : créature
Entretien cumulatif  (Au début de votre entretien, mettez un marqueur «&nbsp;âge&nbsp;» sur ce permanent puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur «&nbsp;âge&nbsp;» sur lui.  peut être payé avec un mana d'un permanent neigeux.)
La créature enchantée gagne +3/+3 pour chaque marqueur « âge » sur le Blindage glacial.
",
                typeEn = "Snow Enchantment — Aura",
                typeFr = "Enchantement neigeux  - aura"
            });
            context.Cards.Add(new Card
            {
                author = "Warren Mahy",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14043&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 2,
                defense = 2,
                flavorEn = @"Clambering up and over the powdery slope, the goblin chanced upon a small furry thing. There they regarded each other: the goblin and his new pair of earmuffs.
",
                flavorFr = @"Escaladant la pente neigeuse, le gobelin vit soudain une petite chose poilue. Ils restèrent tous deux immobiles : le gobelin face à sa prochaine paire de protège-oreilles.
",
                force = 2,
                id = 14196,
                manaCost = "(1)(R)",
                multiverseIdEn = 121185,
                multiverseIdFr = 127114,
                nameEn = "Goblin Furrier",
                nameFr = "Fourreur gobelin",
                number = 82,
                picturePath = @"Coldsnap\Goblin Furrier.jpg",
                power = "2 / 2",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Prevent all damage that Goblin Furrier would deal to snow creatures.
",
                textFr = @"Prévenez toutes les blessures que le Fourreur gobelin devrait infliger aux créatures neigeuses.
",
                typeEn = "Creature — Goblin Warrior",
                typeFr = "Créature  - gobelin et guerrier"
            });
            context.Cards.Add(new Card
            {
                author = "Christopher Rush",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14044&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 3,
                defense = 2,
                flavorEn = @"Rimerunners set off avalanches to immobilize foes as well as to create more challenging slopes.
",
                flavorFr = @"Les lamegivres déclenchent des avalanches pour paralyser leurs ennemis et créer des pistes plus redoutables.
",
                force = 2,
                id = 14197,
                manaCost = "(2)(R)",
                multiverseIdEn = 121219,
                multiverseIdFr = 127115,
                nameEn = "Goblin Rimerunner",
                nameFr = "Lamegivre gobelin",
                number = 83,
                picturePath = @"Coldsnap\Goblin Rimerunner.jpg",
                power = "2 / 2",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(T): Target creature can't block this turn.
: Goblin Rimerunner gains haste until end of turn. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"(T)&nbsp;: La créature ciblée ne peut pas bloquer ce tour-ci.
&nbsp;: Le Lamegivre gobelin acquiert la célérité jusqu'à la fin du tour. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Creature — Goblin Warrior",
                typeFr = "Créature neigeuse  - gobelin et guerrier"
            });
            context.Cards.Add(new Card
            {
                author = "Yokota Katsumi",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14045&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 6,
                defense = 4,
                flavorEn = @"Having charted their way up the difficult face, the two mountaineers had to contend with the mountain's decision to stand up.
",
                flavorFr = @"Ayant préparé leur difficile escalade, les deux montagnards furent très surpris de voir la montagne se lever.
",
                force = 4,
                id = 14198,
                manaCost = "(4)(R)(R)",
                multiverseIdEn = 121208,
                multiverseIdFr = 127116,
                nameEn = "Greater Stone Spirit",
                nameFr = "Grand esprit de pierre",
                number = 84,
                picturePath = @"Coldsnap\Greater Stone Spirit.jpg",
                power = "4 / 4",
                price = 0.158865F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Greater Stone Spirit can't be blocked by creatures with flying.
(2)(R): Until end of turn, target creature gets +0/+2 and gains ""(R): This creature gets +1/+0 until end of turn.""
",
                textFr = @"Le Grand esprit de pierre ne peut pas être bloqué par les créatures avec le vol.
(2)(R)&nbsp;: Jusqu'à la fin du tour, la créature ciblée gagne +0/+2 et acquiert «&nbsp;(R)&nbsp;: Cette créature gagne +1/+0 jusqu'à la fin du tour.&nbsp;»
",
                typeEn = "Creature — Elemental Spirit",
                typeFr = "Créature  - élémental et esprit"
            });
            context.Cards.Add(new Card
            {
                author = "John Avon",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14053&amp;partner=URZGTHR",
                colorId = 7,
                convertedManaCost = 0,
                defense = 0,
                flavorEn = @"""Our noble land, enslaved by Rime,
Is it our fate to freeze through time?
If this be true, oh wicked crime.""
—The Dynasty of Winter Kings
",
                flavorFr = @"« Le Givre a conquis notre noble contrée,
Est-ce notre destinée de geler pour l'éternité ?
Qu'avons-nous fait pour le mériter ? »
—La dynastie des Rois de l'hiver
",
                force = 0,
                id = 14206,
                manaCost = "",
                multiverseIdEn = 121259,
                multiverseIdFr = 127124,
                nameEn = "Highland Weald",
                nameFr = "Sylve des hautes terres",
                number = 147,
                picturePath = @"Coldsnap\Highland Weald.jpg",
                power = "",
                price = 0.49929F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Highland Weald enters the battlefield tapped.
(T): Add (R) or (G) to your mana pool.
",
                textFr = @"La Sylve des hautes terres arrive en jeu engagée.
(T)&nbsp;: Ajoutez (R) ou (G) à votre réserve.
",
                typeEn = "Snow Land",
                typeFr = "Terrain neigeux"
            });
            context.Cards.Add(new Card
            {
                author = "Warren Mahy",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14054&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 4,
                defense = 0,
                flavorEn = @"As the Thaw met Terisiare, mountains shed their icy skins, crushing homes and hopes alike.
",
                flavorFr = @"Quand le Dégel s'abattit sur Terisiare, espoir et maisons furent écrasés par le manteau de glace des montagnes.
",
                force = 0,
                id = 14207,
                manaCost = "(2)(R)(R)",
                multiverseIdEn = 121143,
                multiverseIdFr = 127125,
                nameEn = "Icefall",
                nameFr = "Chuteglace",
                number = 85,
                picturePath = @"Coldsnap\Icefall.jpg",
                power = "",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Destroy target artifact or land.
Recover (R)(R) (When a creature is put into your graveyard from the battlefield, you may pay (R)(R). If you do, return this card from your graveyard to your hand. Otherwise, exile this card.)
",
                textFr = @"Détruisez l'artefact ciblé ou le terrain ciblé.
Recouvrement (R)(R) (Quand une créature est mise dans votre cimetière depuis le jeu, vous pouvez payer (R)(R). Si vous faites ainsi, renvoyez cette carte dans votre main depuis votre cimetière. Sinon, retirez cette carte de la partie.)
",
                typeEn = "Sorcery",
                typeFr = "Rituel"
            });
            context.Cards.Add(new Card
            {
                author = "Richard Sardinha",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14055&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"""Our border lands fall under the grip of Heidar's second winter. Go forth and reclaim them for Yavimaya.""
—Kaysa, elder druid of the Juniper Order
",
                flavorFr = @"« Nos terres frontalières subissent l'assaut du deuxième hiver de Heidar. Récupérez-les au nom de la Yavimaya. »
—Kaysa, doyenne des druides de l'Ordre du genévrier
",
                force = 0,
                id = 14208,
                manaCost = "(1)(G)",
                multiverseIdEn = 121199,
                multiverseIdFr = 127126,
                nameEn = "Into the North",
                nameFr = "Vers le Nord",
                number = 111,
                picturePath = @"Coldsnap\Into the North.jpg",
                power = "",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Search your library for a snow land card and put it onto the battlefield tapped. Then shuffle your library.
",
                textFr = @"Cherchez dans votre bibliothèque une carte de terrain neigeux et mettez-la en jeu engagée. Mélangez ensuite votre bibliothèque.
",
                typeEn = "Sorcery",
                typeFr = "Rituel"
            });
            context.Cards.Add(new Card
            {
                author = "Matt Cavotta",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14056&amp;partner=URZGTHR",
                colorId = 6,
                convertedManaCost = 3,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14209,
                manaCost = "(3)",
                multiverseIdEn = 122066,
                multiverseIdFr = 127127,
                nameEn = "Jester’s Scepter",
                nameFr = "Sceptre du bouffon",
                number = 137,
                picturePath = @"Coldsnap\Jester's Scepter.jpg",
                power = "",
                price = 0.582505F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"When Jester's Scepter enters the battlefield, exile the top five cards of target player's library face down. You may look at those cards for as long as they remain exiled.
(2), (T), Put a card exiled with Jester's Scepter into its owner's graveyard: Counter target spell if it has the same name as that card.
",
                textFr = @"Quand le Sceptre du bouffon arrive en jeu, retirez de la partie, face cachée, les cinq cartes du dessus de la bibliothèque du joueur ciblé. Vous pouvez regarder ces cartes tant qu'elles restent retirées de la partie.
(2), (T), mettez une carte retirée de la partie par le Sceptre du bouffon dans le cimetière de son propriétaire&nbsp;: Contrecarrez le sort ciblé s'il a le même nom que cette carte.
",
                typeEn = "Artifact",
                typeFr = "Artefact"
            });
            context.Cards.Add(new Card
            {
                author = "Mark Zug",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14057&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 7,
                defense = 12,
                flavorEn = @"",
                flavorFr = @"",
                force = 12,
                id = 14210,
                manaCost = "(4)(U)(U)(U)",
                multiverseIdEn = 121198,
                multiverseIdFr = 127128,
                nameEn = "Jokulmorder",
                nameFr = "Jokulmorder",
                number = 37,
                picturePath = @"Coldsnap\Jokulmorder.jpg",
                power = "12 / 12",
                price = 0.27234F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Trample
Jokulmorder enters the battlefield tapped.
When Jokulmorder enters the battlefield, sacrifice it unless you sacrifice five lands.
Jokulmorder doesn't untap during your untap step.
Whenever you play an Island, you may untap Jokulmorder.
",
                textFr = @"Piétinement
Le Jokulmorder arrive en jeu engagé.
Quand le Jokulmorder arrive en jeu, sacrifiez-le à moins que vous ne sacrifiiez cinq terrains.
Le Jokulmorder ne se dégage pas pendant votre étape de dégagement.
À chaque fois que vous jouez une île, vous pouvez dégager le Jokulmorder.
",
                typeEn = "Creature — Leviathan",
                typeFr = "Créature  - léviathan"
            });
            context.Cards.Add(new Card
            {
                author = "Franz Vohwinkel",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14058&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 2,
                defense = 4,
                flavorEn = @"",
                flavorFr = @"",
                force = 4,
                id = 14211,
                manaCost = "(1)(W)",
                multiverseIdEn = 122075,
                multiverseIdFr = 127129,
                nameEn = "Jötun Grunt",
                nameFr = "Grognard jötun",
                number = 8,
                picturePath = @"Coldsnap\Jötun Grunt.jpg",
                power = "4 / 4",
                price = 0.9078F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Cumulative upkeep—Put two cards from a single graveyard on the bottom of their owner's library. (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
",
                textFr = @"Entretien cumulatif — Mettez deux cartes d'un cimetière unique au-dessous de la bibliothèque de leur propriétaire. (Au début de votre entretien, mettez un marqueur « âge » sur ce permanent puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur « âge » sur lui.)
",
                typeEn = "Creature — Giant Soldier",
                typeFr = "Créature  - géant et soldat"
            });
            context.Cards.Add(new Card
            {
                author = "Dave Dorman",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14059&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 3,
                defense = 3,
                flavorEn = @"",
                flavorFr = @"",
                force = 3,
                id = 14212,
                manaCost = "(2)(W)",
                multiverseIdEn = 121236,
                multiverseIdFr = 127130,
                nameEn = "Jötun Owl Keeper",
                nameFr = "Garde-hibou jötun",
                number = 9,
                picturePath = @"Coldsnap\Jötun Owl Keeper.jpg",
                power = "3 / 3",
                price = 0.16643F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Cumulative upkeep (W) or (U) (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
When Jötun Owl Keeper dies, put a 1/1 white Bird creature token with flying onto the battlefield for each age counter on it.
",
                textFr = @"Entretien cumulatif (W) ou (U) (Au début de votre entretien, mettez un marqueur «&nbsp;âge&nbsp;» sur ce permanent puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur «&nbsp;âge&nbsp;» sur lui.)
Quand le Garde-hibou jötun est mis dans un cimetière depuis le jeu, mettez en jeu un jeton de créature 1/1 blanche Oiseau avec le vol pour chaque marqueur « âge » sur lui.
",
                typeEn = "Creature — Giant",
                typeFr = "Créature  - géant"
            });
            context.Cards.Add(new Card
            {
                author = "Greg Hildebrandt",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14060&amp;partner=URZGTHR",
                colorId = 8,
                convertedManaCost = 5,
                defense = 4,
                flavorEn = @"To protect the alliance between Kjeldor and Yavimaya, they trained in the ways of both.
",
                flavorFr = @"Leur entraînement incorporait les stratégies du Kjeldor et de la Yavimaya pour protéger leur alliance.
",
                force = 2,
                id = 14213,
                manaCost = "(3)(G)(W)",
                multiverseIdEn = 121172,
                multiverseIdFr = 127131,
                nameEn = "Juniper Order Ranger",
                nameFr = "Ranger de l’Ordre du genévrier",
                number = 130,
                picturePath = @"Coldsnap\Juniper Order Ranger.jpg",
                power = "2 / 4",
                price = 0.945625F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Whenever another creature enters the battlefield under your control, put a +1/+1 counter on that creature and a +1/+1 counter on Juniper Order Ranger.
",
                textFr = @"À chaque fois qu'une autre créature arrive en jeu sous votre contrôle, mettez un marqueur +1/+1 sur cette créature et un marqueur +1/+1 sur le Ranger de l'Ordre du genévrier.
",
                typeEn = "Creature — Human Knight",
                typeFr = "Créature  - humain et chevalier"
            });
            context.Cards.Add(new Card
            {
                author = "Zoltan Boros & Gabor Szikszai",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14046&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14199,
                manaCost = "(1)(B)",
                multiverseIdEn = 122114,
                multiverseIdFr = 127117,
                nameEn = "Grim Harvest",
                nameFr = "Sinistre récolte",
                number = 58,
                picturePath = @"Coldsnap\Grim Harvest.jpg",
                power = "",
                price = 0.143735F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Return target creature card from your graveyard to your hand.
Recover (2)(B) (When a creature is put into your graveyard from the battlefield, you may pay (2)(B). If you do, return this card from your graveyard to your hand. Otherwise, exile this card.)
",
                textFr = @"Renvoyez une carte de créature ciblée depuis votre cimetière dans votre main.
Recouvrement (2)(B) (Quand une créature est mise dans votre cimetière depuis le jeu, vous pouvez payer (2)(B). Si vous faites ainsi, renvoyez cette carte dans votre main depuis votre cimetière. Sinon, retirez cette carte de la partie.)
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Dave Allsop",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14047&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 5,
                defense = 3,
                flavorEn = @"""There it was, clawing the ice as it chittered and clicked its teeth. We fled in horror before it unearthed its grisly meal.""
—Aevar Borg, northern guide, journal entry
",
                flavorFr = @"« Il se tenait là, creusant la glace avec ses griffes et faisant grincer ses dents. Nous avons fui, horrifiés, avant qu'il ne déterre son révoltant repas. »
—Ævar Borg, guide du Nord, extrait de journal
",
                force = 3,
                id = 14200,
                manaCost = "(4)(B)",
                multiverseIdEn = 121133,
                multiverseIdFr = 127118,
                nameEn = "Gristle Grinner",
                nameFr = "Grimaceur aux ligaments",
                number = 59,
                picturePath = @"Coldsnap\Gristle Grinner.jpg",
                power = "3 / 3",
                price = 0.158865F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Whenever a creature dies, Gristle Grinner gets +2/+2 until end of turn.
",
                textFr = @"À chaque fois qu'une créature est mise dans un cimetière depuis le jeu, le Grimaceur aux ligaments gagne +2/+2 jusqu'à la fin du tour.
",
                typeEn = "Creature — Zombie",
                typeFr = "Créature  - zombie"
            });
            context.Cards.Add(new Card
            {
                author = "Kensuke Okabayashi",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14048&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 3,
                defense = 2,
                flavorEn = @"""Make sure those wretches feed only upon the plagued. The blood of the healthy is reserved for me alone.""
—Garza Zol, plague queen
",
                flavorFr = @"« Assure-toi que ces misérables ne se nourrissent que des pestiférés. Le sang de ceux qui ne sont pas contaminés m'est réservé. »
—Garza Zol, reine de la peste
",
                force = 2,
                id = 14201,
                manaCost = "(2)(B)",
                multiverseIdEn = 121194,
                multiverseIdFr = 127119,
                nameEn = "Gutless Ghoul",
                nameFr = "Goule au foie blanc",
                number = 60,
                picturePath = @"Coldsnap\Gutless Ghoul.jpg",
                power = "2 / 2",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(1), Sacrifice a creature: You gain 2 life.
",
                textFr = @"(1), sacrifiez une créature&nbsp;: Vous gagnez 2 points de vie.
",
                typeEn = "Snow Creature — Zombie",
                typeFr = "Créature neigeuse  - zombie"
            });
            context.Cards.Add(new Card
            {
                author = "Mark Zug",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14049&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 3,
                defense = 3,
                flavorEn = @"",
                flavorFr = @"",
                force = 3,
                id = 14202,
                manaCost = "(1)(B)(B)",
                multiverseIdEn = 122045,
                multiverseIdFr = 127120,
                nameEn = "Haakon, Stromgald Scourge",
                nameFr = "Haakon, plaie de Stromgald",
                number = 61,
                picturePath = @"Coldsnap\Haakon, Stromgald Scourge.jpg",
                power = "3 / 3",
                price = 2.36028F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"You may cast Haakon, Stromgald Scourge from your graveyard, but not from anywhere else.
As long as Haakon is on the battlefield, you may play Knight cards from your graveyard.
When Haakon dies, you lose 2 life.
",
                textFr = @"Vous pouvez jouer Haakon, plaie de Stromgald depuis votre cimetière, mais pas depuis une autre zone.
Tant que Haakon est en jeu, vous pouvez jouer des cartes de chevalier depuis votre cimetière.
Quand Haakon est mis dans un cimetière depuis le jeu, vous perdez 2 points de vie.
",
                typeEn = "Legendary Creature — Zombie Knight",
                typeFr = "Créature légendaire  - zombie et chevalier"
            });
            context.Cards.Add(new Card
            {
                author = "Ron Spears",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14050&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 5,
                defense = 3,
                flavorEn = @"""The umber stain of the Thaw will be bleached away. Once again the world will be sharp, white, perfect""
",
                flavorFr = @"« La tache sombre du Dégel sera effacée. Le monde sera à nouveau blanc, tranchant et parfait  »
",
                force = 3,
                id = 14203,
                manaCost = "(4)(U)",
                multiverseIdEn = 121147,
                multiverseIdFr = 127121,
                nameEn = "Heidar, Rimewind Master",
                nameFr = "Heidar, maître de Soufflegivre",
                number = 36,
                picturePath = @"Coldsnap\Heidar, Rimewind Master.jpg",
                power = "3 / 3",
                price = 0.27234F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(2), (T): Return target permanent to its owner's hand. Activate this ability only if you control four or more snow permanents.
",
                textFr = @"(2), (T)&nbsp;: Renvoyez le permanent ciblé dans la main de son propriétaire. Ne jouez cette capacité que si vous contrôlez au moins quatre permanents neigeux.
",
                typeEn = "Legendary Creature — Human Wizard",
                typeFr = "Créature légendaire  - humain et sorcier"
            });
            context.Cards.Add(new Card
            {
                author = "Alex Horley-Orlandelli",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14051&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 7,
                defense = 4,
                flavorEn = @"",
                flavorFr = @"",
                force = 2,
                id = 14204,
                manaCost = "(6)(B)",
                multiverseIdEn = 121250,
                multiverseIdFr = 127122,
                nameEn = "Herald of Leshrac",
                nameFr = "Héraut de Leshrac",
                number = 62,
                picturePath = @"Coldsnap\Herald of Leshrac.jpg",
                power = "2 / 4",
                price = 0.74137F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying
Cumulative upkeep—Gain control of a land you don't control. (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
Herald of Leshrac gets +1/+1 for each land you control but don't own.
When Herald of Leshrac leaves the battlefield, each player gains control of each land he or she owns that you control.
",
                textFr = @"Vol
Entretien cumulatif — Acquérez le contrôle d'un terrain que vous ne contrôlez pas.
Le Héraut de Leshrac gagne +1/+1 pour chaque terrain que vous contrôlez mais que vous ne possédez pas.
Quand le Héraut de Leshrac quitte le jeu, chaque joueur acquiert le contrôle de chaque terrain qu'il possède que vous contrôlez.
",
                typeEn = "Creature — Avatar",
                typeFr = "Créature  - avatar"
            });
            context.Cards.Add(new Card
            {
                author = "Steven Belledin",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14052&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 5,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14205,
                manaCost = "(4)(G)",
                multiverseIdEn = 121139,
                multiverseIdFr = 127123,
                nameEn = "Hibernation’s End",
                nameFr = "Fin de l’hibernation",
                number = 110,
                picturePath = @"Coldsnap\Hibernation's End.jpg",
                power = "",
                price = 0.310165F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Cumulative upkeep (1) (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
Whenever you pay Hibernation's End's cumulative upkeep, you may search your library for a creature card with converted mana cost equal to the number of age counters on Hibernation's End and put it onto the battlefield. If you do, shuffle your library.
",
                textFr = @"Entretien cumulatif (1)
À chaque fois que vous payez l'entretien cumulatif de la Fin de l'hibernation, vous pouvez chercher dans votre bibliothèque une carte de créature avec un coût converti de mana égal au nombre de marqueurs « âge » sur la Fin de l'hibernation et la mettre en jeu. Si vous faites ainsi, mélangez votre bibliothèque.
",
                typeEn = "Enchantment",
                typeFr = "Enchantement"
            });
            context.Cards.Add(new Card
            {
                author = "Wayne England",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14061&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 4,
                defense = 3,
                flavorEn = @"",
                flavorFr = @"",
                force = 3,
                id = 14214,
                manaCost = "(2)(R)(R)",
                multiverseIdEn = 122070,
                multiverseIdFr = 127132,
                nameEn = "Karplusan Minotaur",
                nameFr = "Minotaure karpluséan",
                number = 86,
                picturePath = @"Coldsnap\Karplusan Minotaur.jpg",
                power = "3 / 3",
                price = 0.36312F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Cumulative upkeep—Flip a coin. (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
Whenever you win a coin flip, Karplusan Minotaur deals 1 damage to target creature or player.
Whenever you lose a coin flip, Karplusan Minotaur deals 1 damage to target creature or player of an opponent's choice.
",
                textFr = @"Entretien cumulatif — Jouez à pile ou face.
À chaque fois que vous gagnez un pile ou face, le Minotaure karpluséan inflige 1 blessure à une cible, créature ou joueur.
À chaque fois que vous perdez un pile ou face, le Minotaure karpluséan inflige 1 blessure à une cible, créature ou joueur, choisie par un adversaire.
",
                typeEn = "Creature — Minotaur Warrior",
                typeFr = "Créature  - minotaure et guerrier"
            });
            context.Cards.Add(new Card
            {
                author = "Dan Scott",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14062&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 4,
                defense = 4,
                flavorEn = @"The strider's long, loping gait is an adaptation that allows it to move quickly in deep snow.
",
                flavorFr = @"L'étrange et longue démarche de l'enjambeur est une adaptation qui lui permet d'avancer rapidement dans la neige.
",
                force = 3,
                id = 14215,
                manaCost = "(3)(G)",
                multiverseIdEn = 121214,
                multiverseIdFr = 127133,
                nameEn = "Karplusan Strider",
                nameFr = "Enjambeur karpluséan",
                number = 112,
                picturePath = @"Coldsnap\Karplusan Strider.jpg",
                power = "3 / 4",
                price = 0.158865F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Karplusan Strider can't be the target of blue or black spells.
",
                textFr = @"L'Enjambeur karpluséan ne peut pas être la cible de sorts bleus ou noirs.
",
                typeEn = "Creature — Yeti",
                typeFr = "Créature  - yeti"
            });
            context.Cards.Add(new Card
            {
                author = "Greg Hildebrandt",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14063&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 1,
                defense = 1,
                flavorEn = @"""They're not easily trained. Fortunately, they already know how to kill.""
—Lovisa Coldeyes, Balduvian chieftain
",
                flavorFr = @"« Ils ne sont pas facilement dressés. Heureusement, ils savent déjà tuer. »
—Lovisa Froid Regard, cheffesse balduviane
",
                force = 1,
                id = 14216,
                manaCost = "(R)",
                multiverseIdEn = 121179,
                multiverseIdFr = 127134,
                nameEn = "Karplusan Wolverine",
                nameFr = "Glouton karpluséan",
                number = 87,
                picturePath = @"Coldsnap\Karplusan Wolverine.jpg",
                power = "1 / 1",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Whenever Karplusan Wolverine becomes blocked, you may have it deal 1 damage to target creature or player.
",
                textFr = @"À chaque fois que le Glouton karpluséan devient bloqué, vous pouvez faire qu'il inflige 1 blessure à une cible, créature ou joueur.
",
                typeEn = "Snow Creature — Wolverine Beast",
                typeFr = "Créature neigeuse  - bête"
            });
            context.Cards.Add(new Card
            {
                author = "Marcelo Vignali",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14064&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 6,
                defense = 3,
                flavorEn = @"The gargoyles were taken from the walls of flooded Kjeldoran cities and brought upland to guard the outposts of New Argive.
",
                flavorFr = @"Les gargouilles furent détachées des murs des villes kjeldoriennes inondées et transportées dans les hauteurs pour garder les avant-postes de la Nouvelle Argive.
",
                force = 3,
                id = 14217,
                manaCost = "(5)(W)",
                multiverseIdEn = 121207,
                multiverseIdFr = 127135,
                nameEn = "Kjeldoran Gargoyle",
                nameFr = "Gargouille kjeldorienne",
                number = 10,
                picturePath = @"Coldsnap\Kjeldoran Gargoyle.jpg",
                power = "3 / 3",
                price = 0.1513F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying, first strike
Whenever Kjeldoran Gargoyle deals damage, you gain that much life.
",
                textFr = @"Vol, initiative
À chaque fois que la Gargouille kjeldorienne inflige des blessures, vous gagnez autant de points de vie.
",
                typeEn = "Creature — Gargoyle",
                typeFr = "Créature  - gargouille"
            });
            context.Cards.Add(new Card
            {
                author = "Luca Zontini",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14073&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 3,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14226,
                manaCost = "(1)(R)(R)",
                multiverseIdEn = 121495,
                multiverseIdFr = 127144,
                nameEn = "Lightning Storm",
                nameFr = "Orage d’éclairs",
                number = 89,
                picturePath = @"Coldsnap\Lightning Storm.jpg",
                power = "",
                price = 0.189125F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Lightning Storm deals X damage to target creature or player, where X is 3 plus the number of charge counters on it.
Discard a land card: Put two charge counters on Lightning Storm. You may choose a new target for it. Any player may activate this ability but only if Lightning Storm is on the stack.
",
                textFr = @"L'Orage d'éclairs inflige X blessures à une cible, créature ou joueur, X étant 3 plus le nombre de marqueurs « charge » sur lui.
Défaussez-vous d'une carte de terrain : Mettez deux marqueurs « charge » sur l'Orage d'éclairs. Vous pouvez lui choisir une nouvelle cible. N'importe quel joueur peut jouer cette capacité, mais uniquement si l'Orage d'éclairs est sur la pile.
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Carl Critchlow",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14066&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 2,
                defense = 2,
                flavorEn = @"""I listen to people. He sniffs the wind. And we both sense something big coming. Something very big.""
",
                flavorFr = @"« J'écoute les gens. Il renifle le vent. Et nous sentons tous les deux que quelque chose approche. Quelque chose de très gros. »
",
                force = 2,
                id = 14219,
                manaCost = "(1)(W)",
                multiverseIdEn = 121188,
                multiverseIdFr = 127137,
                nameEn = "Kjeldoran Outrider",
                nameFr = "Cavalier kjeldorien",
                number = 12,
                picturePath = @"Coldsnap\Kjeldoran Outrider.jpg",
                power = "2 / 2",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(W): Kjeldoran Outrider gets +0/+1 until end of turn.
",
                textFr = @"(W)&nbsp;: Le Cavalier kjelkdorien gagne +0/+1 jusqu'à la fin du tour.
",
                typeEn = "Creature — Human Soldier",
                typeFr = "Créature  - humain et soldat"
            });
            context.Cards.Add(new Card
            {
                author = "Michael Phillippi",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14067&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"King Darien's breath crystallized and fell to the frozen battlefield, but its command carried true to all soldiers of New Argive.
",
                flavorFr = @"Le souffle du roi Darien se cristallisa dans le froid du champ de bataille, mais son ordre parvint à tous les soldats de la Nouvelle Argive.
",
                force = 0,
                id = 14220,
                manaCost = "(1)(W)",
                multiverseIdEn = 121148,
                multiverseIdFr = 127138,
                nameEn = "Kjeldoran War Cry",
                nameFr = "Cri de guerre kjeldorien",
                number = 13,
                picturePath = @"Coldsnap\Kjeldoran War Cry.jpg",
                power = "",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Creatures you control get +X/+X until end of turn, where X is 1 plus the number of cards named Kjeldoran War Cry in all graveyards.
",
                textFr = @"Les créatures que vous contrôlez gagnent +X/+X jusqu'à la fin du tour, X étant 1 plus le nombre de cartes appelées Cri de guerre kjeldorien dans tous les cimetières.
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Jeremy Jarvis",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14068&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"Plague-induced dreams became real as they swirled above Krov, mingling with the magical residue of the World Spell.
",
                flavorFr = @"Les rêves nés de la peste, tourbillonnant au-dessus de Krov, devinrent réalité en se mêlant aux résidus magiques de l'Enchantement du monde.
",
                force = 0,
                id = 14221,
                manaCost = "(1)(U)",
                multiverseIdEn = 122047,
                multiverseIdFr = 127139,
                nameEn = "Krovikan Mist",
                nameFr = "Brume krovoise",
                number = 38,
                picturePath = @"Coldsnap\Krovikan Mist.jpg",
                power = "* / *",
                price = 0.431205F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying
Krovikan Mist's power and toughness are each equal to the number of Illusions on the battlefield.
",
                textFr = @"Vol 
La force et l'endurance de la Brume krovoise sont chacune égale au nombre d'illusions en jeu.
",
                typeEn = "Creature — Illusion",
                typeFr = "Créature  - illusion"
            });
            context.Cards.Add(new Card
            {
                author = "Michael Sutfin",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14069&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 3,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14222,
                manaCost = "(2)(B)",
                multiverseIdEn = 122050,
                multiverseIdFr = 127140,
                nameEn = "Krovikan Rot",
                nameFr = "Pourrissement krovois",
                number = 63,
                picturePath = @"Coldsnap\Krovikan Rot.jpg",
                power = "",
                price = 0.1513F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Destroy target creature with power 2 or less.
Recover (1)(B)(B) (When a creature is put into your graveyard from the battlefield, you may pay (1)(B)(B). If you do, return this card from your graveyard to your hand. Otherwise, exile this card.)
",
                textFr = @"Détruisez la créature ciblée de force 2 ou moins.
Recouvrement (1)(B)(B) (Quand une créature est mise dans votre cimetière depuis le jeu, vous pouvez payer (1)(B)(B). Si vous faites ainsi, renvoyez cette carte dans votre main depuis votre cimetière. Sinon, retirez cette carte de la partie.)
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Ralph Horsley",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14070&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 2,
                defense = 1,
                flavorEn = @"The few surviving humans of Krov would have welcomed the return of winter and its sterilizing cold. They often peered northward, hoping that the snow's edge had reached their infested city-tomb.
",
                flavorFr = @"Les quelques humains survivants à Krov auraient voulu le retour de l'hiver et de son froid stérilisant. Souvent, ils regardaient vers le Nord, espérant que la neige atteindrait enfin leur tombe-cité infestée.
",
                force = 2,
                id = 14223,
                manaCost = "(1)(B)",
                multiverseIdEn = 121226,
                multiverseIdFr = 127141,
                nameEn = "Krovikan Scoundrel",
                nameFr = "Vaurien krovois",
                number = 64,
                picturePath = @"Coldsnap\Krovikan Scoundrel.jpg",
                power = "2 / 1",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"",
                textFr = @"",
                typeEn = "Creature — Human Rogue",
                typeFr = "Créature  - humain et gredin"
            });
            context.Cards.Add(new Card
            {
                author = "Nick Percival",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14071&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 4,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14224,
                manaCost = "(3)(U)",
                multiverseIdEn = 121493,
                multiverseIdFr = 127142,
                nameEn = "Krovikan Whispers",
                nameFr = "Chuchotements krovois",
                number = 39,
                picturePath = @"Coldsnap\Krovikan Whispers.jpg",
                power = "",
                price = 0.158865F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Enchant creature
Cumulative upkeep (U) or (B) (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
You control enchanted creature.
When Krovikan Whispers is put into a graveyard from the battlefield, you lose 2 life for each age counter on it.
",
                textFr = @"Enchanter : créature
Entretien cumulatif (U) ou (B)
Vous contrôlez la créature enchantée.
Quand les Chuchotements krovois sont mis dans un cimetière depuis le jeu, vous perdez 2 points de vie pour chaque marqueur « âge » sur eux.
",
                typeEn = "Enchantment — Aura",
                typeFr = "Enchantement  - aura"
            });
            context.Cards.Add(new Card
            {
                author = "John Avon",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14072&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 1,
                defense = 1,
                flavorEn = @"Ice exploded into steam in its wake, hissing like a thousand serpents hailing their blazing master.
",
                flavorFr = @"Sur son sillage, la glace explosait dans une gerbe de vapeur, sifflant comme mille serpents saluant leur maître incandescent.
",
                force = 2,
                id = 14225,
                manaCost = "(X)(R)",
                multiverseIdEn = 121220,
                multiverseIdFr = 127143,
                nameEn = "Lightning Serpent",
                nameFr = "Serpent d’éclairs",
                number = 88,
                picturePath = @"Coldsnap\Lightning Serpent.jpg",
                power = "2 / 1",
                price = 0.991015F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Trample, haste
Lightning Serpent enters the battlefield with X +1/+0 counters on it.
At the beginning of the end step, sacrifice Lightning Serpent.
",
                textFr = @"Piétinement, célérité
Le Serpent d'éclairs arrive en jeu avec, sur lui, X marqueurs +1/+0.
À la fin du tour, sacrifiez le Serpent d'éclairs.
",
                typeEn = "Creature — Elemental Serpent",
                typeFr = "Créature  - élémental et serpent"
            });
            context.Cards.Add(new Card
            {
                author = "Dan Scott",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14081&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 1,
                defense = 1,
                flavorEn = @"""Weep not for me. I will rise with the spring's new growth.""
",
                flavorFr = @"« Ne me pleurez pas. Je serai de retour quand viendra le printemps. »
",
                force = 1,
                id = 14234,
                manaCost = "(G)",
                multiverseIdEn = 121145,
                multiverseIdFr = 127152,
                nameEn = "Martyr of Spores",
                nameFr = "Martyre aux spores",
                number = 113,
                picturePath = @"Coldsnap\Martyr of Spores.jpg",
                power = "1 / 1",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(1), Reveal X green cards from your hand, Sacrifice Martyr of Spores: Target creature gets +X/+X until end of turn.
",
                textFr = @"(1), révélez X cartes vertes depuis votre main, sacrifiez la Martyre aux spores&nbsp;: La créature ciblée gagne +X/+X jusqu'à la fin du tour.
",
                typeEn = "Creature — Human Shaman",
                typeFr = "Créature  - humain et shamane"
            });
            context.Cards.Add(new Card
            {
                author = "Brian Snoddy",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14074&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 5,
                defense = 3,
                flavorEn = @"""I lead my horde to the northwest. I won't return until the ice wizards fall and their fiendish contraptions are crushed""
",
                flavorFr = @"« Je mène ma horde vers le Nord-ouest. Je ne reviendrai pas avant la mort des sorciers des glaces et la destruction de leurs machines infernales. »
",
                force = 3,
                id = 14227,
                manaCost = "(3)(R)(R)",
                multiverseIdEn = 113542,
                multiverseIdFr = 127145,
                nameEn = "Lovisa Coldeyes",
                nameFr = "Lovisa Froid Regard",
                number = 90,
                picturePath = @"Coldsnap\Lovisa Coldeyes.jpg",
                power = "3 / 3",
                price = 0.416075F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Warrior, Berserker, and/or other Barbarian creatures get +2/+2 and have haste.
",
                textFr = @"Les barbares, guerriers et berserkers gagnent +2/+2 et ont la célérité.
",
                typeEn = "Legendary Creature — Human Barbarian",
                typeFr = "Créature légendaire  - humain et seigneur"
            });
            context.Cards.Add(new Card
            {
                author = "Daren Bader",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14075&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 1,
                defense = 0,
                flavorEn = @"""The White Shield is not the burnished metal you lash to your forearm but the conviction that burns in your chest.""
—Lucilde Fiksdotter,
leader of the Order of the White Shield
",
                flavorFr = @"« Le Bouclier blanc n'est pas le métal que vous portez à l'avant-bras, mais la conviction qui brûle dans votre poitrine. »
—Lucilde Fiksdotter, capitaine de l'Ordre du Bouclier blanc
",
                force = 0,
                id = 14228,
                manaCost = "(W)",
                multiverseIdEn = 121153,
                multiverseIdFr = 127146,
                nameEn = "Luminesce",
                nameFr = "Luminescence",
                number = 14,
                picturePath = @"Coldsnap\Luminesce.jpg",
                power = "",
                price = 0.1513F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Prevent all damage that black sources and red sources would deal this turn.
",
                textFr = @"Prévenez toutes les blessures que des sources noires et/ou rouges devraient infliger ce tour-ci.
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Matt Cavotta",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14076&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 4,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14229,
                manaCost = "(2)(R)(R)",
                multiverseIdEn = 121163,
                multiverseIdFr = 127147,
                nameEn = "Magmatic Core",
                nameFr = "Noyau magmatique",
                number = 91,
                picturePath = @"Coldsnap\Magmatic Core.jpg",
                power = "",
                price = 0.158865F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Cumulative upkeep (1) (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
At the beginning of your end step, Magmatic Core deals X damage divided as you choose among any number of target creatures, where X is the number of age counters on it.
",
                textFr = @"Entretien cumulatif (1) (Au début de votre entretien, mettez un marqueur «&nbsp;âge&nbsp;» sur ce permanent puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur «&nbsp;âge&nbsp;» sur lui.)
À la fin de votre tour, le Noyau magmatique inflige X blessures réparties comme vous le désirez entre n'importe quel nombre de créatures ciblées, X étant le nombre de marqueurs « âge » sur lui.
",
                typeEn = "Enchantment",
                typeFr = "Enchantement"
            });
            context.Cards.Add(new Card
            {
                author = "Ralph Horsley",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14077&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 1,
                defense = 1,
                flavorEn = @"She turns ash into flame and burns enemies to ash.
",
                flavorFr = @"Elle transforme les cendres en flammes et ses ennemis en cendres.
",
                force = 1,
                id = 14230,
                manaCost = "(R)",
                multiverseIdEn = 121170,
                multiverseIdFr = 127148,
                nameEn = "Martyr of Ashes",
                nameFr = "Martyre aux cendres",
                number = 92,
                picturePath = @"Coldsnap\Martyr of Ashes.jpg",
                power = "1 / 1",
                price = 0.143735F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(2), Reveal X red cards from your hand, Sacrifice Martyr of Ashes: Martyr of Ashes deals X damage to each creature without flying.
",
                textFr = @"(2), révélez X cartes rouges depuis votre main, sacrifiez la Martyre aux cendres&nbsp;: La Martyre aux cendres inflige X blessures à chaque créature sans le vol.
",
                typeEn = "Creature — Human Shaman",
                typeFr = "Créature  - humain et shamane"
            });
            context.Cards.Add(new Card
            {
                author = "E. M. Gist",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14078&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 1,
                defense = 1,
                flavorEn = @"Puppeteered by Heidar's icy hand, they were sacrificed to the Frost Marsh to raise Haakon's army.
",
                flavorFr = @"Manipulés par la main glacée d'Heidar, ils furent sacrifiés au Marécage gelé pour lever l'armée d'Haakon.
",
                force = 1,
                id = 14231,
                manaCost = "(B)",
                multiverseIdEn = 121131,
                multiverseIdFr = 127149,
                nameEn = "Martyr of Bones",
                nameFr = "Martyr aux ossements",
                number = 65,
                picturePath = @"Coldsnap\Martyr of Bones.jpg",
                power = "1 / 1",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(1), Reveal X black cards from your hand, Sacrifice Martyr of Bones: Exile up to X target cards from a single graveyard.
",
                textFr = @"(1), révélez X cartes noires depuis votre main, sacrifiez le Martyr aux ossements&nbsp;: Retirez de la partie jusqu'à X cartes ciblées d'un cimetière unique.
",
                typeEn = "Creature — Human Wizard",
                typeFr = "Créature  - humain et sorcier"
            });
            context.Cards.Add(new Card
            {
                author = "Wayne England",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14079&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 1,
                defense = 1,
                flavorEn = @"""Do not call the Balduvians barbaric. Their magic is as potent as it is primal.""
—Zur the Enchanter
",
                flavorFr = @"« Ne pensez pas que les Balduvians soient barbares. Leur magie est aussi puissante qu'elle est primordiale. »
—Zur l'enchanteur
",
                force = 1,
                id = 14232,
                manaCost = "(U)",
                multiverseIdEn = 121164,
                multiverseIdFr = 127150,
                nameEn = "Martyr of Frost",
                nameFr = "Martyr au givre",
                number = 40,
                picturePath = @"Coldsnap\Martyr of Frost.jpg",
                power = "1 / 1",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(2), Reveal X blue cards from your hand, Sacrifice Martyr of Frost: Counter target spell unless its controller pays (X).
",
                textFr = @"(2), révélez X cartes bleues depuis votre main, sacrifiez le Martyr au givre&nbsp;: Contrecarrez le sort ciblé à moins que son contrôleur ne paie (X).
",
                typeEn = "Creature — Human Wizard",
                typeFr = "Créature  - humain et sorcier"
            });
            context.Cards.Add(new Card
            {
                author = "Randy Gallegos",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14080&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 1,
                defense = 1,
                flavorEn = @"""Only in our vulnerability is there true power, and that power is life itself.""
",
                flavorFr = @"« C'est dans notre vulnérabilité qu'on trouve le véritable pouvoir, et ce pouvoir est la vie. »
",
                force = 1,
                id = 14233,
                manaCost = "(W)",
                multiverseIdEn = 121263,
                multiverseIdFr = 127151,
                nameEn = "Martyr of Sands",
                nameFr = "Martyre aux sables",
                number = 15,
                picturePath = @"Coldsnap\Martyr of Sands.jpg",
                power = "1 / 1",
                price = 0.81702F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(1), Reveal X white cards from your hand, Sacrifice Martyr of Sands: You gain three times X life.
",
                textFr = @"(1), révélez X cartes blanches depuis votre main, sacrifiez la Martyre aux sables&nbsp;: Vous gagnez trois fois X points de vie.
",
                typeEn = "Creature — Human Cleric",
                typeFr = "Créature  - humain et clerc"
            });
            context.Cards.Add(new Card
            {
                author = "Dave Dorman",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14065&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 1,
                defense = 2,
                flavorEn = @"",
                flavorFr = @"",
                force = 1,
                id = 14218,
                manaCost = "(W)",
                multiverseIdEn = 121235,
                multiverseIdFr = 127136,
                nameEn = "Kjeldoran Javelineer",
                nameFr = "Javelinière kjeldorienne",
                number = 11,
                picturePath = @"Coldsnap\Kjeldoran Javelineer.jpg",
                power = "1 / 2",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Cumulative upkeep (1) (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
(T): Kjeldoran Javelineer deals damage equal to the number of age counters on it to target attacking or blocking creature.
",
                textFr = @"Entretien cumulatif (1) (Au début de votre entretien, mettez un marqueur «&nbsp;âge&nbsp;» sur ce permanent puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur «&nbsp;âge&nbsp;» sur lui.)
(T)&nbsp;: La Javelinière kjeldorienne inflige à la créature attaquante ou bloqueuse ciblée un nombre de blessures égal au nombre de marqueurs «&nbsp;âge&nbsp;» sur la Javelinière kjeldorienne.
",
                typeEn = "Creature — Human Soldier",
                typeFr = "Créature  - humain et soldat"
            });
            context.Cards.Add(new Card
            {
                author = "Chippy",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14082&amp;partner=URZGTHR",
                colorId = 6,
                convertedManaCost = 0,
                defense = 0,
                flavorEn = @"""Arcum is a babbling fool Phyrexian technology is our greatest blessing. Take this delightful trinket for instance . . .""
—Heidar, Rimewind master
",
                flavorFr = @"« Arcum n'est qu'un imbécile  La technologie phyrexiane est une bénédiction. Regardez cette merveilleuse petite babiole . . . »
—Heidar, maître de Soufflegivre
",
                force = 0,
                id = 14235,
                manaCost = "(0)",
                multiverseIdEn = 122122,
                multiverseIdFr = 127153,
                nameEn = "Mishra’s Bauble",
                nameFr = "Babiole de Mishra",
                number = 138,
                picturePath = @"Coldsnap\Mishra's Bauble.jpg",
                power = "",
                price = 0.733805F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(T), Sacrifice Mishra's Bauble: Look at the top card of target player's library. Draw a card at the beginning of the next turn's upkeep.
",
                textFr = @"(T), sacrifiez la Babiole de Mishra&nbsp;: Regardez la carte du dessus de la bibliothèque du joueur ciblé. Piochez une carte au début de l'entretien du prochain tour.
",
                typeEn = "Artifact",
                typeFr = "Artefact"
            });
            context.Cards.Add(new Card
            {
                author = "Daren Bader",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14083&amp;partner=URZGTHR",
                colorId = 7,
                convertedManaCost = 0,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14236,
                manaCost = "",
                multiverseIdEn = 121234,
                multiverseIdFr = 127154,
                nameEn = "Mouth of Ronom",
                nameFr = "Gueule de Ronom",
                number = 148,
                picturePath = @"Coldsnap\Mouth of Ronom.jpg",
                power = "",
                price = 0.31773F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(T): Add (1) to your mana pool.
(4), (T), Sacrifice Mouth of Ronom: Mouth of Ronom deals 4 damage to target creature. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"(T)&nbsp;: Ajoutez (1) à votre réserve de mana.
(4), (T), sacrifiez la Gueule de Ronom&nbsp;: La Gueule de Ronom inflige 4 blessures à la créature ciblée. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Land",
                typeFr = "Terrain neigeux"
            });
            context.Cards.Add(new Card
            {
                author = "Chippy",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14084&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 4,
                defense = 0,
                flavorEn = @"The sun-hot glow radiated from the druids, leaving scattered metal in steaming pools as it passed.
",
                flavorFr = @"La lueur, brûlante comme le soleil, qui irradiait des druides, ne laissait que flaques fumantes et métal éparpillé sur son passage.
",
                force = 0,
                id = 14237,
                manaCost = "(3)(G)",
                multiverseIdEn = 121141,
                multiverseIdFr = 127155,
                nameEn = "Mystic Melting",
                nameFr = "Fonte mystique",
                number = 114,
                picturePath = @"Coldsnap\Mystic Melting.jpg",
                power = "",
                price = 0.189125F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Destroy target artifact or enchantment.
Draw a card at the beginning of the next turn's upkeep.
",
                textFr = @"Détruisez l'artefact ciblé ou l'enchantement ciblé.
Piochez une carte au début de l'entretien du prochain tour.
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Kev Walker",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14085&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 3,
                defense = 3,
                flavorEn = @"The ohran viper is not cold-blooded. Its veins course with the same antigelid venom used to kill its prey.
",
                flavorFr = @"La vipère d'Ohran n'a pas le sang froid. Le venin antigel qui tue ses proies coule aussi dans ses veines.
",
                force = 1,
                id = 14238,
                manaCost = "(1)(G)(G)",
                multiverseIdEn = 121266,
                multiverseIdFr = 127156,
                nameEn = "Ohran Viper",
                nameFr = "Vipère d’Ohran",
                number = 115,
                picturePath = @"Coldsnap\Ohran Viper.jpg",
                power = "1 / 3",
                price = 2.31489F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Whenever Ohran Viper deals combat damage to a creature, destroy that creature at end of combat.
Whenever Ohran Viper deals combat damage to a player, you may draw a card.
",
                textFr = @"À chaque fois que la Vipère d'Ohran inflige des blessures de combat à une créature, détruisez cette créature à la fin du combat.
À chaque fois que la Vipère d'Ohran inflige des blessures de combat à un joueur, vous pouvez piocher une carte.
",
                typeEn = "Snow Creature — Snake",
                typeFr = "Créature neigeuse  - serpent"
            });
            context.Cards.Add(new Card
            {
                author = "Wayne Reynolds",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14086&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 4,
                defense = 3,
                flavorEn = @"When a snowdrift shows you its eyes, it's already too late.
",
                flavorFr = @"Quand une congère ouvre les yeux, il est déjà trop tard.
",
                force = 3,
                id = 14239,
                manaCost = "(3)(R)",
                multiverseIdEn = 121144,
                multiverseIdFr = 127157,
                nameEn = "Ohran Yeti",
                nameFr = "Yeti d’Ohran",
                number = 93,
                picturePath = @"Coldsnap\Ohran Yeti.jpg",
                power = "3 / 3",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(2): Target snow creature gains first strike until end of turn. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"(2)&nbsp;: La créature neigeuse ciblée acquiert l'initiative jusqu'à la fin du tour. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Creature — Yeti",
                typeFr = "Créature neigeuse  - yeti"
            });
            context.Cards.Add(new Card
            {
                author = "Alan Pollack",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14087&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 3,
                defense = 1,
                flavorEn = @"Blood calls to blood.
",
                flavorFr = @"Le sang engendre le sang.
",
                force = 2,
                id = 14240,
                manaCost = "(2)(R)",
                multiverseIdEn = 121232,
                multiverseIdFr = 127158,
                nameEn = "Orcish Bloodpainter",
                nameFr = "Peintresang orque",
                number = 94,
                picturePath = @"Coldsnap\Orcish Bloodpainter.jpg",
                power = "2 / 1",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(T), Sacrifice a creature: Orcish Bloodpainter deals 1 damage to target creature or player.
",
                textFr = @"(T), sacrifiez une créature&nbsp;: Le Peintresang orque inflige 1 blessure à une cible, créature ou joueur.
",
                typeEn = "Creature — Orc Shaman",
                typeFr = "Créature  - orque et shamane"
            });
            context.Cards.Add(new Card
            {
                author = "Jim Pavelec",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14088&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 7,
                defense = 5,
                flavorEn = @"""Step lightly and we might be able to use it as a bridge.""
—Ib Halfheart, goblin tactician
",
                flavorFr = @"« Marchez doucement, et nous pourrons peut-être nous en servir de pont. »
—Ib Demicœur, tacticien gobelin
",
                force = 9,
                id = 14241,
                manaCost = "(5)(G)(G)",
                multiverseIdEn = 121264,
                multiverseIdFr = 127159,
                nameEn = "Panglacial Wurm",
                nameFr = "Guivre panglaciaire",
                number = 116,
                picturePath = @"Coldsnap\Panglacial Wurm.jpg",
                power = "9 / 5",
                price = 2.110635F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Trample
While you're searching your library, you may cast Panglacial Wurm from your library.
",
                textFr = @"Piétinement
Tant que vous cherchez dans votre bibliothèque, vous pouvez jouer la Guivre panglaciaire depuis votre bibliothèque.
",
                typeEn = "Creature — Wurm",
                typeFr = "Créature  - guivre"
            });
            context.Cards.Add(new Card
            {
                author = "Dany Orizio",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14089&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"When the School of the Unseen fell, so many magical treasures lay abandoned that no amount of death could deter the stream of thieves and desperate scholars.
",
                flavorFr = @"Après la destruction de l'École de l'Inapparence, tant de trésors magiques avaient été abandonnés que même la mort ne pouvait dissuader les voleurs et les érudits désespérés.
",
                force = 0,
                id = 14242,
                manaCost = "(1)(U)",
                multiverseIdEn = 121238,
                multiverseIdFr = 127160,
                nameEn = "Perilous Research",
                nameFr = "Recherche périlleuse",
                number = 41,
                picturePath = @"Coldsnap\Perilous Research.jpg",
                power = "",
                price = 0.25721F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Draw two cards, then sacrifice a permanent.
",
                textFr = @"Piochez deux cartes, et sacrifiez ensuite un permanent.
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Steven Belledin",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14090&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 3,
                defense = 3,
                flavorEn = @"",
                flavorFr = @"",
                force = 3,
                id = 14243,
                manaCost = "(1)(B)(B)",
                multiverseIdEn = 121146,
                multiverseIdFr = 127161,
                nameEn = "Phobian Phantasm",
                nameFr = "Phantasme phobien",
                number = 66,
                picturePath = @"Coldsnap\Phobian Phantasm.jpg",
                power = "3 / 3",
                price = 0.158865F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying; fear (This creature can't be blocked except by artifact creatures and/or black creatures.)
Cumulative upkeep (B) (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
",
                textFr = @"Vol, peur
Entretien cumulatif (B) (Au début de votre entretien, mettez un marqueur «&nbsp;âge&nbsp;» sur ce permanent puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur «&nbsp;âge&nbsp;» sur lui.)
",
                typeEn = "Creature — Illusion",
                typeFr = "Créature  - illusion"
            });
            context.Cards.Add(new Card
            {
                author = "Ron Spears",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14091&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 3,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14244,
                manaCost = "(B)(B)(B)",
                multiverseIdEn = 121121,
                multiverseIdFr = 127162,
                nameEn = "Phyrexian Etchings",
                nameFr = "Gravures phyrexianes",
                number = 67,
                picturePath = @"Coldsnap\Phyrexian Etchings.jpg",
                power = "",
                price = 0.27234F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Cumulative upkeep (B) (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
At the beginning of your end step, draw a card for each age counter on Phyrexian Etchings.
When Phyrexian Etchings is put into a graveyard from the battlefield, you lose 2 life for each age counter on it.
",
                textFr = @"Entretien cumulatif (B) (Au début de votre entretien, mettez un marqueur «&nbsp;âge&nbsp;» sur ce permanent puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur «&nbsp;âge&nbsp;» sur lui.)
À la fin de votre tour, piochez une carte pour chaque marqueur « âge » sur les Gravures phyrexianes.
Quand les Gravures phyrexianes sont mises dans un cimetière depuis le jeu, vous perdez 2 points de vie pour chaque marqueur « âge » sur elles.
",
                typeEn = "Enchantment",
                typeFr = "Enchantement"
            });
            context.Cards.Add(new Card
            {
                author = "Stephan Martiniere",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14092&amp;partner=URZGTHR",
                colorId = 6,
                convertedManaCost = 3,
                defense = 4,
                flavorEn = @"It took the Rimewind cultists days to realize they had successfully activated the creature—it just wasn't interested in moving.
",
                flavorFr = @"Il fallut plusieurs jours aux cultistes de Soufflegivre pour réaliser qu'ils avaient activé la créature — elle n'avait aucune envie de bouger.
",
                force = 3,
                id = 14245,
                manaCost = "(3)",
                multiverseIdEn = 121127,
                multiverseIdFr = 127163,
                nameEn = "Phyrexian Ironfoot",
                nameFr = "Piédefer phyrexian",
                number = 139,
                picturePath = @"Coldsnap\Phyrexian Ironfoot.jpg",
                power = "3 / 4",
                price = 0.22695F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Phyrexian Ironfoot doesn't untap during your untap step.
(1): Untap Phyrexian Ironfoot. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"Le Piédefer phyrexian ne se dégage pas pendant votre étape de dégagement.
(1)&nbsp;: Dégagez le Piédefer phyrexian. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Artifact Creature — Construct",
                typeFr = "Créature-artefact neigeuse  - construction"
            });
            context.Cards.Add(new Card
            {
                author = "Dave Allsop",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14093&amp;partner=URZGTHR",
                colorId = 6,
                convertedManaCost = 6,
                defense = 5,
                flavorEn = @"Its plow wasn't designed for snow, but to carve a path through shrieking armies.
",
                flavorFr = @"Son soc n'est pas conçu pour déblayer la neige, mais pour se frayer un chemin au travers d'armées hurlantes.
",
                force = 6,
                id = 14246,
                manaCost = "(6)",
                multiverseIdEn = 121142,
                multiverseIdFr = 127164,
                nameEn = "Phyrexian Snowcrusher",
                nameFr = "Écrabouilleur de neige phyrexian",
                number = 140,
                picturePath = @"Coldsnap\Phyrexian Snowcrusher.jpg",
                power = "6 / 5",
                price = 0.1513F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Phyrexian Snowcrusher attacks each turn if able.
(1): Phyrexian Snowcrusher gets +1/+0 until end of turn. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"L'Écrabouilleur de neige phyrexian attaque à chaque tour si possible.
(1)&nbsp;: L'Écrabouilleur de neige phyrexian gagne +1/+0 jusqu'à la fin du tour. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Artifact Creature — Juggernaut",
                typeFr = "Créature-artefact neigeuse  - djaggernaut"
            });
            context.Cards.Add(new Card
            {
                author = "Brian Snoddy",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14094&amp;partner=URZGTHR",
                colorId = 6,
                convertedManaCost = 3,
                defense = 8,
                flavorEn = @"The Phyrexian minds that constructed it did not live past its awakening.
",
                flavorFr = @"Les cerveaux phyrexians qui l'ont construit n'ont pas survécu à son éveil.
",
                force = 8,
                id = 14247,
                manaCost = "(3)",
                multiverseIdEn = 121160,
                multiverseIdFr = 127165,
                nameEn = "Phyrexian Soulgorger",
                nameFr = "Engloutâmes phyrexian",
                number = 141,
                picturePath = @"Coldsnap\Phyrexian Soulgorger.jpg",
                power = "8 / 8",
                price = 0.33286F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Cumulative upkeep—Sacrifice a creature. (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
",
                textFr = @"Entretien cumulatif — Sacrifiez une créature. (Au début de votre entretien, mettez un marqueur « âge » sur ce permanent puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur « âge » sur lui.)
",
                typeEn = "Snow Artifact Creature — Construct",
                typeFr = "Créature-artefact neigeuse  - construction"
            });
            context.Cards.Add(new Card
            {
                author = "Daren Bader",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14095&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14248,
                manaCost = "(1)(G)",
                multiverseIdEn = 121223,
                multiverseIdFr = 127166,
                nameEn = "Resize",
                nameFr = "Changetaille",
                number = 117,
                picturePath = @"Coldsnap\Resize.jpg",
                power = "",
                price = 0.1513F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Target creature gets +3/+3 until end of turn.
Recover (1)(G) (When a creature is put into your graveyard from the battlefield, you may pay (1)(G). If you do, return this card from your graveyard to your hand. Otherwise, exile this card.)
",
                textFr = @"La créature ciblée gagne +3/+3 jusqu'à la fin du tour.
Recouvrement (1)(G) (Quand une créature est mise dans votre cimetière depuis le jeu, vous pouvez payer (1)(G). Si vous faites ainsi, renvoyez cette carte dans votre main depuis votre cimetière. Sinon, retirez cette carte de la partie.)
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Jeff Nentrup",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14096&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"The unfortunates so transformed hungered not for flesh, but for warmth.
",
                flavorFr = @"Les malheureux ainsi altérés n'avaient pas d'appétit pour la chair, mais pour la chaleur.
",
                force = 0,
                id = 14249,
                manaCost = "(1)(B)",
                multiverseIdEn = 121257,
                multiverseIdFr = 127167,
                nameEn = "Rime Transfusion",
                nameFr = "Transfusion de givre",
                number = 68,
                picturePath = @"Coldsnap\Rime Transfusion.jpg",
                power = "",
                price = 0.16643F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Enchant creature
Enchanted creature gets +2/+1 and has "": This creature can't be blocked this turn except by snow creatures."" ( can be paid with one mana from a snow permanent.)
",
                textFr = @"Enchanter : créature
La créature enchantée gagne +2/+1 et a «&nbsp;&nbsp;: Cette créature ne peut pas être bloquée ce tour-ci excepté par des créatures neigeuses.&nbsp;» ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Enchantment — Aura",
                typeFr = "Enchantement neigeux  - aura"
            });
            context.Cards.Add(new Card
            {
                author = "Dave Kendall",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14097&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 1,
                defense = 1,
                flavorEn = @"""Tresserhorn is ours now. Dredge the lake and bring me all the bones you find. We'll build you a new army, the likes of which Terisiare has never seen.""
—Heidar, Rimewind master, to Haakon
",
                flavorFr = @"« Tresserhorn nous appartient. Drague le lac et rapporte-moi tous les ossements que tu trouveras. Nous allons lever une armée telle que Terisiare n'en a jamais vue. »
—Heidar, maître de Soufflegivre, à Haakon
",
                force = 1,
                id = 14250,
                manaCost = "(B)",
                multiverseIdEn = 121136,
                multiverseIdFr = 127168,
                nameEn = "Rimebound Dead",
                nameFr = "Mort bridegivre",
                number = 69,
                picturePath = @"Coldsnap\Rimebound Dead.jpg",
                power = "1 / 1",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @": Regenerate Rimebound Dead. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"&nbsp;: Régénérez le Mort bridegivre. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Creature — Skeleton",
                typeFr = "Créature neigeuse  - squelette"
            });
            context.Cards.Add(new Card
            {
                author = "Kensuke Okabayashi",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14098&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 7,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14251,
                manaCost = "(5)(U)(U)",
                multiverseIdEn = 122116,
                multiverseIdFr = 127169,
                nameEn = "Rimefeather Owl",
                nameFr = "Hibou plumegivre",
                number = 42,
                picturePath = @"Coldsnap\Rimefeather Owl.jpg",
                power = "* / *",
                price = 0.279905F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying
Rimefeather Owl's power and toughness are each equal to the number of snow permanents on the battlefield.
(1): Put an ice counter on target permanent.
Permanents with ice counters on them are snow.
",
                textFr = @"Vol
La force et l'endurance du Hibou plumegivre sont chacune égale au nombre de permanents neigeux en jeu.
(1)&nbsp;: Mettez un marqueur «&nbsp;glace&nbsp;» sur le permanent ciblé.
Les permanents avec des marqueurs « glace » sur eux sont neigeux.
",
                typeEn = "Snow Creature — Bird",
                typeFr = "Créature neigeuse  - oiseau"
            });
            context.Cards.Add(new Card
            {
                author = "Brian Despain",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14099&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 5,
                defense = 3,
                flavorEn = @"",
                flavorFr = @"",
                force = 3,
                id = 14252,
                manaCost = "(4)(G)",
                multiverseIdEn = 121210,
                multiverseIdFr = 127170,
                nameEn = "Rimehorn Aurochs",
                nameFr = "Aurochs cornegivre",
                number = 118,
                picturePath = @"Coldsnap\Rimehorn Aurochs.jpg",
                power = "3 / 3",
                price = 0.1513F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Trample
Whenever Rimehorn Aurochs attacks, it gets +1/+0 until end of turn for each other attacking Aurochs.
(2): Target creature blocks target creature this turn if able. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"Piétinement
À chaque fois que l'Aurochs cornegivre attaque, il gagne +1/+0 jusqu'à la fin du tour pour chaque autre aurochs attaquant.
(2)&nbsp;: La créature ciblée bloque la créature ciblée ce tour-ci si possible. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Creature — Aurochs",
                typeFr = "Créature neigeuse  - aurochs"
            });
            context.Cards.Add(new Card
            {
                author = "Jeff Easley",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14100&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 7,
                defense = 5,
                flavorEn = @"",
                flavorFr = @"",
                force = 5,
                id = 14253,
                manaCost = "(5)(R)(R)",
                multiverseIdEn = 121184,
                multiverseIdFr = 127171,
                nameEn = "Rimescale Dragon",
                nameFr = "Dragon à écailles de givre",
                number = 95,
                picturePath = @"Coldsnap\Rimescale Dragon.jpg",
                power = "5 / 5",
                price = 0.84728F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying
(2): Tap target creature and put an ice counter on it. ( can be paid with one mana from a snow permanent.)
Creatures with ice counters on them don't untap during their controllers' untap steps.
",
                textFr = @"Vol
(2)&nbsp;: Engagez la créature ciblée et mettez un marqueur «&nbsp;glace&nbsp;» sur elle. ( peut être payé avec un mana d'un permanent neigeux.)
Les créatures avec des marqueurs « glace » sur eux ne se dégagent pas pendant les étapes de dégagement de leurs contrôleurs.
",
                typeEn = "Snow Creature — Dragon",
                typeFr = "Créature neigeuse  - dragon"
            });
            context.Cards.Add(new Card
            {
                author = "Dan Scott",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14101&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 4,
                defense = 3,
                flavorEn = @"""The Thaw brings flooding, disease, and death. We will do all in our power to bring frigid peace back to the world.""
",
                flavorFr = @"« Le Dégel apporte avec lui les inondations, la maladie et la mort. Nous ferons tout ce qui est en notre pouvoir pour ramener une paix glacée dans le monde. »
",
                force = 2,
                id = 14254,
                manaCost = "(3)(U)",
                multiverseIdEn = 121215,
                multiverseIdFr = 127172,
                nameEn = "Rimewind Cryomancer",
                nameFr = "Cryomancienne de Soufflegivre",
                number = 43,
                picturePath = @"Coldsnap\Rimewind Cryomancer.jpg",
                power = "2 / 3",
                price = 0.16643F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(1), (T): Counter target activated ability. Activate this ability only if you control four or more snow permanents. (Mana abilities can't be targeted.)
",
                textFr = @"(1), (T)&nbsp;: Contrecarrez la capacité activée ciblée. Ne jouez cette capacité que si vous contrôlez au moins quatre permanents neigeux. (Les capacités de mana ne peuvent pas être ciblées.)
",
                typeEn = "Creature — Human Wizard",
                typeFr = "Créature  - humain et sorcier"
            });
            context.Cards.Add(new Card
            {
                author = "Ron Spears",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14102&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 2,
                defense = 2,
                flavorEn = @"""Find solace in the sun? Burning, blinding, laying secrets bare? No, solace is found under the blanket of cold.""
",
                flavorFr = @"« Trouver sanctuaire au soleil ? Le soleil brûlant, aveuglant, exposant tous les secrets ? Non, le vrai sanctuaire est caché sous la couverture du froid. »
",
                force = 1,
                id = 14255,
                manaCost = "(1)(U)",
                multiverseIdEn = 121239,
                multiverseIdFr = 127173,
                nameEn = "Rimewind Taskmage",
                nameFr = "Mage de force de Soufflegivre",
                number = 44,
                picturePath = @"Coldsnap\Rimewind Taskmage.jpg",
                power = "1 / 2",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(1), (T): You may tap or untap target permanent. Activate this ability only if you control four or more snow permanents.
",
                textFr = @"(1), (T)&nbsp;: Engagez ou dégagez le permanent ciblé. Ne jouez cette capacité que si vous contrôlez au moins quatre permanents neigeux.
",
                typeEn = "Creature — Human Wizard",
                typeFr = "Créature  - humain et sorcier"
            });
            context.Cards.Add(new Card
            {
                author = "Dany Orizio",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14103&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 1,
                defense = 0,
                flavorEn = @"Deep beneath the ice, beneath the soil and the rock, Dominaria's fire still burned hot.
",
                flavorFr = @"Profondément enfoui sous la glace, la terre et la roche, le feu de Dominaria brûlait toujours.
",
                force = 0,
                id = 14256,
                manaCost = "(R)",
                multiverseIdEn = 121217,
                multiverseIdFr = 127174,
                nameEn = "Rite of Flame",
                nameFr = "Rite de flammes",
                number = 96,
                picturePath = @"Coldsnap\Rite of Flame.jpg",
                power = "",
                price = 1.641605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Add (R)(R) to your mana pool, then add (R) to your mana pool for each card named Rite of Flame in each graveyard.
",
                textFr = @"Ajoutez (R)(R) à votre réserve, puis ajoutez (R) à votre réserve pour chaque carte appelée Rite de flammes dans chaque cimetière.
",
                typeEn = "Sorcery",
                typeFr = "Rituel"
            });
            context.Cards.Add(new Card
            {
                author = "Zoltan Boros & Gabor Szikszai",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14104&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 5,
                defense = 6,
                flavorEn = @"",
                flavorFr = @"",
                force = 5,
                id = 14257,
                manaCost = "(4)(G)",
                multiverseIdEn = 121270,
                multiverseIdFr = 127175,
                nameEn = "Ronom Hulk",
                nameFr = "Carcasse de Ronom",
                number = 119,
                picturePath = @"Coldsnap\Ronom Hulk.jpg",
                power = "5 / 6",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Protection from snow
Cumulative upkeep (1) (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
",
                textFr = @"Protection contre le neigeux
Entretien cumulatif (1) (Au début de votre entretien, mettez un marqueur «&nbsp;âge&nbsp;» sur ce permanent puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur «&nbsp;âge&nbsp;» sur lui.)
",
                typeEn = "Creature — Beast",
                typeFr = "Créature  - bête"
            });
            context.Cards.Add(new Card
            {
                author = "Alan Pollack",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14132&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 3,
                defense = 1,
                flavorEn = @"",
                flavorFr = @"",
                force = 2,
                id = 14285,
                manaCost = "(2)(U)",
                multiverseIdEn = 121224,
                multiverseIdFr = 127203,
                nameEn = "Survivor of the Unseen",
                nameFr = "Survivante de l’Inapparence",
                number = 48,
                picturePath = @"Coldsnap\Survivor of the Unseen.jpg",
                power = "2 / 1",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Cumulative upkeep (2) (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
(T): Draw two cards, then put a card from your hand on top of your library.
",
                textFr = @"Entretien cumulatif (2) (Au début de votre entretien, mettez un marqueur «&nbsp;âge&nbsp;» sur ce permanent puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur «&nbsp;âge&nbsp;» sur lui.)
(T)&nbsp;: Piochez deux cartes, puis mettez une carte de votre main au-dessus de votre bibliothèque.
",
                typeEn = "Creature — Human Wizard",
                typeFr = "Créature  - humain et sorcier"
            });
            context.Cards.Add(new Card
            {
                author = "Michael Sutfin",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14133&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"Darien's call to Yavimaya would have fallen red to the snow had it not been for the agility of the aesthir.
",
                flavorFr = @"L'appel à la Yavimaya de Darien n'aurait pas été reçu sans l'agilité des aeszirs.
",
                force = 0,
                id = 14286,
                manaCost = "(1)(W)",
                multiverseIdEn = 121255,
                multiverseIdFr = 127204,
                nameEn = "Swift Maneuver",
                nameFr = "Manœuvre filante",
                number = 21,
                picturePath = @"Coldsnap\Swift Maneuver.jpg",
                power = "",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Prevent the next 2 damage that would be dealt to target creature or player this turn.
Draw a card at the beginning of the next turn's upkeep.
",
                textFr = @"Prévenez, ce tour-ci, les prochaines 2 blessures qui devraient être infligées à une cible, créature ou joueur.
Piochez une carte au début de l'entretien du prochain tour.
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "rk post",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14134&amp;partner=URZGTHR",
                colorId = 8,
                convertedManaCost = 3,
                defense = 4,
                flavorEn = @"When Freyalise spoke the World Spell, the tamanoa rose to bring a new morning to Terisiare.
",
                flavorFr = @"Quand Freyalise énonça l'Enchantement du monde, la tamanoa offrit une nouvelle aube à Terisiare.
",
                force = 2,
                id = 14287,
                manaCost = "(R)(G)(W)",
                multiverseIdEn = 121262,
                multiverseIdFr = 127205,
                nameEn = "Tamanoa",
                nameFr = "Tamanoa",
                number = 132,
                picturePath = @"Coldsnap\Tamanoa.jpg",
                power = "2 / 4",
                price = 0.416075F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Whenever a noncreature source you control deals damage, you gain that much life.
",
                textFr = @"À chaque fois qu'une source non-créature que vous contrôlez inflige des blessures, vous gagnez autant de points de vie.
",
                typeEn = "Creature — Spirit",
                typeFr = "Créature  - esprit"
            });
            context.Cards.Add(new Card
            {
                author = "Jeff Miracola",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14135&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 1,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14288,
                manaCost = "(U)",
                multiverseIdEn = 122119,
                multiverseIdFr = 127206,
                nameEn = "Thermal Flux",
                nameFr = "Flux thermique",
                number = 49,
                picturePath = @"Coldsnap\Thermal Flux.jpg",
                power = "",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Choose one — Target nonsnow permanent becomes snow until end of turn; or target snow permanent isn't snow until end of turn.
Draw a card at the beginning of the next turn's upkeep.
",
                textFr = @"Choisissez l'un — Le permanent non-neigeux ciblé devient neigeux jusqu'à la fin du tour ; ou le permanent neigeux ciblé n'est pas neigeux jusqu'à la fin du tour.
Piochez une carte au début de l'entretien du prochain tour.
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Dan Dos Santos",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14136&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 5,
                defense = 3,
                flavorEn = @"Slicking the ice with its heated underside, the thermopod skates at great speed to overtake its prey.
",
                flavorFr = @"Utilisant son ventre pour chauffer la glace, le thermopode patine à grande vitesse pour rattraper sa proie.
",
                force = 4,
                id = 14289,
                manaCost = "(4)(R)",
                multiverseIdEn = 121173,
                multiverseIdFr = 127207,
                nameEn = "Thermopod",
                nameFr = "Thermopode",
                number = 100,
                picturePath = @"Coldsnap\Thermopod.jpg",
                power = "4 / 3",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @": Thermopod gains haste until end of turn. ( can be paid with one mana from a snow permanent.)
Sacrifice a creature: Add (R) to your mana pool.
",
                textFr = @"&nbsp;: Le Thermopode acquiert la célérité jusqu'à la fin du tour. ( peut être payé avec un mana d'un permanent neigeux.)
Sacrifiez une créature&nbsp;: Ajoutez (R) à votre réserve.
",
                typeEn = "Snow Creature — Slug",
                typeFr = "Créature neigeuse  - limace"
            });
            context.Cards.Add(new Card
            {
                author = "Rob Alexander",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14137&amp;partner=URZGTHR",
                colorId = 6,
                convertedManaCost = 5,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14290,
                manaCost = "(5)",
                multiverseIdEn = 124451,
                multiverseIdFr = 127208,
                nameEn = "Thrumming Stone",
                nameFr = "Pierre psalmodique",
                number = 142,
                picturePath = @"Coldsnap\Thrumming Stone.jpg",
                power = "",
                price = 4.26666F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Spells you cast have ripple 4. (Whenever you cast a spell, you may reveal the top four cards of your library. You may cast any revealed cards with the same name as the spell without paying their mana costs. Put the rest on the bottom of your library.)
",
                textFr = @"Les sorts que vous contrôlez ont remous 4. (À chaque fois que vous jouez un sort, vous pouvez révéler les quatre cartes du dessus de votre bibliothèque. Vous pouvez jouer n'importe quel nombre des cartes révélées ayant le même nom que ce sort sans payer leurs coûts de mana. Mettez les autres au-dessous de votre bibliothèque.)
",
                typeEn = "Legendary Artifact",
                typeFr = "Artefact légendaire"
            });
            context.Cards.Add(new Card
            {
                author = "Darrell Riche",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14138&amp;partner=URZGTHR",
                colorId = 7,
                convertedManaCost = 0,
                defense = 0,
                flavorEn = @"""Our land oppressed by silent Cold,
We weary wretches, young and old,
Pray that Springtime loose his hold.""
—The Dynasty of Winter Kings
",
                flavorFr = @"« Notre terre, opprimée par le Froid silencieux,
Nous, pauvres misérables, jeunes et vieux,
Prions pour que le printemps émerge victorieux. »
—La dynastie des Rois de l'hiver
",
                force = 0,
                id = 14291,
                manaCost = "",
                multiverseIdEn = 121125,
                multiverseIdFr = 127209,
                nameEn = "Tresserhorn Sinks",
                nameFr = "Charniers de Tresserhorn",
                number = 150,
                picturePath = @"Coldsnap\Tresserhorn Sinks.jpg",
                power = "",
                price = 0.537115F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Tresserhorn Sinks enters the battlefield tapped.
(T): Add (B) or (R) to your mana pool.
",
                textFr = @"Les Charniers de Tresserhorn arrivent en jeu engagés.
(T)&nbsp;: Ajoutez (B) ou (R) à votre réserve.
",
                typeEn = "Snow Land",
                typeFr = "Terrain neigeux"
            });
            context.Cards.Add(new Card
            {
                author = "Dan Dos Santos",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14139&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 7,
                defense = 3,
                flavorEn = @"Kjeldorans who fled battle were exiled to the wastes. Those who strayed near Tresserhorn were pressed into service in Haakon's army.
",
                flavorFr = @"Les Kjeldoriens qui désertèrent le combat furent exilés dans les landes. Ceux qui s'aventurèrent près de Tresserhorn furent contraints de rejoindre l'armée d'Haakon.
",
                force = 5,
                id = 14292,
                manaCost = "(5)(B)(B)",
                multiverseIdEn = 121195,
                multiverseIdFr = 127210,
                nameEn = "Tresserhorn Skyknight",
                nameFr = "Chevalier céleste de Tresserhorn",
                number = 73,
                picturePath = @"Coldsnap\Tresserhorn Skyknight.jpg",
                power = "5 / 3",
                price = 0.16643F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying
Prevent all damage that would be dealt to Tresserhorn Skyknight by creatures with first strike.
",
                textFr = @"Vol 
Prévenez toutes les blessures qui devraient être infligées au Chevalier céleste de Tresserhorn par les créatures avec l'initiative.
",
                typeEn = "Creature — Zombie Knight",
                typeFr = "Créature  - zombie et chevalier"
            });
            context.Cards.Add(new Card
            {
                author = "Ron Spencer",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14105&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 6,
                defense = 6,
                flavorEn = @"With the spread of Rimewind's sorcerous winter, snow dwellers reclaimed their places atop the food chain.
",
                flavorFr = @"Avec l'avancée de l'hiver magique de Soufflegivre, les habitants des neiges reprirent leur place au sommet de la chaîne alimentaire.
",
                force = 5,
                id = 14258,
                manaCost = "(5)(U)",
                multiverseIdEn = 121176,
                multiverseIdFr = 127176,
                nameEn = "Ronom Serpent",
                nameFr = "Serpent de Ronom",
                number = 45,
                picturePath = @"Coldsnap\Ronom Serpent.jpg",
                power = "5 / 6",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Ronom Serpent can't attack unless defending player controls a snow land.
When you control no snow lands, sacrifice Ronom Serpent.
",
                textFr = @"Le Serpent de Ronom ne peut pas attaquer à moins que le joueur défenseur ne contrôle un terrain neigeux.
Quand vous ne contrôlez pas de terrain neigeux, sacrifiez le Serpent de Ronom.
",
                typeEn = "Snow Creature — Serpent",
                typeFr = "Créature neigeuse  - serpent"
            });
            context.Cards.Add(new Card
            {
                author = "Carl Critchlow",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14106&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 2,
                defense = 2,
                flavorEn = @"The aberrant magic of the Rimewind drew the unicorns back from the northern wastes to do battle once again.
",
                flavorFr = @"Les aberrations magiques de Soufflegivre firent revenir les licornes des steppes du nord pour combattre.
",
                force = 2,
                id = 14259,
                manaCost = "(1)(W)",
                multiverseIdEn = 121237,
                multiverseIdFr = 127177,
                nameEn = "Ronom Unicorn",
                nameFr = "Licorne de Ronom",
                number = 16,
                picturePath = @"Coldsnap\Ronom Unicorn.jpg",
                power = "2 / 2",
                price = 0.13617F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Sacrifice Ronom Unicorn: Destroy target enchantment.
",
                textFr = @"Sacrifiez la Licorne de Ronom : Détruisez l'enchantement ciblé.
",
                typeEn = "Creature — Unicorn",
                typeFr = "Créature  - licorne"
            });
            context.Cards.Add(new Card
            {
                author = "Dave Dorman",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14107&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"""Concentration is key. Without it, a mage conjures nothing but a splitting headache.""
—Zur the Enchanter
",
                flavorFr = @"« L'important, c'est la concentration. Sans elle, un mage ne peut invoquer qu'une terrible migraine. »
—Zur l'enchanteur
",
                force = 0,
                id = 14260,
                manaCost = "(1)(U)",
                multiverseIdEn = 121247,
                multiverseIdFr = 127178,
                nameEn = "Rune Snag",
                nameFr = "Accroc de rune",
                number = 46,
                picturePath = @"Coldsnap\Rune Snag.jpg",
                power = "",
                price = 0.59007F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Counter target spell unless its controller pays (2) plus an additional (2) for each card named Rune Snag in each graveyard.
",
                textFr = @"Contrecarrez le sort ciblé à moins que son contrôleur ne paie (2) plus (2) supplémentaires pour chaque carte appelée Accroc de rune dans chaque cimetière.
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Thomas M. Baxa",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14108&amp;partner=URZGTHR",
                colorId = 7,
                convertedManaCost = 0,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14261,
                manaCost = "",
                multiverseIdEn = 121204,
                multiverseIdFr = 127179,
                nameEn = "Scrying Sheets",
                nameFr = "Strates de scrutation",
                number = 149,
                picturePath = @"Coldsnap\Scrying Sheets.jpg",
                power = "",
                price = 1.505435F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"(T): Add (1) to your mana pool.
(1), (T): Look at the top card of your library. If that card is snow, you may reveal it and put it into your hand. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"(T)&nbsp;: Ajoutez (1) à votre réserve.
(1), (T)&nbsp;: Regardez la carte du dessus de votre bibliothèque. Si cette carte est neigeuse, vous pouvez la révéler et la mettre dans votre main. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Land",
                typeFr = "Terrain neigeux"
            });
            context.Cards.Add(new Card
            {
                author = "Jeff Miracola",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14109&amp;partner=URZGTHR",
                colorId = 8,
                convertedManaCost = 5,
                defense = 3,
                flavorEn = @"Karplusan legend told of an orc so cruel that he burned his own followers in rage—yet so revered that they rose from their pyres to serve him.
",
                flavorFr = @"Les légendes karpluséanes parlent d'un orque si cruel qu'il incinère les membres de sa tribu dans sa colère. Mais ils le vénèrent tant qu'ils se lèvent du bûcher pour le servir.
",
                force = 4,
                id = 14262,
                manaCost = "(2)(B)(R)(G)",
                multiverseIdEn = 121261,
                multiverseIdFr = 127180,
                nameEn = "Sek’Kuar, Deathkeeper",
                nameFr = "Sek’Kuar, gardemort",
                number = 131,
                picturePath = @"Coldsnap\Sek'Kuar, Deathkeeper.jpg",
                power = "4 / 3",
                price = 0.28747F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Whenever another nontoken creature you control dies, put a 3/1 black and red Graveborn creature token with haste onto the battlefield.
",
                textFr = @"À chaque fois qu'une autre créature non-jeton que vous contrôlez est mise dans un cimetière depuis le jeu, mettez en jeu un jeton de créature 3/1 noire et rouge Désencavé avec la célérité.
",
                typeEn = "Legendary Creature — Orc Shaman",
                typeFr = "Créature légendaire  - orque et shamane"
            });
            context.Cards.Add(new Card
            {
                author = "Ron Spencer",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14110&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 6,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14263,
                manaCost = "(3)(G)(G)(G)",
                multiverseIdEn = 122073,
                multiverseIdFr = 127181,
                nameEn = "Shape of the Wiitigo",
                nameFr = "Forme du wytigo",
                number = 120,
                picturePath = @"Coldsnap\Shape of the Wiitigo.jpg",
                power = "",
                price = 0.25721F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Enchant creature
When Shape of the Wiitigo enters the battlefield, put six +1/+1 counters on enchanted creature.
At the beginning of your upkeep, put a +1/+1 counter on enchanted creature if it attacked or blocked since your last upkeep. Otherwise, remove a +1/+1 counter from it.
",
                textFr = @"Enchanter : créature 
Quand la Forme du wytigo arrive en jeu, mettez six marqueurs +1/+1 sur la créature enchantée.
Au début de votre entretien, mettez un marqueur +1/+1 sur la créature enchantée si elle a attaqué ou bloqué depuis votre dernier entretien. Sinon, retirez-lui un marqueur +1/+1.
",
                typeEn = "Enchantment — Aura",
                typeFr = "Enchantement  - aura"
            });
            context.Cards.Add(new Card
            {
                author = "Pete Venters",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14111&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 2,
                defense = 5,
                flavorEn = @"",
                flavorFr = @"",
                force = 5,
                id = 14264,
                manaCost = "(1)(G)",
                multiverseIdEn = 122069,
                multiverseIdFr = 127182,
                nameEn = "Sheltering Ancient",
                nameFr = "Ancien protecteur",
                number = 121,
                picturePath = @"Coldsnap\Sheltering Ancient.jpg",
                power = "5 / 5",
                price = 0.28747F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Trample
Cumulative upkeep—Put a +1/+1 counter on a creature an opponent controls. (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
",
                textFr = @"Piétinement
Entretien cumulatif — Mettez un marqueur +1/+1 sur une créature qu'un adversaire contrôle. (Au début de votre entretien, mettez un marqueur « âge » sur ce permanent puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur « âge » sur lui.)
",
                typeEn = "Creature — Treefolk",
                typeFr = "Créature  - sylvin"
            });
            context.Cards.Add(new Card
            {
                author = "Warren Mahy",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14112&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 4,
                defense = 3,
                flavorEn = @"""It's odd to see the apes rip down trees to arm themselves in defense of their forests.""
—Taaveti of Kelsinko, elvish hunter
",
                flavorFr = @"« C'est si étrange de voir des singes arracher des arbres pour s'armer et défendre leurs forêts. »
—Taaveti le Kelsinkois, chasseur elfe
",
                force = 3,
                id = 14265,
                manaCost = "(3)(G)",
                multiverseIdEn = 121183,
                multiverseIdFr = 127183,
                nameEn = "Simian Brawler",
                nameFr = "Bagarreur simiesque",
                number = 122,
                picturePath = @"Coldsnap\Simian Brawler.jpg",
                power = "3 / 3",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Discard a land card: Simian Brawler gets +1/+1 until end of turn.
",
                textFr = @"Défaussez-vous d'une carte de terrain : Le Bagarreur simiesque gagne +1/+1 jusqu'à la fin du tour.
",
                typeEn = "Creature — Ape Warrior",
                typeFr = "Créature  - grand singe et guerrier"
            });
            context.Cards.Add(new Card
            {
                author = "Christopher Moeller",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14113&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 1,
                defense = 0,
                flavorEn = @"""This close to Rimewind Keep, no avalanche is nature's doing.""
—Ukoten, centaur chieftain
",
                flavorFr = @"« À cette distance de la Forteresse de Soufflegivre, les avalanches ne sont pas naturelles. »
—Ukoten, chef de clan centaure
",
                force = 0,
                id = 14266,
                manaCost = "(R)",
                multiverseIdEn = 122120,
                multiverseIdFr = 127184,
                nameEn = "Skred",
                nameFr = "Skred",
                number = 97,
                picturePath = @"Coldsnap\Skred.jpg",
                power = "",
                price = 0.158865F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Skred deals damage to target creature equal to the number of snow permanents you control.
",
                textFr = @"Le Skred inflige à la créature ciblée un nombre de blessures égal au nombre de permanents neigeux que vous contrôlez.
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Jim Nelson",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14114&amp;partner=URZGTHR",
                colorId = 7,
                convertedManaCost = 0,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14267,
                manaCost = "",
                multiverseIdEn = 121192,
                multiverseIdFr = 127185,
                nameEn = "Snow-Covered Forest",
                nameFr = "Forêt enneigée",
                number = 155,
                picturePath = @"Coldsnap\Snow-Covered Forest.jpg",
                power = "",
                price = 0.370685F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"G
",
                textFr = @"G
",
                typeEn = "Basic Snow Land — Forest",
                typeFr = "Terrain neigeux de base  - forêt"
            });
            context.Cards.Add(new Card
            {
                author = "Franz Vohwinkel",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14115&amp;partner=URZGTHR",
                colorId = 7,
                convertedManaCost = 0,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14268,
                manaCost = "",
                multiverseIdEn = 121130,
                multiverseIdFr = 127186,
                nameEn = "Snow-Covered Island",
                nameFr = "Île enneigée",
                number = 152,
                picturePath = @"Coldsnap\Snow-Covered Island.jpg",
                power = "",
                price = 0.55981F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"U
",
                textFr = @"U
",
                typeEn = "Basic Snow Land — Island",
                typeFr = "Terrain neigeux de base  - île"
            });
            context.Cards.Add(new Card
            {
                author = "John Zeleznik",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14116&amp;partner=URZGTHR",
                colorId = 7,
                convertedManaCost = 0,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14269,
                manaCost = "",
                multiverseIdEn = 121233,
                multiverseIdFr = 127187,
                nameEn = "Snow-Covered Mountain",
                nameFr = "Montagne enneigée",
                number = 154,
                picturePath = @"Coldsnap\Snow-Covered Mountain.jpg",
                power = "",
                price = 0.52955F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"R
",
                textFr = @"R
",
                typeEn = "Basic Snow Land — Mountain",
                typeFr = "Terrain neigeux de base  - montagne"
            });
            context.Cards.Add(new Card
            {
                author = "Mark Romanoski",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14117&amp;partner=URZGTHR",
                colorId = 7,
                convertedManaCost = 0,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14270,
                manaCost = "",
                multiverseIdEn = 121267,
                multiverseIdFr = 127188,
                nameEn = "Snow-Covered Plains",
                nameFr = "Plaine enneigée",
                number = 151,
                picturePath = @"Coldsnap\Snow-Covered Plains.jpg",
                power = "",
                price = 0.40851F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"W
",
                textFr = @"W
",
                typeEn = "Basic Snow Land — Plains",
                typeFr = "Terrain neigeux de base  - plaine"
            });
            context.Cards.Add(new Card
            {
                author = "Rob Alexander",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14118&amp;partner=URZGTHR",
                colorId = 7,
                convertedManaCost = 0,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14271,
                manaCost = "",
                multiverseIdEn = 121256,
                multiverseIdFr = 127189,
                nameEn = "Snow-Covered Swamp",
                nameFr = "Marais enneigé",
                number = 153,
                picturePath = @"Coldsnap\Snow-Covered Swamp.jpg",
                power = "",
                price = 0.446335F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"B
",
                textFr = @"B
",
                typeEn = "Basic Snow Land — Swamp",
                typeFr = "Terrain neigeux de base  - marais"
            });
            context.Cards.Add(new Card
            {
                author = "Wayne England",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14119&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 7,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14272,
                manaCost = "(5)(B)(B)",
                multiverseIdEn = 121165,
                multiverseIdFr = 127190,
                nameEn = "Soul Spike",
                nameFr = "Pointe d’âme",
                number = 70,
                picturePath = @"Coldsnap\Soul Spike.jpg",
                power = "",
                price = 0.431205F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"You may exile two black cards from your hand rather than pay Soul Spike's mana cost.
Soul Spike deals 4 damage to target creature or player and you gain 4 life.
",
                textFr = @"Vous pouvez retirer de la partie deux cartes noires de votre main à la place de payer le coût de mana de la Pointe d'âme.
La Pointe d'âme inflige 4 blessures à une cible, créature ou joueur, et vous gagnez 4 points de vie.
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Jim Nelson",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14120&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 3,
                defense = 0,
                flavorEn = @"""If you call the wolves, ensure you have a worthy hunt, or you may become the hunted.""
—Taaveti of Kelsinko, elvish hunter
",
                flavorFr = @"« Si vous appelez les loups, assurez-vous de faire bonne chasse, ou vous pourriez devenir leurs proies. »
—Taaveti le Kelsinkois, chasseur elfe
",
                force = 0,
                id = 14273,
                manaCost = "(2)(G)",
                multiverseIdEn = 121156,
                multiverseIdFr = 127191,
                nameEn = "Sound the Call",
                nameFr = "Sonner le cor",
                number = 123,
                picturePath = @"Coldsnap\Sound the Call.jpg",
                power = "",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Put a 1/1 green Wolf creature token onto the battlefield. It has ""This creature gets +1/+1 for each card named Sound the Call in each graveyard.""
",
                textFr = @"Mettez en jeu un jeton de créature 1/1 verte Loup avec « Cette créature gagne +1/+1 pour chaque carte appelée Sonner le cor dans chaque cimetière. »
",
                typeEn = "Sorcery",
                typeFr = "Rituel"
            });
            context.Cards.Add(new Card
            {
                author = "Joel Thomas",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14121&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 2,
                defense = 1,
                flavorEn = @"""The scouts claim the cold has malice, and a mind. I begin to believe them. Impassable drifts seem to appear before us at every turn.""
—Aevar Borg, northern guide, journal entry
",
                flavorFr = @"« Les éclaireurs prétendent que le froid est mauvais et qu'il a une vie propre. Je commence à les croire. Des congères infranchissables semblent apparaître à chaque tournant. »
—Ævar Borg, guide du Nord, extrait de journal
",
                force = 1,
                id = 14274,
                manaCost = "(1)(W)",
                multiverseIdEn = 121273,
                multiverseIdFr = 127192,
                nameEn = "Squall Drifter",
                nameFr = "Dériveur des bourrasques",
                number = 17,
                picturePath = @"Coldsnap\Squall Drifter.jpg",
                power = "1 / 1",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying
(W), (T): Tap target creature.
",
                textFr = @"Vol
(W), (T)&nbsp;: Engagez la créature ciblée.
",
                typeEn = "Snow Creature — Elemental",
                typeFr = "Créature neigeuse  - élémental"
            });
            context.Cards.Add(new Card
            {
                author = "Brian Snoddy",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14122&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 4,
                defense = 3,
                flavorEn = @"",
                flavorFr = @"",
                force = 3,
                id = 14275,
                manaCost = "(2)(R)(R)",
                multiverseIdEn = 122046,
                multiverseIdFr = 127193,
                nameEn = "Stalking Yeti",
                nameFr = "Yeti en chasse",
                number = 98,
                picturePath = @"Coldsnap\Stalking Yeti.jpg",
                power = "3 / 3",
                price = 0.158865F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"When Stalking Yeti enters the battlefield, if it's on the battlefield, it deals damage equal to its power to target creature an opponent controls and that creature deals damage equal to its power to Stalking Yeti.
(2): Return Stalking Yeti to its owner's hand. Activate this ability only any time you could cast a sorcery. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"Quand le Yeti en chasse arrive en jeu, s'il est en jeu, il inflige à la créature ciblée qu'un adversaire contrôle un nombre de blessures égal à sa force et cette créature inflige au Yeti en chasse un nombre de blessures égal à sa force.
(2)&nbsp;: Renvoyez le Yeti en chasse dans la main de son propriétaire. Ne jouez cette capacité que lorsque vous pourriez jouer un rituel. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Creature — Yeti",
                typeFr = "Créature neigeuse  - yeti"
            });
            context.Cards.Add(new Card
            {
                author = "Christopher Rush",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14123&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 5,
                defense = 5,
                flavorEn = @"Its belly produces a boiling-hot fluid it can spit as a weapon or spin slowly enough to freeze into a defensive web.
",
                flavorFr = @"Son ventre sécrète un fluide en ébullition qu'elle peut cracher pour se défendre ou tisser assez lentement pour créer une toile défensive gelée.
",
                force = 1,
                id = 14276,
                manaCost = "(4)(G)",
                multiverseIdEn = 121240,
                multiverseIdFr = 127194,
                nameEn = "Steam Spitter",
                nameFr = "Cracheuse de vapeur",
                number = 124,
                picturePath = @"Coldsnap\Steam Spitter.jpg",
                power = "1 / 5",
                price = 0.173995F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Reach (This creature can block creatures with flying.)
(R): Steam Spitter gets +1/+0 until end of turn.
",
                textFr = @"La Cracheuse de vapeur peut bloquer comme si elle avait le vol.
(R)&nbsp;: La Cracheuse de vapeur gagne +1/+0 jusqu'à la fin du tour.
",
                typeEn = "Creature — Spider",
                typeFr = "Créature  - araignée"
            });
            context.Cards.Add(new Card
            {
                author = "Volkan Baga",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14124&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 2,
                defense = 1,
                flavorEn = @"""The White-Shielders think their code justifies their actions. In truth it only binds their hands.""
",
                flavorFr = @"« Les Porteurs de Bouclier blanc pensent que leur éthique justifie leurs actions. En vérité, elle ne fait que lier leurs mains. »
",
                force = 2,
                id = 14277,
                manaCost = "(B)(B)",
                multiverseIdEn = 121253,
                multiverseIdFr = 127195,
                nameEn = "Stromgald Crusader",
                nameFr = "Croisé de Stromgald",
                number = 71,
                picturePath = @"Coldsnap\Stromgald Crusader.jpg",
                power = "2 / 1",
                price = 1.75508F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Protection from white
(B): Stromgald Crusader gains flying until end of turn.
(B)(B): Stromgald Crusader gets +1/+0 until end of turn.
",
                textFr = @"Protection contre le blanc
(B)&nbsp;: Le Croisé de Stromgald acquiert le vol jusqu'à la fin du tour.
(B)(B)&nbsp;: Le Croisé de Stromgald gagne +1/+0 jusqu'à la fin du tour.
",
                typeEn = "Creature — Zombie Knight",
                typeFr = "Créature  - zombie et chevalier"
            });
            context.Cards.Add(new Card
            {
                author = "Michael Sutfin",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14125&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"""Heidar has forced the sun into hiding, but it has not forgotten us.""
",
                flavorFr = @"« Heidar a peut-être contraint le soleil à se cacher, mais l'astre ne nous a pas abandonné. »
",
                force = 0,
                id = 14278,
                manaCost = "(1)(W)",
                multiverseIdEn = 121494,
                multiverseIdFr = 127196,
                nameEn = "Sun’s Bounty",
                nameFr = "Don du soleil",
                number = 18,
                picturePath = @"Coldsnap\Sun's Bounty.jpg",
                power = "",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"You gain 4 life.
Recover (1)(W) (When a creature is put into your graveyard from the battlefield, you may pay (1)(W). If you do, return this card from your graveyard to your hand. Otherwise, exile this card.)
",
                textFr = @"Vous gagnez 4 points de vie.
Recouvrement (1)(W) (Quand une créature est mise dans votre cimetière depuis le jeu, vous pouvez payer (1)(W). Si vous faites ainsi, renvoyez cette carte dans votre main depuis votre cimetière. Sinon, retirez cette carte de la partie.)
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Jim Murray",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14126&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 7,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14279,
                manaCost = "(5)(W)(W)",
                multiverseIdEn = 121251,
                multiverseIdFr = 127197,
                nameEn = "Sunscour",
                nameFr = "Abolition du soleil",
                number = 19,
                picturePath = @"Coldsnap\Sunscour.jpg",
                power = "",
                price = 0.59007F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"You may exile two white cards from your hand rather than pay Sunscour's mana cost.
Destroy all creatures.
",
                textFr = @"Vous pouvez retirer de la partie deux cartes blanches de votre main à la place de payer le coût de mana de l'Abolition du soleil.
Détruisez toutes les créatures.
",
                typeEn = "Sorcery",
                typeFr = "Rituel"
            });
            context.Cards.Add(new Card
            {
                author = "Anthony S. Waters",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14127&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 4,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14280,
                manaCost = "(3)(U)",
                multiverseIdEn = 122052,
                multiverseIdFr = 127198,
                nameEn = "Surging AEther",
                nameFr = "AEther tumultueux",
                number = 47,
                picturePath = @"Coldsnap\Surging Æther.jpg",
                power = "",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Ripple 4 (When you cast this spell, you may reveal the top four cards of your library. You may cast any revealed cards with the same name as this spell without paying their mana costs. Put the rest on the bottom of your library.)
Return target permanent to its owner's hand.
",
                textFr = @"Remous 4 (Quand vous jouez ce sort, vous pouvez révéler les quatre cartes du dessus de votre bibliothèque. Vous pouvez jouer n'importe quel nombre des cartes révélées ayant le même nom que ce sort sans payer leur coût de mana. Mettez les autres au-dessous de votre bibliothèque.)
Renvoyez le permanent ciblé dans la main de son propriétaire.
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Hideaki Takamura",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14128&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14281,
                manaCost = "(1)(B)",
                multiverseIdEn = 122053,
                multiverseIdFr = 127199,
                nameEn = "Surging Dementia",
                nameFr = "Démence tumultueuse",
                number = 72,
                picturePath = @"Coldsnap\Surging Dementia.jpg",
                power = "",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Ripple 4 (When you cast this spell, you may reveal the top four cards of your library. You may cast any revealed cards with the same name as this spell without paying their mana costs. Put the rest on the bottom of your library.)
Target player discards a card.
",
                textFr = @"Remous 4 (Quand vous jouez ce sort, vous pouvez révéler les quatre cartes du dessus de votre bibliothèque. Vous pouvez jouer n'importe quel nombre des cartes révélées ayant le même nom que ce sort sans payer leur coût de mana. Mettez les autres au-dessous de votre bibliothèque.)
Le joueur ciblé se défausse d'une carte.
",
                typeEn = "Sorcery",
                typeFr = "Rituel"
            });
            context.Cards.Add(new Card
            {
                author = "Ron Spencer",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14129&amp;partner=URZGTHR",
                colorId = 2,
                convertedManaCost = 2,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14282,
                manaCost = "(1)(R)",
                multiverseIdEn = 121269,
                multiverseIdFr = 127200,
                nameEn = "Surging Flame",
                nameFr = "Flamme tumultueuse",
                number = 99,
                picturePath = @"Coldsnap\Surging Flame.jpg",
                power = "",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Ripple 4 (When you cast this spell, you may reveal the top four cards of your library. You may cast any revealed cards with the same name as this spell without paying their mana costs. Put the rest on the bottom of your library.)
Surging Flame deals 2 damage to target creature or player.
",
                textFr = @"Remous 4 (Quand vous jouez ce sort, vous pouvez révéler les quatre cartes du dessus de votre bibliothèque. Vous pouvez jouer n'importe quel nombre des cartes révélées ayant le même nom que ce sort sans payer leur coût de mana. Mettez les autres au-dessous de votre bibliothèque.)
La Flamme tumultueuse inflige 2 blessures à une cible, créature ou joueur.
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Luca Zontini",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14130&amp;partner=URZGTHR",
                colorId = 5,
                convertedManaCost = 3,
                defense = 0,
                flavorEn = @"",
                flavorFr = @"",
                force = 0,
                id = 14283,
                manaCost = "(2)(G)",
                multiverseIdEn = 121205,
                multiverseIdFr = 127201,
                nameEn = "Surging Might",
                nameFr = "Puissance tumultueuse",
                number = 125,
                picturePath = @"Coldsnap\Surging Might.jpg",
                power = "",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Enchant creature
Enchanted creature gets +2/+2.
Ripple 4 (When you cast this spell, you may reveal the top four cards of your library. You may cast any revealed cards with the same name as this spell without paying their mana costs. Put the rest on the bottom of your library.)
",
                textFr = @"Enchanter : créature 
La créature enchantée gagne +2/+2. 
Remous 4 (Quand vous jouez ce sort, vous pouvez révéler les quatre cartes du dessus de votre bibliothèque. Vous pouvez jouer n'importe quel nombre des cartes révélées ayant le même nom que ce sort sans payer leur coût de mana. Mettez les autres au-dessous de votre bibliothèque.)
",
                typeEn = "Enchantment — Aura",
                typeFr = "Enchantement  - aura"
            });
            context.Cards.Add(new Card
            {
                author = "Christopher Moeller",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14131&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 3,
                defense = 1,
                flavorEn = @"",
                flavorFr = @"",
                force = 2,
                id = 14284,
                manaCost = "(2)(W)",
                multiverseIdEn = 122118,
                multiverseIdFr = 127202,
                nameEn = "Surging Sentinels",
                nameFr = "Sentinelles tumultueuses",
                number = 20,
                picturePath = @"Coldsnap\Surging Sentinels.jpg",
                power = "2 / 1",
                price = 0.128605F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"First strike
Ripple 4 (When you cast this spell, you may reveal the top four cards of your library. You may cast any revealed cards with the same name as this spell without paying their mana costs. Put the rest on the bottom of your library.)
",
                textFr = @"Initiative 
Remous 4 (Quand vous jouez ce sort, vous pouvez révéler les quatre cartes du dessus de votre bibliothèque. Vous pouvez jouer n'importe quel nombre des cartes révélées ayant le même nom que ce sort sans payer leur coût de mana. Mettez les autres au-dessous de votre bibliothèque.)
",
                typeEn = "Creature — Human Soldier",
                typeFr = "Créature  - humain et soldat"
            });
            context.Cards.Add(new Card
            {
                author = "Yokota Katsumi",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14140&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 5,
                defense = 3,
                flavorEn = @"",
                flavorFr = @"",
                force = 3,
                id = 14293,
                manaCost = "(4)(W)",
                multiverseIdEn = 121150,
                multiverseIdFr = 127211,
                nameEn = "Ursine Fylgja",
                nameFr = "Fylgja ursidé",
                number = 22,
                picturePath = @"Coldsnap\Ursine Fylgja.jpg",
                power = "3 / 3",
                price = 0.1513F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Ursine Fylgja enters the battlefield with four healing counters on it.
Remove a healing counter from Ursine Fylgja: Prevent the next 1 damage that would be dealt to Ursine Fylgja this turn.
(2)(W): Put a healing counter on Ursine Fylgja.
",
                textFr = @"Le Fylgja ursidé arrive en jeu avec, sur lui, quatre marqueurs « guérison ».
Retirez un marqueur « guérison » du Fylgja ursidé : Prévenez la prochaine 1 blessure qui devrait être infligée au Fylgja ursidé ce tour-ci.
(2)(W)&nbsp;: Mettez un marqueur «&nbsp;guérison&nbsp;» sur le Fylgja ursidé.
",
                typeEn = "Creature — Spirit Bear",
                typeFr = "Créature  - esprit et ours"
            });
            context.Cards.Add(new Card
            {
                author = "Rebekah Lynn",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14141&amp;partner=URZGTHR",
                colorId = 8,
                convertedManaCost = 4,
                defense = 0,
                flavorEn = @"Out of sight, into mind.
",
                flavorFr = @"Loin des yeux, proche de l'esprit.
",
                force = 0,
                id = 14294,
                manaCost = "(2)(W)(U)",
                multiverseIdEn = 121187,
                multiverseIdFr = 127212,
                nameEn = "Vanish into Memory",
                nameFr = "Disparition dans la mémoire",
                number = 133,
                picturePath = @"Coldsnap\Vanish into Memory.jpg",
                power = "",
                price = 0.16643F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Exile target creature. You draw cards equal to that creature's power. At the beginning of your next upkeep, return that card to the battlefield under its owner's control. If you do, discard cards equal to its toughness.
",
                textFr = @"Retirez la créature ciblée de la partie. Vous piochez un nombre de cartes égal à la force de cette créature. Au début de votre prochain entretien, renvoyez cette carte en jeu sous le contrôle de son propriétaire. Si vous faites ainsi, défaussez-vous d'un nombre de cartes égal à son endurance.
",
                typeEn = "Instant",
                typeFr = "Éphémère"
            });
            context.Cards.Add(new Card
            {
                author = "Lars Grant-West",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14142&amp;partner=URZGTHR",
                colorId = 3,
                convertedManaCost = 3,
                defense = 4,
                flavorEn = @"",
                flavorFr = @"",
                force = 4,
                id = 14295,
                manaCost = "(1)(U)(U)",
                multiverseIdEn = 122071,
                multiverseIdFr = 127213,
                nameEn = "Vexing Sphinx",
                nameFr = "Sphinx vexatoire",
                number = 50,
                picturePath = @"Coldsnap\Vexing Sphinx.jpg",
                power = "4 / 4",
                price = 0.370685F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying
Cumulative upkeep—Discard a card. (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
When Vexing Sphinx dies, draw a card for each age counter on it.
",
                textFr = @"Vol
Entretien cumulatif — Défaussez-vous d'une carte. (Au début de votre entretien, mettez un marqueur « âge » sur ce permanent, puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur « âge » sur lui.)
Quand le Sphinx vexatoire est mis dans un cimetière depuis le jeu, piochez une carte pour chaque marqueur « âge » sur lui.
",
                typeEn = "Creature — Sphinx",
                typeFr = "Créature  - Sphinx"
            });
            context.Cards.Add(new Card
            {
                author = "E. M. Gist",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14143&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 6,
                defense = 5,
                flavorEn = @"",
                flavorFr = @"",
                force = 4,
                id = 14296,
                manaCost = "(4)(B)(B)",
                multiverseIdEn = 121129,
                multiverseIdFr = 127214,
                nameEn = "Void Maw",
                nameFr = "Gueule du néant",
                number = 74,
                picturePath = @"Coldsnap\Void Maw.jpg",
                power = "4 / 5",
                price = 0.279905F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Trample
If another creature would die, exile it instead.
Put a card exiled with Void Maw into its owner's graveyard: Void Maw gets +2/+2 until end of turn.
",
                textFr = @"Piétinement
Si une autre créature devait être mise dans un cimetière depuis le jeu, retirez-la de la partie à la place.
Mettez une carte retirée de la partie par la Gueule du néant dans le cimetière de son propriétaire : La Gueule du néant gagne +2/+2 jusqu'à la fin du tour.
",
                typeEn = "Creature — Horror",
                typeFr = "Créature  - horreur"
            });
            context.Cards.Add(new Card
            {
                author = "Alex Horley-Orlandelli",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14144&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 2,
                defense = 8,
                flavorEn = @"",
                flavorFr = @"",
                force = 1,
                id = 14297,
                manaCost = "(1)(W)",
                multiverseIdEn = 121225,
                multiverseIdFr = 127215,
                nameEn = "Wall of Shards",
                nameFr = "Mur d’échardes",
                number = 23,
                picturePath = @"Coldsnap\Wall of Shards.jpg",
                power = "1 / 8",
                price = 0.34799F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Defender, flying
Cumulative upkeep—An opponent gains 1 life. (At the beginning of your upkeep, put an age counter on this permanent, then sacrifice it unless you pay its upkeep cost for each age counter on it.)
",
                textFr = @"Défenseur, vol
Entretien cumulatif — Un adversaire gagne 1 point de vie. (Au début de votre entretien, mettez un marqueur « âge » sur ce permanent puis sacrifiez-le à moins que vous ne payiez son coût d'entretien pour chaque marqueur « âge » sur lui.)
",
                typeEn = "Snow Creature — Wall",
                typeFr = "Créature neigeuse  - mur"
            });
            context.Cards.Add(new Card
            {
                author = "Jeff Easley",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14145&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 2,
                defense = 1,
                flavorEn = @"""Honor your steed and it will carry you to great deeds—and bring you home to tell of them.""
",
                flavorFr = @"« Honore ta monture, elle t'aidera à faire de grandes choses — et te ramènera au bercail pour les raconter. »
",
                force = 2,
                id = 14298,
                manaCost = "(W)(W)",
                multiverseIdEn = 121216,
                multiverseIdFr = 127216,
                nameEn = "White Shield Crusader",
                nameFr = "Croisé du Bouclier blanc",
                number = 24,
                picturePath = @"Coldsnap\White Shield Crusader.jpg",
                power = "2 / 1",
                price = 0.25721F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Protection from black
(W): White Shield Crusader gains flying until end of turn.
(W)(W): White Shield Crusader gets +1/+0 until end of turn.
",
                textFr = @"Protection contre le noir
(W)&nbsp;: Le Croisé du Bouclier blanc acquiert le vol jusqu'à la fin du tour.
(W)(W)&nbsp;: Le Croisé du Bouclier blanc gagne +1/+0 jusqu'à la fin du tour.
",
                typeEn = "Creature — Human Knight",
                typeFr = "Créature  - humain et chevalier"
            });
            context.Cards.Add(new Card
            {
                author = "Anthony S. Waters",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14146&amp;partner=URZGTHR",
                colorId = 8,
                convertedManaCost = 3,
                defense = 3,
                flavorEn = @"""Don't be so quick to reclaim the thawing lands. They might have acquired a taste for freedom.""
—Taaveti of Kelsinko, elvish hunter
",
                flavorFr = @"« Ne vous pressez pas de vouloir reprendre le contrôle des régions affectées par le Dégel. Elles pourraient avoir acquis un goût pour la liberté. »
—Taaveti le Kelsinkois, chasseur elfe
",
                force = 0,
                id = 14299,
                manaCost = "(1)(R)(G)",
                multiverseIdEn = 121191,
                multiverseIdFr = 127217,
                nameEn = "Wilderness Elemental",
                nameFr = "Élémental des régions reculées",
                number = 134,
                picturePath = @"Coldsnap\Wilderness Elemental.jpg",
                power = "* / 3",
                price = 0.204255F,
                rarityId = 2,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Trample
Wilderness Elemental's power is equal to the number of nonbasic lands your opponents control.
",
                textFr = @"Piétinement
La force de l'Élémental des régions reculées est égale au nombre de terrains non-base que vos adversaires contrôlent.
",
                typeEn = "Creature — Elemental",
                typeFr = "Créature  - élémental"
            });
            context.Cards.Add(new Card
            {
                author = "Richard Sardinha",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14147&amp;partner=URZGTHR",
                colorId = 4,
                convertedManaCost = 4,
                defense = 7,
                flavorEn = @"",
                flavorFr = @"",
                force = 7,
                id = 14300,
                manaCost = "(2)(W)(W)",
                multiverseIdEn = 121230,
                multiverseIdFr = 127218,
                nameEn = "Woolly Razorback",
                nameFr = "Sanglier laineux",
                number = 25,
                picturePath = @"Coldsnap\Woolly Razorback.jpg",
                power = "7 / 7",
                price = 0.3026F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Woolly Razorback enters the battlefield with three ice counters on it.
As long as Woolly Razorback has an ice counter on it, prevent all combat damage it would deal and it has defender.
Whenever Woolly Razorback blocks, remove an ice counter from it.
",
                textFr = @"Le Sanglier laineux arrive en jeu avec, sur lui, trois marqueurs « glace ».
Tant que le Sanglier laineux a un marqueur « glace » sur lui, il a défenseur et toutes les blessures de combat qu'il infligerait sont prévenues.
À chaque fois que le Sanglier laineux bloque, retirez un marqueur « glace » du Sanglier laineux.
",
                typeEn = "Creature — Boar Beast",
                typeFr = "Créature  - bête"
            });
            context.Cards.Add(new Card
            {
                author = "Kev Walker",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14148&amp;partner=URZGTHR",
                colorId = 1,
                convertedManaCost = 4,
                defense = 3,
                flavorEn = @"The World Spell thawed their icy graves, promising rest in soft, quiet earth at last. But Heidar called them to duty for a twisted cause.
",
                flavorFr = @"L'Enchantement du monde fit fondre leurs tombes de glace, leur promettant enfin un repos dans une terre meuble et silencieuse. Mais Heidar les invoqua pour servir ses desseins ignobles.
",
                force = 2,
                id = 14301,
                manaCost = "(3)(B)",
                multiverseIdEn = 121154,
                multiverseIdFr = 127219,
                nameEn = "Zombie Musher",
                nameFr = "Zombie liquéfieur",
                number = 75,
                picturePath = @"Coldsnap\Zombie Musher.jpg",
                power = "2 / 3",
                price = 0.12104F,
                rarityId = 1,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Snow landwalk
: Regenerate Zombie Musher. ( can be paid with one mana from a snow permanent.)
",
                textFr = @"Traversée des terrains neigeux
&nbsp;: Régénérez le Zombie liquéfieur. ( peut être payé avec un mana d'un permanent neigeux.)
",
                typeEn = "Snow Creature — Zombie",
                typeFr = "Créature neigeuse  - zombie"
            });
            context.Cards.Add(new Card
            {
                author = "Pete Venters",
                cardMarketLink = "http://store.tcgplayer.com/product.aspx?id=14149&amp;partner=URZGTHR",
                colorId = 8,
                convertedManaCost = 4,
                defense = 4,
                flavorEn = @"Zur remained aloof from Terisiare's suffering, intent only on his own perfection.
",
                flavorFr = @"Zur resta sourd aux souffrances de Terisiare, uniquement intéressé par sa propre perfection.
",
                force = 1,
                id = 14302,
                manaCost = "(1)(W)(U)(B)",
                multiverseIdEn = 121162,
                multiverseIdFr = 127220,
                nameEn = "Zur the Enchanter",
                nameFr = "Zur l’enchanteur",
                number = 135,
                picturePath = @"Coldsnap\Zur the Enchanter.jpg",
                power = "1 / 4",
                price = 2.413235F,
                rarityId = 3,
                rulings = new Ruling[0],
                size = new Size { isPlane = false, isScheme = false },
                tag = "",
                textEn = @"Flying
Whenever Zur the Enchanter attacks, you may search your library for an enchantment card with converted mana cost 3 or less and put it onto the battlefield. If you do, shuffle your library.
",
                textFr = @"Vol
À chaque fois que Zur l'enchanteur attaque, vous pouvez chercher dans votre bibliothèque une carte d'enchantement ayant un coût converti de mana de 3 ou moins et la mettre en jeu. Si vous faites ainsi, mélangez votre bibliothèque.
",
                typeEn = "Legendary Creature — Human Wizard",
                typeFr = "Créature légendaire  - humain et sorcier"
            });

        }
    }
}