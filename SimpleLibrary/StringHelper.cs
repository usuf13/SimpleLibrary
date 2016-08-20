using SimpleLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    public class StringHelper: IStringHelper
    {
        public string GetMySubsting(string text, int startPos, int? length)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            if (length == 0)
                return text.Substring(startPos);

            return text.Substring(startPos, length ?? 0);
        }
    }
}
