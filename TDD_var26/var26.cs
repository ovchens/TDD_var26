using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_var26
{
    public class var26
    {
        public static bool birthday_Check(DateTime date)
        {
            return (date.Month == DateTime.Now.Month && date.Day == DateTime.Now.Day);

        }
    }
}
