using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace MinuKonspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //console.writeline("Hello, World");

            //Muutujad, Matemaatilised tehted, IF; ELSE IF ja ELSE:

            //1tuvasta sisu võrdluse tühja stringiga, string andmetüüp
            Console.WriteLine("Tere kasutaja, mis on sinu nimmi");
            string nimi = Console.ReadLine();

            if (nimi == "")
            {
                Console.WriteLine("Kasutaja ei sisetanud oma nime");
            }
            else if (nimi == "")
            {
                Console.WriteLine("Tere " + nimi + "!");

            }
            else
            {
                Console.WriteLine("kasutaja ei sisetanud oma nime");
            }
            //2.tuvasta arvuvahemik, võrdluse piirväärtustega, int/double/float andmetüüp
            Console.WriteLine(nimi + ", mis on sinu vanus?:");
            int kasutajavanus = int.Parse(Console.ReadLine());

            //2.1 mitu tingimust pesastatud if-ide abil
            //if (kasutajavanus > 0)
            //{
            //    if (kasutajavanus < 18)
            //    {
            //        Console.WriteLine("Kahjuks energiajookit sulle ei müüda, oled Monsterist ilma 😊");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Saad osta Monsterit, YIPPIE");
            //    }
            //}

            //2.2 mitu tingimust ühe ifi sees kasutades loogilist tehet "and", välitides pesatamist 
            if (kasutajavanus > 0 && kasutajavanus < 18) {

                Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled Monsterist ilma");
            }
            else
            {
                Console.WriteLine("Saad osta Monstrit, YIPPE");
            }
            //2.3 mitu vahemikku, if-elseif abil,double/float 
            Console.WriteLine("sisesta oma pikkus ka, palun " + nimi + ":");
            double pikkus = double.Parse(Console.ReadLine());
            if (pikkus < 1.00d)
            {
                Console.WriteLine("Oled juntsu");
            }
            else if (pikkus < 1.25d && pikkus > 1.00d)
            {
                Console.WriteLine("Oled peaaegu allameetrimes");
            }
            else if (pikkus < 1.50d && pikkus > 1.25d)
            {
                Console.WriteLine("Oioi, päkapikk ena´m ei olegi " + nimi + "!");
            }
            else if (pikkus < 1.75d && pikkus > 1.5d)
            {
                Console.WriteLine("Oled enamasti standardpikkuses, kui mitte just natuke lühike");
            }
            else if (pikkus < 2.00d && pikkus > 1.75d)
            {
                Console.WriteLine("Pikk kolge, vaate et sa pead vastu uksepiita ära ei löö.");
            }
            else if (pikkus > 2.00d)
            {

                Console.WriteLine("Täielik tulnukas, kuidas pilved välja näevad?");
            }
            else
            {
                Console.WriteLine("pikkust ei tunta ");
            }

            Console.WriteLine("Tere. Sisesta esimene liidetav arv");
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tere. Sisesta esimene liidetav arv");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("siseta tehtemärk: /  * + -");
            string tehtetyyp = Console.ReadLine();

            int tulemus = 0;
            if (tehtetyyp == "+")
            {
                tulemus = arv1 + arv2;

            }
            if (tehtetyyp == "-")
            {
                tulemus = arv1 + arv2;
            }
            if (tehtetyyp == "/")
            {
                tulemus = arv1 + arv2;
            }
            if (tehtetyyp == "+")
            {
                tulemus = arv1 / arv2;
            }



            Console.WriteLine(tulemus);

            Console.WriteLine("sisesta esimene lahutamine");
            int lahutatav1 = int.Parse(Console.ReadLine());
            Console.WriteLine("sisesta teine lahutamine");
            int lahutatav2 = int.Parse(Console.ReadLine());
            int lahutamine = lahutatav1 / lahutatav2;
            Console.WriteLine(lahutamine);

            /* ISESEISev tunni ülesanne: */
            /* Kirjuta ka jagamis, korrutamis ning lahutustehted liitmise eeskujul*/

            // + liitmine
            // / jagamine 
            // * korrutamine 
            // - lahutamine 
            Console.WriteLine("Tere minu nimi Slava");
            int sony1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tere see on jagunemine");
            int sony2 = int.Parse(Console.ReadLine());
            int sonyk = sony1! + sony2;
            Console.WriteLine(tulemus);

            //4 parool, if ja string andmetüüp 
            Console.WriteLine("Programmi edasiseks tööks sisesta palun parool:");
            string password = Console.ReadLine();

            if (password == "simsalabim")
            {
                Console.WriteLine("Parool on õige, aarete laegas avaneb");
            }
            else if (password == "saatana" || password == "1234")
            {
                Console.WriteLine("Parool on sobimatu, palun mingi muu");
            }
            else
            {
                Console.WriteLine("Parool on vale,proovi uuesti");
            }

            //5 värvituvastus 
            Console.WriteLine("Milline värv sulle kõige rohkem meeldib?:");
            string favouriteColour = Console.ReadLine();
            if (favouriteColour == "punane")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (favouriteColour == "oranz")
            {
                Console.WriteLine("Kahjuks oranzi ei ole");
            }
            if (favouriteColour == "kollane") ;
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.WriteLine("Värvi ei tunne");
            }
            Console.WriteLine("Värv muudetud!");

            // 
            // \v/ ISESEISEV TÖÖ LÄHED SIIA 
            //# Kolija kalkulaator - Kirjuta programm mis:
            //#    - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
            //#    - olenevalt kasutaja sisestusest küsib ta:
            //#    - - tünni jaoks:
            //#    - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
            //#    - - - tünni kõrgust
            //#    - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
            //#    - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
            //#    - - kasti jaoks:
            //#    - - - Kas kast on kuubiku kujuline või risttahuka kujuline
            //#    - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
            //#    - - - - kui on risttahukas siis küsib kasutajalt:
            //#    - - - - - pikima külje pikkust, 
            //#    - - - - - lühima külje pikkust ja
            //#    - - - - - kasti kõrgust
            //#    - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)

            Console.WriteLine(" Kas sa tahad mõõta kasti või tünni?");
            string sisend = Console.ReadLine();
            //#     -olenevalt kasutaja sisestusest küsib ta:
            
            //#   - - tünni jaoks:
            if (sisend == "tünn")
            { 
            //# - - - kas kasutaja teab põhja raadiust (r) võ põhja läbimõõtu (d):
            Console.WriteLine("Tere see on kalkulaator");
            Console.WriteLine("Kas soovid mõõta pappkasti või õlitünni? (kast/tünn): ");
            string rvõid = Console.ReadLine();
            Console.WriteLine("Kas sa tead tünni raadiust R või läbimõõtu D");
            Console.WriteLine("Mis on selle raadius/läbimõõt? meetrites");
            double kasutajamõõt = double.Parse(Console.ReadLine());
            //# - - - tünni kõrgust 
            Console.WriteLine("Kui kõrge on su tühn? meetrites");
            double kõrgus = double.Parse(Console.ReadLine());
            //# - - - kaane paksus, kuna kaan võtab tünni küljepindala, tünni kogupindala 
            double Sp = 0;
            if (rvõid == "R")
            {
                Sp = Math.PI * (kasutajamõõt * kasutajamõõt); 
            }
           else if (rvõid == "D")
            {
                kasutajamõõt = kasutajamõõt /2
                    Sp = Math.PI * (kasutajamõõt * kasutajamõõt); 
            }
            double V = 0;
            kõrgus = kõrgus - kaanepaksus;
            V = Sp * kõrgus;
            //Tünni ruumala on olemas. arvutame tünni kogupindala 
            double S = Sp + Sk;
            Console.WriteLine("sinu tünn mahutab {V}\nTünni küljepindala on{Sk}\nTünni kogupindala on {S}"); 











        } 
    } 
} 