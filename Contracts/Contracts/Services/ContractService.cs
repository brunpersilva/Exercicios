using System;
using Contracts.Entities;

namespace Contracts.Services
{
    class ContractService
    {
        private IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;   
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i<= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _paymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _paymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installements(date, fullQuota));
            }
        }


    }
}
