using System;   // Używa System

class Kalkulator // Określenie klasy: Kalkulator
{
    public int dodaj(int a, int b)  // Instancja publiczna zwracająca liczby     // Tutaj określamy że w tej instancji mają znajdować się a i b
    {
        int wynik = a + b; // Tutaj określamy wynik
        
        return wynik;   // A tutaj go zwracamy.
    }

    public static void Main(string[] args)  // Klasa publiczna statyczna Main, zwracająca argumenty
    {
        Kalkulator kalkulator = new Kalkulator();   //  Deklaracja obiektu kalkulator

        // Poniżej deklaracja wartości zmiennych a i b
        int a = 5;  
        int b = 10;
        int wynik = kalkulator.dodaj(a, b); // Deklaracja wyniku dodawania a i b, z obiektu kalkulator, instancji dodaj.

        Console.WriteLine(wynik); // Wynik!
    }
}