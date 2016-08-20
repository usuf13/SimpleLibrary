using SimpleLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary.Interfaces
{
    public interface IDb
    {
        Account GetAcount(int id);
        void AddAcount(Account acount);
        void UpdateAcount(Account acount);
        void RemoveAcount(Account acount);
    }
}
