﻿using System;
using Core.Common.Entities;
using System.Collections;
using Core.Business.Interfaces;
using Core.Common.Interfaces;

namespace Core.Business
{
    public class AccountManager : IAccountManager
    {
        private PrimaryAccount _account;

        public AccountManager(IAccount account)
        {
            //_account = account;
        }


        public void RecordDeposit(Transaction t)
        {
            _account.Ledger.CreateDebit(t);
        }
        public void RecordWithdrawal(Transaction t)
        {
            _account.Ledger.CreateCredit(t);
        }

        public IEnumerable ViewTransactionHistory(PrimaryAccount account)
        {
            return _account.Ledger.ViewAllTransactionsByDate();
        }

        public IEnumerable ViewTransactionHistory(IAccount account)
        {
            throw new NotImplementedException();
        }

        public decimal CheckBalance(ILedger ledger)
        {
            throw new NotImplementedException();
        }
    }
}