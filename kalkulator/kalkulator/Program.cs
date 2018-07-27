using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Program umożliwia wielokrotne obliczenie: sum iloczynów i różnych średnich ciągów liczbowych");
            Console.WriteLine("");


            ConsoleKeyInfo wyborFunkcjonalności;
            do
            {
                Console.WriteLine("Funkcjonalne menu programu: ");
                Console.WriteLine("A. Obliczanie sumy <in-line>");
                Console.WriteLine("B. Obliczanie sumy <method-call>");
                Console.WriteLine("C. Obliczanie iloczynu <in-line>");
                Console.WriteLine("D. Obliczanie iloczynu <method-call>");
                Console.WriteLine("E. Obliczanie średniej arytmetycznej <in-line>");
                Console.WriteLine("F. Obliczanie średniej arytmetycznej <method-call>");
                Console.WriteLine("G. Obliczanie średniej ważonej <in-line>");
                Console.WriteLine("H. Obliczanie średniej ważonej <method-call>");
                Console.WriteLine("I. Obliczanie ceny jednostki paszy <in-line>");
                Console.WriteLine("J. Obliczanie ceny jednostki paszy <method-call>");
                Console.WriteLine("K. Obliczanie średniej harmonicznej <in-line>");
                Console.WriteLine("L. Obliczanie średniej harmonicznej <method-call>");
                Console.WriteLine("M. Obliczanie średniej geometrycznej <in-line>");
                Console.WriteLine("N. Obliczanie średniej geometrycznej <method-call>");
                Console.WriteLine("O. Obliczanie średniej kwadratowej <in-line>");
                Console.WriteLine("P. Obliczanie średniej kwadratowej <method-call>");
                Console.WriteLine("R. Obliczanie średniej potegowej <in-line>");
                Console.WriteLine("S. Obliczanie średniej potegowej <method-call>");


                Console.WriteLine("");
                Console.WriteLine("X. Zakończenie (wyjśćie z) programu");

                Console.WriteLine("");
                Console.WriteLine("Naciśnij klawisz przypisany do odpowiedniej funkcjonalności z której chcesz skorzystać: ");

                wyborFunkcjonalności = Console.ReadKey();

                if (wyborFunkcjonalności.Key == ConsoleKey.A)
                {
                    double ktIloscLiczb = 0;
                    float ktSuma = 0.0f;

                    do
                    {

                        Console.WriteLine("Ile liczb chcesz zawrzeć w sumie? ");
                        while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                            Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                        for (int i = 0; i < ktIloscLiczb; i++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Podaj liczbę do obliczenia sumy:");
                            float liczba;
                            while (!float.TryParse(Console.ReadLine(), out liczba))
                                Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                            ktSuma += liczba;
                        }

                    } while (ktIloscLiczb <= 0);

                    Console.WriteLine("");
                    Console.WriteLine("Wynik sumowania to " + ktSuma);
                    Console.WriteLine(" ");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.B)
                {
                    Console.WriteLine("Wynik sumowania to:" + ktObliczanieSumy());
                    Console.WriteLine(" ");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.C)
                {
                    double ktIloscLiczb = 0;
                    float ktIloczyn = 0.0f;

                    do
                    {

                        Console.WriteLine("Ile liczb chcesz zawrzeć w iloczynie? ");
                        while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                            Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");
                        for (int i = 0; i < ktIloscLiczb; i++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Podaj liczbę do obliczenia iloczynu:");
                            float liczba;
                            while (!float.TryParse(Console.ReadLine(), out liczba))
                                Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                            ktIloczyn *= liczba;
                        }

                    } while (ktIloscLiczb <= 0);
                    Console.WriteLine("");

                    Console.WriteLine("Wynikiem iloczynu jest:" + ktIloczyn);
                    Console.WriteLine(" ");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.D)
                {
                    Console.WriteLine("Wynik iloczynu to: " + ktObliczanieIloczynu());
                    Console.WriteLine(" ");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.E)
                {
                    double ktIloscLiczb = 0;
                    double ktSuma = 0.0f;
                    double ktLiczba = 0;

                    do
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Ile liczb chcesz zawrzeć w średniej?: ");
                        while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                            Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                        for (int i = 0; i < ktIloscLiczb; i++)
                        {
                            Console.WriteLine("Podaj liczbę: ");
                            while (!double.TryParse(Console.ReadLine(), out ktLiczba))
                                Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                            ktSuma += ktLiczba;
                        }


                    } while (ktIloscLiczb <= 0);

                    Console.WriteLine("Średnia arytmetyczna z podanych liczb wynosi: " + ktSuma / ktIloscLiczb);
                    Console.WriteLine(" ");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.F)
                {
                    Console.WriteLine("Średnia arytmetyczna z podanych liczb wynosi: " + ktObliczanieSredniejArytmetycznej());
                    Console.WriteLine(" ");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.G)
                {
                    double ktLicznik = 0;
                    double ktMianownik = 0;
                    double ktIloscLiczb = 0;
                    double ktLiczba = 0;
                    double ktWaga = 0;
                    double ktUlamek = 0.0f;

                    do
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Ile liczb chcesz zawrzeć w średniej?: ");
                        while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                            Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                        for (int i = 0; i < ktIloscLiczb; i++)
                        {

                            Console.WriteLine("Podaj liczbę: ");
                            while (!double.TryParse(Console.ReadLine(), out ktLiczba))
                                Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                            Console.WriteLine("Podaj wagę: ");
                            while (!double.TryParse(Console.ReadLine(), out ktWaga))
                                Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                            ktLicznik += ktLiczba * ktWaga;
                            ktMianownik += ktWaga;

                            ktUlamek = ktLicznik / ktMianownik;
                        }

                    } while (ktIloscLiczb <= 0);


                    Console.WriteLine("Średnia ważona z podanych liczb to: " + ktUlamek);
                    Console.WriteLine(" ");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.H)
                {
                    Console.WriteLine("Średnia ważona to: " + ktObliczanieSredniejWazonej());
                    Console.WriteLine("");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.I)
                {
                    double ktLicznik = 0;
                    double ktMianownik = 0;
                    double ktIloscLiczb = 0;
                    double ktLiczba = 0;
                    double ktWaga = 0;
                    double ktUlamek = 0.0f;

                    do
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Ile rodzajów paszy chcesz zawrzeć w średniej?: ");
                        while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                            Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");


                        for (int i = 0; i < ktIloscLiczb; i++)
                        {

                            Console.WriteLine("Podaj cenę: ");
                            while (!double.TryParse(Console.ReadLine(), out ktLiczba))
                                Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                            Console.WriteLine("Podaj wagę: ");
                            while (!double.TryParse(Console.ReadLine(), out ktWaga))
                                Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                            ktLicznik += ktLiczba * ktWaga;
                            ktMianownik += ktWaga;
                            ktUlamek = ktLicznik / ktMianownik;
                        }


                    } while (ktIloscLiczb <= 0);

                    Console.WriteLine("Cena jednostki paszy to: " + ktUlamek);
                    Console.WriteLine("");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.J)
                {
                    Console.WriteLine("Średnia ważona to: " + ktObliczanieCenyPaszy());
                    Console.WriteLine("");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.K)
                {
                    double ktLicznik = 0;
                    double ktMianownik = 0;
                    double ktIloscLiczb = 0;
                    double ktLiczba = 0;
                    double ktIloczynLiczb = 0;
                    double ktUlamek = 0.0f;

                    do
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Ile liczb chcesz zawżeć w średniej?: ");
                        while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                            Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");


                        for (int i = 0; i < ktIloscLiczb; i++)
                        {

                            Console.WriteLine("Podaj liczbę: ");
                            while (!double.TryParse(Console.ReadLine(), out ktLiczba))
                                Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");


                            ktIloczynLiczb *= ktLiczba;
                            ktLicznik = ktIloscLiczb * ktIloczynLiczb;
                            ktMianownik += ktLiczba;
                            ktUlamek = ktLicznik / ktMianownik;

                        }

                    } while (ktIloscLiczb <= 0);

                    Console.WriteLine("Średnia harmoniczna z podanych liczb wynosi: " + ktUlamek);
                    Console.WriteLine("");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.L)
                {
                    Console.WriteLine("Średnia harmoniczna to: " + ktObliczanieSredniejHarmonicznej());
                    Console.WriteLine("");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.M)
                {
                    double ktIloscLiczb = 0;
                    double ktLiczba = 0;
                    double ktIloczynLiczb = 0;
                    double ktPierwiastek = 0.0f;

                    do
                    {

                        Console.WriteLine("");
                        Console.WriteLine("Ile liczb chcesz zawżeć w średniej?: ");
                        while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                            Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                        for (int i = 0; i < ktIloscLiczb; i++)
                        {

                            Console.WriteLine("Podaj liczbę: ");
                            while (!double.TryParse(Console.ReadLine(), out ktLiczba))
                                Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                            ktIloczynLiczb *= ktLiczba;
                            ktPierwiastek = Math.Sqrt(ktIloczynLiczb);

                        }

                    } while (ktIloscLiczb <= 0);
                    Console.WriteLine("Średnią geometryczną z podanych liczb jest: " + ktPierwiastek);
                    Console.WriteLine("");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.N)
                {
                    Console.WriteLine("Średnia geometryczna podanych liczb to: " + ktObliczanieSredniejGeometrycznej());
                    Console.WriteLine("");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.O)
                {
                    double ktIloscLiczb = 0;
                    double ktLiczba = 0;
                    double ktIloczynLiczb = 0;
                    double ktPotega = 0;
                    double ktUlamek = 0;
                    double ktPierwiastek = 0.0f;

                    do
                    {
                        Console.WriteLine("Ile liczb chcesz zawżeć w średniej?: ");
                        while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                            Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                        for (int i = 0; i < ktIloscLiczb; i++)
                        {

                            Console.WriteLine("Podaj liczbę: ");
                            while (!double.TryParse(Console.ReadLine(), out ktLiczba))
                                Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");
                            ktPotega = Math.Pow(ktLiczba, 2);

                            ktIloczynLiczb *= ktLiczba;
                            ktUlamek = ktIloczynLiczb / ktIloscLiczb;
                            ktPierwiastek = Math.Sqrt(ktUlamek);

                        }

                    } while (ktIloscLiczb <= 0);
                    Console.WriteLine("Średnia kwadratowa z podanych liczb to: " + ktPierwiastek);
                    Console.WriteLine("");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.P)
                {
                    Console.WriteLine("Średnia kwadratowa z podanych liczb to: " + ktObliczanieSredniejKwadratowej());
                    Console.WriteLine("");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.R)
                {
                    double ktIloscLiczb = 0;
                    double ktLiczba = 0;
                    double ktSumaLiczb = 0;
                    double ktPotega = 0;
                    double ktUlamek = 0;
                    double ktRzad = 0;
                    double ktWynik = 0.0f;

                    do
                    {
                        Console.WriteLine("Podaj rząd średniej: ");
                        while (!double.TryParse(Console.ReadLine(), out ktRzad))
                            Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                        Console.WriteLine("Ile liczb chcesz zawżeć w średniej?: ");
                        while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                            Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                        for (int i = 0; i < ktIloscLiczb; i++)
                        {

                            Console.WriteLine("Podaj liczbę: ");
                            while (!double.TryParse(Console.ReadLine(), out ktLiczba))
                                Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");
                            ktPotega = Math.Pow(ktLiczba, ktRzad);

                            ktSumaLiczb += ktLiczba;
                            ktUlamek = ktSumaLiczb / ktIloscLiczb;
                            ktWynik = Math.Pow(ktUlamek, 1 / ktRzad);

                        }

                    } while (ktIloscLiczb <= 0);

                    Console.WriteLine("Średnia potęgowa z podanych liczb to: " + ktWynik);
                    Console.WriteLine("");
                }
                else if (wyborFunkcjonalności.Key == ConsoleKey.S)
                {
                    Console.WriteLine("Średnia potęgowa z podanych liczb to: " + ktObliczanieSredniejPotegowej());
                    Console.WriteLine("");
                }

            } while (wyborFunkcjonalności.Key != ConsoleKey.X);
            Console.WriteLine(" ");
            Console.WriteLine("Zakończenie programu");
            Console.ReadKey();
        }

        static float ktObliczanieSumy()
        {
            double ktIloscLiczb = 0;
            float ktSuma = 0.0f;

            do
            {

                Console.WriteLine("Ile liczb chcesz zawrzeć w sumie? ");
                while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                    Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                for (int i = 0; i < ktIloscLiczb; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Podaj liczbę do obliczenia sumy:");
                    float liczba;
                    while (!float.TryParse(Console.ReadLine(), out liczba))
                        Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                    ktSuma += liczba;
                }

                return ktSuma;

            } while (ktIloscLiczb <= 0);

            Console.WriteLine("");
        }
        static float ktObliczanieIloczynu()
        {
            double ktIloscLiczb = 0;
            float ktIloczyn = 0.0f;

            do
            {

                Console.WriteLine("Ile liczb chcesz zawrzeć w iloczynie? ");
                while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                    Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");
                for (int i = 0; i < ktIloscLiczb; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Podaj liczbę do obliczenia iloczynu:");
                    float liczba;
                    while (!float.TryParse(Console.ReadLine(), out liczba))
                        Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                    ktIloczyn *= liczba;
                }
                return ktIloczyn;

            } while (ktIloscLiczb <= 0);
            Console.WriteLine("");

        }
        static double ktObliczanieSredniejArytmetycznej()
        {
            double ktIloscLiczb = 0;
            double ktSuma = 0.0f;
            double ktLiczba = 0;

            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Ile liczb chcesz zawrzeć w średniej?: ");
                while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                    Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                for (int i = 0; i < ktIloscLiczb; i++)
                {
                    Console.WriteLine("Podaj liczbę: ");
                    while (!double.TryParse(Console.ReadLine(), out ktLiczba))
                        Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                    ktSuma += ktLiczba;
                }
                return ktSuma / ktIloscLiczb;

            } while (ktIloscLiczb <= 0);
            Console.WriteLine(" ");

        }
        static double ktObliczanieSredniejWazonej()
        {
            double ktLicznik = 0;
            double ktMianownik = 0;
            double ktIloscLiczb = 0;
            double ktLiczba = 0;
            double ktWaga = 0;
            double ktUlamek = 0.0f;

            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Ile liczb chcesz zawrzeć w średniej?: ");
                while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                    Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                for (int i = 0; i < ktIloscLiczb; i++)
                {

                    Console.WriteLine("Podaj liczbę: ");
                    while (!double.TryParse(Console.ReadLine(), out ktLiczba))
                        Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                    Console.WriteLine("Podaj wagę: ");
                    while (!double.TryParse(Console.ReadLine(), out ktWaga))
                        Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                    ktLicznik += ktLiczba * ktWaga;
                    ktMianownik += ktWaga;

                    ktUlamek = ktLicznik / ktMianownik;
                }
                return ktUlamek;

            } while (ktIloscLiczb <= 0);
            Console.WriteLine("");
        }
        static double ktObliczanieCenyPaszy()
        {
            double ktLicznik = 0;
            double ktMianownik = 0;
            double ktIloscLiczb = 0;
            double ktLiczba = 0;
            double ktWaga = 0;
            double ktUlamek = 0.0f;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Ile rodzajów paszy chcesz zawrzeć w średniej?: ");
                while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                    Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");


                for (int i = 0; i < ktIloscLiczb; i++)
                {

                    Console.WriteLine("Podaj cenę: ");
                    while (!double.TryParse(Console.ReadLine(), out ktLiczba))
                        Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                    Console.WriteLine("Podaj wagę: ");
                    while (!double.TryParse(Console.ReadLine(), out ktWaga))
                        Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                    ktLicznik += ktLiczba * ktWaga;
                    ktMianownik += ktWaga;
                    ktUlamek = ktLicznik / ktMianownik;
                }
                return ktUlamek;

            } while (ktIloscLiczb <= 0);
            Console.WriteLine("");
        }
        static double ktObliczanieSredniejHarmonicznej()
        {
            double ktLicznik = 0;
            double ktMianownik = 0;
            double ktIloscLiczb = 0;
            double ktLiczba = 0;
            double ktIloczynLiczb = 0;
            double ktUlamek = 0.0f;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Ile liczb chcesz zawżeć w średniej?: ");
                while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                    Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");


                for (int i = 0; i < ktIloscLiczb; i++)
                {

                    Console.WriteLine("Podaj liczbę: ");
                    while (!double.TryParse(Console.ReadLine(), out ktLiczba))
                        Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");


                    ktIloczynLiczb *= ktLiczba;
                    ktLicznik = ktIloscLiczb * ktIloczynLiczb;
                    ktMianownik += ktLiczba;
                    ktUlamek = ktLicznik / ktMianownik;

                }
                return ktUlamek;

            } while (ktIloscLiczb <= 0);

            Console.WriteLine("");
        }
        static double ktObliczanieSredniejGeometrycznej()
        {
            double ktIloscLiczb = 0;
            double ktLiczba = 0;
            double ktIloczynLiczb = 0;
            double ktPierwiastek = 0.0f;

            do
            {

                Console.WriteLine("");
                Console.WriteLine("Ile liczb chcesz zawżeć w średniej?: ");
                while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                    Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                for (int i = 0; i < ktIloscLiczb; i++)
                {

                    Console.WriteLine("Podaj liczbę: ");
                    while (!double.TryParse(Console.ReadLine(), out ktLiczba))
                        Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                    ktIloczynLiczb *= ktLiczba;
                    ktPierwiastek = Math.Sqrt(ktIloczynLiczb);

                }
                return ktPierwiastek;

            } while (ktIloscLiczb <= 0);
            Console.WriteLine("");
        }
        static double ktObliczanieSredniejKwadratowej()
        {
            double ktIloscLiczb = 0;
            double ktLiczba = 0;
            double ktIloczynLiczb = 0;
            double ktPotega = 0;
            double ktUlamek = 0;
            double ktPierwiastek = 0.0f;

            do
            {
                Console.WriteLine("Ile liczb chcesz zawżeć w średniej?: ");
                while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                    Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                for (int i = 0; i < ktIloscLiczb; i++)
                {

                    Console.WriteLine("Podaj liczbę: ");
                    while (!double.TryParse(Console.ReadLine(), out ktLiczba))
                        Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");
                    ktPotega = Math.Pow(ktLiczba, 2);

                    ktIloczynLiczb *= ktLiczba;
                    ktUlamek = ktIloczynLiczb / ktIloscLiczb;
                    ktPierwiastek = Math.Sqrt(ktUlamek);

                }
                return ktPierwiastek;

            } while (ktIloscLiczb <= 0);
            Console.WriteLine("");
        }
        static double ktObliczanieSredniejPotegowej()
        {
            double ktIloscLiczb = 0;
            double ktLiczba = 0;
            double ktSumaLiczb = 0;
            double ktPotega = 0;
            double ktUlamek = 0;
            double ktRzad = 0;
            double ktWynik = 0.0f;

            do
            {
                Console.WriteLine("Podaj rząd średniej: ");
                while (!double.TryParse(Console.ReadLine(), out ktRzad))
                    Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                Console.WriteLine("Ile liczb chcesz zawżeć w średniej?: ");
                while (!double.TryParse(Console.ReadLine(), out ktIloscLiczb))
                    Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");

                for (int i = 0; i < ktIloscLiczb; i++)
                {

                    Console.WriteLine("Podaj liczbę: ");
                    while (!double.TryParse(Console.ReadLine(), out ktLiczba))
                        Console.WriteLine("To nie jest liczba, podaj wartość jeszcze raz");
                    ktPotega = Math.Pow(ktLiczba, ktRzad);

                    ktSumaLiczb += ktLiczba;
                    ktUlamek = ktSumaLiczb / ktIloscLiczb;
                    ktWynik = Math.Pow(ktUlamek, 1 / ktRzad);

                }
                return ktWynik;
            } while (ktIloscLiczb <= 0);
            Console.WriteLine("");

        }

    }
}
