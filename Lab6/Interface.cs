using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    interface IPlanet
    {
        void ReportAboutMovement();
        void ReportAboutLife();
    }

    class Earth : IPlanet
    {
        public void ReportAboutMovement()
        {
            Console.WriteLine("Земля рухається навколо Сонця");
        }
        public void ReportAboutLife()
        {
            Console.WriteLine("На Землі є життя");
        }
    }
    class Moon : IPlanet
    {
        public void ReportAboutMovement()
        {
            Console.WriteLine("Місяць рухається навколо Землі");
        }
        public void ReportAboutLife()
        {
            Console.WriteLine("На Місяці немає життя");
        }
    }

    static void Main(string[] args)
    {
        IPlanet planet = new Earth();
        Console.WriteLine("Про Землю:");
        planet.ReportAboutMovement();
        planet.ReportAboutLife();
        Console.WriteLine("Про Місяць:");
        planet = new Moon();
        planet.ReportAboutMovement();
        planet.ReportAboutLife();
    }
}