using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAcccountService
    {
        private IAccountRepository accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return accountRepository.GetAccounts();
        }

        public void TransferFunds(AccountTransfer accountTransfer)
        {
            throw new NotImplementedException();
        }
    }
}
