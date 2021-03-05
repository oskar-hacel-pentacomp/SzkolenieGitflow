using BibliotekaWspolna;
using System;

namespace AplikacjaKonsolowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! z poprawka po release z poprawka po hotfix push test");

            Test test = new Test();

            test.TestBibliotekiWspolnej();
            test.TestNowejFunkcjonalnosciOskar();
        }
    }
}
