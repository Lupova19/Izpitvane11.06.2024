using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PassportsZadacha
{
    public class Passport
    {
        private string name;
        private int egn;
        private string number;
        private string date;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Egn
        {
            get { return egn; }
            set 
            {
                if (egn > 10 && egn < 10)
                {
                    throw new ArgumentException("Vavedeni sa po-malko ili poveche cifri za EGN");
                } 
                this.egn = value;
            }
        }
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public Passport(string name, int egn, string number, string date) 
        {
            this.Name = name;
            this.Egn = egn;
            this.Number = number;
            this.Date = date;
        }
        public Passport() 
        {
            this.Name = "Ivan";
            this.Egn = 0749555123;
            this.Number = "ABM43";
            this.Date = "10.02.2024g.";
        }
        public void Print()
        {
            Console.WriteLine($"Name:{this.Name}, EGN:{this.Egn}, Number of passport:{this.Number}, Date:{this.Date}");
        }
        
    }
}
