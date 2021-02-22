using Payroll.backend;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplikacja aplikacja = new Aplikacja();

            List<Pracownik> listaPracownikow = aplikacja.UtworzBazePracownikow();

            Console.WriteLine("DZIAŁ KADR I PŁAC");
            Console.WriteLine("");
            Console.WriteLine("Lista Pracowników Firmy");
            Console.WriteLine("");

            WyswietlListePracownikow(listaPracownikow);

            //Walidacja poprawnosci wprowadzonej liczby
            string wprowadzoneId = "";
            bool wartoscJestLiczba = false;
            bool wartoscJestPrawidlowa = false;
            while (!wartoscJestLiczba && !wartoscJestPrawidlowa) {
                wartoscJestLiczba = false;
                wartoscJestPrawidlowa = false;
                wprowadzoneId = Console.ReadLine();
                int wybraneIdUzytkownika;
                if (int.TryParse(wprowadzoneId, out wybraneIdUzytkownika)) {
                    wartoscJestLiczba = true;
                    if (wybraneIdUzytkownika <= listaPracownikow.Count) {
                        wartoscJestPrawidlowa = true;
                    } else {
                        Console.WriteLine("Podana wartosc jest wieksza niz liczba pracownikow");
                    }
                } else {
                    Console.WriteLine("Podana wartosc nie jest liczba");
                }
            }
            Console.Clear();
            WyswietlDanePracownika(wprowadzoneId, listaPracownikow);
            Console.ReadLine();
        }

        static void WyswietlListePracownikow(List<Pracownik> listaPracownikow)
        {
            foreach (var pracownik in listaPracownikow) {
                Console.WriteLine($"{pracownik.id}. {pracownik.imie} {pracownik.nazwisko}");
            }
        }

        static void WyswietlDanePracownika(string wprowadzoneId, List<Pracownik> listaPracownikow)
        {
            int idPracownika = int.Parse(wprowadzoneId);
            List<Pracownik> danePracownika = listaPracownikow.Where(pracownik => pracownik.id == idPracownika).ToList();
            int PracownikFizyczny = 0;
            string czyPracownikJestFizyczny;
            if (danePracownika[0].fizyczny == true) {
                czyPracownikJestFizyczny = "";
                checked { PracownikFizyczny += 100; }
            } else {
                czyPracownikJestFizyczny = "nie";
            }
            Console.WriteLine($"Imie i nazwisko: {danePracownika[0].imie} {danePracownika[0].nazwisko}");
            Console.WriteLine($"Pracownik {czyPracownikJestFizyczny} jest fizyczny");
            Console.WriteLine($"Stawka godzinowa: {danePracownika[0].stawka}");
            Console.WriteLine($"Przepracowanych dni: {danePracownika[0].iloscPrzepracowanychDni}");
            Console.WriteLine($"Ilosc dni na zwolnieniu: {danePracownika[0].iloscDniNaZwolnieniu}");
            Console.WriteLine($"===============================================================");

            /* int netto = 0;
            danePracownika.stawka * danePracownika[0].iloscPrzepracowanychDni * 8  ;           
            int podatekdochodowy = 0
                 danePracownika.netto *= 1.23;
            dowyplaty()
            danePracownika.netto =+ PracownikFizyczny;          
            brutto()
            { danePracownika.netto =+ danePracownika.podatekdochodowy}
             zus
                { danePracownika.brutto *= 0.30} */
        }

        static void WyswietlPremie(string netto, List<Pracownik> Suma)
        {
            int Pensja = int.Parse(netto);
            List<Pracownik> danePracownika = 
        }                                 
    }
}
