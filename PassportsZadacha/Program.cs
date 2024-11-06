using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PassportsZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Passport passport = new Passport();
                passport.Print();
                List<Passport> passports = new List<Passport>();
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    var danni = Console.ReadLine().Split();
                    Passport passportsDanni = new Passport(danni[0], int.Parse(danni[1]), danni[2], danni[3]);
                    passports.Add(passportsDanni);
                }
                passports.ForEach(x => x.Print());
                Console.Write("Vavedi ime:");
                string name = Console.ReadLine();
                passports.Where(x => x.Name == name).ToList().ForEach(x => x.Print());
                var youngestPerson = passports.Min(x => x.Egn);
                Console.WriteLine($"Min stojnost: {youngestPerson}");

                Console.WriteLine("Sortirani po data v nixhodqsht red:");
                passports.OrderByDescending(x => x.Date).ToList().ForEach(x => x.Print());

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }


        }
    }
}
