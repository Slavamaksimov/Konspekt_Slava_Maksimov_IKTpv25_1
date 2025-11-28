using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace MinuKonspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // //console.writeline("Hello, World");

            // //Muutujad, Matemaatilised tehted, IF; ELSE IF ja ELSE:

            // //1tuvasta sisu võrdluse tühja stringiga, string andmetüüp
            // Console.WriteLine("Tere kasutaja, mis on sinu nimmi");
            // string nimi = Console.ReadLine();

            // if (nimi == "")
            // {
            //     Console.WriteLine("Kasutaja ei sisetanud oma nime");
            // }
            // else if (nimi == "")
            // {
            //     Console.WriteLine("Tere " + nimi + "!");

            // }
            // else
            // {
            //     Console.WriteLine("kasutaja ei sisetanud oma nime");
            // }
            // //2.tuvasta arvuvahemik, võrdluse piirväärtustega, int/double/float andmetüüp
            // Console.WriteLine(nimi + ", mis on sinu vanus?:");
            // int kasutajavanus = int.Parse(Console.ReadLine());

            // //2.1 mitu tingimust pesastatud if-ide abil
            // //if (kasutajavanus > 0)
            // //{
            // //    if (kasutajavanus < 18)
            // //    {
            // //        Console.WriteLine("Kahjuks energiajookit sulle ei müüda, oled Monsterist ilma 😊");
            // //    }
            // //    else
            // //    {
            // //        Console.WriteLine("Saad osta Monsterit, YIPPIE");
            // //    }
            // //}

            // //2.2 mitu tingimust ühe ifi sees kasutades loogilist tehet "and", välitides pesatamist 
            // if (kasutajavanus > 0 && kasutajavanus < 18) {

            //     Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled Monsterist ilma");
            // }
            // else
            // {
            //     Console.WriteLine("Saad osta Monstrit, YIPPE");
            // }
            // //2.3 mitu vahemikku, if-elseif abil,double/float 
            // Console.WriteLine("sisesta oma pikkus ka, palun " + nimi + ":");
            // double pikkus = double.Parse(Console.ReadLine());
            // if (pikkus < 1.00d)
            // {
            //     Console.WriteLine("Oled juntsu");
            // }
            // else if (pikkus < 1.25d && pikkus > 1.00d)
            // {
            //     Console.WriteLine("Oled peaaegu allameetrimes");
            // }
            // else if (pikkus < 1.50d && pikkus > 1.25d)
            // {
            //     Console.WriteLine("Oioi, päkapikk ena´m ei olegi " + nimi + "!");
            // }
            // else if (pikkus < 1.75d && pikkus > 1.5d)
            // {
            //     Console.WriteLine("Oled enamasti standardpikkuses, kui mitte just natuke lühike");
            // }
            // else if (pikkus < 2.00d && pikkus > 1.75d)
            // {
            //     Console.WriteLine("Pikk kolge, vaate et sa pead vastu uksepiita ära ei löö.");
            // }
            // else if (pikkus > 2.00d)
            // {

            //     Console.WriteLine("Täielik tulnukas, kuidas pilved välja näevad?");
            // }
            // else
            // {
            //     Console.WriteLine("pikkust ei tunta ");
            // }

            // Console.WriteLine("Tere. Sisesta esimene liidetav arv");
            // int arv1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Tere. Sisesta esimene liidetav arv");
            // int arv2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("siseta tehtemärk: /  * + -");
            // string tehtetyyp = Console.ReadLine();

            // int tulemus = 0;
            // if (tehtetyyp == "+")
            // {
            //     tulemus = arv1 + arv2;

            // }
            // if (tehtetyyp == "-")
            // {
            //     tulemus = arv1 + arv2;
            // }
            // if (tehtetyyp == "/")
            // {
            //     tulemus = arv1 + arv2;
            // }
            // if (tehtetyyp == "+")
            // {
            //     tulemus = arv1 / arv2;
            // }



            // Console.WriteLine(tulemus);

            // Console.WriteLine("sisesta esimene lahutamine");
            // int lahutatav1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("sisesta teine lahutamine");
            // int lahutatav2 = int.Parse(Console.ReadLine());
            // int lahutamine = lahutatav1 / lahutatav2;
            // Console.WriteLine(lahutamine);

            // /* ISESEISev tunni ülesanne: */
            // /* Kirjuta ka jagamis, korrutamis ning lahutustehted liitmise eeskujul*/

            // // + liitmine
            // // / jagamine 
            // // * korrutamine 
            // // - lahutamine 
            // Console.WriteLine("Tere minu nimi Slava");
            // int sony1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Tere see on jagunemine");
            // int sony2 = int.Parse(Console.ReadLine());
            // int sonyk = sony1! + sony2;
            // Console.WriteLine(tulemus);

            // //4 parool, if ja string andmetüüp 
            // Console.WriteLine("Programmi edasiseks tööks sisesta palun parool:");
            // string password = Console.ReadLine();

            // if (password == "simsalabim")
            // {
            //     Console.WriteLine("Parool on õige, aarete laegas avaneb");
            // }
            // else if (password == "saatana" || password == "1234")
            // {
            //     Console.WriteLine("Parool on sobimatu, palun mingi muu");
            // }
            // else
            // {
            //     Console.WriteLine("Parool on vale,proovi uuesti");
            // }

            // //5 värvituvastus 
            // Console.WriteLine("Milline värv sulle kõige rohkem meeldib?:");
            // string favouriteColour = Console.ReadLine();
            // if (favouriteColour == "punane")
            // {
            //     Console.BackgroundColor = ConsoleColor.Red;
            // }
            // if (favouriteColour == "oranz")
            // {
            //     Console.WriteLine("Kahjuks oranzi ei ole");
            // }
            // if (favouriteColour == "kollane") ;
            // {
            //     Console.BackgroundColor = ConsoleColor.Green;
            // }
            // else
            // {
            //     Console.WriteLine("Värvi ei tunne");
            // }
            // Console.WriteLine("Värv muudetud!");

            // // 
            // // \v/ ISESEISEV TÖÖ LÄHED SIIA 
            // //# Kolija kalkulaator - Kirjuta programm mis:
            // //#    - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
            // //#    - olenevalt kasutaja sisestusest küsib ta:
            // //#    - - tünni jaoks:
            // //#    - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
            // //#    - - - tünni kõrgust
            // //#    - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
            // //#    - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
            // //#    - - kasti jaoks:
            // //#    - - - Kas kast on kuubiku kujuline või risttahuka kujuline
            // //#    - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
            // //#    - - - - kui on risttahukas siis küsib kasutajalt:
            // //#    - - - - - pikima külje pikkust, 
            // //#    - - - - - lühima külje pikkust ja
            // //#    - - - - - kasti kõrgust
            // //#    - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)

            // Console.WriteLine(" Kas sa tahad mõõta kasti või tünni?");
            // string sisend = Console.ReadLine();
            // //#     -olenevalt kasutaja sisestusest küsib ta:

            // //#   - - tünni jaoks:
            // if (sisend == "tünn")
            // { 
            // //# - - - kas kasutaja teab põhja raadiust (r) võ põhja läbimõõtu (d):
            // Console.WriteLine("Tere see on kalkulaator");
            // Console.WriteLine("Kas soovid mõõta pappkasti või õlitünni? (kast/tünn): ");
            // string rvõid = Console.ReadLine();
            // Console.WriteLine("Kas sa tead tünni raadiust R või läbimõõtu D");
            // Console.WriteLine("Mis on selle raadius/läbimõõt? meetrites");
            // double kasutajamõõt = double.Parse(Console.ReadLine());
            // //# - - - tünni kõrgust 
            // Console.WriteLine("Kui kõrge on su tühn? meetrites");
            // double kõrgus = double.Parse(Console.ReadLine());
            // //# - - - kaane paksus, kuna kaan võtab tünni küljepindala, tünni kogupindala 
            // double Sp = 0;
            // if (rvõid == "R")
            // {
            //     Sp = Math.PI * (kasutajamõõt * kasutajamõõt); 
            // }
            //else if (rvõid == "D")
            // {
            //     kasutajamõõt = kasutajamõõt /2
            //         Sp = Math.PI * (kasutajamõõt * kasutajamõõt); 
            // }
            // double V = 0;
            // kõrgus = kõrgus - kaanepaksus;
            // V = Sp * kõrgus;
            // //Tünni ruumala on olemas. arvutame tünni kogupindala 
            // double S = Sp + Sk;
            // Console.WriteLine("sinu tünn mahutab {V}\nTünni küljepindala on{Sk}\nTünni kogupindala on {S}"); 

            Console.WriteLine("hapukapsas");
            // "console"    -> on moodul C# mida me adresserime, Console aitab teha tegevusi käsureal
            // .            -> näitab, et meil on vaja adresseerida mingisugust funktsiooni või meetodit
            //                mooduli "Console"seest.
            // "Writeline"  -> Funktsioon mida me parasjagu kasutame. 
            // ()           -> sulupaar mis omad funktsioni tööks vajalikus infot 
            // []           -> tähistab massiive 
            // {}           -> koodiplokk, tavaliselt kas pärast (if, else if) tingimust, namespacei või funktsiooni kirjeldust
            // "hapukapsas" -> parmeeter mis antakse funktsioonile Writeline töötlemiseks kaasa.
            //            -> Taane aitab arendajal aru saada, kuskohas millise koodiploki sees kood
            //        asub, see on vajalik ka kompilaatorile samal eesmärgil.
            // ;           -> kõik koodilaused lõppevad komakolooniga, mis tähistavad lause lõpp 
            //  //      -> tähistab üherealist kommentaari
            // /**/      -> tähistab mitmerealist kommentaari või kommentaariregiooni


            int muutaja = 3;
            // int           -> on muutaja nime ees olev andmetübi kirjeldus mis näitab ära, millist
            //                  tüüpi andmed selle muutaja sees on.
            //"muutaja"      -> on nimetus, ehk muutaja, mis hoiab endas mingeid andmed, inimloetava 
            //                  sõnaga, ja mille abil saab neid addresseerida koodi sees.
            // =             -> üksik võrdusmärk omistab muutaja sisse vastava väärtuse mis asub
            //                  teiselpool võrdusmärki.
            // 3             -> muutujale omistatav väärtus.

            /* Võimalikud admetüübid mida vaja võib minna: */
            int a = 1; // int on täisarv 
            decimal b = 2.1M; // decimal on kümnedsüsteemis olev komakohaga arv
            float c = 3.9f; // float on 32-bitine komakohaga arv   
            double d = 5.6d; // double on 64-bitine komakohaga arv 
            char cl = 'a'; // üksainus täht või tähemärk mis tähistatakse ülakomadga '' 
            string s = "tekst"; //tähtadest koosnev sõna või tekst, tähistatakse jutumärkidega ""
            var x = "abc";//var on ebamäärse andmetüübiga kohalik muutuja 
            var y = 123; //ta võib omada endas teisi andmetüüpe  
            const int z = 9; // konstant-tüüpi muutujaid ei saa muuta, nende sisu on read-only
            //void on andmetüüp, mida muutuja tekitamisel kasutada ei saa. Kasutatakse ainult meetodite signatuurides väljendamaks et
            //meetod ei tagasta midagi.
            /* Võimalikud komposiitandmetüübid */
            // 1. masiiv:
            // [] ->  Masiiv on komposiitandmetüüp, mille sees saab olla mitmeid sama tüüpi lihtandmeid. Masiivi tähistatakse kantsulgudega
            //        Masiive saab olla ükskõik millist lihtandmetüüpi masiive.
            //        Masiivi tekitamisel tuleb ära öelda kui pikk või kui suur see masiiv on.
            //        Masiiv ei pea olema koostatud ainult lihtametüüpidest, vaid masiive saab olla ka tehtud teistest komposiitandmetüüpidest
            //        Sealhulgas masiiv ise.
            // Esimene tekitusviis. 
            int[] arvuMasiiv = new int[3];    // andmetüüp int väljendab et tegu on täisarvutüüpi andmega ja kantsulud väljendavad et ühtlasi on 
                                              // tegu ka masiiviga. muutuja nimeks on "arvuMasiivi" ja võrdusmärgi abil on omistatud muutujasse 
                                              // uus tühi masiiv kasutajades kaitstud sõna "new" millele järgneb selle masiive andmetüübi ja 
                                              // pikkuse sätetsus "int[3]" . See tähendab et siin masiivis on 3 elementi, mis on täisarvud.
                                              // Teine tekitusviis:
            int[] arvuMasiiv2 = [1, 2, 3];  // teine masiivi tekitusviis kus järjendi pikkuse sätestamise asemel, pannakse elemendid kohe 
                                            //järjendit omava muutuja sisse, järjendi pikkust sätestama ei pea, kuna pikkuse tuletab kompilaator
                                            //sina sisse pandud elementide koduse järgi.
                                            // -- masiivi sisemised metodid
            int hasThisMany = arvuMasiiv.Length;  // masiivi meetod "Length" mille me saame kasutusele vtta punkti abil, loendab kokku 
                                                  // mitu elementi, adresseeritav masiiv omab, omistatakse ainult järjendi pikkus, mitte 
                                                  //järjendi sees olevaid elemente. 





            //põhilised matemaatilised tehted 
            int liitmine = 1 + 1; //liitmine, kaks arvu liidetakse kokku 
            int lahutamine = 1 - 1; //lahutamine, kus esimesest arvust lahutatakse maha teine
            double korrutamine = 1 * 2 //korrutamine, kus teine arv korrutatakse esimese arvu kordi.
            double jagamine = 1 / 2; //jagamine. esimene arv jagatakse teise arvuga.

            //Matemaatilised tehred moodulist "Math"
            double astendamine = Math.Pow(2.2); //astndamine, esimene arv astendatakse teisega 
            double juurimine = Math.Spqrt(2); //ruutjuur, parameetrina juuritav arv 
            double newD = 4.0000001d;
            Math.Round(newD);  //Moodulist "Math" kutsutakse esile punkti abil meetod "Round" , sulgude vahel on esimese parameetrina 
                               //ümardatav arv, teise parameetrina komakohtade arv. Round ümardab sulgude vahel oleva arvväärtuse
                               //teises parameetris oleva komakohtadeni. Kui komakohti ei ole seatud, ümardatakse lähima täisarvuni.
                               //0-4 ümardatakse allapoole, 5-9 ümardatakse ülespoole.
            double newPI = Math.PI; //Moodulist "Math" kutsutakse punkti abil esile kaitstud väärtus, PI, mis väljendab mate
                                    //maatilist pi-d ja seda saab kasutada nagu tavaline arv.

            //Castimine, ehk arvu teisendus ühest andmetüübist teise 
             
            //Castimine on viis, kuidas ühest andmetüübist teist saada, Castimist ennast on kahte eri liiki - Automaatne ja 
            //manuaalne. Automaatne castimine toimub siis, kui teisendatakse väiksemast andmetüübist suuremasse, aga manuaalselt 
            //on vaja castida siis, kui üritame suuremast andmetüübist väiksemat saada. Manuaalne castimise käib nii, et
            //sihtmuutuja võrdusmärgi taga oleva muutuja nimetuse ette, pannakse suludes soovitava andmetüübi nimetus.

            double newData1 = 2.22d; //tekitame, või on kuskil olemas, suure mahuga andmed muutujas "newData1" kus on tegu double 
                                     //andmetüübiga
            float datafloat = (float)newData1; //"(float)" teisedab double tüüpi andmed float tüüpi andmetakse.
            long data1Long = (long)newData1; //"(long)"teisedab double tüüpi andmed float tüüpi andmetakse.
            int data1Int = (int)newData1; //"(int)"teisedab double tüüpi andmed float tüüpi andmetakse.
            char data1Char = (char)newData1; //"(char)"teisedab double tüüpi andmed float tüüpi andmetakse.)

            //Automaatne Castimine
            int backToInt = data1Char; //char andmetüübist, suuremasse, int tüüpi andmeteks muutumisel ei ole vaja muutuja ette casti panna
            long backToLong = backToInt; //int suuremasse, long tüüpi andmetakse teisenndmisel, casti panna ei ole vaja 
            float backToFloat = backToLong; //long andmetüübist suuremasse, float tüüpi andmeteks teisendamisel, casti panna ei ole vaja 
            double backToDouble = backToFloat; //float andmetüübist suuremasse, double tüüpi andmetekse teisendamisel, casti panna ei ole vaja 


            // muutuja nimed 
            int arv = 0; //sobib
            string sõne = "abc"; //sobib
                                 //stringstring = "abc"; //kaitstud sõna kasutada ei saa

            //mutuja nimeks ei sobi järgnevad sõnad:
            //abstract, as, base, bool, break, byte, case, 
            //catch, char, cheked, class, count, continue, decimal,
            //default, delegate, do, double, else, enum, event,
            //explict, extern, false, finally, fixed, float, for,
            //foreach, goto, if, imlicit, in, int, interfacr, internal
            //is, lock, long, namespace, new, null, object, operator, 
            //out, overrid, params, private, protectod, public, readonly,
            //ref, return, sbyte, sealed, short, sixeof, stackalloc,
            //static, string, struct, switch, this, throw, try, typeof
            //uint, ulong, uncheked, undsafe, ushort, using, virtual, 
            //void, volatile, while.

            Console.WriteLine("Tere. Sisesta esimene arv");
            //Adresserime moodulit "Console" punkti abil ütleme, et kasutame funktsiooni Writeline 
            //Selle jaoks etöelda kasutajale sõnum mis asub funktsiooni nime järele salgude vahel
            //ümbritsetuna jutumörkidega. Kasutajale esitatav sõnum on "Tere, Sisesta esimene arv".

            int arv1 = int.Parse(Console.ReadLine());
            //instantsieerime muutuja nimega "arv1", ning selle ette anname andmetüübiks "int", see 
            //ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil
            //väärtuse, mille saame kasutajalt. Selle jaoks, adresseerime uuesti "Console" moodulit
            //Aga seekord on funktsiooni nimi "Readline". Selleks, et käsureapealt tulev aru programmile
            //tekstina ei näe välja, küsime int moduli sest omakorda funktsiooni "Parse" , ning paneme 
            //Readline funktsiooni Parse() sulgude vahele. 

            Console.WriteLine("Tere. Sisesta teine arv");
            //ümbritsetuna jutumörkidega. Kasutajale esitatav sõnum on "Tere, Sisesta esimene arv".
            //Selle jaoks etöelda kasutajale sõnum mis asub funktsiooni nime järele salgude vahel
            //ümbritsetuna jutumörkidega. Kasutajale esitatav sõnum on "Tere. Sisesta teine arv".

            int arv2 = int.Parse(Console.ReadLine());
            //instantsieerime muutuja nimega "arv2", ning selle ette anname andmetüübiks "int", see 
            //ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil
            //väärtuse, mille saame kasutajalt. Selle jaoks, adresseerime uuesti "Console" moodulit
            //Aga seekord on funktsiooni nimi "Readline". Selleks, et käsureapealt tulev aru programmile
            //tekstina ei näe välja, küsime int moduli sest omakorda funktsiooni "Parse" , ning paneme 
            //Readline funktsiooni Parse() sulgude vahele.

            Console.WriteLine("Sisesta tehtmärk: * + -");
            //Adresseerimine moodulit "console" koos "Writeline" funktsiooniga, et esitada kasutajale
            //küsimuse "Sisesta tehtmärk: / * -". Punkti abil saaame modulist Console, funktsiooni
            //Writeline, ning sulgude vahel ongi kasutajale esitatav tekst. Tekst ise on ka ümbritsetude
            //jutumärkitega. LAuse lõppeb lauselõpumärgidega ";"

            string tehtetyyp = Console.ReadLine();
            //instantsieerime muutuja nimega "tehtetyyp", mille ette kirjutame andmetüübiks "string".
            //omistame võrdusmärgi abil, sellesse muutujasse kasutajalt sisendi mille saame kasutade
            //Console" moodulis oleva Readline() funktsiooni abil. Lause lõppeb lauselõpumärgiga";".

            int tulemus = 0;
            //instantsieerimine muutuja nimega "tulemus", andmetüüpiga int, ning omistame talle algse
            //väärtuse võrdusmärgi abil, milleks on 0. Lause lõppeb lauselõpumärgiga";"

            if (tehtetyyp == "+")
            //teeme tingimuslause if, ning selle tingimuse määrame ära sulgudega, mille vahel on 
            //võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid samal kujul
            //nagu võrdusmärkidest teisel pool olev tekst "+". Siin lause ei lõppe, kuna tegu ei 
            //ole koodiga mis midagi kindlalt veel ära teeb. 
            {
                tulemus = arv1 + arv2;
            }
            //peale tingimust on koodiplokk{} sulgude vahel, mis sisaldab endas ühte koodirida.
            //selles lauses omistame muutujale "tulemus" võrdusmärk abil liitmistehte tulemuse,
            //kus liidame kokku muutuja "arv1" ja muutuja "arv2" sisu. Lause lõppeb lauselõpumärgiga";"

            else if (tehtetyyp == "-")
            //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega . 
            //sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid
            //samal kujul nagu võrdusmärkidest teisel pool olev tekst "-" kui eelnev tingimus ei
            // täitnud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk
            {
                tulemus = arv1 - arv2;
            }
            //peale tingimust on kodiplokk{} loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodirida. Selles lauses omistame muutujale "tulemus" võrdusmärgi abil lahutestehte
            //tulemuse, kus lahutame muutuja "arv" sees olevast väärtusest maha "arv2" muutujas 
            //oleva väärtuse.Lause lõppeb Lauselõpumärgiga ";".

            else if (tehtetyyp == "/")
            //teeme sekundaarse tingimuslause "else if" , ning määrassme tema tingimuse ära sulgudega.
            //sulgude vahel on võrdsuskontroll.Kontrollime kas muutuja "tehtetyyp" omab andmeid 
            //samal kujul nagu võrdusmärkidest teisel pool olev tekst"/" kui eelnev tingimus ei 
            //täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            {
                tulemus = arv1 / arv2;
            }
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisldab endas ühte 
            //koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abilkorrutustehte
            //tulemuse, kus jagame muutujas "arv1" oleva väärtuse, muutujas "arv2" oleva jagajaga
            //Lause lõppeb lauselõpumärgiga ";"

            else if (tehtetyyp == "*")
            //teeme sekundaarse tingimuslause "else if" , ning määrame tema tingimuse öra sulgudega.
            //sulguda vahel on võrdsuskontroll. Kontrolline kas muutuja "tehtetyyp" omab andmeid
            //samal kujul nagu võrdusmärkidest teisel pool olev tekst "*" kui eelnev tingimus ei
            //täitunud. Lause siin ei lõppe, vaid tingimusele jargneb koodiplokk.
            {
                tulemus = arv1 * arv2;
            }
            //peale tingimust on koodiplokk {} sulgude vahel, mis sisaldab endas ühte 
            //koodirida. Selles lauses omistame muutujale "tulemus" võrdusmärgi abil korrutustehte 
            //tulemuse, kus korrutame muutujas "arv2" oleva väärtuse muutujas "arv1" oleva väärtuse 
            //kordi. Lause lõppeb lauselõpumärgiga";"
            else if (tehtetyyp == "^")
            //teeme sekundaarse tingimuslause "else if" ning määrame tema tingimuse ära sulgudega.
            //sulgude vahel on võrduskontroll, kontrollime kas muutuja "tehtetyyp" omab andeid 
            //samal kujul nagu võrdusmärkidest teisel pool olev tekst "^" kei eelnev tingimus ei 
            //töitnud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            {
                tulemus = (int)Math.Pow(arv1, arv2);
            }
            //peale tingimust on koodiplokk {} loogileste sulgude vahel, mis sisaldab endas ühte
            //koodirida. Selles lauses omistatakse võrdusmärgi abil muutujasse "tulemus" mille saame 
            //"Math" moodulist pärineva funktsiooni "Pow()" abil. Math.Pow() võtab parameetritena 
            //sisse muutjad "arv1" ja "arv2". Esimene parameeter on astendatav, teine parameeter
            //on astendaja. Funktsiooni Math.Pow() ees on kiirteisendus (int), kuna muutuja 
            //"tulemus" andmetüüp on täisarv.Math.Pow() väljund teisendatakse nii täisarvuks
            //Lause lõppeb lauslõpumärgiga ";".
            else
            //peale kõiki järeltingimusi on meil tingimuslause osa "else" mida täidatekse kõikide 
            //muude tingimuslause osade mittetäitumisel. Siin eraldi tingimust välja ei kirjutada 
            // ning sellest tulenevalt ei ole ka sulge. Järgneb ainult koodiplokk.
            {
                Console.WriteLine("Palun sisesta teha, mida kalkulaator tuvastada oskab");
            }
            //peale "else" on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte 
            //koodrida. Selles koodireas kasutame moodulist "console" punkti abil funktsiooni 
            //"Writeline" et örlda kasutajale 2Palun sisesta teha, mida kalkulaator tuvastada
            //oskab": Koodiriga lõppeb lauselõpumärgiga ";"

            Console.WriteLine(tulemus);
            //kasutame moodulist "console" punkti abil funktsiooni "Writeline" et kuvada kasutajale
            //tehte tulemus. Selle jaoks on Writeline funktsiooni patameetrina pandud muutuja
            //"tulemus" ilma tekstiks teisendamata. Lause lõppeb lauselõpumärgiga";".

            Console.WriteLine("Sisesta ostusumma");
            double ostusumma = double.Parse(Console.ReadLine());
            if (ostusumma > 100)
            {
                Console.WriteLine("saad 20% allahindlust!!!!!!!!!!!!!!!!!!!!OMFGZEROONE!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
            else if (ostusumma < 101 && ostusumma > 50)
            {
                Console.WriteLine("Saad 10% allahindlust. c: yay");
            }
            else if (ostusumma < 51 && ostusumma > 20)
            {
                Console.WriteLine("5% allahindlust.");
            }
            else if (ostusumma < 21 && ostusumma > 0)
            {
                Console.WriteLine("allahindlust ei saa");
            }
            else
            {
                Console.WriteLine("Sisestatud on vigane arv");
            }





            //string kasutajaNimi = "";
            //do
            //{
            //    Console.WriteLine("Palun sisesta oma kasutajanimi");
            //    kasutajaNimi = Console.ReadLine();
            //} while (kasutajaNimi != "user1");
            //if (kasutajaNimi == "user1")
            //{
            //    int ruuduSuurus = 0;

            //    do
            //    {
            //        Console.WriteLine("Kui suurt ruuta saada tahad?");
            //        ruuduSuurus = int.Parse(Console.ReadLine());
            //    } while (ruuduSuurus < 0 || ruuduSuurus > 20);

            //    char reaKujund = '█';
            //    string üksRida = "";
            //    int tsükliMuutuja = ruuduSuurus;

            //    do
            //    {
            //        üksRida = üksRida + "_" + reaKujund;
            //        tsükliMuutuja = tsükliMuutuja - 1;
            //    } while (tsükliMuutuja != 0);

            //    tsükliMuutuja = ruuduSuurus;

            //    do
            //    {
            //        Console.WriteLine(üksRida);
            //        tsükliMuutuja -= 1;
            //    } while (tsükliMuutuja != 0);

            //    Console.WriteLine($"Palun, siis on sinu ruut, suurusega {ruuduSuurus}x{ruuduSuurus}");
            //} 

            /* tingimuslause osad */
            if (true) { } //kaitstud sõna if esile tingimuslause, mille tingimus on sulgude vahel, ning millele järgneb 
                          // koodiplokk tingimuse täitumisel teostatav koodiga 
            else if (true) { } // kaitstud sõnad "else" ja "if" (else if) kutsuvad esile sekundaarse tingimuslause, mille tingimus 
                               // on samamoodi sulgude vahel, ning millel pepab eelnema alat kus "if" või teine "else if". Tingimuse täitumisel
                               // ja eelneva tingimuse mittetäitumise, millele peab eelnem kas "if" või "else if", ning mille koodiplokki sisu 
            else { } //kaitstud sõna "else" kutsub esile järeltingimuse, millele peab eelnema kas "if" või "else if", ning mille koodiplokk sisu 
                     //täidetakse kõikidel teiste "if" ja "else if" tingimuste läbikukkumisel. 
            int option = 3; // --------
            switch (option)//"switch" on kaitstud sõna alternatiivnse tingimuskontrolli jaoks mida saab ef else_if asemel kasutada.
                           //sulgude vahel käib muutuja nimi, mille põhjal tingimuslik ümberlülitus toimub. Siin sulgude vahel.
                           //ei ole tingimus ise, vaid kõigest kontrollitav muutuja, või omakord sulgude vahel muu tingimus.
                           //pärast lülitusvalikut tuleb koodiplokk 
            {
                case 1:               //koodiploki see on erinevad juhtumid, juhtumit sätestatakse kaitsud sõna "case" abil. antud juhul kontrollitakse, 
                                      //kas muutujas "option" on väärtus 1, millele järgneb koolon !:" väljendades tingimuse täitumisel tehtava
                                      //kooditeguvuse algust
                    break;           //kui tegevus on tehtud, väljutakse mitte ainult juhtumist vaid kogu käesolev case-tingimustikust kaitstud
                                     //sõnaga "break". Peale breaki on läuselõpumärk ";" 
                case 2:            //Juhtumeid võib olla mitmeid antud juhul on neid kolm kindlasti.
                    break;
                case 3:
                    Console.WriteLine(option); //tehtav kooditegevus.
                    break;
                default:    //Default juhtumist täidetakse siis, kui ülejäänud juhtumid ei kirjelda muutujas "option" olevat seisu.
                    break;  //Ka default lõppeb sõnaga break.
            }

            /* sõne tööriistad ja muud tekstiga sseotut */
            string alfa = "a\nb";         // n -> tekitab ühe sõne sise reurde, sõne kus on see üks "\n", omab kahte rida.
            string beta = $"a {alfa} b"; // $ -> lubab kasutada muutujaid loogeliste sulgudega otse teksti sees. on variant 
                                         //      formateeritud stringist.


            /* Loogilied tehted */

            // && -> "and" loogiline tehe, mida kasutatakse tingimuste kirjeldamise, ning mis annab positiivse vastuse (true) juhul kui 
            //       mõlemal poll "&&" märki olevad tingimused o täidetud. Kui üks neist ei ole, siis annab negatiivse vastuse (false).
            // || -> "or"! loogiline tege, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse (true) siis kui 
            //       vähemalt üks tingimus on täidetud. Negatiivne vastus (false) tagastatakse siis, kui kõik tingimused on täitamata. 
            // ! -> "not" loogiline tehe, mida kasutatakse tingimuse tulemus inverteerimiseks. Tulemus, mis muidu tagastaks (true)
            //       hüüumärgi abil tagastab (false), ja vastupidi - tulemus mis muidu tagastaks (false), hüüumärgi abil tagastab (true) 

            /* Võrdlusoperaatorid */

            // == -> "on võrdne". Võrdusmärkide ühel pool olev objelt peab vastama täpselt oma olumuselt võrdusmärkide teise pool oleva 
            //        objektiga. ei ole samanagu üks võrdusmärk, üks võrdusmärk omistab, kaks võrdleb.
            // != ->  "ei ole võrdne". Võrdusmärgi ühel pool olev objekt *EI TOHI* olla samal kujul nagu võrdusmärgi teisel pool olev objekt.
            //         Ta võib olla ükskõik mis muul kujul, aga mitte võrreldav objektiga samal kujul. Võrdlusoperaator on kombinitsioon 
            //         "on võrdne operaatorist, ja loogilisest tehtest "not". 
            // >  ->   " on suurem kui". Märgist vasakul pool olev objekt peaks olema suurem, kui paremal pool olev objekt.
            // <  ->   "on väiksem kui". Märgist vasakul pol olev objekt peaks olema väiksem, kui paremal pool olev objekt.
            // <= ->   "suuremvõrdne". Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või suurem kui parempoolne objekt.
            //         Võrdusoperaator on kombintatsioon "on võrdne" ja " on suurem kui" operaatoritest.
            // <= ->   "väiksemvõrdne" . Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või väiksem kui parempoolne objekt.
            //          Võrdluspoperaator on kombinatsioon "on võrdne" ja "on väiksem kui" operaatoritest.

            /* omistusoperaatorid ja kiirtehed */

            int thing = 1;// = -> üksik võrdusmärk omistab muutuja sisse väärtuse, mida saab kasutada läbi muutuja nime.
            thing += 1;   // += -> Võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool olev arvu. 
                          //       asendab tehet "thing = thing + 1". on kombinatsioon matematlisest tehtest "+" ja omistamisest "=".
            thing -= 1;   // -= -> võrdusmärk mille ees on miinus, automaatselt lautab muutujast maha võrdusmärgi teisel pool oleva arvu. 
                          //       asendab tehet "thing = thing - 12. on kombinatsioon matemaatilisest tehtest "-" ja omistamisest "="
            thing *= 2;   // *= -> võrdusmärk mille ees on korrutusmärk "*" automaatselt korrutab muutuja sisu, võrdusmärgi teisel pool 
                          //       oleva arvu kordi. asendab tehet "thing = thing * 2". on kombinatsioon matemaatilisest tehtest "*" ja
                          //       omistamistest "=" 
            thing /= 2;   // /= -> võrdusmärk mille ees on korrutusmärk "/" automaatselt korrutab muutuja sisu, võrdusmärgi teisel pool
                          // arvu osadeks. asendab tehet "thing = thing / 2" . on kombinatsioon matemaatilisest tehtest "/" ja 
                          // omistamisest "=".
            thing++;      // ++ -> on spetsiifiliselt ühe juurde liitmiseks kiirtehe. 
            thing--;      // -- -> on spetsiifiliselt ühe maha liitmiseks kiirtehe.

            /* Tsüklid */
            // 1. do-while 
            int dew = 0;
            do // "do" on kaitstud sõna, mis alustab do-while tsüklit. Pärst seda on koodiplokk {} ning ütleb et tee seda koodi 
            {
                dew++;
            } while (dew != 5); //niikaua kuni whie järel olevate sulgude vahel tingimus ei täitu, käivitatakse eelnev kood uuesti. 

            // 2. while
            int i = 1;   //tsüklimuutuja mis aitab järge pidada while tsükli toimimisel 
            while (i < 5) //"while" on kaitstud sõna mis alustab while tsükli varianti, ilma "do-ta, ning vaab alati välist
                          //tsüklimuutujat. antud juhul on selleks i. Tsükli tingimus, mis pele "while" sõna on, asub sulgude vahel,
                          // siin kontrollitaksegi tsükli tööd, läbi kindla tingimuse kasutades tsüklimuutujat.
                          //antud juhul tsükkel töötab iikaua, kuni i on väiksem kui 5. kui i on sama suur nagu, 5 siis tsükkel 
                          //ketkeb. 
            {
                //koodiplokk kus midagi tehakse 
                i++;     //ning seejärel muudrtakse tsüklimuutuja "i" olekut. antud juhul liidetakse 1 juurde kiirtehtega "++". 
            }
            // 3. for 
            int kogus = 6;  //muutuja mida tsükkel kasutab oma töö tegimiseks - teisisõnu, töödeldav materjal 
            for (int k = 0; k < kogus; k++) // kaitstud sõnaa "for" alustab for-tsüklit, pärast mida on sulud, mille vahel on kõik tsükli
                                            // töö jaoks vajalik olemas. Esimene parameeter, tekitab tsükli töö jaoks kohaliku muutuja
                                            // "int k = 0;" mida tsükli ENDA töö juhtimiseks. Teine parameeter on tingimuslause, mis kontrollib 
                                            // tingimuse täitumist " k < kogus;" ning mile täitumisel tsükli töö jatkub, aga mille 
                                            // mitte-täitumisel tsükkel katkeb. Klmas parameeter on tsüklimuutuja inkrementeerimine kiirtehtega 
                                            // "k++". Pane tähele, et iga sulgude vahel oleva osa järel ( välja arvatud viimase) on
                                            // lauselõpumrk. Tsükli tööd kontrolliv tingimuslause koosneb olmest reast, mitte ühest 
                                            // nagu "while" või "do-while" puhul. 
                                            // sulgudele järgneb, loogeliste sulgude vahel ole koodiplikk {}
            {
                Console.WriteLine(k);  // töötlustegevus tsükli sees, on muutuja "k" hetkearvu väljakuvamine.
            }
            /*Meetoddid*/

            // Meetodid on väljakutsutavad koodijupid. Meetodid teostavad tavaliselt mingeid spetsiifilised funktsioone või tegevusi.
            // Meetodid lasevad programmeerijal taaskasutada oma eelnevalt kirjutatud koodi - write once use many times.
            // Meetodeid on kahte liiki - ühed, mis tagastavad mingisuguse töö või tegevuse tagajärjel või tulemusena andmeid, ja teised.
            // mis ei tagasta midagi, kui omavad siiski mingit tegevust.

            // Meetodi signatuur & selle kompositsioon:
            // Meetodi signatuur on kõige esimene rida, mis meetodi tekitamiseks kirjutatakse, ning mis kirjeldab, meetodit ennast, ning selle 
            // omadusi.
            // Meetodi signatuur koosneb mitmest kindlast ärmääratud omaduseset. Nendeks on juurdepäsu modifikaator, tagastustüüp,
            // meetodi enda nimi, olenevalt meetodi liigist ka parameetrid mis on sulgude vahel (), ning koodipokist mis on meetodi sisu.
            // - Juurdepääsu modifikaator ütleb ära, kust ja kuidas seda meetodit välja kutsuda või adresseerida saab. Juurdepääsu modi-
            // fikaatoreid on tähtsamatest 4-5 tükki
            // 1 - public --- meetod on avalik ja kättesaadav ka teistes klassides, peale selle klassi, kus meetodisse asub.
            // 2 - private --- meetod on saadav ainult selles klassis kui meetod ise asub.
            // 2 - protected --- meetod on saadav ainult selles klassis kus meetod ise asub ja klassis mis pärilusega saab
            // 4 - internal --- meetod on saadav ainult selles klassis ja ainult selles failis. 
            // 5 - static --- vahest võib olla pandud ka static, see ütleb lihtsalt et see meetod asub siin.
            // 
            // - Tagastustüüp on meetod omadus, mis ütleb ära mis tüüpi andmed, meetodi väljakutsumise asukohta tagastatakse, kui üldse.
            // Andmetüüp, mida tagastada, võib olla ükskõik milline liht- või kombinatsioonandmetüüp. Aga kui meetod ei tagasta üldse andmeid
            // pannakse selle asemel andmetüübiks "võid". Kui meetodil on tagastustüüp mis on midagi muud kui void, on meetodi sees, iga toiniva
            // koodisuuna lõpus kaitstud sõna "return", return ütleb, et just see asi on vaja tagastada. peale returni on alati mingisugune kindel
            // muutuja, või tegevuse tulemus, mis tagastatakse meetodi väljakutseasukohta, peaele käivitatud returni, ei teostata mitte ühtegi
            // muud meetodis olevat koodi, sest meetod on leinud oma tagastatava objekti, ning meetodi töö sellele hetkel katkestatakse 
            // Return on osaliselt ka kui break
            //
            // - Meetodi enda nimi on midagi mille järgi arendaja meetodit kasutab, kutsub koodis välja, ning meetodi nimi peaks kuvama
            //üldsõnaliselt mida see meetod teeb. Näites meetod nimega "A();" ei ole hea, sest sõna "A" ei ütle programmeerijale mitte midagi.
            //Aga näiteks meetod, nimega "ArvutaArvudKokku();" Ütleb arendajale ära, mida see meetod teeb. Ta ei raiska oma aega, selle 
            //
            // - Parameetrid on need, mis ütlevad, mis meetodil tema tääks vaja on,. Parameeter, meetodi signatuuris võib olla teistmoodi
            // //
            // 1. tüüpi meetod - ei tagasta midagi:
            public static void UusMeetod() // meetodi signatuur, mis juurdepääsumodifikaatorit "public", "static" ütleb et ta kuulub sellesse
                                           // klassi. Tagastustüüp on "void" mis ütlb et andmeid meie meetod ei tagasta. Pärast omadusi on selle
                                           // Meetodi nimi "uusMeetod" peale mida on sulud, kus parameetreid ei ole.
                                           // pärast signatuuri on koodiplokk selle meetodi koodiga, logeliste sulgude vahel {}
        {
            Console.WriteLine("Tere"); // ainult juhul on meetodi sisuks sõnumi kuvamine, mooduli "Console" abiga, mille seest punkti abil "."
                                       // adresseerime Console meetodit "WriteLine", ning mille parameetriks on sõne "Tere" , parameeter asub
                                       // peale meetodi nime olevate sulgude vahel. Lause lõppeb lauselõpumärgiga ";"
                                       // See arendaja poold kirjutatud meetod rokem koodi ei ome.
        }

        // 2. tüüpi meetod - tagastab väärtuse:
        int[] arvutatavadArvud = new int[] { 67, 69, 420, 9001 }; //Töödeldavad andmed, mis asuvad täisarvumassiivis, muutujanimega
                                                                   //"arvutatavadArvud".

        public static int ArvutaKokku(int[] arvud)//Meetod mille signatuuris on juurdepääsumodifikaator "public", "static" ütleb et ta kuulub 
                                                    //sellesse klassi, tagastustüüp "int" ütleb, et programmis tagastatakse täisarv asukohta
                                                    //koodis kus meetod algselt välja kutsuti. Siis on meetdi nii "ArvutaKokku", ning sulgude
                                                    //vahel ootab meetod täisarvumassiivi. Sellele massiivil pannakse meetodi sisselt ajutine 
                                                    //nimi "arvud". Meetod ootab esimese parameetri asukohal just arvumasiiv olenemata mis 
                                                    //tema muutuja nimi on. Peale signatuuri on koodiplokk tehatava abil arv 0. Lause

        {
            int summa = 0; //tekitasme täisarvundametüüpi muutuja nimega "summa", kuhu esialgu omistatakse võrdusmärgi abil arv 0. Lause
                           //lõppeb lauselõpumärgiga";"
            foreach (var arv in arvud) //tekitame "foreach" tsükli, mille kogumikuks on meetodisisene arvudemasiiv nimega "arvud", mille 
                                       //iga elemendi ajutise muutuja nimi on "arv"
            { //peale seda on koodiplokk
                summa += arv; // muutujale summa omistatakse += märgga juurde hetkel tsüklis kasutuse
            }
            return summa;
        } 




















        }

    }     
}         

                  