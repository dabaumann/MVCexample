using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCexample.Services
{
    public class DataService : IDataService
    {

        public List<Account> accounts = new List<Account>();
        public bool CreateAccount(string user, int accountNumber)
        {
            try
            {
                if (accounts.FindIndex(acct => acct.AccountNumber == accountNumber) != -1)
                {
                    accounts.Add(new Account(accounts.Count + 1, AccountTypes.Checking, accountNumber, 0, 0, 0));
                    return true;
                }
                
               
            }
            catch(Exception)
            {
                return false;
            }
            return false;
        }

        public List<Account> getAccounts()
        {
            return accounts;
        }
    }
}