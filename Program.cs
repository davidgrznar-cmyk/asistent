// tu začína cyklus
while (true)
{
 Console.WriteLine("Akú funkciu by si chcel využiť?");
 string funkcia = Console.ReadLine();
 if (funkcia == "exit")
 {
  Console.WriteLine("Asistent ukončený");
  break;
 }
 //tu začínajú funkcie
 void vykonaj_sum()
 {
  {
   Console.WriteLine("zadaj prvé číslo");
   int.TryParse(Console.ReadLine(), out int cislo_na_scitanie_1);
   Console.WriteLine("zadaj druhé číslo");
   int.TryParse(Console.ReadLine(), out int cislo_na_scitanie_2);
   Console.WriteLine("tvoj súčet dvoch čísel je "+(cislo_na_scitanie_2 + cislo_na_scitanie_1));

  }
 }

 void vykonaj_odm()
 {
  {
   Console.WriteLine("zadaj číslo na odmocnenie");
   int.TryParse(Console.ReadLine(), out int cislo_na_odmocnenie);
   double odmocnina = Math.Sqrt(cislo_na_odmocnenie);
   Console.WriteLine("odmocnina tvojho čísla je " +(odmocnina));
  }
 }


 void pomoc()
 {
  { 
   Console.WriteLine("Toto sú všetky príkazy: sum - sčíta dve Čísla spolu, odm - odmocní jedno číslo, help - vypíše všetky príkazy a čo robia, find - vyhľadá podreťazec vo vete a vypíše na akom indexe začína.");
  }
 }


 void najdi()
 {
  {
   Console.WriteLine("Zadaj vetu:");
   string celaveta = Console.ReadLine();
   Console.WriteLine("Zadaj, čo hľadáš:");
   string podretazec = Console.ReadLine();

   int index = celaveta.IndexOf(podretazec);

   if (index != -1)
   {
    Console.WriteLine("Podreťazec " + (podretazec) + " sa začína vo vete na indexe " + (index));
   }
   else
   {
    Console.WriteLine("Podreťazec " + podretazec + " sa vo vete nenachádza.");
   }
  }
 }

 void rect()
 {
  {
   Console.WriteLine("Poďme zmerať obdĺžnik");
   Console.WriteLine("Zadaj dĺžku prvej strany:");
   int.TryParse(Console.ReadLine(), out int strana_a);
   Console.WriteLine("Zadaj dĺžku druhej strany:");
   int.TryParse(Console.ReadLine(), out int strana_b);
   if ((strana_b != strana_a) & (strana_b > 0) & (strana_a > 0) )
   {
    Console.WriteLine("Pracujeme s obdĺžníkom s rozmerom" + strana_b + "x" + strana_a);
    Console.WriteLine("Čo chceme zmerať?");
    string funkcia_v_obdlzniku = Console.ReadLine();

    void area()
    {
     int nasobenie_v_obdlzniku = strana_b * strana_a;
     Console.WriteLine("Obsah obdĺžnika je "+ nasobenie_v_obdlzniku);
    }

    void perimeter()
    {
     int obvod_obdlznika = strana_b + strana_b + strana_a + strana_a;
     Console.WriteLine("Obvod obdĺžnika je "+ obvod_obdlznika);
    }

    void diagonal()
    {
     double odvesna_strana_a = Math.Pow(strana_a,2);
     double odvesna_strana_b = Math.Pow(strana_b,2);
     double prepona = Math.Sqrt(odvesna_strana_b + odvesna_strana_a);
     Console.WriteLine("Uhlopriečka tvojho obdĺžnika je " + prepona);
    }
    if (funkcia_v_obdlzniku == "area")
    {
     area();
    }

    if (funkcia_v_obdlzniku == "perimeter")
    {
     perimeter();
    }

    if (funkcia_v_obdlzniku == "diagonal")
    {
     diagonal();
    }

   }
   else
   {
    Console.WriteLine("Neexistujúci obdĺžnik, skús znovu");
   }

   
  }
 }
// tu začínaju if
 if (funkcia == "sum")
 {
  vykonaj_sum();
 }

 if (funkcia == "odm")
 {
  vykonaj_odm();
 }

 if (funkcia == "help")
 {
  pomoc();
 }

 if (funkcia == "find")
 {
  najdi();
 }

 if (funkcia == "rect")
 {
  rect();
 }

}

