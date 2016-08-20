using SimpleLibrary.Interfaces;
using SimpleLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    public class ProcessingAccount: IProcessingAccount
    {
        private IDb _db;
        public ProcessingAccount(IDb db)
        {
            _db = db;
        }

        public string GetAcountName(int id)
        {
            var account = _db.GetAcount(id);
            return account.Name;
        }

        public Account UpdateAccount(Account acount)
        {
            acount.LastUpdate = DateTime.UtcNow;
            _db.UpdateAcount(acount);
            return _db.GetAcount(acount.Id);
        }
    }
}
