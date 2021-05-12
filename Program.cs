using OpenQA.Selenium.Firefox;
using System;
using System.Linq;
using System.Threading;

namespace szczepienia
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var driver = new FirefoxDriver();
            driver.Url = "https://pacjent.erejestracja.ezdrowie.gov.pl";
            Console.WriteLine("zaloguj się określ parametry wyszukiwania i kliknij enter w tym oknie");
            Console.ReadLine();
            while (true)
            {
                var searchbutton = driver.FindElementByXPath(@"//button[contains(., 'Szukaj')]");
                searchbutton.Click();
                Thread.Sleep(500);
                var applyButtons = driver.FindElementsByXPath(@"//button[contains(., 'Wybierz')]");
                if (applyButtons.Count > 0)
                {
                    applyButtons.First().Click();
                    driver.FindElementByXPath(@"//button[contains(., 'Tak')]").Click();
                    Console.WriteLine("ZNALEZIONO TERMIN SPRAWDŹ CZY SIĘ UDAŁO");
                }
                Thread.Sleep(10000);
            }
        }
    }
}