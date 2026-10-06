
if (funkcia == "odm")
{
 Console.WriteLine("zadaj číslo na odmocnenie");
 int.TryParse(Console.ReadLine(), out int cislo_na_odmocnenie);
 double odmocnina = Math.Sqrt(cislo_na_odmocnenie);
 Console.WriteLine("odmocnina tvojho čísla je " +(odmocnina));
}

if (funkcia == "help")
{
 Console.WriteLine("Toto sú všetky príkazy: sum, odm, help, find");
}

if (funkcia == "find")
{
 Console.WriteLine("Zadaj vetu:");
 string celaveta = Console.ReadLine();
 Console.WriteLine("Zadaj, čo hľadáš:");
 string podretazec = Console.ReadLine();

 int index = celaveta.IndexOf(podretazec);

 if (index != -1)
 {
  Console.WriteLine("Podreťazec "+ (podretazec) + " sa začína vo vete na indexe "+ (index));
 }
 else
 {
  Console.WriteLine("Podreťazec "+ podretazec +  " sa vo vete nenachádza.");
 }
}