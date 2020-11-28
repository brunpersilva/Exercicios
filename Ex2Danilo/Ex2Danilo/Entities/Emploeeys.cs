using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ex2Danilo.Entities
{
    class Emploeeys
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public double Salary { get; set; }
        public string Job { get; set; }

        public Emploeeys()
        {

        }

        public Emploeeys(string name, DateTime birthDate, double salary, string job)
        {
            Name = name;
            BirthDate = birthDate;
            Salary = salary;
            Job = job;
        }

        public override string ToString()
        {
            return "Name: "
                + Name
                + ", "
                + "Birth: "
                + BirthDate
                + ", Salary: "
                + Salary.ToString("F2", CultureInfo.InvariantCulture)
                + ", Job: "
                + Job;

        }

    }
}
