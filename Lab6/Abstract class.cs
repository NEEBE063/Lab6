using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public abstract class Planet
    {
        public abstract void ReportAboutMovement();
        public abstract void ReportAboutLife();
    }
    public class Earth : Planet
    {
        public override void ReportAboutMovement()
        {
            Console.WriteLine("Земля рухається навколо Сонця");
        }
        public override void ReportAboutLife()
        {
            Console.WriteLine("На Землі є життя");
        }
    }
    
    public class Moon : Planet
    {
        public override void ReportAboutMovement()
        {
            Console.WriteLine("Місяць рухається навколо Землі");
        }
        public override void ReportAboutLife()
        {
            Console.WriteLine("На Місяці немає життя");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Planet planet;
            planet = new Earth();
            Console.WriteLine("Про Землю:");
            planet.ReportAboutMovement();
            planet.ReportAboutLife();
            Console.WriteLine();
            Console.WriteLine("Про Місяць:");
            planet = new Moon();
            planet.ReportAboutMovement();
            planet.ReportAboutLife();
            Console.ReadLine();
        }
    }
}
