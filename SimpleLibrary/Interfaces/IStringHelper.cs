using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary.Interfaces
{
    public interface IStringHelper
    {
        string GetMySubsting(string text, int startPos, int? length);
    }
}
