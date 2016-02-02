using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioTaajuudetEtc
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();

            bool tilat = true;
            while(tilat)
            {
                Console.WriteLine("1) On / Off \n 2) Volume \n 3) Taajuus");
                int valikko;
                valikko = int.Parse(Console.ReadLine());
                switch(valikko)
                {
                    case 1:
                        radio.Tila();
                        break;
                    case 2:
                        Console.WriteLine("Syota aanevoimakkuuden maara 1-9");
                        int voluumi = int.Parse(Console.ReadLine());
                        radio.Voimakkuus(voluumi);
                        break;
                    case 3:
                        radio.Taajuus();
                        break;
                    case 4:
                        tilat = false;
                        break;
                    default:
                        break;

                }
            }
        }
    }
    class Radio {
        public float Ltaajuus = 2000;
        public int volume = 5;
        public bool onoff = false; //true == ON || false == OFF
        public void Taajuus()
        {
            bool seppo = true;
            Console.WriteLine("Komennot ovat: + Nostaa taajuutta \n - Laskee taajuutta \n set asettaa manuualisesti taajuuden \n ok sammuttaa taajuuden antamisen");
            while(seppo) {
                string plusorminus;
                plusorminus = Console.ReadLine();
                switch(plusorminus)
                {
                    case "+": 
                        Ltaajuus++;
                        Console.WriteLine("Radion taajuus asetettu: " + Ltaajuus);
                        if (Ltaajuus > 26000.0)
                        {
                            Ltaajuus = 26000;
                        }
                        break;
                    case "-":
                        Console.WriteLine("Radion taajuus asetettu: " + Ltaajuus);
                        Ltaajuus--;
                        if(Ltaajuus < 2000)
                        {
                            Ltaajuus = 2000;
                        }
                        break;
                    case "set":
                        Console.WriteLine("Voit nostaa manuaalisesti taajuuden arvoa syottamallasi luvulla: ");
                       
                        Ltaajuus = Ltaajuus + float.Parse(Console.ReadLine());
                        Console.WriteLine("Radion taajuus asetettu: " + Ltaajuus);
                        seppo = false;
                        break;
                    case "ok":
                        seppo = false;
                        break;
                }
 
            
        }
        }
        public void Tila()
        {

        
            if(onoff == true)
            {
                Console.WriteLine("Radio on sammutettu! ");
                onoff = false;
            }
                else {
                onoff = true ;
                Console.WriteLine("Radio on käynnissä! ");
            }
        }
        public void Voimakkuus(int luku)
        {
            if(luku > 9)
            {
                Console.WriteLine("Voimakkuus on nyt: " + volume);
                volume = 9;
            }
            if(luku < 0)
            {
                volume = 0;
                Console.WriteLine("Voimakkuus on nyt: " +volume);
            }
            else
            {
                volume = luku;
                Console.WriteLine("Voimakkuus on nyt: "+ luku);
            }
        }

    }
}
