using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities
{
    class Contract
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installements> Installment {get; set;}

        public Contract(int id, DateTime date, double totalValue)
        {
            Id = id;
            Date = date;
            TotalValue = totalValue;
            Installment = new List<Installements>();
        }

        public void AddInstallment(Installements installements)
        {
            Installment.Add(installements);
        }
    }
}
