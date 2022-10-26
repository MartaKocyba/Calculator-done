//
using System;

double liczba1, liczba2;
bool sukces;
int dzialanie;

System.Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Kalkulator prosty\n");

do
{
    Console.Write("Podaj pierwszą liczbę: ");
    sukces = double.TryParse(Console.ReadLine(), out liczba1);
}
while (!sukces);

do
{
    Console.Write("Podaj drugą liczbę: ");
    sukces = double.TryParse(Console.ReadLine(), out liczba2);
}
while (!sukces);


Console.WriteLine("\n1. Dodawanie");
Console.WriteLine("2. Odejmowanie");
Console.WriteLine("3. Mnożenie");
Console.WriteLine("4. Dzielenie");
Console.WriteLine("5. Procenty");
Console.WriteLine("6. Do kwadratu");
Console.WriteLine("7. Pierwiastkowanie\n");


do
{
    Console.Write("Wybierz działanie od 1 do 7: ");
    sukces = int.TryParse(Console.ReadLine(), out dzialanie);
}
while ((dzialanie < 1) || (dzialanie > 7));

switch (dzialanie){
    case 1:
        {
            Console.WriteLine($"Wynik: {liczba1} + {liczba2} = " + (liczba1 + liczba2));
            break;
        }
    case 2:
        {
            Console.WriteLine($"Wynik: {liczba1} - {liczba2} = " + (liczba1 - liczba2));
            break;
        }
    case 3:
        {
            Console.WriteLine($"Wynik: {liczba1} * {liczba2} = " + (liczba1 * liczba2));
            break;
        }
    case 4:
        {
            if (liczba2 == 0) Console.WriteLine("Nie można dzielić przez 0.");
            else Console.WriteLine($"Wynik: {liczba1} / {liczba2} = " + (liczba1 / liczba2));
            break;
        }
    case 5:
        {
            Console.WriteLine($"Wynik: {liczba1}% z {liczba2} = " + (liczba1 * liczba2 / 100 ));
            break;
        }
    case 6:
        {
            int wybor;
            do
            {
                Console.Write("Której liczby chcesz użyć (1 lub 2)? ");
                sukces = int.TryParse(Console.ReadLine(), out wybor);
            }
            while ((wybor != 1) && (wybor != 2));
            if (wybor == 1)
                Console.WriteLine($"Wynik: {liczba1}\u00b2 = " + (liczba1 * liczba1));
            if (wybor == 2)
                Console.WriteLine($"Wynik: {liczba2}\u00b2 = " + (liczba2 * liczba2));
            break;
        }
    case 7:
        {
            int wybor;
            do
            {
                Console.Write("Której liczby chcesz użyć (1 lub 2)? ");
                sukces = int.TryParse(Console.ReadLine(), out wybor);
            }
            while ((wybor != 1) && (wybor != 2));
            if (wybor == 1)
                Console.WriteLine($"Wynik: \u221A{liczba1} = " + (Math.Sqrt(liczba1)));
            if (wybor == 2)
                Console.WriteLine($"Wynik: \u221A{liczba2} = " + (Math.Sqrt(liczba2)));
            break;
        }
}
Console.WriteLine("Naciśnij dowolny klawisz by zamknąć program...");
Console.ReadKey();

