using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCexample.Services
{
    public interface IDataService
    {
        bool CreateAccount(string user, int accountNumber);
        List<Account> getAccounts();
    }
}
