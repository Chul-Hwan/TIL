using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers
{
    internal class GettingMaxMin
    {
        public string Solution(string s)
        {
            StringBuilder sb = new StringBuilder();

            var integerList = s.Split(' ').Select(integer => int.Parse(integer)).ToList();
            
            sb.Append(integerList.Min().ToString());
            sb.Append(' ');
            sb.Append(integerList.Max().ToString());

            return sb.ToString();
        }
    }
}
